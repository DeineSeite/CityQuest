using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace CityQuest.Core.ViewModels
{
    [ImplementPropertyChanged]
    public class TestPageViewModel:FreshMvvm.FreshBasePageModel
    {
        public string MainText { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            MainText = "Test Page!";
        }
    }
}
