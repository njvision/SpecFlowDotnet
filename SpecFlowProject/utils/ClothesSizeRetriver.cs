using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.utils
{
    public class ClothesSizeRetriver : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return propertyType == typeof(InternalStorage);

        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value)
            {
                case "XXL":
                    return new InternalStorage { InternalName = "ExtraLarge", Width = "240cm", Height = "240cm" };
                case "L":
                    return new InternalStorage { InternalName = "Large", Width = "200cm", Height = "200cm" };
                case "S":
                    return new InternalStorage { InternalName = "Small", Width = "140cm", Height = "140cm" };
                default:
                    return new InternalStorage { InternalName = "Unidentify", Width = "none", Height = "none" };

            }
        }
    }
}
