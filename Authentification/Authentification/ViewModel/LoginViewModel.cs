using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        #region Fields

        public Action DisplayPrompt;

        #endregion

        public string title { get; set; }

        public string Message { get; set; }


        //public event PropertyChangedEventHandler PropertyChanged;
        private String _login;
        private String _password;


        public String Login 
        {
            get { return _login; }
            set
            {
                _login = value;
                SetProperty(ref _login, value);
            }
        }

       
       
        public String Password    
        {
            get { return _password; }
            set
            {
                _password = value;
                SetProperty(ref _password, value);
            }
        }

     
        //public ICommand SubmitCommand
        //{ protected set; get; }


        public LoginViewModel(INavigation nav)
        {
            _nav = nav;
            CurrentPage = DependencyInject<MainPage>.Get();
          

            OpenPage();
        }

        public LoginViewModel()
        {
           
        }





        public ICommand SubmitCommand => new Command(async () =>
        {
            if (_login != "emna" || _password != "admin")
            {
                Title = "Failed Authentification !";
                Message = "Login not correct, empty user name or password";
                DisplayInvalidLoginPrompt();
            }
            else
            {
                //Title = "Authentification Successful !";
                //Message = "Welcome, This could be your Dashboard";
                //DisplayInvalidLoginPrompt();

                //Nav.PushAsync(new MasterEmp());


            }

            var page1 = DependencyService.Get<ContactViewModel>() ?? (new ContactViewModel(_nav));

        });
    }
}
