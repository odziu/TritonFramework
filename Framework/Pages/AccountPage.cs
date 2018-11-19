using OpenQA.Selenium;

namespace Framework.Pages
{
    public class AccountPage : MainPage
    {
        public IWebDriver webDriver;

        public AccountPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Locators

        private By LOGOUT_BTN =
            By.XPath("//form[@action='/account/logout']/button[@type='submit']");
        private By SAVE_BTN =
            By.XPath("/html//div[@class='']//form[@action='/account']//button[@type='submit']");
        private By ORDERS_BTN =
            By.LinkText("Мои заказы");

        #endregion

        #region UI Elements

        public IWebElement LogoutBtn => webDriver.FindElement(LOGOUT_BTN);

        public IWebElement SaveBtn => webDriver.FindElement(SAVE_BTN);

        private IWebElement OrdersBtn => webDriver.FindElement(ORDERS_BTN);

        #endregion

        #region Methods

        public OrdersPage GoToOrdersPage()
        {
            var ordersPage = new OrdersPage(webDriver);
            waiters.ClickAndWaitForPageToLoad(OrdersBtn);
            return ordersPage;
        }
        
        #endregion
    }
}
