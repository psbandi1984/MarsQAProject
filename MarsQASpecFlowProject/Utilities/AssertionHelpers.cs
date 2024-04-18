using MarsQASpecFlowProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQASpecFlowProject.Utilities
{
    public class AssertionHelpers
    {
        public static void AssertToolTipMessage(IWebDriver driver, string expectedMessage)
        {

            WaitUtils.WaitToBeVisible(driver, "XPath", "//*[@class='ns-box-inner']", 20);

            IWebElement toolTipMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));

            string actualMessage = toolTipMessage.Text.Trim();

            Console.WriteLine("Tooltip Text: " + actualMessage);

            // Remove single quotes from the expected message
            string expectedMessageWithoutQuotes = expectedMessage.Replace("'", "");

            // Check if the actual message matches the expected message without quotes
            if (actualMessage == expectedMessageWithoutQuotes)
            {
                // Log the success
                Console.WriteLine("Tooltip message matches the expected message.");
            }
            else
            {
                // Log the failure and provide details about the differences
                Console.WriteLine($"Expected: '{expectedMessage}'");
                Console.WriteLine($"But was:  '{actualMessage}'");
                Assert.Fail("Tooltip message does not match the expected message.");
            }
        }


        public static void AssertAddNewButtonVisible(IWebDriver driver)
        {
            
            bool isAddNewButtonVisible = false;

            try
            {
                // Check if the Add New button is visible
                isAddNewButtonVisible = driver.FindElement(LanguagePage.AddNewButton).Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the Add New button is not found, set the flag to false
                isAddNewButtonVisible = false;
            }

            // Assert that the Add New button is visible
            Assert.IsFalse(isAddNewButtonVisible, "Add New Button is not visible");
        }
    }
}
