Feature: As a user I want add item a Card

Background: User is logger into sauce demo web page
	Given I set username with "standard_user"
	And I set password with "secret_sauce"
	When I click on the login button
	Scenario Outline: Product add in the 
		When I add Sauce Labs Backpack product to the cart
		When I click on the shopping card
		Then I verify that <item> and <price> in the card
		
		Examples: 
			| item                  |price	|
			| Sauce Labs Backpack   |$29.99	|