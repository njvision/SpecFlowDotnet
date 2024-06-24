using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.utils
{
    public class ClothesSizeComparer : IValueComparer
    {
        public bool CanCompare(object actualValue)
        {
            return actualValue is InternalStorage;
        }

        public bool Compare(string expectedValue, object actualValue)
        {
            return (actualValue as InternalStorage).InternalName == expectedValue;
        }
    }
}
