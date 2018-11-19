using OpenQA.Selenium;

namespace Framework.Pages
{
    public class OrdersPage : MainPage
    {
        public IWebDriver webDriver;

        public OrdersPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Locators

        private By LOGOUT_BTN =
            By.XPath("//form[@action='/account/logout']/button[@type='submit']");
        
        #endregion

        #region UI Elements

        public IWebElement LogoutBtn => webDriver.FindElement(LOGOUT_BTN);
        
        #endregion

        #region Methods

        

        #endregion
    }
}
