Feature: Enable engineers to collect a delivery using an OTA/Job-Based code in Thiventory Mobile with valid company code and collection code

@THIN-6427
Scenario: As a Thinventory Mobile user when I press the 'Use collection code' button I want to be able to enter my collection code details
	Given Thinventory Mobile is launched in QA mode
	  And User select use collection code button
	 Then OTACollectionDetailsPage is displayed
	  And Company code edit button is displayed
	  And Collection code edit button is displayed
	  And Continue button is displayed and disabled
	  And Cancel button is displayed
	  And Hamburger menu is displayed

@THIN-6427
Scenario: OTACollectionDetailsPage Company code and collection code min length validation
	Given OTACollectionDetails Page is displayed
	 When Length for company code and collection code matches to min length required "KVV" and "123456"		  
	 Then Continue button should be enabled

@THIN-6427
Scenario: OTACollectionDetailsPage Company code and collection code null and less than min length validation
	 Given OTACollectionDetails Page is displayed
	 When Length for company code and collection code less than minimum length "AB" and "12345"			   		   
	 Then Continue button should be disabled	 

@THIN-6427
Scenario: OTACollectionDetailsPage Company code and collection code max length validation
	Given OTACollectionDetails Page is displayed
	 When Length for company code and collection code "ABC" and "12345678912345678912"		  		  
	 Then Continue button should be enabled

@THIN-6427
Scenario: OTACollectionDetailsPage cancel button navigation
	Given OTACollectionDetails Page is displayed
	 When cancel button is selected 
	 Then Signin page is displayed

@THIN-6427
Scenario: OTACollectionDetailsPage hamburger menu validation
	Given OTACollectionDetails Page is displayed
	 When Hamburger menu is selected 
	 Then Menu items are displayed to the user 
		 