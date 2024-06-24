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

[assembly: Parallelize(Scope = ExecutionScope.ClassLevel)]
namespace SpecFlowProject.definition;

[Binding]
public partial class Step_Given : ContextHelper
{
    [Given(@"I have the following data")]
    public void GivenIHaveTheFollowingData(Table table)
    {

        ProductContextDetails.ProductDetailsList = table.CreateSet<ProductDetails>();

    }

    [Given(@"I am on the product detail page of product (.*)")]
    public void GivenIAmOnTheProductDetailPageOfProduct(string productName)
    {
        ProductContextDetails.ProductDetails = ((IEnumerable<ProductDetails>)ProductContextDetails.ProductDetailsList).Where(x => x.ProductID == productName).First();
    }

    [Given(@"user have following offercodes")]
    public void GivenUserHaveFollowingOffercodes(Table table)
    {
        OfferCodesContextDetails.OfferCodesList = table.CreateSet<OfferCodes>();
    }


    [Given(@"today is '([^']*)'")]
    public void GivenTodayIs(DateTime today)
    {

    }

    [Given(@"user have following size of clothes")]
    public void GivenUserHaveFollowingSizeOfClothes(Table table)
    {
        ClothesToByContext.ClothesToByDetails = table.CreateSet<ClothesToBy>();

    }

    [Given(@"exists following users")]
    public void GivenExistsFollowingUsers(Table table)
    {
       UserContext.UserList = table.CreateSet<Users>();
    }

    [Given(@"user has the following stores")]
    public void GivenUserHasTheFollowingStores(IEnumerable<Stores> stores)
    {
        var value = stores;
    }

    [Given(@"user has offer code '([^']*)' which expires in '([^']*)'")]
    [Given(@"user has offer code '([^']*)' which expires '([^']*)'")]
    public void GivenUserHasOfferCodeWhichExpiresIn(string code, DateTime date)
    {
        
    }

    [Given(@"user is '([^']*)' customer to view the offer page")]
    public void GivenUserIsCustomerToViewTheOfferPage(int order)
    {
        
    }


}

