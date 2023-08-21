using OpenQA.Selenium;
using System.Xml.Linq;
using TestProject.PageObject;
using TestProject.Serv;
using static RestAssured.Dsl;




namespace TestProject.Test
{
    public class AuthorizationTest : BaseClass

    {

        //[Test]
        //public void LoginWithCorrectCredentials()
        //{
        //    var LoginPage = Navigation.NavigateToLoginPage(driver);
        //}

        //[Test]
        //public void LoginWithWrongCredentials()
        //{
        //    var LoginPage = Navigation.NavigateToLoginPage(driver);
        //    var a = LoginPage.GoToSignupPage(driver).AccountNextCreatedPage(driver);
        //}



        [Test, Order(1)]
        public void AddingAndRemovingItemsToCart()
        {
            var ProductPage = Navigation.NavigateToProductPage(driver);
            ProductPage.ScrollTo(driver);
            ProductPage.AddItemToCart(driver);
            ProductPage.OpenPageViewCart(driver).RemoveItemFromCart(driver);
        }


        //[Test]
        //public void GetLocationsForUsZipCode90210_CheckStatusCode_ShouldBe200()
        //{
        //    Given()
        //    .When()
        //    .Get("http://api.zippopotam.us/us/90210")
        //    .Then()
        //    .StatusCode(200);
        //}
    }
}




