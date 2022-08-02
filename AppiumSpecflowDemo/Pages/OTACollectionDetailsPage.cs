using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowDemo.Pages
{
    class OTACollectionDetailsPage
    {
        private ScenarioContext _scenarioContext;
        private AndroidDriver<AndroidElement> androidDriver;


        public OTACollectionDetailsPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        AndroidElement CompanyCode => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("CompanyCode");
        AndroidElement CollectionCode => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("CollectionCode"); 
        AndroidElement ContinueButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("ContinueButton"); 
        AndroidElement CancelButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("CancelButton");
        AndroidElement BurgerMenuIcon => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("BurgerMenuIcon");
        AndroidElement HelpAndSupportMenuItem => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("HelpAndSupportMenuItem");
        AndroidElement ReopenLastAccessedLockersMenuItem => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("ReopenLastAccessedLockersMenuItem");
        AndroidElement BurgerCloseButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("BurgerCloseButton");        
          

        public bool CollectionCodeEditButtonExist() => CollectionCode.Displayed;
        public bool CompanyCodeEditButtonExist() => CompanyCode.Displayed;

        public bool ContinueButtonExist() => ContinueButton.Displayed;
        public bool CancelButtonExist() => CancelButton.Displayed;
        public bool BurgerMenuIconExist() => BurgerMenuIcon.Displayed;

        public void ClickBurgerMenuIcon() => BurgerMenuIcon.Click();

        public bool HelpAndSupportMenuItemExist() => HelpAndSupportMenuItem.Displayed;
        public bool ReopenLastAccessedLockersMenuItemExist() => ReopenLastAccessedLockersMenuItem.Displayed;

        public void ClickBurgerCloseButton() => BurgerCloseButton.Click();

        public bool ContinueButtonEnabled() => ContinueButton.Enabled;

        public void ClickCancelButton() => CancelButton.Click();

        public void ClickContinueButton() => ContinueButton.Click();

        public void CompanyCodeSendKeys(String code)
        {
            CompanyCode.SendKeys(code);
        }

        public void CollectionCodeSendKeys(ulong code)
        {
            CollectionCode.SendKeys(code.ToString());
        }

        public string GetInputCompanyCode()
        {
            var companyCode = CompanyCode.Text;
            Console.WriteLine("code --------"+companyCode);
            return companyCode;
        }

        public string GetInputCollectionCode()
        {
            var companyCollectionCode = CollectionCode.Text;
            Console.WriteLine("code --------" + companyCollectionCode);
            return companyCollectionCode;
        }



    }
}
