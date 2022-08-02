Feature: Enable engineers to collect a delivery using an OTA/Job-Based code in Thiventory Mobile

@THIN-6426 
Scenario: As an unregistered Thinventory Mobile user I want the option of using Thinventory Mobile with a collection code
	Given Thinventory Mobile is launched in QA mode
	 Then Signin page is displayed
	  And Username and password edit labels are displayed
	  And Log In button is displayed
	  And Forgotten Password link is displayed and enabled
	  And Use collection code button is displayed
	 When user select use collection code button
	 Then OTACollectionDetailsPage is displayed
	  
		 