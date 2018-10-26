Feature: SignIn
	In order to test if sign in works
	As a user
	I want to be able to access the system after I enter my credencials

@mytag
Scenario: Sign in to Automation practice web site 2
Given User navigates to automation practice web site 2
	And user clicks on sign in button 2
	And authentication page is displayed 2
When user enters valid email address and password
	And user clicks on the sign in button
Then user is successfuly signed in