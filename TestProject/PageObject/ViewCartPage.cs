using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TestProject.Helpers;


namespace TestProject.PageObject
{

    public class ViewCartPage
    {

        private IWebDriver _webDriver;
        readonly By buttonDeleteProduct = By.XPath("//a[@class='cart_quantity_delete']");
        readonly By cartIsEmpty = By.XPath("//*[@id='empty_cart']/p/b");


        public ViewCartPage(IWebDriver driver)
        {
            _webDriver = driver;
            Helper.CheckLocation(_webDriver, "/view_cart");
        }

        public void RemoveItemFromCart(IWebDriver driver)
        {
            var _buttonDeleteProduct = driver.FindElement(buttonDeleteProduct);
            _buttonDeleteProduct.Click();

            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10))
               .Until(ExpectedConditions.TextToBePresentInElementLocated(cartIsEmpty, "Cart is empty!"));

            //var _cartIsEmpty = driver.FindElement(cartIsEmpty);
            //Assert.That(_cartIsEmpty.Text.ToString, Is.EqualTo("Cart is empty!"));

        }
    }
}

