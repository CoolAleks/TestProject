using OpenQA.Selenium;
using TestProject.Helpers;

namespace TestProject.PageObject
{
    public class MainMenuPage
    {
        private IWebDriver driver;

        readonly By pageTitleDisplay = By.XPath("//a[contains(text(),' Home')]");
        readonly By buttonLogin = By.XPath("//a[contains(text(),' Signup')]");


        public MainMenuPage(IWebDriver driver)
        {
            this.driver = driver;
            var _pageTitleDisplay = driver.FindElement(pageTitleDisplay);
            Assert.That(_pageTitleDisplay.Text, Is.EqualTo("Home"));
        }

        public LoginPage LoginButtonClick(IWebDriver driver)
        {
            var _buttonLogin = driver.FindElement(buttonLogin);
            Helper.WaitElementIsVisible(driver, buttonLogin);
            _buttonLogin.Click();
            return new LoginPage(driver);

        }
    }
}
