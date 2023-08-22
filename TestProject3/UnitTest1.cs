using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestProject3
{
    public class Tests
    {

        public IWebDriver driver;
        public ChromeOptions chromeOptions = new ChromeOptions();

        [SetUp]
        public void Setup()

        {
            //without opening a browser
            //chromeOptions.AddArguments("headless");

            chromeOptions.AddArgument("--start-maximized");

            chromeOptions.PageLoadStrategy = PageLoadStrategy.None;
            driver = new ChromeDriver(@"C:\webdriver\chromedriver", chromeOptions);
            try
            {
                driver.Navigate().GoToUrl("https://automationexercise.com/products");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection to url: Failed " + ex.StackTrace);
            }
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }


        [Test]
        public void Run()
        {  // 1 display
            IWebElement pageTitleDisplay = driver.FindElement(By.XPath("//*[@id='search_product']"));
            pageTitleDisplay.Click();

            //2 scroll
            IWebElement fieldViewCart = driver.FindElement(By.XPath("//*[@id ='susbscribe_email']"));
            new Actions(driver).ScrollToElement(fieldViewCart).Perform();
            Thread.Sleep(6000);
            //3 click product

            var addProductToCart2 = driver.FindElement(By.XPath("//img[@src='/get_product_picture/43']/following-sibling::a"));
            // Return x and y coordinates referenced element
            System.Console.WriteLine(addProductToCart2.Location);
            // Returns height, width
            System.Console.WriteLine(addProductToCart2.Size);



            IWebElement addProductToCart = driver.FindElement(By.XPath("//img[@src='/get_product_picture/43']/following-sibling::a"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(addProductToCart).Click().Build().Perform();
            Thread.Sleep(6000);
            //4 click button View_Cart
            IWebElement clickViewCart = driver.FindElement(By.XPath("//u[text()='View Cart']"));
            clickViewCart.Click();

            //5 Assert Displayed
            IWebElement fieldShoppingCart = driver.FindElement(By.XPath("//li[@class='active']"));
            Assert.IsTrue(fieldShoppingCart.Displayed);
            Thread.Sleep(6000);

            //6 delete 
            IWebElement buttonDeleteProduct = driver.FindElement(By.XPath("//a[@class='cart_quantity_delete']"));
            buttonDeleteProduct.Click();
            Thread.Sleep(6000);

            //7 Assert  Displayed);
            IWebElement cartIsEmpty = driver.FindElement(By.XPath("//b[text()='Cart is empty!']"));
            Assert.IsTrue(cartIsEmpty.Displayed);
            Console.WriteLine(cartIsEmpty.Text);
            Console.WriteLine(cartIsEmpty.Text.Contains("Cart is empty!"));
            Thread.Sleep(6000);
           
        }
    }
}
