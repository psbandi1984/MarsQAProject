using MarsQASpecFlowProject.Pages;
using MarsQASpecFlowProject.Utilities;


namespace MarsQASpecFlowProject.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions
    {

        
        private LanguagePage languagePageObject;
       
        public LanguageStepDefinitions(LanguagePage languagePageObject)
        {
            this.languagePageObject = languagePageObject;
                   
        }

               
        [When(@"User sign into Mars portal")]
        public void WhenUserSignIntoMarsPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
        }

        [Then(@"User clean all existing data")]
        public void ThenUserCleanAllExistingData()
        {
            TestDataManager.ClearLanguage(languagePageObject);
        }


        //Testcase 1,2,3 & 4
        [Given(@"User log into Mars portal")]
        public void GivenUserLogIntoMarsPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
           
        }

        [When(@"User navigate to Language module")]
        public void WhenUserNavigateToLanguageModule()
        {
            languagePageObject.Click_LanguageTab();
        }

        [When(@"User create a new Language record '([^']*)' '([^']*)'")]
        public void WhenUserCreateANewLanguageRecord(string Language, string Level)
        {
           
            languagePageObject.CreateLanguageRecord(Language, Level);
        }

        [Then(@"the tooltip message should be ""([^""]*)""")]
        public void ThenTheTooltipMessageShouldBe(string expectedMessage)
        {
            AssertionHelpers.AssertToolTipMessage(languagePageObject, expectedMessage);
        }

        //Testcase 6
        [Given(@"User log into MARS portal")]
        public void GivenUserLogIntoMARSPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
            
        }

        [Given(@"User create a new language record without data")]
        public void GivenUserCreateANewLanguageRecordWithoutData()
        {
            languagePageObject.CreateLanguageRecord("", "");
        }

        //Testcase 7
        [Given(@"User create a new language record '([^']*)' '([^']*)'")]
        public void GivenUserCreateANewLanguageRecord(string English, string Basic)
        {
            languagePageObject.CreateLanguageRecord(English, Basic);
        }

        //Testcase 8
        [Given(@"User log into the MARS portal")]
        public void GivenUserLogIntoTheMARSPortal()
        {
            AssertionHelpers.AssertLogin(languagePageObject);
        }


        [Then(@"the AddNewButton Does Not Exist")]
        public void ThenTheAddNewButtonDoesNotExist()
        {
            AssertionHelpers.AssertAddNewButtonVisible(languagePageObject);
        }

        [When(@"User edit an existing Language record '([^']*)'  '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditAnExistingLanguageRecord(string oldLanguage, string newLanguage, string oldLevel, string newLevel)
        {
            languagePageObject.EditLanguageRecord(oldLanguage, newLanguage, oldLevel, newLevel);
        }

        [When(@"User delete an existing Language record '([^']*)'")]
        public void WhenUserDeleteAnExistingLanguageRecord(string newLanguage)
        {
           languagePageObject.DeletespecificLanguageRecords(newLanguage);
            
        }

       
    }
}

