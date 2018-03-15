using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Input;
using Authentification.Model;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    class UpadateItemViewModel : BaseViewModel
    {


        public Action DisplayPrompt;

        public UpadateItemViewModel()

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

        public UpadateItemViewModel(Employee emp, INavigation nav)

        {

            //emp._name = name;
            //emp._gsm = gsm;

            gsm = emp._gsm;

            _nav = nav;

            CurrentPage = DependencyInject<Page2>.Get();

            OpenPage();

        }

        public int nnn;
        private Employee s;

        public ICommand SaveCommandUp => new Command(async () =>

        {

            foreach (Employee emp in ContactList)

            {


                if (emp._name.Equals(name))
                {


                    emp._name = name;
                    emp._gsm = gsm;
                    //await CurrentPage.DisplayAlert("Modif", "Modification avec succes", "Okay");
                }

                //nnn = ContactList.Count;

                //    ContactList.Remove(emp);
                //    nnn = ContactList.Count;
                //    Contacts = ContactList;


            }

          await  _nav.PopAsync();
            var page = DependencyService.Get<ViewModel.ContactViewModel>() ?? new ContactViewModel(_nav, ContactList);
        });

        public UpadateItemViewModel(INavigation nav)

        {

            _nav = nav;

            CurrentPage = DependencyInject<Page2>.Get();

            OpenPage();



        }


        //    public ICommand DeleteCommand => new Command(async () =>

        //    {
        //           foreach (Employee emp in ContactList)

        //    {


        //        if (emp._name.Equals(name))
        //        {
        //            ContactList.Remove(emp);
        //        }

        //            //foreach (Employee emp in ContactList)

        //            //{


        //            //    if (emp._name.Equals(name))
        //            //    {


        //            //        nnn = ContactList.Count;

        //            //        ContactList.Remove(emp);
        //            //        nnn = ContactList.Count;



        //            //    }

        //            //    Contacts = ContactList;


        //        }

        //        var page = DependencyService.Get<ViewModel.ContactViewModel>() ?? new ContactViewModel(_nav, Contacts);
        //    });
    }
}
