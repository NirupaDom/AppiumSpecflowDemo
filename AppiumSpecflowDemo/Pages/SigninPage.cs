using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecflowDemo.Pages
{
    class SigninPage
    {
        private ScenarioContext _scenarioContext;
        private AndroidDriver<AndroidElement> androidDriver;


        public SigninPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        AndroidElement Username => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("Username");
        AndroidElement Password => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("Password"); 
        AndroidElement SignInButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("SignInButton");
        AndroidElement ForgottenPassword => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("PasswordResetLink");

        AndroidElement CollectionCodeButton => _scenarioContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("CollectionCodeButton");

        public bool CollectionCodeButtonEXist() => CollectionCodeButton.Displayed;

        public bool SignInButtonEXist() => SignInButton.Displayed;

        public void ClickUseCollectionCode() => CollectionCodeButton.Click();

        public bool UsernameEditLabelExist() => Username.Displayed;

        public bool PasswordEditLabelExist() => Password.Displayed;

        public bool ForgottenPasswordlinkExist() => ForgottenPassword.Displayed;
        








    }
}
