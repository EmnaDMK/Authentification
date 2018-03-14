using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        //public Action DisplayValidLoginPrompt;
        public string Title = "";
        public string _Message = "";
        public INavigation _Navigation;

        public event PropertyChangedEventHandler PropertyChanged;
        private String _login;
        private String _password;


        public String Login 
        {
            get { return _login; }
            set
            {
                _login = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Login"));
            }
        }

       
       
        public String Password    
        {
            get { return _password; }
            set
            {
                _password = value; 
                PropertyChanged(this, new PropertyChangedEventArgs("Password")); 
            }
        }

        public INavigation Nav
        {
            get { return _Navigation; }
            set
            {
                _Navigation = value;
               
            }
        }

        public ICommand SubmitCommand
        { protected set; get; }


        public LoginViewModel(INavigation _nav)
        {
            Nav = _nav;
            SubmitCommand = new Command(Submit);
        } 
      




        public void Submit()
        {
            if (_login != "emna" || _password != "admin")
            {
                Title = "Failed Authentification !";
                _Message = "Login not correct, empty user name or password";
                DisplayInvalidLoginPrompt();
            }
            else
            {
                //Title = "Authentification Successful !";
                //_Message = "Welcome, This could be your Dashboard";
                //DisplayInvalidLoginPrompt();

                Nav.PushAsync(new MasterEmp());


            }

      
       
        }
    }
}
