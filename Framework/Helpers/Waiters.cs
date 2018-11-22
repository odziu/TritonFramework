using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Helpers
{
    public class Waiters
    {
        private IWebDriver webDriver;

        public Waiters(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public void ClickAndWaitForPageToLoad(IWebElement element, int timeout = 10)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
            Assert.IsTrue(element.Displayed && element.Enabled);
            element.Click();
            wait.Until(ExpectedConditions.StalenessOf(element));
        }
    }
}
