using OpenQA.Selenium;

namespace NUnitTestProject
{
    public static class Locators
    {
        //Login
        public static By UserName = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/div/div/form/div[1]/div/input");
        public static By Password = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/div/div/form/div[2]/div/div/input");
        public static By LoginBtn = By.CssSelector("#submit");

        //OTP
        public static By SecurityCodeTxt = By.CssSelector("body > div.main.ng-scope > div > div > div > div:nth-child(2) > ui-view > div > form > div.page-header.pt-head > h1");
        public static By Num1 = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/form/div[2]/fieldset/div/div/div/input[1]");
        public static By Num2 = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/form/div[2]/fieldset/div/div/div/input[2]");
        public static By Num3 = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/form/div[2]/fieldset/div/div/div/input[3]");
        public static By Num4 = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/form/div[2]/fieldset/div/div/div/input[4]");
        public static By Num5 = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/form/div[2]/fieldset/div/div/div/input[5]");
        public static By Num6 = By.XPath("/html/body/div[2]/div/div/div/div[2]/ui-view/div/form/div[2]/fieldset/div/div/div/input[6]");
        public static By ConfirmBtn = By.CssSelector("body > div.main.ng-scope > div > div > div > div:nth-child(2) > ui-view > div > form > div.page-buttons.mt-head > button > span");

        //Dashboard
        public static By AxosLogo = By.CssSelector("#navbarMainMenu > a > img");
    }
}