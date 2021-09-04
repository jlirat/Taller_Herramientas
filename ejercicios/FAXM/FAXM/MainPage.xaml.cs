using FAXM.Controller;
using FAXM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FAXM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        readonly UserController ctrl = new UserController();
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            var isUserValid = !string.IsNullOrEmpty(txtUser.Text);
            var isPassValid = !string.IsNullOrEmpty(txtPassword.Text);
            if(isUserValid&&isPassValid)
            {
                User user = new User
                {
                    Username = txtUser.Text,
                    Pass = txtPassword.Text
                };
                bool response = ctrl.Login(user);
                if (response)
                    Navigation.PushAsync(new HomePage());
                else
                    DisplayAlert("Alert", "Error al iniciar sesión","Cancelar");
            } else
            {
                DisplayAlert("Alert", "Error al iniciar sesión, no puede enviar datos vacíos", "Cancelar");
            }
        }
    }
}
