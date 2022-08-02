Feature: ReturnsComplete MSD flow with and without verify returns enabled FC

@e2e @5544
Scenario: As an engineer when I have confirmed my return door is closed I want to be informed that my returns are complete
	Given the field person signed into the app and changed to QA mode "NotEnabledVerifyReturns"
		And MSD feature toggle is enabled
		And Lock simulator is enabled
    	And Customise lock configuration "closeAfter"
		When engineer selects the drop off my return
		Then SuitableReturnDoorPage is displayed
		When engineer selects Locker Suitable
		Then ReturnsLockerOpenPage is displayed
		When engineer places an item selects Door closed-continue
		Then ReturnsCompletePage is displayed
		And engineer selects "Done"

 @e2e @5386
Scenario:As an engineer when I have successfully made my return and closed the door I want to confirm that my return was successful
	Given the field person signed into the app and changed to QA mode "NotEnabledVerifyReturns"
		And MSD feature toggle is enabled
		And Lock simulator is enabled
		And Customise lock configuration "openFlex"
		When engineer selects the drop off my return
		Then SuitableReturnDoorPage is displayed
		When engineer selects Locker Suitable
		Then ReturnsLockerOpenPage is displayed
		When engineer places an item selects Door closed-continue(door open)
		Then door still open page is displayed
		When enginner closes the door selects continue 
		Then ReturnsCompletePage is displayed
		And engineer selects "Done"

 @e2e @5547
Scenario:As an engineer when I have confirmed that the opened door is suitable I want to be able to Verify my items and complete the return process
prerequisite : FCEnabled verify returns
	Given the field person signed into the app and changed to QA mode "FCEnabledVerifyReturns"
		And MSD feature toggle is enabled
		And Lock simulator is enabled
		And Customise lock configuration "closeAfter"
		When engineer selects the drop off my return
		Then SuitableReturnDoorPage is displayed
		When engineer selects Locker Suitable 
		Then VerifyReturnsLockerOpenPage is displayed
		When engineer selects verify returns Locker Suitable
		Then VerifyReturnsPage is displayed
		When engineer places an item selects verify Door closed-continue
		Then ReturnsCompletePage is displayed
		And engineer selects "Done"
  @e2e @5548
Scenario: As an engineer once I have completed my return I want the option to find more return doors or exit the return process
		Given the field person signed into the app and changed to QA mode "NotEnabledVerifyReturns"
		And MSD feature toggle is enabled
		And Lock simulator is enabled
		And Customise lock configuration "closeAfter"
		When engineer selects the drop off my return
		Then SuitableReturnDoorPage is displayed
		When engineer selects Locker Suitable
		Then ReturnsLockerOpenPage is displayed
		When engineer places an item selects Door closed-continue
		Then ReturnsCompletePage is displayed
		When engineer selects "Return More Items"
		Then new return process start
