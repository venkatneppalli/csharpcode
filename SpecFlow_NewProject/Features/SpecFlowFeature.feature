Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@LoginQA
Scenario Outline: Login with Credentails
	Given I have entered url into the "<Browser>"
	And I have entered "<username>" as well as "<passname>"
	When I press loginBtn_xpath
	Then the result should be "<status>" on the screen

	Examples:
	| Browser | username        | passname | status  |
	| chrome  | seleniumtesting | password1  | success |