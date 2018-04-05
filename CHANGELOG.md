# Changelog
All notable changes to this project will be documented in this file.

##Team member: Castiel Li (CL) , Jason Chen (JC) , Harrison Milbradt (HM) , Mu Chen (Paul) Li (ML)

## [0.1.3]
### 2018-03-22
#### Changed
* Fix the BoatPicture Max size to Int.maxValue so it fits the amount of bytes when uploading pictures - NC
* Edited the Detail and Index views to display the image - NC
* Edited the Create and Edit views to include input type file - NC
* Fix the Edit view to display status correctly - NC
#### Added
* Added control for image upload inside the BoatController.Create and Edit function - NC
* Add Login and Register API
* Use OpenIddict token authentication
* Add token view models

## [0.1.2]
### 2018-03-20
#### Changed
* Fix boat and user models - JC
* Fix boat Controllers and Views - JC
* Fix Boat status dropdown menu - JC

## [0.1.1]
### 2018-03-20
#### Changed
* Clean up docker configuration files - JC
* Update README - JC

## [0.1.0]
### 2018-03-13
#### Added
* Boat API Controller, regular controller and views - ML
* A workaround in Startup.cs to the "No parameterless constructor defined for this object" error when trying to create a controller. Check Startup.cs - ML
* Add user, boat, and reservation models - JC
* setup docker yml files - JC
* Add enumerators status - JC

#### Changed
* Updated Error message for Boat Model - CL
* Updated Error message for User Model - CL
* Updated Error message for Reservation Model - CL
* Modify register view and controller - JC

## [0.0.2]
### 2018-03-09
#### Added
* Setup Travis - HM
* Added Unit testing project - HM
* Added travis to readme - HM

## [0.0.1]
### 2018-03-01
#### Added
* Setup MVC template - JC

### 2018-02-27
#### Added
* project folder - JC

#### Changed
* readme.md (Added addtional information for readme) - CL