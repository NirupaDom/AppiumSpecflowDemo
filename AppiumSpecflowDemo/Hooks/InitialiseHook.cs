using AppiumSpecflowDemo.Drivers;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Appium.Android;


namespace AppiumSpecflowDemo.Hooks
{
    [Binding]
    internal class InitialiseHook
    {
        private static ScenarioContext _scenarioContext;
        public static AppiumDriver _appiumDriver = new AppiumDriver();
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;


        public InitialiseHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\nirupa.neerugatti\source\repos\AppiumSpecflowDemo\AppiumSpecflowDemo\Reports\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }

        [BeforeFeature]
        [Obsolete]
        public static void Initialize(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            featureContext.Set(_appiumDriver.InitialiseAppium());
            featureContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("Username").SendKeys("Quality");
            featureContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("Password").SendKeys("Quality");
            featureContext.Get<AndroidDriver<AndroidElement>>().FindElementByAccessibilityId("SignInButton").Click();            
        }

        [BeforeScenario]
        [Obsolete]
        public static void initailiseScenario()
        {
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterStep]
        public static void InsertReportingsteps()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
        }     


        [AfterScenario]
        public void TearUp()
        {
            _appiumDriver.QuitApp();

        }

       
    }
}
