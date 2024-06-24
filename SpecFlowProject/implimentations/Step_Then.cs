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
    public partial class Step_Then : ContextHelper
    {
        private ScenarioContext _scenarioContext;

        public Step_Then(ScenarioContext context)
        {
            _scenarioContext = context;
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var expectedProduct = table.CreateInstance<ProductDetails>();
            expectedProduct.ProductID = ProductContextDetails.ProductDetails.ProductID;
            table.CompareToInstance(ProductContextDetails.ProductDetails);

        }

        [Then(@"a message (.*) is displayed to the customer")]
        public void ThenSomeMessageIsDisplayedToTheCustomer(string expectedMessage)
        {
            Assert.AreEqual(_scenarioContext[ContextConstants.MESSAGE], expectedMessage);
        }

        [Then(@"the offer is valid")]
        [Then(@"the offer is not valid")]
        public void ThenTheOfferIsValid()
        {
           
        }

        [Then(@"the clothing data is translated as following")]
        public void ThenTheClothingDataIsTranslatedAsFollowing(Table table)
        {
            table.CompareToSet(ClothesToByContext.ClothesToByDetails);
        }

        [Then(@"user receives special discount")]
        public void ThenUserReceivesSpecialDiscount()
        {
            
        }
    }
}
