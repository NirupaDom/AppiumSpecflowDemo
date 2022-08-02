Feature: Display RetrieveDeliveryDetailsErrorPage when API call fails

@THIN-6509
Scenario: As an unauthenticated Thinventory Mobile user I want to be informed if the delivery details lookup fails
	Given Thinventory Mobile is launched in QA mode
	  And Block API calls in TM App
	  And User select use collection code button
	  And User enter valid details and tap on Continue Button
			| CompanyCode | CompanyCollectionCode |
			| KVV         | 999999                |
	 Then RetrieveDeliveryDetailsErrorPage is displayed
	 
		 