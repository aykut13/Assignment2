using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace HW2.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Action DisplayMenu;
       
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (email != "aa@etu.edu.tr" && password !="mobile")
            {
                DisplayInvalidLoginPrompt();
                
            }
            if (email == "aa@etu.edu.tr" && password == "mobile")
            {
                DisplayMenu();
            }
        }
    }
}