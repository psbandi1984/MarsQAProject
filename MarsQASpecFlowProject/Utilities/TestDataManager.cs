using MarsQASpecFlowProject.Pages;
using OpenQA.Selenium;
using System.Reflection.Metadata.Ecma335;

namespace MarsQASpecFlowProject.Utilities
{
    public class TestDataManager
    {
        public static void ClearLanguage(LanguagePage languagePageObject)
        {

            int rowCount = languagePageObject.LanguageRows.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                languagePageObject.DeleteLastLanguageRecords();
            }
           
        }

        public static void ClearSkill(SkillsPage skillsPageObject)
        {

            int rowCount = skillsPageObject.SkillsRows.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                skillsPageObject.DeleteLastSkillRecords();
            }

        }

    }
        
}

