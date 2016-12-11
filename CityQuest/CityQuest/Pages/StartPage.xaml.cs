using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Compass;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CityQuest.Pages
{
  
    public partial class StartPage : BasePage
    {
        public StartPage()
        {
            InitializeComponent();
            QuestWebView.Source = "http://app.deineseite.at/cityquest/TestQuest/Compass.html";
            CrossCompass.Current.CompassChanged += (s, e) =>
            {
                Debug.WriteLine("*** Compass Heading = {0}", Math.Round(e.Heading, 5));

                QuestWebView.Eval(string.Format("rotateCompass({0})", Math.Round(e.Heading,5)));

            };

            CrossCompass.Current.Start();
        }
    }
}