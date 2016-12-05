using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CityQuest.Services;
using CityQuest.ViewModels;
using FreshMvvm;
using Xamarin.Forms;

namespace CityQuest.Forms
{
    public partial class App : Application
    {
        public App()
        {
      
            InitializeComponent();
            InitializeFreshMvvm();
            var page= FreshMvvm.FreshPageModelResolver.ResolvePageModel<TestPageViewModel>();
            MainPage = new FreshNavigationContainer(page);
        }

        void InitializeFreshMvvm()
        {
            FreshPageModelResolver.PageModelMapper = new CityQuestPageModelMapper();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
