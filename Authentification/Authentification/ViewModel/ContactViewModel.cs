using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Authentification.Model;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    public class ContactViewModel : BaseViewModel
    {



        #region Fields

        //public INavigation navigation;

        public Command<Object> _tapCommand;
        public Command<Object> _RemoveCommand;

        #endregion



        #region Properties

        public Command<Object> TapCommand

        {

            get { return _tapCommand; }

            set { _tapCommand = value; }

        }

        public Command<Object> RemoveCommand

        {

            get { return _RemoveCommand; }

            set { _RemoveCommand = value; }

        }


        //public INavigation Navigation

        //{

        //    get { return navigation; }

        //    set { navigation = value; }

        //}



        #endregion



        #region Constructor with parameters



        public ContactViewModel(INavigation nav)

        {

            _nav = nav;
            ;

            _tapCommand = new Command<Object>(OnTapped);

            _RemoveCommand = new Command<Object>(OnRemove);
            CurrentPage = DependencyInject<View.Page1>.Get();
            OpenPage();





        }

        public ContactViewModel(INavigation nav, ObservableCollection<Employee> ctv)

        {

            _nav = nav;

            _tapCommand = new Command<Object>(OnTapped);
            _RemoveCommand = new Command<Object>(OnRemove);
            ContactList = ctv;
            CurrentPage = DependencyInject<View.Page1>.Get();

            OpenPage();





        }



        #endregion



      

        public ContactViewModel()
        {

        }

        public void OnTapped(Object o)

        {

            var nextPage = new Page2();

            nextPage.BindingContext = o;

            _nav.PushAsync(nextPage);

        }

        public void OnRemove(Object o)
        {
            if (o != null)
            {
                var employee = o as Employee;
                ContactList.Remove(employee);
            }
        }


        public ICommand OnAddCommand => new Command(async () =>
        {

            var page = DependencyService.Get<ViewModel.AddNewItem>() ?? new AddNewItem(_nav);

        });

        public ICommand OnUpCommand => new Command(async () =>
        {

            var page = DependencyService.Get<ViewModel.UpadateItemViewModel>() ?? new UpadateItemViewModel(_nav);

        });


        //public ICommand SaveCommand => new Command(async () =>
        //{

        //    var page = DependencyService.Get<ViewModel.UpadateItemViewModel>() ?? new UpadateItemViewModel(_nav);

        //});

    }
}