using System;
using TechTalk.SpecFlow;
using UdemyTestProject.PageObjects;

namespace UdemyTestProject.StepDefinitions
{
    [Binding]
    public class SignUpSteps
    {
        SignUpPage signUpPage;
        
        public SignUpSteps()
        {
            signUpPage = new SignUpPage(); //instantiate and delare 
        }       
                
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebsite();
            
            throw new PendingStepException();
        }

        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUserName();

            throw new PendingStepException();
        }

        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            signUpPage.EnterEmail();
            
            throw new PendingStepException();
        }

        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPassword();
            
            throw new PendingStepException();
        }

        [When(@"I click on Signup")]
        public void WhenIClickOnSignup()
        {
            signUpPage.ClickSignUpButton();
            
            throw new PendingStepException();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
