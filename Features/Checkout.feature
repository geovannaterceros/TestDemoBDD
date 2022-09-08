Feature: As a user I should be able to checkout a purchase
	Background: User is logger into sauce demo web page
		Given I set username with "standard_user"
		And I set password with "secret_sauce"
		When I click on the login button
	Scenario: Sauce Labs Backpack checkout
		When I add Sauce Labs Backpack product to the cart
		And I click on the shopping card
		And I click on the checkout button
		And I fill the customer data with
			| key | value |
			| lastName | Geovanna Lizette | 
			| firstName | Gil Terceros | 
			| codigoPostal | 591 |
		And I click on continue button
		And I click on finish button
		Then I should see a message that says "THANK YOU FOR YOUR ORDER"
		
	