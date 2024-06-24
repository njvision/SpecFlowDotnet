using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.utils
{
    internal class BooleanCustomRetriver : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value)
            {
                case "y":
                case "T":
                case "yes":
                case "true":
                case "no":
                case "n":
                case "F":
                case "false":
                    return true;
                default:
                    return false;
            }
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            switch (keyValuePair.Value)
            {
                case "y":
                case "T":
                case "yes":
                case "true":
                    return true;
                case "no":
                case "n":
                case "F":
                case "false":
                    return false;
                default:
                    return false;
            }

        }
    }
}
