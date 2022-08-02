using AppiumSpecflowDemo.Drivers;
using AppiumSpecflowDemo.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace AppiumSpecflowDemo.StepDefinitions
{
    [Binding]
    public class OTACollectionDetailsPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        SigninPage signinPage;
        OTACollectionDetailsPage otaCollectionDetailsPage;

        public OTACollectionDetailsPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            signinPage = new SigninPage(scenarioContext);
            otaCollectionDetailsPage = new OTACollectionDetailsPage(scenarioContext);
        }

        [Given(@"OTACollectionDetails Page is displayed")]
        public void OTACollectionDetailsPageIsDisplayed()
        {
            AppiumDriver _appiumDriver = new AppiumDriver();
            _scenarioContext.Set(_appiumDriver.RelaunchApp());

            signinPage.ClickUseCollectionCode();            
        }


        [Then(@"Company code edit button is displayed")]
        public void ThenCompanyCodeEditButtonIsDisplayed()
        {
            otaCollectionDetailsPage.CompanyCodeEditButtonExist();
        }

        [Then(@"Collection code edit button is displayed")]
        public void ThenCollectionCodeEditButtonIsDisplayed()
        {
           Assert.That(otaCollectionDetailsPage.CollectionCodeEditButtonExist(),Is.True);
        }

        [Then(@"Continue button is displayed and disabled")]
        public void ThenContinueButtonIsDisplayedandDisabled()
        {
            Assert.That(otaCollectionDetailsPage.ContinueButtonExist(),Is.True);
            Assert.That(otaCollectionDetailsPage.ContinueButtonEnabled, Is.False);
        }

        [Then(@"Cancel button is displayed")]
        public void ThenCancelButtonIsDisplayed()
        {
            Assert.That(otaCollectionDetailsPage.CancelButtonExist(),Is.True);
        }

        [Then(@"Hamburger menu is displayed")]
        public void ThenHamburgerMenuIsDisplayed()
        {
            Assert.That(otaCollectionDetailsPage.BurgerMenuIconExist(),Is.True);
        }

        [When(@"Length for company code and collection code matches to min length required ""([^""]*)"" and ""([^""]*)""")]
        public void LengthForCompanyCodeAndCollectionCodeMatchesToMinLengthRequiredAnd(string CompCode, ulong CollectionCode)
        {
            otaCollectionDetailsPage.CompanyCodeSendKeys(CompCode);
            otaCollectionDetailsPage.CollectionCodeSendKeys(CollectionCode);
        }

        [Then(@"Continue button should be enabled")]
        public void ThenContinueButtonShouldBeEnabled()
        {
            var compCode = otaCollectionDetailsPage.GetInputCompanyCode();
            var collectionCode = otaCollectionDetailsPage.GetInputCollectionCode();
            
            if (compCode.Length == 3 || collectionCode.Length <= 6)
            {
                Assert.That(otaCollectionDetailsPage.ContinueButtonEnabled, Is.True);
            }            
        }

        [When(@"Length for company code and collection code less than minimum length ""([^""]*)"" and ""([^""]*)""")]
        public void WhenLengthForCompanyCodeAndCollectionCodeLessThanMinimumLengthAnd(string compCode, ulong collectionCode)
        {
            otaCollectionDetailsPage.CompanyCodeSendKeys(compCode);
            otaCollectionDetailsPage.CollectionCodeSendKeys(collectionCode);
        }

        [Then(@"Continue button should be disabled")]
        public void ThenContinueButtonShouldBeDisabled()
        {
            var compCode = otaCollectionDetailsPage.GetInputCompanyCode();
            var collectionCode = otaCollectionDetailsPage.GetInputCollectionCode();

            if (compCode.Length == 3 || collectionCode.Length <= 6)
            {
                Assert.That(otaCollectionDetailsPage.ContinueButtonEnabled, Is.False);
            }

        }

        [When(@"Length for company code and collection code ""([^""]*)"" and ""([^""]*)""")]
        public void WhenLengthForCompanyCodeAndCollectionCodeAnd(string compCode, ulong collectionCode)
        {
            otaCollectionDetailsPage.CompanyCodeSendKeys(compCode);
            otaCollectionDetailsPage.CollectionCodeSendKeys(collectionCode);
        }


        [When(@"cancel button is selected")]
        public void CancelButtonIsSelected()
        {
            otaCollectionDetailsPage.ClickCancelButton();
        }

        [When(@"Hamburger menu is selected")]
        public void WhenHamburgerMenuIsSelected()
        {
            otaCollectionDetailsPage.ClickBurgerMenuIcon();
        }

        [Then(@"Menu items are displayed to the user")]
        public void ThenMenuItemsAreDisplayedToTheUser()
        {
            Assert.That(otaCollectionDetailsPage.HelpAndSupportMenuItemExist, Is.True);
            Assert.That(otaCollectionDetailsPage.ReopenLastAccessedLockersMenuItemExist, Is.True);
        }



    }
}
