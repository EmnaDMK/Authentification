using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Authentification.Model;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    public  class ContactViewModel : BaseViewModel
    {



        #region Fields

        public INavigation navigation;

        public Command<Object> _tapCommand;

        #endregion



        #region Properties

        public Command<Object> TapCommand

        {

            get { return _tapCommand; }

            set { _tapCommand = value; }

        }



        public INavigation Navigation

        {

            get { return navigation; }

            set { navigation = value; }

        }



        #endregion



        #region Constructor with parameters



        public ContactViewModel(INavigation _nav)

        {

            Navigation = _nav; ;

            _tapCommand = new Command<Object>(OnTapped);
            DependencyInject<View.Page1>.Get();
            OpenPage();
        }



        #endregion



        #region OnTapped Method Implementation

        public ContactViewModel()
        {
                
        }

        public void OnTapped(Object o)

        {

            var nextPage = new Page2();

            nextPage.BindingContext = o;

            Navigation.PushAsync(nextPage);

        }



        #endregion



        #region List of Names and Departments  



     

        public event PropertyChangedEventHandler PropertyChanged;





        #endregion



    }





}