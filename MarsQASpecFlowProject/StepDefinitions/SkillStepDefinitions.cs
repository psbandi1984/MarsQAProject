using MarsQASpecFlowProject.Pages;
using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium.Chrome;

namespace MarsQASpecFlowProject.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        LoginPage loginPageObject = new LoginPage();
        SkillsPage SkillsPageObject = new SkillsPage();


        [BeforeScenario]
        public void SetUpSkillsPage()
        {
            //Open Chrome browser
            driver = new ChromeDriver();
            Thread.Sleep(1000);
        }

        [Given(@"User logs into Mars portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
            loginPageObject.LoginSteps(driver);
        }
    

        [When(@"User navigate to Skill module")]
        public void WhenUserNavigateToSkillModule()
        {
            SkillsPageObject.Click_SkillsTab(driver);
        }

        [When(@"User create a new Skill record '([^']*)' '([^']*)'")]
        public void WhenUserCreateANewSkillRecord(string Skills, string Level)
        {
            SkillsPageObject.CreateSkillsRecord(driver, Skills, Level);
        }

        [Then(@"tooltip message should be ""([^""]*)""")]
        public void ThenTooltipMessageShouldBe(string expectedMessage)
        {
            AssertionHelpers.AssertToolTipMessage(driver, expectedMessage);
        }

        [Given(@"User logs into MARS portal")]
        public void GivenUserLogsIntoMARSPortal()
        {
            loginPageObject.LoginSteps(driver);
        }

        [When(@"User navigates to skill module")]
        public void WhenUserNavigatesToSkillModule()
        {
            SkillsPageObject.Click_SkillsTab(driver);
        }


        [When(@"User create a new Skill record without data")]
        public void WhenUserCreateANewSkillRecordWithoutData()
        {
            SkillsPageObject.CreateSkillsRecord(driver, "", "");
        }


        [Given(@"User create a new Skill record '([^']*)' '([^']*)'")]
        public void GivenUserCreateANewSkillRecord(string SpecFlow, string Beginner)
        {
            SkillsPageObject.CreateSkillsRecord(driver, SpecFlow, Beginner);
        }


        [When(@"User edit an existing Skill record '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditAnExistingSkillRecord(string oldSkills, string newSkills, string oldLevel, string newLevel)
        {
            SkillsPageObject.EditSkillsRecord(driver, oldSkills, newSkills, oldLevel, newLevel);

        }

        [When(@"User delete an existing Skill record '([^']*)'")]
        public void WhenUserDeleteAnExistingSkillRecord(string Java)
        {
            SkillsPageObject.DeleteSkillsRecord(driver, Java);
        }

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
