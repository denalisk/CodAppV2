# "Cods on Ice" An exercise in C# and the ASP.Net framework

#### _Cod on Ice_, 04.22.2017

### By _Sam Kirsch_

## Description

#### A simple website built for a fictitious fishmonger as an exercise in ASP.NET Core and MSSQL database usage. Users can add themselves to a mailing list and read about the fish company, while administrators perform basic site management tasks. The site implements basic User Authentication to separate anonymous users from administrators.

## Specifications

* Users may add themselves to the mailing list and view the newsletters
* Admins can view the mailing list
* Admins can edit content on the homepage and create newsletters
* Admins can add, edit, or delete articles in newsletters
* Admins can add other Admins

## Setup
>Requirements: Microsoft Visual Studio 2017
* Clone this repository
* Open the solution in visual studio 2017
* In the directory CodApp run the command dotnet restore
* In the directory CodApp>src>CodApp run the command dotnet ef database update ArticleRework
* In the same directory, open the file script.sql in MSSQL Management Studio and execute it
* Click the "run" green arrow in Microsoft visual studio - you will automatically be redirected to the home page
* The default administrator login is Username: "admin",  Password: "Password1!"

### Technologies Used

* HTML and CSS
* C# with ASP.Net
* MSSQL database manager

[github link for this project](https://github.com/denalisk/codappv2)

##### Copyright (c) 2017 Sam Kirsch.

##### Licensed under the MIT license.
