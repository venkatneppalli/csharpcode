Feature: TestHotelApp
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@LoginDummy
Scenario: LoginIntoDummy
	Given I go to http://rediff.com on Chrome
	And I enter username as "usertext"
	And I enter password as "passowrdtext"
	When I press on Login button
	Then I see login success message
