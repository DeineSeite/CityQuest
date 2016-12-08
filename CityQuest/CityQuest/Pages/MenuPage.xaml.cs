using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CityQuest.Pages
{
    public partial class MenuPage : BasePage
    {
        public View MenuContentView
        {
            get { return MenuView.Content; }
            set { MenuView.Content = value; }
        }

        public MenuPage()
        {
            InitializeComponent();
        }
    }
}
