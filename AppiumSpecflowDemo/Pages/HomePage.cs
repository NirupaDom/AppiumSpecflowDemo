using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowDemo.Pages
{
    class HomePage
    {
        private ScenarioContext _scenarioContext;
        private AndroidDriver<AndroidElement> androidDriver;


        public HomePage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        AndroidElement homeButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("homeButton");

        public bool IsHomeButtonExist() => homeButton.Displayed;








    }
}
