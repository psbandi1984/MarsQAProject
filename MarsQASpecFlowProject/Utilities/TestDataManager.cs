using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQASpecFlowProject.Utilities
{
    public class TestDataManager
    {
        public static void ClearLanguageIfPresent(CommonDriver page)
        {

            IWebDriver driver = page.getDriver();
            int numOfLanguages = driver.FindElements(By.XPath("//*[@data-tab='first']//*[@class='ui fixed table']/tbody")).Count;
            for (int i = 0; i < numOfLanguages; i++)
            {
                IWebElement LastDeleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
                LastDeleteIcon.Click();
                Thread.Sleep(4000);
            }
        }

        public static void ClearSkillIfPresent(CommonDriver page)
        {

            IWebDriver driver = page.getDriver();
            int num = driver.FindElements(By.XPath("//*[@data-tab='second']//*[@class='ui fixed table']/tbody")).Count;
            for (int i = 0; i < num; i++)
            {
                IWebElement deleteSkillButton = driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[2]"));
                deleteSkillButton.Click();
                Thread.Sleep(4000);
            }


        }
    }
}

