using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Authentification.Model;
using Xamarin.Forms;

namespace Authentification.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged

    {
        private string[] Names = new string[]

        {

            "Rym",
            "Aymen",
            "Yassin",
            "Emna",
            "Salwa",

        };

        public ObservableCollection<Employee> ContactList { get; set; } 
        public INavigation _nav;
        public Action DisplayInvalidLoginPrompt;
        public ContentPage CurrentPage { get; set; }

        public BaseViewModel()
        {
            ContactList = new ObservableCollection<Employee>();

            Random r = new Random();

            foreach (var name in Names)

            {

                var Contact = new Employee(name, r.Next(216, 870).ToString() + "-" + r.Next(22222222, 22999999));

                Contact.Image = ImageSource.FromResource("Authentification.Images.image" + r.Next(0, 3) + ".png");


                ContactList.Add(Contact);


            }
        }

        public ObservableCollection<Employee> EmployeeList

        {

            get

            {



                return ContactList ?? (ContactList = new ObservableCollection<Employee>());

            }

            set

            {

                ContactList = value;

                OnPropertyChanged("EmployeeList");

            }

        }

        public void OpenPage()

        {



            if (CurrentPage != null)

            {

                CurrentPage.BindingContext = this;

                _nav.PushAsync(CurrentPage);

            }

        }

        bool isBusy = false;

        public bool IsBusy

        {

            get { return isBusy; }

            set { SetProperty(ref isBusy, value); }

        }



        string title = string.Empty;

        public string Title

        {

            get { return title; }

            set { SetProperty(ref title, value); }

        }



        protected bool SetProperty<T>(ref T backingStore, T value,

            [CallerMemberName]string propertyName = "",

            Action onChanged = null)

        {

            if (EqualityComparer<T>.Default.Equals(backingStore, value))

                return false;



            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyName);

            return true;

        }



        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")

        {

            var changed = PropertyChanged;

            if (changed == null)

                return;



            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion




        public ObservableCollection<Employee> Contacts

        {

            get

            {
  return ContactList ?? (ContactList = new ObservableCollection<Employee>());

            }

            set

            {

                ContactList = value;

                OnPropertyChanged("Contacts");

            }

        }
    }

}