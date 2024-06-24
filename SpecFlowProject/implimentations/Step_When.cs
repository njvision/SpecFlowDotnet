using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist.Attributes;
using TechTalk.SpecFlow.Assist;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowProject.utils;

namespace SpecFlowProject.definition
{
    [Binding]
    public partial class Step_When : ContextHelper
    {
        private ScenarioContext _scenarioContext;

        public Step_When(ScenarioContext context)
        {
            _scenarioContext = context;
        }

        [When(@"I click the Add to Busket button")]
        public void WhenIClickTheAddToBusketButton()
        {
            if (ProductContextDetails.ProductDetails.Stock != 0 && ProductContextDetails.ProductDetails.Basket != 1)
            {
                ProductContextDetails.ProductDetails.Basket++;
                ProductContextDetails.ProductDetails.Stock--;
                _scenarioContext.Add(ContextConstants.MESSAGE, "Added to basket");
            }
            else if (ProductContextDetails.ProductDetails.Basket == 1)
            {
                _scenarioContext.Add(ContextConstants.MESSAGE, "Limited to one only");
            }
            else
            {
                _scenarioContext.Add(ContextConstants.MESSAGE, "Not in stock");
            }
        }

        [When(@"user add offer code '([^']*)' to the basket")]
        public void WhenUserAddOfferCodeToTheBasket(string p0)
        {
           
        }

        [When(@"user adds offer code '([^']*)' to the basket")]
        public void WhenUserAddsOfferCodeToTheBasket(string p0)
        {
           
        }

    }
}
