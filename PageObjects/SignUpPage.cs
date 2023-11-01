using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyTestProject.Utilities;

namespace UdemyTestProject.PageObjects
{
    internal class SignUpPage
    {
        public SignUpPage() 
        {
            driver = Hooks1.driver; 

        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));  //username element

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']")); // email element

        IWebElement password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));




        public void EnterUserName()
        {
            username.SendKeys("UdemyTest");
        }

        public void EnterEmail()
        {
            email.SendKeys("udemy@demo.com");
        }
        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
            
        }
        public void ClickSignUpButton()
        {
            signUp.Click();
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }


    }
}
