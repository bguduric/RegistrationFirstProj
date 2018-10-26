Feature: Registration
	In order to test if sign in works
	As a user
	I want to be able to access the system after I enter my data

@mytag
Scenario: Register to automation practice site
Given User navigates to automation practice web site
	And user clicks on sign in button
Then authentication page is displayed
When user enters valid email address
	And user clicks on the Create an account button
	Then create an account page is displayed
	When user enters valid data
	And click Register button
	Then user is successfully created
	When user clicks on sign out button
	Then authentication page is displayed user can login
	When user enters valid email address and password
	And user clicks on the sign in button
Then user is successfuly signed in