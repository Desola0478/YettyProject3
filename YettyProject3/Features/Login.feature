Feature: Login
	In order to access my giftrete account
	I need to login
	
	

@mytag
Scenario: Login
	Given I navigate to giftrete website
	And I click on sign in
	When I enter my email address
	And I enter my Password
	And I click on Sign in button
	Then I should be logged in
