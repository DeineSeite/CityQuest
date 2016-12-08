using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CityQuest.Navigation;
using CityQuest.Services;
using CityQuest.ViewModels;
using FreshMvvm;
using Xamarin.Forms;

namespace CityQuest.Forms
{
    public partial class App : Application
    {
        public  ThemedMasterDetailNavigationContainer MasterDetailNavigation { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeFreshMvvm();
            PrepairMasterDetailNav();
            MainPage = MasterDetailNavigation;
        }
        #region Private methods
        void InitializeFreshMvvm()
        {
            FreshPageModelResolver.PageModelMapper = new CityQuestPageModelMapper();
        }

        void PrepairMasterDetailNav()
        {
            MasterDetailNavigation= new ThemedMasterDetailNavigationContainer();;
            MasterDetailNavigation.Init("Menu","Menu.png");
            MasterDetailNavigation.AddPageWithIcon<StartPageViewModel>("Home", "home.png");
            MasterDetailNavigation.AddPageWithIcon<NewsPageViewModel>("News", "news.png");
            MasterDetailNavigation.AddPageWithIcon<QuestsListPageViewModel>("Quests", "quests.png");
        }
#endregion
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
