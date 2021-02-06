Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
	In order to avoid silly mistakes
	As a math idiot
	I *want* to be told the **sum** of ***two*** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given I navigate to Mens Tennis Shoe page
	When I save the value of shoe 1 price element as alias price
	When I click on shoe 1 element
	Then I am on the Shoe1 page
	Then I Verify the element Price to be equal to alias price

@mytag
Scenario: Api call for Vehicles
Then I verify api call vehicles/?search=Sand with passenger 30
