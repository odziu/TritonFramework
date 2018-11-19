using Framework.Pages;
using Framework.Pages.ProductsPages;
using OpenQA.Selenium;

namespace Framework.PageObjects
{
    public class Header
    {
        public IWebDriver webDriver;

        public Header(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Locators

        //********* Menu_1              [line1]
        //private By MENU_1_BTN = By.XPath("//div[@class='line1']//buttom[@class='mobil']");

        //private By O_KOMPANII_BTN = By.XPath("//div[@class='line1']//a[@href='/pages/o_kompanii']");
        //private By USLOVIYA_DOSTAVKI_BTN = By.XPath("//div[@class='line1']//a[@href='/pages/usloviya_dostavki']");
        //private By CHASTYE_VOPROSY_BTN = By.XPath("//div[@class='line1']//a[@href='/pages/chastye_voprosy']");
        //private By KONTAKTY_BTN = By.LinkText("Контакты");
        //private By NEWS_BTN = By.LinkText("Новости");
        //private By OBRATNAYA_SVYAZ_BTN = By.XPath("//a[@href='/pages/obratnaya_svyaz']");

        //********* Menu_2 = Products   [line3]
        //private By MENU_2_BTN = By.XPath("//div[@class='line3']//buttom[@class='mobil']");

        private By ZHENSKAYA_OBUV_BTN = By.XPath("//a[@href='/catalog/zhenskaya_obuv']");
        private By MUZHSKAYA_OBUV_BTN = By.XPath("//a[@href='/catalog/muzhskaya_obuv']");
        //private By SUMKI_I_AKSESSUARY_BTN = By.XPath("//a[@href='/catalog/sumki_i_aksessuary']");
        //private By NEW_BTN = By.XPath("//a[@href='/catalog/new']");
        //private By SALE_BTN = By.XPath("//a[@href='/catalog/sale']");
        //private By MANUFACTURERS_BTN = By.XPath("//a[@href='/manufacturers']");

        private By ACCOUNT_BTN = By.XPath("//a[@href='/account']");
        //private By CART_BTN = By.Id("miniCart");
        //private By SEARCH_BTN = By.XPath("//div[@class='line3']//a[@href='#']");

        #endregion

        #region UI Elements

        private IWebElement WoomenShoesBtn => webDriver.FindElement(ZHENSKAYA_OBUV_BTN);

        private IWebElement MenShoesBtn => webDriver.FindElement(MUZHSKAYA_OBUV_BTN);

        private IWebElement AccountBtn => webDriver.FindElement(ACCOUNT_BTN);

        #endregion

        #region Methods

        public MenShoesPage GoToMenShoesPage()
        {
            var menShoes = new MenShoesPage(webDriver);
            MenShoesBtn.Click();
            return menShoes;
        }

        public WoomenShoesPage GoToWoomenShoesPage()
        {
            var woomenShoes = new WoomenShoesPage(webDriver);
            WoomenShoesBtn.Click();
            return woomenShoes;
        }

        public AccountPage GoToAccountPage()
        {
            var accountPage = new AccountPage(webDriver);
            AccountBtn.Click();
            return accountPage;
        }

        #endregion
    }
}
