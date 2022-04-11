using OpenQA.Selenium;

namespace SpecFlowProjectBlogAndre.Pages
{
    public class BasePage
    {
        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver { get; }

        public void StupidExampleOfAGeneralMethodYouWantToUseForEachPage()
        {
            Driver.FindElement(By.Id("Logo"));
        }
    }
}