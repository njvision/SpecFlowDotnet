using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.utils
{
    [Binding]
    public class TimeTransformationArgument
    {
        [StepArgumentTransformation(@"(\d+) days time")]
        public DateTime DaysTime(int days)
        {
            return Caculations(-days);
        }

        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgo(int days)
        {
            return Caculations(days);
        }

        [StepArgumentTransformation(@"(\d+)(?:st|nd|rd|th)")]
        public int Order(int order)
        {
            return order;
        }

        [StepArgumentTransformation]
        public IEnumerable<Stores> StoresConversion(Table table)
        {
            return table.CreateSet<Stores>();
        }

        private DateTime Caculations(int days)
        {
            return DateTime.Today.Add(TimeSpan.FromDays(days));
        }
    }
}
