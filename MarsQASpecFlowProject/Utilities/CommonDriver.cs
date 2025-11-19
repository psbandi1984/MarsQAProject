using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsQASpecFlowProject.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        public CommonDriver()
        {

        }
        public CommonDriver(IWebDriver driver)
        {
            this.driver = driver;

        }

        public IWebDriver Initialize()
        {
            driver = new ChromeDriver();
            return driver;
        }

        public IWebDriver getDriver()
        {
            return driver;
        }

        public void GoToSkillsTab()
        {
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skillsTab.Click();
        }

        public Boolean verifyLogin()
        {
            Console.WriteLine(driver.Url);
            if (driver.Url != "http://localhost:5000/Home" && driver.Url != "data:,")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
