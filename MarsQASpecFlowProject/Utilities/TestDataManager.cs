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

               
    }
}

