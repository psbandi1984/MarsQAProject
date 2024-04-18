using NUnit.Framework;
using OpenQA.Selenium;
namespace MarsQASpecFlowProject.Pages
{

    public class LoginPage
    {
        
        //Locators
        public static By SignINButton = By.XPath("//*[contains(text(),\"Sign\")]");
        public static By EmailAddressTextbox = By.XPath("//input[@Placeholder='Email address']");
        public static By PasswordTextbox = By.XPath("//input[@Placeholder='Password']");
        public static By LoginButton = By.XPath("//button[contains(text(),'Login')]");
        public static By SkillTab = By.XPath("//a[@data-tab='second']");

        
        //Method
        public void LoginSteps(IWebDriver driver)
        {
            // launch Mars portal
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000");
            Thread.Sleep(1000);

            try
            {
                // Identify Sign In button
                driver.FindElement(SignINButton).Click();

            }
            catch(Exception ex) 
            {
                Assert.Fail($"MARS portal hasn't launched., {ex.Message}");
            }
           

            // identify the EmailAddress textbox and enter a valid username
            driver.FindElement(EmailAddressTextbox).SendKeys("pb842253@gmail.com");

            // identify password textbox and enter valid password
            driver.FindElement(PasswordTextbox).SendKeys("@pb123456");

            // click on login button
            driver.FindElement(LoginButton).Click();
            Thread.Sleep(2000);
        }

        //To navigate to Skills tab in Profile Page
        public void GoToSkillsTab(IWebDriver driver)
        {
            driver.FindElement(SkillTab).Click();
            
        }

    }
}
