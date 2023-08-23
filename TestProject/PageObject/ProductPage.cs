using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestProject.Helpers;

namespace TestProject.PageObject
{
    public class ProductPage
    {
        readonly IWebDriver _webDriver;

        //readonly By fieldViewCart = By.XPath("//*[@id ='susbscribe_email']");
        readonly By addProductToCart2 = By.XPath("(//a[@data-product-id='43'])[1]");
        readonly By clickViewCart = By.XPath("//u[text()='View Cart']");
        readonly By clickView = By.CssSelector(".col-sm-4:nth-child(36) .product-overlay .btn");



        public ProductPage(IWebDriver driver)
        {
            _webDriver = driver;
            Helper.CheckLocation(_webDriver, "/products");
        }

        public IWebElement ScrollTo(IWebDriver driver)
        {
            ((IJavaScriptExecutor)_webDriver)
        .ExecuteScript("arguments[0].scrollIntoView(true)", _webDriver.FindElement(clickView));
            return _webDriver.FindElement(clickView);
            //Actions actions = new Actions(driver);
            //actions.ScrollToElement(_webDriver.FindElement(clickView)).Perform();
        }

        public void AddItemToCart(IWebDriver driver)
        {
            var _addProductToCart2 = driver.FindElement(addProductToCart2);
            Actions actions = new Actions(driver);
            actions.MoveToElement(_addProductToCart2).Click().Build().Perform();

        }

        public ViewCartPage OpenPageViewCart(IWebDriver driver)
        {
            
            var _clickViewCart = driver.FindElement(clickViewCart);
            Helper.WaitElementIsVisible(driver, clickViewCart);
            _clickViewCart.Click();
            return new ViewCartPage(driver);

        }
    }
}


