using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace NUnitTestProject
{
    
    class NUnit_Demo_1
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://staging-www.axosinvest.com/dashboard/login";
        IWebDriver driver;

        [SetUp]
        public void Start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            driver = brow.getDriver;

            driver.FindElement(Locators.UserName, 15);
            driver.FindElement(Locators.UserName).SendKeys("staging+1100");
            driver.FindElement(Locators.Password).SendKeys("Password1!");
            driver.FindElement(Locators.LoginBtn, 1).Click();

            var Security = driver.IsElementPresent(Locators.SecurityCodeTxt);
            if (Security)
            {
                driver.FindElement(Locators.Num1, 1).SendKeys("1");
                driver.FindElement(Locators.Num2, 1).SendKeys("2");
                driver.FindElement(Locators.Num3, 1).SendKeys("3");
                driver.FindElement(Locators.Num4, 1).SendKeys("4");
                driver.FindElement(Locators.Num5, 1).SendKeys("5");
                driver.FindElement(Locators.Num6, 1).SendKeys("6");
                driver.FindElement(Locators.ConfirmBtn).Click();
            }

            driver.FindElement(Locators.AxosLogo, 10);
        }
        
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}