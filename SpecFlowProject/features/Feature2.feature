Feature: Shopping basket

Background:
	Given I have the following data
		| Product id | Reserve Qty | Basket |
		| 1          | 2           | 0      |
		| 2          | 0           | 0      |
		| 3          | 2           | 1      |
		| 4          | 5           | 1      |

Scenario Outline: Testing functionality of basket when product is <Test Description>
	Given I am on the product detail page of product <Product>
	When I click the Add to Busket button
	Then the quantities are
		| Field       | Value    |
		| Reserve Qty | <Stock>  |
		| basket      | <Busket> |
	And a message <Message> is displayed to the customer

Examples:
	| Test Description  | Product | Stock | Busket | Message             |
	| In stock          | 1       | 1     | 1      | Added to basket     |
	| Not stock         | 2       | 0     | 0      | Not in stock        |
	| Already in basket | 3       | 2     | 1      | Limited to one only |

Scenario: Customer can add an offer to the basket
	Given user have following offercodes
		| OfferCode | Expiry     | CodesType | IsValid |
		| CODE1     | 01/31/2024 | ByDate    | yes     |
		| CODE2     | 01/15/2024 | ByProduct | no      |
	And today is '01/12/2024'
	When user add offer code 'CODE1' to the basket
	Then the offer is valid

Scenario: Customer can add non-expired offer code to the basket
	Given user has offer code 'CODE1' which expires in '3 days time'
	When user adds offer code 'CODE1' to the basket
	Then the offer is valid

	@anotherExample
Scenario: Customer can not add expired offer code to the basket
	Given user has offer code 'CODE1' which expires '7 days ago'
	When user adds offer code 'CODE1' to the basket
	Then the offer is not valid

@example
Scenario: Customer discount check
	Given user is '3rd' customer to view the offer page
	Then user receives special discount
