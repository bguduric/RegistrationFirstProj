using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Pages
{
    class CreateAccountPage
    {
        private IWebDriver driver;

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("authentication")));

        }

        public bool IsPageDisplayed()
        {
            By createAcc = By.Id("authentication");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(createAcc)).Displayed;
        }

        public IWebElement MrClickable()
        {
            By MrClick = By.Id("id_gender1");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MrClick));
        }
        //public IWebElement MrsClickable()
        //{
        //    By MrsClick = By.Id("id_gender2");
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //    return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(MrsClick));
        //}


        public IWebElement FirstNameInputField()
        {
            By firstNameCustomer = By.Id("customer_firstname");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(firstNameCustomer));
        }

        public IWebElement LastNameInputField()
        {
            By lastName = By.Id("customer_lastname");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(lastName));
        }

        public IWebElement EmailField()
        {
            By emailCustomer = By.Id("email");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(emailCustomer));
        }
        public IWebElement CustomerPassword()
        {
            By customer_pass = By.CssSelector("input[id=passwd]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(customer_pass));
        }


        public IWebElement DateOfBirth()
        {
            By date_of_birth = By.Id("days");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(date_of_birth));


        }
        public IWebElement MonthOfBirth()
        {
            By month_of_birth = By.Id("months");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(month_of_birth));
        }
        public IWebElement YearOfBirth()
        {
            By year_of_birth = By.Id("years");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(year_of_birth));
        }

        public IWebElement SignUpCheckBox()
        {
            By check1 = By.XPath("//input[@id='newsletter']");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(check1));
        }
        public IWebElement ReceiveCheckBox()
        {
            By check2 = By.XPath("//input[@id='optin']");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(check2));
        }
        ////Your Address

        public IWebElement FirstName()
        {
            By first_name = By.CssSelector("input[id=firstname]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(first_name));
        }
        public IWebElement LastName()
        {
            By last_name = By.CssSelector("input[id=lastname]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(last_name));
        }
        public IWebElement Company()
        {
            By company = By.CssSelector("input[id=company]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(company));
        }
        public IWebElement Address()
        {
            By address = By.CssSelector("input[id=address1]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(address));
        }
        public IWebElement Address2()
        {
            By address2 = By.CssSelector("input[id=address2]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(address2));
        }
        public IWebElement City()
        {
            By city = By.CssSelector("input[id=city]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(city));
        }
        public IWebElement State()
        {
            By state = By.XPath("//select[@id='id_state']");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(state));
        }

        public IWebElement ZipCode()
        {
            By zipcode = By.CssSelector("input[id=postcode]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(zipcode));
        }
        public IWebElement SelectContury()
        {
            By select_contury = By.XPath("//select[@id='id_country']");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select_contury));
        }
        public IWebElement Additional_Info()
        {
            By textarea = By.CssSelector("textarea[id=other]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(textarea));
        }

        public IWebElement HomePhone()
        {
            By phone = By.CssSelector("input[id=phone]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(phone));
        }
        public IWebElement MobilePhone()
        {
            By mobile_phone = By.CssSelector("input[id=phone_mobile]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(mobile_phone));
        }
        public IWebElement Assign()
        {
            By assign = By.CssSelector("input[id=alias]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(assign));
        }

        public IWebElement RegisterButton()
        {
            By submit = By.Id("submitAccount");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(submit));
        }
    
    }
}
