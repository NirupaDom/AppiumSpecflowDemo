Feature: ViewOnMapDeliveryLocationDetails

@THIN-6503
Scenario: As an unauthenticated Thinventory Mobile user I want be able to view my delivery location on a map
	Given Thinventory Mobile is launched in QA mode
	  And User select use collection code button
	  And User enter valid details and tap on Continue Button
			| CompanyCode | CompanyCollectionCode |
			| KVV         | 999999                |
	 Then OTADeliveryDetailsFoundPage is displayed
	 When User select Viewonmap button
	 Then Default Map Application is launched and location is pinned 
	  

		 