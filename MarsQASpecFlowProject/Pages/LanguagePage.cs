using MarsQASpecFlowProject.Utilities;
using OpenQA.Selenium;


namespace MarsQASpecFlowProject.Pages
{
    public class LanguagePage
    {
        // Locators
        public static By LanguageTab = By.XPath("//a[contains(text(),'Languages')]");
        public static By AddNewButton = By.XPath("//*[@class='ui teal button ']");
        public static By LanguageTextbox = By.XPath("//*[@placeholder='Add Language']");
        public static By chooseLevelDropdown = By.XPath("//*[@class='ui dropdown']");
        public static By chooseLevelOption = By.XPath("//*[@value='\" + Level + \"']");
        public static By AddButton = By.XPath("//input[@value='Add']");
        public static By CancelButton = By.XPath("//input[@value='Cancel']");
        public static By ToolTipMessage = By.XPath("//*[@class='ns-box-inner']");
        public static By EditLanguageTextbox = By.XPath("//*[@placeholder='Add Language']");
        public static By EditChooseLevelDropdown = By.XPath("//*[@class='ui dropdown']");
        public static By EditPencilIcon = By.XPath("//div[@id='account-profile-section']//form//table//tbody[2]/tr/td[3]/span[1]/i");
        public static By UpdateButton = By.XPath("//input[@value='Update']");
        public static By EditChooseLevelOption = By.XPath("//*[@value='\" + newLevel + \"']");
        public static By LastDeleteIcon = By.XPath("//div[@id=\"account-profile-section\"]//form//table//tbody[2]/tr/td[3]//span[2]/i\r\n");


        //Methods
        public void Click_LanguageTab(IWebDriver driver)
        {
            WaitUtils.WaitToBeVisible(driver, "Xpath", "LanguageTab", 10);
            driver.FindElement(LanguageTab).Click();
        }
        public void CreateLanguageRecord(IWebDriver driver, string Language, string Level)
        {
            // Click on Add New button
            WaitUtils.WaitToBeVisible(driver, "Xpath", "AddNewButton", 10);
            driver.FindElement(AddNewButton).Click();

            // Enter Language    
            driver.FindElement(LanguageTextbox).Click();
            driver.FindElement(LanguageTextbox).SendKeys(Language);

            // Select Language Level from dropdown list
            driver.FindElement(chooseLevelDropdown).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@value='" + Level + "']")).Click();

            // Click on save button
            driver.FindElement(AddButton).Click();
            Thread.Sleep(4000);

        }

        public void EditLanguageRecord(IWebDriver driver, string oldLanguage, string newLanguage, string oldLevel, string newLevel)
        {

            // click edit pencil icon for the existing record
            Thread.Sleep(4000);
            driver.FindElement(EditPencilIcon).Click();
            
            if (newLanguage.Length > 0)
            {
                driver.FindElement(EditLanguageTextbox).Clear();
                driver.FindElement(EditLanguageTextbox).SendKeys(newLanguage);
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

        //To Delete the language record
        public void DeleteLanguageRecord(IWebDriver driver, string newLanguage)
        {
            driver.FindElement(LastDeleteIcon).Click();   
        }

    }
}
