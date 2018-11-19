using OpenQA.Selenium;

namespace Framework.Pages.ProductsPages
{
    public class WoomenShoesPage : MainPage
    {
        public IWebDriver webDriver;

        public WoomenShoesPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
