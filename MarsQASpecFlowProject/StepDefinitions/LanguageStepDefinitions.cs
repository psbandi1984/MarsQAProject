using MarsQASpecFlowProject.Pages;
using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium.Chrome;

namespace MarsQASpecFlowProject.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        LoginPage loginPageObject = new LoginPage();
        LanguagePage languagePageObject = new LanguagePage();

        [BeforeScenario]
        public void SetUpLanguagePage()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            Thread.Sleep(1000);
        }

        //Testcase 1,2,3 & 4
        [Given(@"User log into Mars portal")]
        public void GivenUserLogIntoMarsPortal()
        {
            
            loginPageObject.LoginSteps(driver);
        }

        [When(@"User navigate to Language module")]
        public void WhenUserNavigateToLanguageModule()
        {
            languagePageObject.Click_LanguageTab(driver);
        }

        [When(@"User create a new Language record '([^']*)' '([^']*)'")]
        public void WhenUserCreateANewLanguageRecord(string Language, string Level)
        {
            
            languagePageObject.CreateLanguageRecord(driver, Language, Level);
        }

        [Then(@"the tooltip message should be ""([^""]*)""")]
        public void ThenTheTooltipMessageShouldBe(string expectedMessage)
        {
            AssertionHelpers.AssertToolTipMessage(driver, expectedMessage);
        }

        //Testcase 6
        [Given(@"User log into MARS portal")]
        public void GivenUserLogIntoMARSPortal()
        {
            loginPageObject.LoginSteps(driver);
        }

        [Given(@"User create a new language record without data")]
        public void GivenUserCreateANewLanguageRecordWithoutData()
        {
            languagePageObject.CreateLanguageRecord(driver, "", "");
        }

        //Testcase 7
        [Given(@"User create a new language record '([^']*)' '([^']*)'")]
        public void GivenUserCreateANewLanguageRecord(string English, string Basic)
        {
            languagePageObject.CreateLanguageRecord(driver, English, Basic);
        }

        //Testcase 8
        [Then(@"the AddNewButton Does Not Exist")]
        public void ThenTheAddNewButtonDoesNotExist()
        {
            AssertionHelpers.AssertAddNewButtonVisible(driver);
        }

        [When(@"User edit an existing Language record '([^']*)'  '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditAnExistingLanguageRecord(string oldLanguage, string newLanguage, string oldLevel, string newLevel)
        {
            languagePageObject.EditLanguageRecord(driver, oldLanguage, newLanguage, oldLevel, newLevel);
        }

        [When(@"User delete an existing Language record '([^']*)'")]
        public void WhenUserDeleteAnExistingLanguageRecord(string French)
        {
            languagePageObject.DeleteLanguageRecord(driver, French);
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
