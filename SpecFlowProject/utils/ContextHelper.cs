using Gherkin.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject.utils
{
    public class ContextHelper : Steps
    {
        protected ProductContextDetails ProductContextDetails
        {
            get
            {
                return ScenarioContext.ScenarioContainer.Resolve<ProductContextDetails>();
            }
        }

        protected OfferCodesContextDetails OfferCodesContextDetails
        {
            get
            {
                return ScenarioContext.ScenarioContainer.Resolve<OfferCodesContextDetails>();
            }
        }

        protected ClothesToByContext ClothesToByContext
        {
            get
            {
                return ScenarioContext.ScenarioContainer.Resolve<ClothesToByContext>();
            }
        }

        protected UserContext UserContext
        {
            get
            {
                return ScenarioContext.ScenarioContainer.Resolve<UserContext>();
            }
        }
    }
}
