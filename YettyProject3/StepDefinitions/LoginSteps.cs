using System;
using TechTalk.SpecFlow;
using YettyProject3.PageObjects;

namespace YettyProject2.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        LoginPage loginpage;

        public LoginSteps()
        {
            loginpage = new LoginPage();
        }

        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            loginpage.NavigateToGiftreteWebsite();
        }
        
        [Given(@"I click on sign in")]
        public void GivenIClickOnSignIn()
        {
            loginpage.ClickOnSignIn();
        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            loginpage.EnterEmailAddress();
        }
        
        [When(@"I enter my Password")]
        public void WhenIEnterMyPassword()
        {
            loginpage.EnterPassword();
        }
        
        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            loginpage.ClickSignInButton();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            
        }
    }
}
