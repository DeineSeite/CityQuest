using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;

namespace CityQuest.Services
{
   public class CityQuestPageModelMapper: IFreshPageModelMapper
    {
        public string GetPageTypeName(Type pageModelType)
        {
            return pageModelType.AssemblyQualifiedName
                  .Replace("PageViewModel", "Page")
                  .Replace("ViewModels","Pages");
            // .Replace("PageModel", "Page")

        }
    }
}
