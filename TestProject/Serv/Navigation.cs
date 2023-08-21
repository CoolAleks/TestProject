using OpenQA.Selenium;
using TestProject.PageObject;


namespace TestProject.Serv
{
    public class Navigation
    {

        public static MainMenuPage NavigateToMainPage(IWebDriver driver)
        {
            driver.Url = "http://automationexercise.com";
            return new MainMenuPage(driver);
        }


        public static LoginPage NavigateToLoginPage(IWebDriver driver)
        {
            driver.Url = "http://automationexercise.com/login";
            return new LoginPage(driver);
        }

        public static ProductPage NavigateToProductPage(IWebDriver driver)
        {
            driver.Url = "https://automationexercise.com/products";
            return new ProductPage(driver);
        }

        public static ViewCartPage NavigateToViewCartPage(IWebDriver driver)
        {
            driver.Url = "https://automationexercise.com/view_cart";
            return new ViewCartPage(driver);
        }


    }
}
