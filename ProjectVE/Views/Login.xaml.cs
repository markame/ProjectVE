using ProjectVE.Views;

namespace ProjectVE
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Login(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Principal());
        }
    }

}
