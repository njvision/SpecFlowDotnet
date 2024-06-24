using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist.Attributes;

namespace SpecFlowProject
{
    /*    public class Product
        {
            private static IEnumerable<ProductDetails> productDetailsList;
            private static ProductDetails productDetails;
            private static ProductDetails expectedProduct;
            private static string message;

            public static IEnumerable<ProductDetails> ProductDetailsList { get { return productDetailsList; } set { productDetailsList = value; } }
            public static ProductDetails ProductDetails { get { return productDetails; } set { productDetails = value; } }
            public static ProductDetails ExpectedProduct { get { return expectedProduct; } set { expectedProduct = value; } }
            public static string Message { get { return message; } set { message = value; } }

        }
    */
    public class ProductDetails
    {
        public string ProductID { get; set; }

        [TableAliases("Reserve Qty")]
        public int Stock { get; set; }

        public int Basket { get; set; }
    }

    public class ProductContextDetails
    {
        public IEnumerable<ProductDetails> ProductDetailsList;
        public ProductDetails ProductDetails;
    }

    public class OfferCodesContextDetails
    {
        public IEnumerable<OfferCodes> OfferCodesList;
        public DateTime OfferCodesDate;
    }

    public class OfferCodes
    {
        public string OfferCode { get; set; }
        public DateTime Expiry { get; set; }
        public OfferCodesType CodesType { get; set; }

        public bool IsValid { get; set; }
    }

    public enum OfferCodesType
    {

        ByDate,
        ByProduct,
        ByDay
    }

    public class ClothesToBy
    {
        [TableAliases("Name")]
        public string ProductName { get; set; }

        [TableAliases("Size")]
        public InternalStorage WebSize { get; set; }
    }

    public class InternalStorage
    {
        public string InternalName { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }

    public class ClothesToByContext
    {
        public IEnumerable<ClothesToBy> ClothesToByDetails;
        public ClothesToBy ClothesToBy;
    }

    public class Users
    {
        public string Name { get; set; }
        public User UserType { get; set; }
        public DateTime? LoginOutLast { get; set; }
    }

    public class User
    {
        public int AccessLevel { get; set; }
        public UserStateEnum State { get; set; }
    }

    public enum UserStateEnum
    {
        Superviser,
        Staff,
        Customer,
        Visitor,
        Undefined
    }

    public class UserContext
    {
        public IEnumerable<Users> UserList;
        public Users User;

    }

    public class Stores
    {
        public string StoreName { get; set; }
        public GeoLocation GeoLocation { get; set; }
    }

    public class GeoLocation
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
