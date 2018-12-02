using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HW2.ViewModels;

namespace HW2.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        public Login()
        {
            var vm1 = new LoginViewModel();
            this.BindingContext = vm1;
            vm1.DisplayMenu += () => DisplayAlert("Login Process", "Username and Password Match!", "OK","Cancel");
            InitializeComponent();
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Login Process", "Username and Password Dismatch!", "Cancel");
            InitializeComponent();


            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }

    }
}