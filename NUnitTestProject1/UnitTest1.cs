using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace NUnitTestProject
{
    
    class NUnit_Demo_1
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://www.amazon.com/";
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

            IWebElement element = driver.FindElement(Locators.SearchBox);
            element.SendKeys("Samsung Galaxy S9");
            element.Submit();
            System.Threading.Thread.Sleep(4000);

            //Price
            element = driver.FindElement(Locators.Fprice);
            string Price = element.Text;
            //Fraction
            element = driver.FindElement(Locators.Ffraction);
            string Fraction = element.Text;
            string Total = "$" + Price + "." + Fraction;
            driver.FindElement(Locators.Fprice).Click();
            element = driver.FindElement(Locators.Oprice);
            string Oprice = element.Text;
            Assert.AreEqual(Oprice, Total);
            Console.WriteLine("Los Precios coinciden");


            driver.FindElement(Locators.AddToCart).Click();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(Locators.MainLogo).Click();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(Locators.YourAmazonBtn).Click();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(Locators.CreatAcctBtn).Click();
            System.Threading.Thread.Sleep(4000);
            
            element = driver.FindElement(Locators.Mail);
            element.SendKeys("Samsung Galaxy S9");
            element = driver.FindElement(Locators.Name);
            element.SendKeys("Samsung Galaxy S9");
            element = driver.FindElement(Locators.Pass);
            element.SendKeys("Samsung Galaxy S9");
            element = driver.FindElement(Locators.Rpass);
            element.SendKeys("Samsung Galaxy S9");
            element = driver.FindElement(Locators.CreatAcctLbl);
            string Label = element.Text;
            Assert.AreEqual("Create account", Label);
        }
        
        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}