Feature: DiscountCalculation
	In order to avoid atract more customers
	As a sales representative
	I want to calculate possible discounts

Scenario: Birthday
	Given A customer
	And it is his birthday
	When I calculate the discount
	Then the result should be 40
