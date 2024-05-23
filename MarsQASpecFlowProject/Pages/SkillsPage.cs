﻿using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium;

namespace MarsQASpecFlowProject.Pages
{
    public class SkillsPage : CommonDriver
    {
        public SkillsPage(IWebDriver driver): base(driver)
        {
        }

        public SkillsPage()
        {
        }

        // Web Elements
        public IWebElement SkillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public IWebElement AddNewButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        public IWebElement SkillsTextbox => driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
        public IWebElement chooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']"));
        public IWebElement chooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + Level + \"']"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement CancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        public IWebElement ToolTipMessage => driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        public IWebElement EditSkillsTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public IWebElement EditChooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']"));
        public IWebElement EditPencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[4]/tr/td[3]/span[1]/i"));
        public IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public IWebElement EditChooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + newLevel + \"']"));
        public IWebElement LastDeleteIcon => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[2]"));
        public IList<IWebElement> SkillsRows => driver.FindElements(By.XPath("//div[@data-tab='second']//table/tbody"));


        //Methods
        public void Click_SkillsTab()
        {
            WaitUtils.WaitToBeVisible(driver, "Xpath", "SkillsTab", 10);
            SkillsTab.Click();
        }
        public void CreateSkillsRecord(string Skills, string Level)
        {
            // Click on Add New button
            WaitUtils.WaitToBeVisible(driver, "Xpath", "AddNewButton", 5);
            AddNewButton.Click();

            // Enter Skills    
            SkillsTextbox.Click();
            SkillsTextbox.SendKeys(Skills);

            // Select Skills Level from dropdown list
            WaitUtils.WaitToBeVisible(driver, "Xpath", "chooseLevelDropdown", 5);
            chooseLevelDropdown.Click();
            //Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@value='" + Level + "']")).Click();

            // Click on save button
            WaitUtils.WaitToBeVisible(driver, "Xpath", "AddButton", 5);
            AddButton.Click();
            //Thread.Sleep(4000);

        }

        public void EditSkillsRecord(string oldSkills, string newSkills, string oldLevel, string newLevel)
        {

            // click edit pencil icon for the existing record
            WaitUtils.WaitToBeVisible(driver, "Xpath", "EditPencilIcon", 5);
            //Thread.Sleep(4000);
            EditPencilIcon.Click();

            if (newSkills.Length > 0)
            {
                EditSkillsTextbox.Clear();
                EditSkillsTextbox.SendKeys(newSkills);
            }
            if (newLevel.Length > 0)
            {
                WaitUtils.WaitToBeVisible(driver, "Xpath", "EditChooseLevelDropdown", 5);
                EditChooseLevelDropdown.Click();
                //Thread.Sleep(4000);

                IWebElement EditChooseLevelOption = driver.FindElement(By.XPath("//*[@value='" + newLevel + "']"));
                EditChooseLevelOption.Click();

            }

            WaitUtils.WaitToBeVisible(driver, "Xpath", "UpdateButton", 5);
            UpdateButton.Click();
            //Thread.Sleep(4000);
        }

        //To Delete the Skills record
        public void DeleteSkillsRecord(string newSkill)
        {
            LastDeleteIcon.Click();
        }

    }
}
