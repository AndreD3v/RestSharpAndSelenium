using OpenQA.Selenium;

namespace SpecFlowProjectBlogAndre.Pages
{
    public class LoginPage : BasePage
    {
        private By UserNameInput => By.Id("UserNameInput-loginPage"); 
        private By PassWordInput => By.Id("PassWordInput-loginPage");
        private By LoginButton => By.Id("submit-loginPage");
                
        public LoginPage(IWebDriver webdriver) : base(webdriver) { }

        public void Login(string user, string password)
        {
            Driver.FindElement(UserNameInput).SendKeys(user);
            Driver.FindElement(PassWordInput).SendKeys(password);
            Driver.FindElement(LoginButton).Click();

            StupidExampleOfAGeneralMethodYouWantToUseForEachPage();
        }
    }
}