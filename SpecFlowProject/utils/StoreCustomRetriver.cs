using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.utils
{
    internal class StoreCustomRetriver : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return propertyType == typeof(GeoLocation);
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            string value = keyValuePair.Value;
            List<string> elements = value.Split(",").ToList();
            return new GeoLocation { Latitude = elements.First(), Longitude = elements.Last() };
        }
    }
}
