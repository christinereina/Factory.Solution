# <h1 align = "center"> Star-on | Star-off Factory

![Preview]()

##### <h4 align = "center">  Many-to-Many Relationships, Indepedent Project for Epicodus, 08.7.2020

#### <h4 align = "center"> By _**Christine Augustine**_

## Description

This factory application is greatly inspired by the Dr.Seuss story "The Sneetches".

This Factory application will help Sylvester McMonkey McBean to keep track of his machine repairs. This MVC web application will help McBean manage their engineers, and the machines they are licensed to fix. McBean will be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. This application will create a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Star-On, the Star-Off) and a machine can have many engineers (Mr.Lima Bean, Ms.Green Beans, Mrs.Red Beans) licensed to repair it.

## Specifications

User is greeted with a splash Welcome page. 

| Behavior   |   Input   |  Output | 
|----------|:-------------:|------:|

## Setup/Installation Requirements 

1. Clone this [repository](https://github.com/christinereina/Factory.Solution) from GitHub
2. Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
3. Once you have the directory open, navigate to the top level of the directory and create a `appsettings.json` file which contains:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=christine_augustine;uid=root;pwd=epicodus;"
  }
}
```
4. Then, install the REPL dotnet script, run dotnet tool `install -g dotnet-script` in your terminal.
5. To install the necessary dependencies, run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

### Recreating the Local Database

1. Open [MySQL](https://www.mysql.com/) + Local 3306
2. Use this query selection to create the database:
```

```

## Known Bugs

N/A

## Support and contact details

_Please feel free to contact the author through GitHub **[christinereina](https://github.com/christinereina)** with any feedback, questions or concerns._


## Technologies Used

* C# 
* .NET-Core 2.2
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Visual Studio Code
* Git Version Control 
* GitHub

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **Christine Augustine**