using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowDemo.Pages
{
    public class OTADeliveryDetailsFoundPage
    {
        private ScenarioContext _scenarioContext;
        private AndroidDriver<AndroidElement> androidDriver;


        public OTADeliveryDetailsFoundPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        AndroidElement PageHeaderTitle => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("PageHeaderTitle");
        AndroidElement ViewOnMapButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("ViewOnMapButton");
        AndroidElement ContinueButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("ContinueButton");
        AndroidElement CancelButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("CancelButton");
        AndroidElement BurgerMenuIcon => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("HeaderImageButton");
        AndroidElement MapApp => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByXPath("/hierarchy/android.widget.FrameLayout");
        AndroidElement DeliveryLocation => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("AB14806 Nirupa01"); 


        public String PageHeaderTitleText() => PageHeaderTitle.Text;
        public void ClickViewMapButton() => ViewOnMapButton.Click();

        public bool ContinueButtonExist() => ContinueButton.Displayed;
        public bool CancelButtonExist() => CancelButton.Displayed;
        public bool ViewMapButtonExist() => ViewOnMapButton.Displayed;
        public bool BurgerMenuIconExist() => BurgerMenuIcon.Displayed;

        public void ClickCancelButton() => CancelButton.Click();
        public string MapLaunch()
        {
            string packageAttribute = MapApp.GetAttribute("Package");
            return packageAttribute; 
        }

        public string DeliveryLocationDetails() => DeliveryLocation.Text;
        
        



    }
}
