using WpfApp1.UserControls;

namespace WpfApp1.Views
{
    public class HomeViewModel
    {
        public Home home;

        public HomeViewModel(Home home)
        {
            this.home = home;
            UserControlMenu menu = new UserControlMenu(this);
            UserControlProfil profil = new UserControls.UserControlProfil(this);
            UserControlDuel battle = new UserControls.UserControlDuel(this);
            //home.Action.Children.Clear();
            home.Menu.Children.Add(menu);
            home.Action.Children.Add(profil);

            //menu.btn_duel += 
        }

    }
}