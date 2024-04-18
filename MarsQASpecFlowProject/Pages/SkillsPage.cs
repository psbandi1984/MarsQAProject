using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium;

namespace MarsQASpecFlowProject.Pages
{
    public class SkillsPage
    {
       
        // Locators
        public static By SkillsTab = By.XPath("//a[contains(text(),'Skills')]");
        public static By AddNewButton = By.XPath("//div[@class='ui teal button']");
        public static By SkillsTextbox = By.XPath("//*[@placeholder='Add Skill']");
        public static By chooseLevelDropdown = By.XPath("//*[@class='ui fluid dropdown']");
        public static By chooseLevelOption = By.XPath("//*[@value='\" + Level + \"']");
        public static By AddButton = By.XPath("//input[@value='Add']");
        public static By CancelButton = By.XPath("//input[@value='Cancel']");
        public static By ToolTipMessage = By.XPath("//*[@class='ns-box-inner']");
        public static By EditSkillsTextbox = By.XPath("//input[@placeholder='Add Skill']");
        public static By EditChooseLevelDropdown = By.XPath("//*[@class='ui fluid dropdown']");
        public static By EditPencilIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td[3]/span[1]/i");
        public static By UpdateButton = By.XPath("//input[@value='Update']");
        public static By EditChooseLevelOption = By.XPath("//*[@value='\" + newLevel + \"']");
        public static By LastDeleteIcon = By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[2]");


        //Methods
        public void Click_SkillsTab(IWebDriver driver)
        {
            WaitUtils.WaitToBeVisible(driver, "Xpath", "SkillsTab", 10);
            driver.FindElement(SkillsTab).Click();
        }
        public void CreateSkillsRecord(IWebDriver driver, string Skills, string Level)
        {
            // Click on Add New button
            WaitUtils.WaitToBeVisible(driver, "Xpath", "AddNewButton", 5);
            driver.FindElement(AddNewButton).Click();

            // Enter Skills    
            driver.FindElement(SkillsTextbox).Click();
            driver.FindElement(SkillsTextbox).SendKeys(Skills);

            // Select Skills Level from dropdown list
            driver.FindElement(chooseLevelDropdown).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@value='" + Level + "']")).Click();

            // Click on save button
            driver.FindElement(AddButton).Click();
            Thread.Sleep(4000);

        }

        public void EditSkillsRecord(IWebDriver driver, string oldSkills, string newSkills, string oldLevel, string newLevel)
        {

            // click edit pencil icon for the existing record
            Thread.Sleep(4000);
            driver.FindElement(EditPencilIcon).Click();

            if (newSkills.Length > 0)
            {
                driver.FindElement(EditSkillsTextbox).Clear();
                driver.FindElement(EditSkillsTextbox).SendKeys(newSkills);
            }
            if (newLevel.Length > 0)
            {
                driver.FindElement(EditChooseLevelDropdown).Click();
                Thread.Sleep(4000);

                IWebElement EditChooseLevelOption = driver.FindElement(By.XPath("//*[@value='" + newLevel + "']"));
                EditChooseLevelOption.Click();

            }

            driver.FindElement(UpdateButton).Click();
            Thread.Sleep(4000);
        }

        //To Delete the Skills record
        public void DeleteSkillsRecord(IWebDriver driver, string newSkill)
        {
            driver.FindElement(LastDeleteIcon).Click();
        }

    }
}
