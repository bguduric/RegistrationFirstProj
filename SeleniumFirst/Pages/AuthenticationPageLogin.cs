using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst.Pages
{
    class AuthenticationPageLogin
    {
       

        private IWebDriver driver;

        public AuthenticationPageLogin(IWebDriver driver)
        {
            this.driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("center_column")));
        }

        public IWebElement EmailInputField()
        {
            By email = By.Id("email");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(email));
        }

        public IWebElement PasswordInputField()
        {
            By password = By.Id("passwd");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(password));
        }

        public IWebElement SignInButton()
        {
            By signIn = By.Id("SubmitLogin");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(signIn));
        }

        public bool IsPageDisplayed()
        {
            By authPage = By.Id("center_column");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(authPage)).Displayed;
        }
    }
}

