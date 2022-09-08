Feature: Home
	
Background: User is logger into sauce demo web page
	Given I set username with "standard_user"
	And I set password with "secret_sauce"
	When I click on the login button
	Scenario Outline: Products are available in the home page
		When I am in the home page
		Then I verify that <item> is displayed
		
		Examples: 
			| item                  |
			| Sauce Labs Backpack   |
		
	