Feature: This Test suite contains test scenarios for Language module
      1.Create Language
      2.Edit Language
      3.Delete Language

 Scenario Outline: A. Create a new Language record 
    Given User log into Mars portal
    When User navigate to Language module
    And User create a new Language record <Language> <Level>  
    Then the tooltip message should be "<Language> has been added to your languages"

    Examples:
      | Language    | Level               |
      | 'English'   | 'Basic'             |
      | 'Hindi'     | 'Conversational'    |
      | 'Japanese'  | 'Native/Bilingual'  |
      | '$@#nch'    | 'Fluent'            |

 Scenario: B. Create a language record without data
	Given User log into MARS portal 
	And User create a new language record without data
	Then the tooltip message should be "Please enter language and level"

 Scenario: C. Create a language record with duplicate data
	Given User log into MARS portal 
	And User create a new language record 'English' 'Basic'
	Then the tooltip message should be "This language is already exist in your language list." 

 Scenario: D.Check the limit of the Language records
    Given User log into MARS portal
	Then the AddNewButton Does Not Exist 
      

 Scenario Outline: E. Edit an existing Language record
    Given User log into Mars portal 
    When User navigate to Language module
    And User edit an existing Language record <oldLanguage>  <newLanguage> <oldLevel> <newLevel> 
    Then the tooltip message should be "<newLanguage> has been updated to your languages"

    Examples:
      | oldLanguage    | newLanguage    | oldLevel          | newLevel               |
      | 'Hindi'        | 'Spanish'      | 'Conversational'  | 'Basic'                |
      | 'Japanese'     | 'French'       | 'Native/Bilingual'| 'Conversational'       |

 Scenario: F. Delete an existing Language record
    Given User log into Mars portal 
    When User navigate to Language module
    And User delete an existing Language record 'French'
    Then the tooltip message should be "French has been deleted from your languages"

