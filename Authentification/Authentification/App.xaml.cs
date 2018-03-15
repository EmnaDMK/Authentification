﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Authentification.View;
using Authentification.ViewModel;
using Xamarin.Forms;

namespace Authentification
{
	public partial class App : Application
	{
		public App ()
		{

			InitializeComponent();

            //MainPage = new NavigationPage(new Page1());
            ////{
            //    BarBackgroundColor = Color.FromHex("#000000")
            //};
            //MainPage = new NavigationPage(new AddNewItem());
            //MainPage = new Authentification.MainPage();
            //MainPage = new NavigationPage(new EmpManagement());
            //MainPage = new NavigationPage(new LoginViewModel());




            //var model = DependencyInject<AddNewItem>.Get();

            //model.CurrentPage = DependencyInject<AddView>.Get();

            //model.CurrentPage.BindingContext = model;

            //var nav = new NavigationPage(model.CurrentPage);

            //model._nav = nav.Navigation;

            //MainPage = nav;




            //var model = DependencyInject<UpadateItemViewModel>.Get();

            //model.CurrentPage = DependencyInject<EditView>.Get();

            //model.CurrentPage.BindingContext = model;

            //var nav = new NavigationPage(model.CurrentPage);

            //model._nav = nav.Navigation;

            //MainPage = nav;


            //var model = DependencyInject<RemoveItemView>.Get();

            //model.CurrentPage = DependencyInject<EditView>.Get();

            //model.CurrentPage.BindingContext = model;

            //var nav = new NavigationPage(model.CurrentPage);

            //model._nav = nav.Navigation;

            //MainPage = nav;


            var model = DependencyInject<LoginViewModel>.Get();

            model.CurrentPage = DependencyInject<MainPage>.Get();

            model.CurrentPage.BindingContext = model;

            var nav = new NavigationPage(model.CurrentPage);

            model._nav = nav.Navigation;

            MainPage = nav;



        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
