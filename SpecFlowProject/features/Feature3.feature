Feature: Buy a clothes

Scenario: Check buying a clothes by user
	Given user have following size of clothes
		| Name           | Size |
		| Test Product 1 | XXL  |
		| Test Product 2 | L    |
		| Test Product 3 | S    |
	Then the clothing data is translated as following
		| Name           | Size       |
		| Test Product 1 | ExtraLarge |
		| Test Product 2 | Large      |
		| Test Product 3 | Small      |

Scenario: Chalenge
	Given exists following users
		| Name    | UserType   | LoginOutLast |
		| John    | Superviser | <null>       |
		| Bob     | Staff      | <null>       |
		| Charlie | Customer   | 01/18/2024   |
		| <null>  | Visitor    | 05/18/2024   |

Scenario: Stores
	Given user has the following stores
		| StoreName   | GeoLocation  |
		| Southampton | 3.14, 5.43   |
		| London      | 3.23, 5.4321 |
		| Bristol     | 5.43, 3.23   |


