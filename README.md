# <h1 align = "center"> Star-on | Star-off Factory

![Preview](./Factory/wwwroot/img/welcome.png)

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
### Installing and Configuring MySQL

1. Start by downloading the MySQL Community Server .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484914). Click the download icon. Use the *No thanks, just start my download link*.
2. Follow along with the Install, once on the configuation make sure you:
- Use Legacy Password Encryption.
- Set a unique password
3. Once finished, open your terminal and enter the command echo `export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`. This will save this path in .bash_profile, which is where our terminal is configured.
4. Next, download the MySQL Workbench .dmg file [HERE](https://dev.mysql.com/downloads/file/?id=484391). Again, use the *No thanks, just start my download link*.
5.Install MySQL Workbench to Applications folder.

### Recreating the Local Database

1. Open **MySQL Workbench**, select Local 3306 and enter your password
2. Use this query selection to create the database:
```
CREATE DATABASE `christine_augustine`; 

USE `christine_augustine`;

CREATE TABLE `EngineerMachine` (
  `EngineerMachineId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerId` int(11) NOT NULL,
  `MachineId` int(11) NOT NULL,
  PRIMARY KEY (`EngineerMachineId`),
  KEY `IX_EngineerMachine_EngineerId` (`EngineerId`),
  KEY `IX_EngineerMachine_MachineId` (`MachineId`),
  CONSTRAINT `FK_EngineerMachine_Engineers_EngineerId` FOREIGN KEY (`EngineerId`) REFERENCES `engineers` (`EngineerId`) ON DELETE CASCADE,
  CONSTRAINT `FK_EngineerMachine_Machines_MachineId` FOREIGN KEY (`MachineId`) REFERENCES `machines` (`MachineId`) ON DELETE CASCADE
);

CREATE TABLE `Engineers` (
  `EngineerId` int(11) NOT NULL AUTO_INCREMENT,
  `EngineerName` longtext,
  `EngineerSkill` longtext,
  `HireDate` datetime(6) NOT NULL,
  PRIMARY KEY (`EngineerId`)
);

CREATE TABLE `Machines` (
  `MachineId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Number` int(11) NOT NULL,
  `Description` longtext,
  PRIMARY KEY (`MachineId`)
);

```
3. Once it connects, you should be all set!

[see detailed instructions for windows/mac](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) 


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