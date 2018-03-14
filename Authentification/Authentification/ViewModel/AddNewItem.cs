using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Authentification.Model;
using Authentification.View;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    class AddNewItem : BaseViewModel
    {
      


        public int nnn;
        public Employee emp;

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

        public ICommand SaveCommand => new Command(async () =>

        {

            Employee emp = new Employee

            {

                _name = name,
                _gsm = gsm,
                _image = ImageSource.FromResource("Authentification.Images.image0.png")

            };
            nnn = ContactList.Count;
            ContactList.Add(emp);
            nnn = ContactList.Count;

            var page = DependencyService.Get<ViewModel.ContactViewModel>() ?? (new ContactViewModel(_nav));


        });

        public AddNewItem(INavigation nav)

        {

            _nav = nav;

            CurrentPage = DependencyInject<AddView>.Get();

            OpenPage();



        }



        public AddNewItem()

        {

        }

    }

}

