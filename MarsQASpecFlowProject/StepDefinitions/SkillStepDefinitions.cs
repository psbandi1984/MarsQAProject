using MarsQASpecFlowProject.Pages;
using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium;

namespace MarsQASpecFlowProject.StepDefinitions
{
    [Binding]
    public class SkillStepDefinitions
    {
        private SkillsPage skillsPageObject;

        public SkillStepDefinitions(SkillsPage skillsPageObject)
        {
            this.skillsPageObject = skillsPageObject;
        }

        [When(@"User log into Mars portal")]
        public void WhenUserLogIntoMarsPortal()
        {
            AssertionHelpers.AssertLogin(skillsPageObject);
        }

        [When(@"User click on Skill tab")]
        public void WhenUserClickOnSkillTab()
        {
            skillsPageObject.Click_SkillsTab();
        }


        [Then(@"User clean all existing data in Skill module")]
        public void ThenUserCleanAllExistingDataInSkillModule()
        {
            TestDataManager.ClearSkill(skillsPageObject);
        }



        [Given(@"User logs into Mars portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
            AssertionHelpers.AssertLogin(skillsPageObject);
            
        }
    

        [When(@"User navigate to Skill module")]
        public void WhenUserNavigateToSkillModule()
        {
            skillsPageObject.Click_SkillsTab();
        }

        [When(@"User create a new Skill record '([^']*)' '([^']*)'")]
        public void WhenUserCreateANewSkillRecord(string Skills, string Level)
        {
            skillsPageObject.CreateSkillsRecord(Skills, Level);
        }

        [Then(@"tooltip message should be ""([^""]*)""")]
        public void ThenTooltipMessageShouldBe(string expectedMessage)
        {
            AssertionHelpers.AssertToolTipMessage(skillsPageObject, expectedMessage);
        }

        [Given(@"User logs into MARS portal")]
        public void GivenUserLogsIntoMARSPortal()
        {
            AssertionHelpers.AssertLogin(skillsPageObject);
           
        }

        [When(@"User navigates to skill module")]
        public void WhenUserNavigatesToSkillModule()
        {
            skillsPageObject.Click_SkillsTab();
        }


        [When(@"User create a new Skill record without data")]
        public void WhenUserCreateANewSkillRecordWithoutData()
        {
            skillsPageObject.CreateSkillsRecord("", "");
        }


        [Given(@"User create a new Skill record '([^']*)' '([^']*)'")]
        public void GivenUserCreateANewSkillRecord(string SpecFlow, string Beginner)
        {
            skillsPageObject.CreateSkillsRecord(SpecFlow, Beginner);
        }


        [When(@"User edit an existing Skill record '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEditAnExistingSkillRecord(string oldSkills, string newSkills, string oldLevel, string newLevel)
        {
            skillsPageObject.EditSkillsRecord(oldSkills, newSkills, oldLevel, newLevel);

        }

        [When(@"User delete an existing Skill record '([^']*)'")]
        public void WhenUserDeleteAnExistingSkillRecord(string Java)
        {
            skillsPageObject.DeletespecificSkillRecords(Java);
        }

    }
}
