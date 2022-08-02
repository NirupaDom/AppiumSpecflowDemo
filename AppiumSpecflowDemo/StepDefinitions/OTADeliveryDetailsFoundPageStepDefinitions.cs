using AppiumSpecflowDemo.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AppiumSpecflowDemo.StepDefinitions
{
    [Binding]
    public class OTADeliveryDetailsFoundPageStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        SigninPage signinPage;
        OTACollectionDetailsPage otaCollectionDetailsPage;
        OTADeliveryDetailsFoundPage otaDeliveryDetailsFoundPage;


        public OTADeliveryDetailsFoundPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            otaCollectionDetailsPage = new OTACollectionDetailsPage(scenarioContext);
            otaDeliveryDetailsFoundPage =  new OTADeliveryDetailsFoundPage(scenarioContext);
        }

        [Given(@"User enter valid details and tap on Continue Button")]
        public void GivenUserEnterValidDetailsAndTapOnContinueButton(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            otaCollectionDetailsPage.CompanyCodeSendKeys(data.CompanyCode);
            otaCollectionDetailsPage.CollectionCodeSendKeys((ulong)data.CompanyCollectionCode);

            otaCollectionDetailsPage.ClickContinueButton();
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        [Then(@"OTADeliveryDetailsFoundPage is displayed")]
        public void ThenOTADeliveryDetailsFoundPageIsDisplayed()
        {
            Assert.That(otaDeliveryDetailsFoundPage.ViewMapButtonExist(), Is.True);
        }

        [When(@"User select Viewonmap button")]
        public void WhenUserSelectViewonmapButton()
        {
            otaDeliveryDetailsFoundPage.ClickViewMapButton();
        }

        [Then(@"Default Map Application is launched and location is pinned")]
        public void ThenDefaultMapApplicationIsLaunchedAndLocationIsPinned()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Assert.AreEqual(otaDeliveryDetailsFoundPage.MapLaunch(), "com.google.android.apps.maps");
            Assert.AreEqual(otaDeliveryDetailsFoundPage.DeliveryLocationDetails(), "AB14806 Nirupa01");
            
        }
    }
}
