using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Pages
{
    class AuthenticationPage
    {
        private IWebDriver driver;

        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("center_column")));
            
        }

        public IWebElement EmailInputField()
        {
            By email = By.Id("email_create");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(email));
        }

        public IWebElement CreateAnAccountButton()
        {
            By CreateAcc = By.Id("SubmitCreate");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CreateAcc));
        }

        public bool IsPageDisplayed()
        {
            By authPage = By.Id("center_column");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(authPage)).Displayed;
        }
    }
}
