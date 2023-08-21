using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TestProject.PageObject;

namespace TestProject.Helpers
{
    public static class Helper
    {
        public static void CheckLocation(IWebDriver webDriver, string location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(20))
                    .Until(ExpectedConditions.UrlContains(location));

            }
            catch (WebDriverTimeoutException ex)
            {

                throw new NotFoundException($"Cannot find location:  {location}", ex);
            }
        }

        public static void WaitElementIsVisible(IWebDriver driver, By element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
              .Until(ExpectedConditions
              .VisibilityOfAllElementsLocatedBy(element));
        }

        public static void SendText(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
