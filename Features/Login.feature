Feature: Login

@mytag
Scenario: I want to be able to login 
	Given I set username with "standard_user"
	And I set password with "secret_sauce"
	When I click on the login button
	When I am in the home page

Scenario: I into Sauce Demo page with user locked 
	Given I set username with "locked_out_user"
	And I set password with "secret_sauce"
	When I click on the login button
	Then I verify that a error message that says "Epic sadface: Sorry, this user has been locked out."