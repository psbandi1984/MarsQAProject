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

//[Binding]
//public class Hooks
//{
//    private readonly IObjectContainer _container;
//    private List<(string Language, string Level)> addedLanguages;

//    public Hooks(IObjectContainer container)
//    {
//        _container = container;
//        addedLanguages = new List<(string Language, string Level)>();
//    }

//    [BeforeScenario]
//    public void BeforeScenario()
//    {
//        var driver = new CommonDriver().Initialize();
//        driver.Manage().Window.Maximize();
//        var loginPage = new LoginPage(driver);
//        loginPage.LoginSteps();

//        var languagePage = new LanguagePage(driver);

//        _container.RegisterInstanceAs<IWebDriver>(driver);
//        _container.RegisterInstanceAs(languagePage);
//    }

//    [AfterScenario]
//    public void AfterScenario()
//    {
//        var languagePage = _container.Resolve<LanguagePage>();
//        TestDataManager.ClearLanguage(languagePage, addedLanguages);

//        var driver = _container.Resolve<IWebDriver>();
//        driver?.Quit();
//    }
//}