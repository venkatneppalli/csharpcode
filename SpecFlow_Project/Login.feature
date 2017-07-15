Feature: LoginTesting
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@LoginTests
Scenario Outline: Loggin into HotelApp
	Given I go to "url" on "<Browser>"
	And I enter "loginusername" as "<Username>"
	And I enter "loginpassword" as "<Password>"
	When I press on "loginbutton"
	Then login should be "success"
	
Examples:|
| Browser  | Username        | Password  |
| Chrome   | seleniumtesting | password1 |