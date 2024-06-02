using MarsQASpecFlowProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
namespace MarsQASpecFlowProject.Pages
{

    public class LoginPage : CommonDriver
    {
        
        public LoginPage()
        {
            
        }
        public LoginPage(IWebDriver driver) : base(driver) 
        {

        }

        //Web Elements
        public IWebElement SignINButton => driver.FindElement(By.XPath("//*[contains(text(),\"Sign\")]"));
        public IWebElement EmailAddressTextbox => driver.FindElement(By.XPath("//input[@Placeholder='Email address']"));
        public IWebElement PasswordTextbox => driver.FindElement(By.XPath("//input[@Placeholder='Password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
        
        
        //Method
        public void LoginSteps()
        {
            driver.Navigate().GoToUrl("http://localhost:5000");
            try
            {
                // Identify Sign In button
                SignINButton.Click();

            }
            catch(Exception ex) 
            {
                Assert.Fail($"MARS portal hasn't launched., {ex.Message}");
            }
           

            // identify the EmailAddress textbox and enter a valid username
            EmailAddressTextbox.SendKeys("pb842253@gmail.com");

            // identify password textbox and enter valid password
            PasswordTextbox.SendKeys("@pb123456");

            // click on login button
            LoginButton.Click();
            Thread.Sleep(2000);
        }

    }
}
