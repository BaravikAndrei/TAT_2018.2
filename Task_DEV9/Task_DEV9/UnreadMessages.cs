using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text;
using System;

namespace Task_DEV9
{
    /// <summary>
    /// Class UnreadMessages implements methods of getting unreaded messags.
    /// </summary>
    class UnreadMessages
    {
        /// <summary>
        /// Method GetUnreadedMessages for getting unreaded messags.
        /// </summary>
        /// <returns>StringBuilder object with unreaded messages.></returns>
        public StringBuilder GetUnreadedMessages()
        {
            var messages = new StringBuilder();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--disable-notifications");
            IWebDriver browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(@"https://www.facebook.com/");
            browser.FindElement(By.Id("email")).SendKeys("+375293589083");
            browser.FindElement(By.Id("pass")).SendKeys("17505701");
            browser.FindElement(By.Id("loginbutton")).Click();
            browser.FindElement(By.CssSelector("#u_0_a #u_0_d")).Click();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var listMessages = browser.FindElements(By.CssSelector("div.uiScrollableAreaBody li a div div div._42ef div div.content div._1iji span span"));
            foreach (IWebElement iw in listMessages)
            {
                messages.Append(iw.Text + '\n');
            }
            return messages;
        }
    }
}
