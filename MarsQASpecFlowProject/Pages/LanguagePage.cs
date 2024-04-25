using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium;


namespace MarsQASpecFlowProject.Pages
{
    public class LanguagePage : CommonDriver
    {
        
        public LanguagePage(IWebDriver driver) : base(driver)
        {
            
        }

        public LanguagePage() 
        { 
        }

        // Web Elements
        public IWebElement LanguageTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        public IWebElement AddNewButton => driver.FindElement(By.XPath("//*[@class='ui teal button ']"));
        public IWebElement LanguageTextbox => driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));
        public IWebElement chooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui dropdown']"));
        public IWebElement chooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + Level + \"']"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement CancelButton => driver.FindElement(By.XPath("//input[@value='Cancel']"));
        public IWebElement ToolTipMessage => driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        public IWebElement EditLanguageTextbox => driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));
        public IWebElement EditChooseLevelDropdown => driver.FindElement(By.XPath("//*[@class='ui dropdown']"));
        public IWebElement EditPencilIcon => driver.FindElement(By.XPath("//div[@id='account-profile-section']//form//table//tbody[2]/tr/td[3]/span[1]/i"));
        public IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        public IWebElement EditChooseLevelOption => driver.FindElement(By.XPath("//*[@value='\" + newLevel + \"']"));
        public IWebElement LastDeleteIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));


        //Methods
        public void Click_LanguageTab()
        {
            WaitUtils.WaitToBeVisible(driver, "Xpath", "LanguageTab", 10);
            LanguageTab.Click();
        }
        public void CreateLanguageRecord(string Language, string Level)
        {
            // Click on Add New button
            WaitUtils.WaitToBeVisible(driver, "Xpath", "AddNewButton", 10);
            AddNewButton.Click();

            // Enter Language    
            LanguageTextbox.Click();
            LanguageTextbox.SendKeys(Language);

            // Select Language Level from dropdown list
            chooseLevelDropdown.Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@value='" + Level + "']")).Click();
            

            // Click on save button
            AddButton.Click();
            Thread.Sleep(4000);

        }

        public void EditLanguageRecord(string oldLanguage, string newLanguage, string oldLevel, string newLevel)
        {

            // click edit pencil icon for the existing record
            Thread.Sleep(4000);
            EditPencilIcon.Click();
            
            if (newLanguage.Length > 0)
            {
                EditLanguageTextbox.Clear();
                EditLanguageTextbox.SendKeys(newLanguage);
            }

            if (newLevel.Length > 0)
            {
                EditChooseLevelDropdown.Click();
                Thread.Sleep(4000);

                IWebElement EditChooseLevelOption = driver.FindElement(By.XPath("//*[@value='" + newLevel + "']"));
                EditChooseLevelOption.Click();

            }

            UpdateButton.Click();
            Thread.Sleep(4000);
        }

        //To Delete the language record
        public void DeleteLanguageRecord(string newLanguage)
        {
            LastDeleteIcon.Click();   
        }

    }
}
