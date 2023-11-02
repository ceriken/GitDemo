Feature: SignUp

In order to be able to use the website, 
the user needs to be able to sign up

@tag1
Scenario: Valid Sign Up
	Given I navigate to the website
	And I enter my username
	And I enter my email
	And I enter my password
	When I click on Signup
	Then I should be able to register successfully

@tag2
Scenario: Invalid Sign Up
	Given I navigate to the website
	And I enter my username
	And I enter my email
	And I enter my password
	When I click on Signup
	Then I should be able to register successfully
