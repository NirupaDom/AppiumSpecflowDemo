using AppiumSpecflowDemo.Drivers;
using AppiumSpecflowDemo.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AppiumSpecflowDemo.StepDefinitions
{
    [Binding]
    public class OTASigninSteps
    {
        private readonly ScenarioContext _scenarioContext;
        SigninPage signinPage;
        OTACollectionDetailsPage otaCollectionDetailsPage;

        public OTASigninSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            signinPage = new SigninPage(scenarioContext);   
            otaCollectionDetailsPage = new OTACollectionDetailsPage(scenarioContext); 
        }

        [Given(@"Thinventory Mobile is launched in QA mode")]
        public void GivenThinventoryMobileIsLaunchedInQAMode()
        {
            AppiumDriver _appiumDriver = new AppiumDriver();
            _scenarioContext.Set(_appiumDriver.RelaunchApp());
        }

        [Then(@"Signin page is displayed")]
        public void ThenSigninPageIsDisplayed()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.That(signinPage.SignInButtonEXist(), Is.True, "Signin page is not displayed");
        }

        [Then(@"Use collection code button is displayed")]
        public void UseCollectionCodeButtonIsDisplayed()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.That(signinPage.CollectionCodeButtonEXist(), Is.True, "Collection code button is not displayed");
        }

        [Then(@"Username and password edit labels are displayed")]
        public void ThenUsernameAndPasswordEditLabelsAreDisplayed()
        {
            signinPage.UsernameEditLabelExist();
            signinPage.PasswordEditLabelExist();
        }

        [Then(@"Log In button is displayed")]
        public void ThenLogInButtonIsDisplayed()
        {
            signinPage.SignInButtonEXist();
        }

        [Then(@"Forgotten Password link is displayed and enabled")]
        public void ThenForgottenPasswordLinkIsDisplayedAndEnabled()
        {
            signinPage.ForgottenPasswordlinkExist();
        }

        [Given(@"User select use collection code button")]
        [When(@"user select use collection code button")]
        public void WhenUserSelectUseCollectionCodeButton()
        {
            signinPage.ClickUseCollectionCode();
        }

        [Then(@"OTACollectionDetailsPage is displayed")]
        public void ThenOTACollectionDetailsPageIsDisplayed()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            otaCollectionDetailsPage.ContinueButtonExist();
        }
    }
}
