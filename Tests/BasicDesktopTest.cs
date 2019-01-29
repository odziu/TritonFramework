using System;
using Framework.PageObjects;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BasicDesktopTest
    {
        public IWebDriver webDriver;
        public MainPage mainPage;
        public Header header;
        
        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.tritonshoes.ru/");
            mainPage = new MainPage(webDriver);
            header = new Header(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TearDown()
        {
            webDriver?.Close();
        }
    }
}
