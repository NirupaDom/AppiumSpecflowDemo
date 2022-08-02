using AppiumSpecflowDemo.Drivers;
using AppiumSpecflowDemo.Pages;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowDemo.StepDefinitions
{
    [Binding]
    public class RetrieveDeliveryDetailsErrorSteps
    {
        public static AppiumDriver _appiumDriver = new AppiumDriver();
        private readonly ScenarioContext _scenarioContext;
        SigninPage signinPage;
        OTACollectionDetailsPage otaCollectionDetailsPage;

        public RetrieveDeliveryDetailsErrorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            signinPage = new SigninPage(scenarioContext);
            otaCollectionDetailsPage = new OTACollectionDetailsPage(scenarioContext);
        }

        [Given(@"Block API calls in TM App")]
        public void GivenBlockAPICallsInTMApp()
        {
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("Username").SendKeys("TMAuto1");
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("Password").SendKeys("password123.");
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("SignInButton").Click();

            //Block API calls in feature toggles page in test card
            Thread.Sleep(TimeSpan.FromSeconds(30));
            var listItem = _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("list");
            listItem.FindElementByAccessibilityId("TestCardMenuOption").Click();
            //_scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("TestCardMenuOption").Click();
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByXPath("//android.view.ViewGroup[@content-desc='MyLayout'']/android.widget.Button[4]").Click();
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("BlockApiCallsSwitch").Click();
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("homeButton").Click();
            _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("SignOutMenuOption").Click();

        }

        [Then(@"RetrieveDeliveryDetailsErrorPage is displayed")]
        public void ThenRetrieveDeliveryDetailsErrorPageIsDisplayed()
        {
            throw new PendingStepException();
        }

    }
}
 