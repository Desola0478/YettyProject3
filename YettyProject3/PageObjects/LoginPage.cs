using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using YettyProject3.Hooks;

namespace YettyProject3.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;

        IWebElement signIn => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[1]"));

        IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id='user_email']"));

        IWebElement password => driver.FindElement(By.CssSelector("#user_password"));

        IWebElement signInButton => driver.FindElement(By.CssSelector("#btn_signin"));

        public void ClickSignInButton()
        {
            signInButton.Click();
        }

        public void EnterPassword()
        {
            password.SendKeys("Iyanuoluwa1");
        }
        

        public void EnterEmailAddress()
        {
            emailAddress.SendKeys("desolakin@gmail.com");
        }

        public void ClickOnSignIn()
        {
            signIn.Click();
        }


        public LoginPage()

        {
            driver = Hook.driver;

        }

        public void NavigateToGiftreteWebsite()
        {
            driver.Navigate().GoToUrl("https://giftrete.com");
        }
    }
}
