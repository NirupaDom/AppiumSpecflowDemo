using System;
using TechTalk.SpecFlow;

namespace AppiumSpecflowDemo.StepDefinitions
{
    [Binding]
    public class ReturnsCompleteMSDFlowSteps
    {
        [Given(@"the field person signed into the app and changed to QA mode ""([^""]*)""")]
        public void GivenTheFieldPersonSignedIntoTheAppAndChangedToQAMode(string notEnabledVerifyReturns)
        {
            throw new PendingStepException();
        }

        [Given(@"MSD feature toggle is enabled")]
        public void GivenMSDFeatureToggleIsEnabled()
        {
            throw new PendingStepException();
        }

        [Given(@"Lock simulator is enabled")]
        public void GivenLockSimulatorIsEnabled()
        {
            throw new PendingStepException();
        }

        [Given(@"Customise lock configuration ""([^""]*)""")]
        public void GivenCustomiseLockConfiguration(string closeAfter)
        {
            throw new PendingStepException();
        }

        [When(@"engineer selects the drop off my return")]
        public void WhenEngineerSelectsTheDropOffMyReturn()
        {
            throw new PendingStepException();
        }

        [Then(@"SuitableReturnDoorPage is displayed")]
        public void ThenSuitableReturnDoorPageIsDisplayed()
        {
            throw new PendingStepException();
        }

        [When(@"engineer selects Locker Suitable")]
        public void WhenEngineerSelectsLockerSuitable()
        {
            throw new PendingStepException();
        }

        [Then(@"ReturnsLockerOpenPage is displayed")]
        public void ThenReturnsLockerOpenPageIsDisplayed()
        {
            throw new PendingStepException();
        }

        [When(@"engineer places an item selects Door closed-continue")]
        public void WhenEngineerPlacesAnItemSelectsDoorClosed_Continue()
        {
            throw new PendingStepException();
        }

        [Then(@"ReturnsCompletePage is displayed")]
        public void ThenReturnsCompletePageIsDisplayed()
        {
            throw new PendingStepException();
        }

        [Then(@"engineer selects ""([^""]*)""")]
        public void ThenEngineerSelects(string done)
        {
            throw new PendingStepException();
        }

       /* [Given(@"Customise lock configuration ""([^""]*)""")]
        public void GivenCustomiseLockConfiguration(string openFlex)
        {
            throw new PendingStepException();
        }*/

        [When(@"engineer places an item selects Door closed-continue\(door open\)")]
        public void WhenEngineerPlacesAnItemSelectsDoorClosed_ContinueDoorOpen()
        {
            throw new PendingStepException();
        }

        [Then(@"door still open page is displayed")]
        public void ThenDoorStillOpenPageIsDisplayed()
        {
            throw new PendingStepException();
        }

        [When(@"enginner closes the door selects continue")]
        public void WhenEnginnerClosesTheDoorSelectsContinue()
        {
            throw new PendingStepException();
        }

        /*[Given(@"the field person signed into the app and changed to QA mode ""([^""]*)""")]
        public void GivenTheFieldPersonSignedIntoTheAppAndChangedToQAMode(string fCEnabledVerifyReturns)
        {
            throw new PendingStepException();
        }*/

        [Then(@"VerifyReturnsLockerOpenPage is displayed")]
        public void ThenVerifyReturnsLockerOpenPageIsDisplayed()
        {
            throw new PendingStepException();
        }

        [When(@"engineer selects verify returns Locker Suitable")]
        public void WhenEngineerSelectsVerifyReturnsLockerSuitable()
        {
            throw new PendingStepException();
        }

        [Then(@"VerifyReturnsPage is displayed")]
        public void ThenVerifyReturnsPageIsDisplayed()
        {
            throw new PendingStepException();
        }

        [When(@"engineer places an item selects verify Door closed-continue")]
        public void WhenEngineerPlacesAnItemSelectsVerifyDoorClosed_Continue()
        {
            throw new PendingStepException();
        }

        [When(@"engineer selects ""([^""]*)""")]
        public void WhenEngineerSelects(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"new return process start")]
        public void ThenNewReturnProcessStart()
        {
            throw new PendingStepException();
        }
    }
}
