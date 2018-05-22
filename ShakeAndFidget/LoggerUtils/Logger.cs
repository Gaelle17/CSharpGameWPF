using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;

namespace LoggerUtil
{

    public class Logger
    {

        public const String SEPARATOR = " : ";
        public const String MODE = "MODE";
        public const String ALERT = "ALERT";

        private List<Mode> modes;

        public List<Mode> Modes
        {
            get { return modes; }
            set { modes = value; }
        }

        private List<Alert> alerts;

        public List<Alert> Alerts
        {
            get { return alerts; }
            set { alerts = value; }
        }

        private void LogInConsole(LogType logType, String content)
        {
            switch (logType)
            {
                case LogType.ALERT:
                    Console.WriteLine(ALERT + SEPARATOR + content);
                    break;
                case LogType.MODE:
                    Console.WriteLine(MODE + SEPARATOR + content);
                    break;
                default:
                    break;
            }
        }

        private void LogInMessageBox(String content)
        {
            MessageBoxResult messageBox = System.Windows.MessageBox
                .Show(ALERT, content, MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }

        private async Task LogInToastAsync(String content)
        {
            Notifier notifier = new Notifier(cfg =>
            {
                cfg.PositionProvider = new WindowPositionProvider(
                    parentWindow: Application.Current.MainWindow,
                    corner: Corner.TopRight,
                    offsetX: 10,
                    offsetY: 10);

                cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                    notificationLifetime: TimeSpan.FromSeconds(3),
                    maximumNotificationCount: MaximumNotificationCount.FromCount(5));

                cfg.Dispatcher = Application.Current.Dispatcher;
            });
            notifier.ShowWarning(content);
            Task.Delay(3000).RunSynchronously();
            notifier.Dispose();
        }

        private void LogOverlay(String content)
        {

        }

        private void LogInCurrentFolder(String content)
        {
            TextWriter file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory);
            file.WriteLine(MODE + SEPARATOR + content);
            file.Close();
        }

        // path -> pack://application:.../
        private void LogInTempFolder(/*String path,*/ String content)
        {
            TextWriter file = new StreamWriter("pack://application:.../", true, UTF8Encoding.UTF8);
            file.WriteLine(MODE + SEPARATOR + content);
            file.Close();
        }

        public void Log(String tag, Object currentClass, String content)
        {
            Log(tag + SEPARATOR + currentClass + content);
        }

        public void Log(String content)
        {
            foreach (var item in Alerts)
            {
                switch (item)
                {
                    case Alert.CONSOLE:
                        Console.ForegroundColor = ConsoleColor.Green;
                        LogInConsole(LogType.ALERT, content);
                        break;
                    case Alert.TOAST:
                        LogInToastAsync(content);
                        break;
                    case Alert.MESSAGE_BOX:
                        LogInMessageBox(content);
                        break;
                    case Alert.OVERLAY:
                        LogOverlay(content);
                        break;
                    case Alert.NONE:
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in Modes)
            {
                switch (item)
                {
                    case Mode.CONSOLE:
                        Console.ForegroundColor = ConsoleColor.Red;
                        LogInConsole(LogType.MODE, content);
                        break;
                    case Mode.EXTERNAL:
                        break;
                    case Mode.CURRENT_FOLDER:
                        LogInCurrentFolder(content);
                        break;
                    case Mode.TEMP_FOLDER:
                        LogInTempFolder(content);
                        break;
                    case Mode.NONE:
                        break;
                    default:
                        break;
                }
            }
        }

        public Logger(List<Alert> alerts, List<Mode> modes)
        {
            this.alerts = alerts;
            this.modes = modes;
        }

    }

}