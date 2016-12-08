using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityQuest.Pages;
using CityQuest.UserControls;
using CityQuest.ViewModels;
using FreshMvvm;
using Xamarin.Forms;

namespace CityQuest.Navigation
{
    public class ThemedMasterDetailNavigationContainer : FreshMasterDetailNavigationContainer
    {
        List<Models.MenuItem> pageIcons = new List<Models.MenuItem>();

        public void AddPageWithIcon<T>(string title, string icon = "", object data = null) where T : FreshBasePageModel
        {
            base.AddPage<T>(title, data);
            pageIcons.Add(new Models.MenuItem
            {
                Title = title,
                IconSource = icon
            });
        }

        protected override void CreateMenuPage(string menuPageTitle, string menuIcon = null)
        {
            var listview = new ListView();
            var _menuPage =(MenuPage)FreshPageModelResolver.ResolvePageModel<MenuPageViewModel>();
            _menuPage.Title = menuPageTitle;

            listview.ItemsSource = pageIcons;
         
            var cell = new DataTemplate(typeof(MenuItemTemplate));

           
            listview.ItemTemplate = cell;
            if (Device.OS == TargetPlatform.iOS)
            {
                listview.SeparatorVisibility = SeparatorVisibility.None;
            }
            listview.ItemSelected += (sender, args) =>
            {
                if (Pages.ContainsKey(((Models.MenuItem)args.SelectedItem).Title))
                {
                    Detail = Pages[((Models.MenuItem)args.SelectedItem).Title];
                }
                IsPresented = false;
            };

            _menuPage.MenuContentView= listview;
            NavigationPage.SetHasNavigationBar(_menuPage, false);
            var navPage = new NavigationPage(_menuPage) { Title = "Menu" };
            if (!string.IsNullOrEmpty(menuIcon))
                navPage.Icon = menuIcon;

            Master = navPage;

        }

        protected override Page CreateContainerPage(Page page)
        {
            var navigation = new NavigationPage(page);
            navigation.BarTextColor = Color.White;

            return navigation;
        }
    }
}
