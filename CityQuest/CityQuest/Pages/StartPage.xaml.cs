using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityQuest.Pages
{
  
    public partial class StartPage : BasePage
    {
        public StartPage()
        {
            InitializeComponent();
            QuestWebView.Source = "http://app.deineseite.at/cityquest/TestQuest/Quest1.html";
        }
    }
}
