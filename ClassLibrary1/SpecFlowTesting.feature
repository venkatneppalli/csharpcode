Feature: SpecFlowTesting
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@logTest
Scenario: Login into HotelApp
	Given I go to "<url>" on "<browser>"
	And I entered "<username>" as "<seleniumtesting>"
	And I entered "<password>" as "<password1>"
	When I press "<loginbutton>"
	Then the result should "<loginsuccess>"


