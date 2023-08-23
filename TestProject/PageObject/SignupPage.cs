using OpenQA.Selenium;
using TestProject.Helpers;
using TestProject.PageObject;



namespace TestProject.PageObject
{
    public class SignupPage
    {
        private IWebDriver _driver;
        private readonly By signupPage = By.XPath("//b[text()='Enter Account Information']");
        private readonly By fieldTitleGenderMrSignup = By.XPath("//div[@id='uniform-id_gender1']");
        //private readonly By fieldPasswordSignup = By.XPath("//input[@id='password']");
        //private readonly By fieldDateOfBirthDays = By.XPath("//select[@id='days']");
        private readonly By day = By.XPath("//option[@value='1']");
        //private readonly By fieldDateOfBirthMonths = By.XPath("//select[@id='months']");
        private readonly By months = By.XPath("//option[@value='6']");
        //private readonly By fieldDateOfBirthYears = By.XPath("//select[@id='years']");
        private readonly By years = By.XPath("//option[@value='1982']");
        private readonly By checkboxNewsletter = By.XPath("//*[@id='newsletter']");
        private readonly By checkboxSpecialOffers = By.XPath("//*[@id='optin']");
        //private readonly By firstName = By.XPath("//input[@id='first_name']");
        //private readonly By lastName = By.XPath("//input[@id='last_name']");
        //private readonly By company = By.XPath("//input[@id='company']");
        //private readonly By address = By.XPath("//input[@id='address1']");
        //private readonly By address2 = By.XPath("//input[@id='address2']");
        private readonly By country = By.XPath("//select[@id='country']");
        private readonly By countryCanada = By.XPath("//option[@value='Canada']");
        //private readonly By state = By.XPath("//input[@id='state']");
        //private readonly By city = By.XPath("//input[@id='city']");
        //private readonly By zipcode = By.XPath("//input[@id='zipcode']");
        //private readonly By mobileNumber = By.XPath("//input[@id='mobile_number']");
        private readonly By buttonCreateAccount = By.XPath("//button[text()='Create Account']");


        private By GetLocator(Id id) => By.XPath($"//input[@id='{id}']");
        private By GetLocator2(Value value) => By.XPath($"//select[@id='{value}']");

        private enum Id
        {
            password,
            first_name,
            last_name,
            company,
            address1,
            address2,
            state,
            city,
            zipcode,
            mobile_number
        }

        private enum Value
        {
            days,
            months,
            years
        }


        public SignupPage(IWebDriver driver)
        {
            _driver = driver;
            var _signupPage = driver.FindElement(signupPage);
            // Helpers.Helper.CheckLocation(_driver, "");
        }


        public void FillingFields(IWebDriver driver)
        {
            var _fieldTitleGenderMrSignup = driver.FindElement(fieldTitleGenderMrSignup);
            _fieldTitleGenderMrSignup.Click();

            var _fieldPasswordSignup = driver.FindElement(GetLocator(Id.password));
            _fieldPasswordSignup.SendKeys(DataFaker.GeneratePasswordSignup());


            var _fieldDateOfBirthDays = driver.FindElement(GetLocator2(Value.days));
            _fieldDateOfBirthDays.Click();

            var _day = driver.FindElement(day);
            _day.Click();

            var _fieldDateOfBirthMonths = driver.FindElement(GetLocator2(Value.months));
            _fieldDateOfBirthMonths.Click();

            var _months = driver.FindElement(months);
            _months.Click();

            var _fieldDateOfBirthYears = driver.FindElement(GetLocator2(Value.years));
            _fieldDateOfBirthYears.Click();

            var _years = driver.FindElement(years);
            _years.Click();

            var _checkboxNewsletter = driver.FindElement(checkboxNewsletter);
            _checkboxNewsletter.Click();

            var _checkboxSpecialOffers = driver.FindElement(checkboxSpecialOffers);
            _checkboxSpecialOffers.Click();

            var _firstName = driver.FindElement(GetLocator(Id.first_name));
            _firstName.SendKeys(DataFaker.GenerateNameFirst());

            var _lastName = driver.FindElement(GetLocator(Id.last_name));
            _lastName.SendKeys(DataFaker.GenerateNameLast());

            var _company = driver.FindElement(GetLocator(Id.company));
            _company.SendKeys(DataFaker.GenerateCompanyName());

            var _address = driver.FindElement(GetLocator(Id.address1));
            _address.SendKeys(DataFaker.GenerateAddress());

            var _address2 = driver.FindElement(GetLocator(Id.address2));
            _address2.SendKeys(DataFaker.GenerateAddress());

            var _country = driver.FindElement(country);
            _country.Click();

            var _countryCanada = driver.FindElement(countryCanada);
            _countryCanada.Click();

            var _state = driver.FindElement(GetLocator(Id.state));
            _state.SendKeys(DataFaker.GenerateState());

            var _city = driver.FindElement(GetLocator(Id.city));
            _city.SendKeys(DataFaker.GenerateAddressCity());

            var _zipcode = driver.FindElement(GetLocator(Id.zipcode));
            _zipcode.SendKeys(DataFaker.GenerateAddressZipCode());

            var _mobileNumber = driver.FindElement(GetLocator(Id.mobile_number));
            _mobileNumber.SendKeys(DataFaker.GeneratePhoneNumber());

        }

        public AccountCreatedPage AccountNextCreatedPage(IWebDriver driver)
        {
            var _buttonCreateAccount = driver.FindElement(buttonCreateAccount);
            Helper.WaitElementIsVisible(driver,(By)_buttonCreateAccount);
            _buttonCreateAccount.Click();

            return new AccountCreatedPage(driver);
        }
    }
}


