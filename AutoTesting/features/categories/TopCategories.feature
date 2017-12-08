Feature: As a user, I want to see the top categories, so that I can make my selection

Background: 
Given I am on the homepage

Scenario Outline: Verify that top categories are displayed for items
When I hover over <option>
Then top categories are displayed
| Women |
| Men   |
| Kids  |

Examples: 
| option  |
| Fashion |