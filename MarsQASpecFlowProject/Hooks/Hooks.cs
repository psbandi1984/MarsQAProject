using BoDi;
using MarsQASpecFlowProject.Pages;
using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium;

namespace MarsQASpecFlowProject.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        
        public Hooks(IObjectContainer container) 
        {
            _container = container;   
        }
       
        [BeforeScenario]
        public void BeforeScenario()
        {
            CommonDriver driverSetup = new CommonDriver();
            IWebDriver driver = driverSetup.Initialize();
            driver.Manage().Window.Maximize();
            LoginPage loginPageObject = new LoginPage(driver);                
            loginPageObject.LoginSteps();
            
            _container.RegisterInstanceAs<IWebDriver>(driver);
            _container.RegisterInstanceAs<LanguagePage>(new LanguagePage(driver));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
            }

        }

    }  
}
