using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Authentification.Model;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    class RemoveItemView : BaseViewModel
    {



        public RemoveItemView()

        {


        }

        public string name;

        public string Name

        {

            get { return name; }

            set

            {

                name = value;

                OnPropertyChanged();

            }

        }

        public string gsm;

        public string GSM

        {

            get { return gsm; }

            set

            {

                gsm = value;

                OnPropertyChanged();

            }
        }

        public RemoveItemView(Employee emp, INavigation nav)

        {

          
            _nav = nav;

            CurrentPage = DependencyInject<EditView>.Get();

            OpenPage();

        }
        public int nnn;

        public ICommand SaveCommand => new Command(async () =>

        {

            foreach (Employee emp in ContactList)

            {


                if (emp._name.Equals(name))
                {


                    nnn = ContactList.Count;

                    ContactList.Remove(emp);
                    nnn = ContactList.Count;
                   


                }

                Contacts = ContactList;


            }

            var page = DependencyService.Get<ViewModel.ContactViewModel>() ?? new ContactViewModel(_nav, Contacts);
        });

        public RemoveItemView(INavigation nav)

        {

            _nav = nav;

            CurrentPage = DependencyInject<EditView>.Get();

            OpenPage();



        }
    }
}

