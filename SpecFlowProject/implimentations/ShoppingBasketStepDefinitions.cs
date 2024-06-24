using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;

namespace SpecFlowProject.definition
{

    public class ShoppingBasketStepDefinitions
    {
        private IEnumerable<ProductDetails> productDetailsList;
        private ProductDetails productDetails;
        private ProductDetails expectedProduct;
        private string message = "";

        private class ProductDetails
        {
            public string ProductID { get; set; }

            [TableAliases("Reserve Qty")]
            public int Stock { get; set; }

            public int Basket { get; set; }
        }
        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {

            productDetailsList = table.CreateSet<ProductDetails>();

        }

        [Given(@"I have vertical data")]
        public void GivenIHaveVerticalData(Table table)
        {

        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(string productName)
        {
            productDetails = productDetailsList.Where(x => x.ProductID == productName).First();
        }

        [When(@"I click the Add to Busket button")]
        public void WhenIClickTheAddToBusketButton()
        {
            if (productDetails.Stock != 0 && productDetails.Basket != 1)
            {
                productDetails.Basket++;
                productDetails.Stock--;
                message = "Added to basket";
            }
            else if (productDetails.Basket == 1)
            {
                message = "Limited to one only";
            }
            else
            {
                message = "Not in stock";
            }
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {

            expectedProduct = table.CreateInstance<ProductDetails>();
            expectedProduct.ProductID = productDetails.ProductID;
            table.CompareToInstance(expectedProduct);

        }

        [Then(@"a message (.*) is displayed to the customer")]
        public void ThenSomeMessageIsDisplayedToTheCustomer(string expectedMessage)
        {
            Assert.AreEqual(message, expectedMessage);
        }
    }
}
