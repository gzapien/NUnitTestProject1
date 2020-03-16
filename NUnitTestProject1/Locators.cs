
using OpenQA.Selenium;

namespace NUnitTestProject
{
    public static class Locators
    {
        //Home
        //IWebElement element = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
        public static By SearchBox = By.CssSelector("#twotabsearchtextbox");
        public static By MainLogo = By.CssSelector("#nav-logo > a > span.nav-sprite.nav-logo-base");
        public static By YourAmazonBtn = By.CssSelector("#nav-your-amazon");
        public static By CreatAcctBtn = By.CssSelector("#createAccountSubmit");
        public static By CreatAcctLbl = By.CssSelector("#ap_register_form > div > div > h1");
        public static By Fprice = By.XPath("//*[@id='search']/div[1]/div[2]/div/span[4]/div[1]/div[1]/div/span/div/div/div/div/div[2]/div[2]/div/div[2]/div[1]/div/div[1]/div/div/a/span/span[2]/span[2]");
        public static By Ffraction = By.CssSelector("#search > div.s-desktop-width-max.s-desktop-content.sg-row > div.sg-col-20-of-24.sg-col-28-of-32.sg-col-16-of-20.sg-col.sg-col-32-of-36.sg-col-8-of-12.sg-col-12-of-16.sg-col-24-of-28 > div > span:nth-child(5) > div:nth-child(1) > div:nth-child(1) > div > span > div > div > div > div > div:nth-child(2) > div.sg-col-4-of-12.sg-col-8-of-16.sg-col-16-of-24.sg-col-12-of-20.sg-col-24-of-32.sg-col.sg-col-28-of-36.sg-col-20-of-28 > div > div:nth-child(2) > div.sg-col-4-of-24.sg-col-4-of-12.sg-col-4-of-36.sg-col-4-of-28.sg-col-4-of-16.sg-col.sg-col-4-of-20.sg-col-4-of-32 > div > div.a-section.a-spacing-none.a-spacing-top-small > div > div > a > span > span:nth-child(2) > span.a-price-fraction");
        public static By Oprice = By.CssSelector("#priceblock_ourprice");
        public static By AddToCart = By.CssSelector("#add-to-cart-button");

        //Create Account Page
        public static By Mail = By.CssSelector("#ap_customer_name");
        public static By Name = By.CssSelector("#ap_email");
        public static By Pass = By.CssSelector("#ap_password");
        public static By Rpass = By.CssSelector("#ap_password_check");

        //public static By B = By.XPath("//*[@id='search']/div[1]/div[2]/div/span[4]/div[1]/div[1]/div/span/div/div/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/h2/a/span");
    }
}