﻿using System;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BasicTest
    {
        public IWebDriver webDriver;
        public MainPage mainPage;

        [SetUp]
        public void GoToMainPage()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.tritonshoes.ru/");
            mainPage = new MainPage(webDriver);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void TearDown()
        {
            if (webDriver != null)
            {
                webDriver.Close();
            }
        }
    }
}