Feature: BlueSkyCitadelForm
	In order to test the blueskycitadel form
	I want to be able to automate it

@regression
Scenario: Valid form submission
	Given I navigate to the Bluesky Citadel form
	And I click on automation testing form
	And I enter the Single line Text
	And  I select one in the select box
	And I enter myemail address
	And I select the multi-select
	And I select the Radio List
	And I select the checkbox list
	And I select United Kingdom as Country
	And I select 12th of the current month
	And I click on the summit button
	Then the message "your form has been sucessfully submitted."
