using OpenQA.Selenium;

namespace Framework.Pages.ProductsPages
{
    public class MenShoesPage : MainPage
    {
        public IWebDriver webDriver;

        public MenShoesPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
