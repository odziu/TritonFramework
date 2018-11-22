using System;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class RegistrationPage : MainPage
    {
        public RegistrationPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Locators

        private By LOGIN_FIELD = By.Id("signupform-username");
        private By EMAIL_FIELD = By.Id("signupform-email");
        private By PASSWORD_FIELD = By.Id("signupform-password");
        private By SIGNUP_BTN = By.XPath("//button[@name='signup-button']");
        
        #endregion

        #region UI Elements

        private IWebElement LoginField => webDriver.FindElement(LOGIN_FIELD);

        private IWebElement EmailField => webDriver.FindElement(EMAIL_FIELD);

        private IWebElement PasswordField => webDriver.FindElement(PASSWORD_FIELD);

        private IWebElement SignUpBtn => webDriver.FindElement(SIGNUP_BTN);

        #endregion

        #region Methods
        
        public MainPage SignUp()
        {
            var mainPage = new MainPage(webDriver);
            LoginField.Clear();
            LoginField.SendKeys(RandomUsername);
            EmailField.Clear();
            EmailField.SendKeys(DateTime.Now.ToString("MMddyyyyhhmmsstt") + "@mail.com");
            PasswordField.Clear();
            PasswordField.SendKeys(RandomPassword);
            waiters.ClickAndWaitForPageToLoad(SignUpBtn);
            return mainPage;
        }

        #endregion
    }
}
