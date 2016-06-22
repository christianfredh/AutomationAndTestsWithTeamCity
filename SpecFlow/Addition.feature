Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given a calculator 
	When I have add 50 and 70 together into the calculator
	Then the result should be 120
