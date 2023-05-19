# _Eau Claire's Hair Salon_

#### By _**Marcus Kyung**_

#### _This EF Core C# web application is designed to allow a user to add stylist and client information to an associated SQL database_

## Technologies Used

* _C#/.NET Version v6.0.402_
* _EF Core v6.0.0_
* _ASP.NET MVC Framework_
* _SQL/MySQLWorkbench_

## Description

This EF Core C# Web application is designed for Eau Claire's hair salon and allows management to add, retrieve, and edit stylist and client information from a SQL database. 

## Setup/Installation Requirements

1. Clone this repo from GH to your local machine.
2. In root directory of the file called HairSalon.Solution, add a file titled ```appsettings.json```. Include this line of code ```{"ConnectionStrings": {"DefaultConnection":"Server=localhost;Port=3306;database=[YOUR_DATA_BASE_HERE];uid=[YOUR_USER_ID_HERE];pwd=[YOUR_PASSWORD_HERE];"}}```
3. Download SQL. Import the SQL database included in this project's repository. 
4. Update the ```appsettings.json``` file with your SQL details, replacing [YOUR_DATA_BASE_HERE], [YOUR_USER_ID_HERE], and [YOUR_PASSWORD_HERE]. 
5. Using your device's terminal navigate to the "HairSalon" directory and use command ```dotnet restore``` to restore project dependencies.
6. Using your device's terminal use command ```dotnet run``` to run this project in your browser. 
7. In your browser window navigate to localhost:5001/ to view project.

## Known Bugs

* _No known bugs as of 5/19/23._

## License

_For questions, comments, or concerns please reach out at Kyungmj@gmail.com_

MIT License

Copyright (c) [2023] [Marcus Kyung]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: 

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR\ A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.