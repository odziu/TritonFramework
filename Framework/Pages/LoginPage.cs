using OpenQA.Selenium;

namespace Framework.Pages
{
    public class LoginPage : MainPage
    {
        private IWebDriver webDriver;
        
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Locators

        private By LOGIN_FIELD = By.Id("loginform-username");
        private By PASSWORD_FIELD = By.Id("loginform-password");
        private By LOGIN_BTN = By.XPath("//button[@name='login-button']");
        private By REGISTRATION_BTN = By.XPath("//a[@href='/account/registration']");
        private By HELP_BLOCK = By.XPath("//form[@id='login-form']/div[2]/p[@class='help-block help-block-error']");

        #endregion

        #region UI Elements

        public IWebElement LoginBtn => webDriver.FindElement(LOGIN_BTN);

        private IWebElement LoginField => webDriver.FindElement(LOGIN_FIELD);

        private IWebElement PasswordField => webDriver.FindElement(PASSWORD_FIELD);

        private IWebElement RegistrationBtn => webDriver.FindElement(REGISTRATION_BTN);

        public IWebElement HelpBlock => webDriver.FindElement(HELP_BLOCK);

        #endregion

        #region Methods

        public AccountPage LogIn()
        {
            var accountPage = new AccountPage(webDriver);
            LoginField.Clear();
            LoginField.SendKeys("6546565");
            PasswordField.Clear();
            PasswordField.SendKeys("p77p77");
            waiters.ClickAndWaitForPageToLoad(LoginBtn);
            return accountPage;
        }

        public AccountPage LogInRandomAccount()
        {
            var accountPage = new AccountPage(webDriver);
            LoginField.Clear();
            LoginField.SendKeys(RandomUsername);
            PasswordField.Clear();
            PasswordField.SendKeys(RandomPassword);
            waiters.ClickAndWaitForPageToLoad(LoginBtn);
            return accountPage;
        }

        public LoginPage LogInWithInvalidCredentials()
        {
            var loginPage = new LoginPage(webDriver);
            LoginField.Clear();
            LoginField.SendKeys(RandomUsername);
            PasswordField.Clear();
            PasswordField.SendKeys(RandomPassword);
            waiters.ClickAndWaitForPageToLoad(LoginBtn);
            return loginPage;
        }

        public RegistrationPage GoToRegistrationPage()
        {
            var registrationPage = new RegistrationPage(webDriver);
            waiters.ClickAndWaitForPageToLoad(RegistrationBtn);
            return registrationPage;
        }

        #endregion
    }
}
