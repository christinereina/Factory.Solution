# <h1 align = "center"> Staron / Staroff Industries

<h4 align = "center">  Many-to-Many Relationships, Indepedent Project for Epicodus, 08.7.2020

 ![Preview](./Factory/wwwroot/img/machine.png)


<h5 align = "center"> The Sneetches got really quite smart on that day,

<h5 align = "center">  The day they decided that Sneetches are Sneetches

<h5 align = "center"> And no kind of Sneetch is the best of the beaches.

# <h4 align = "center"> By Christine Augustine

## Description

This factory application is greatly inspired by the Dr.Seuss story ["The Sneetches"](https://www.seussville.com/book/43167/the-sneetches-and-other-stories/)

This Factory application will help Sylvester McMonkey McBean to keep track of his machine repairs. This MVC web application will help McBean manage their engineers, and the machines they are licensed to fix. McBean will be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. This application will create a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Star-On, the Star-Off) and a machine can have many engineers (Mr.Lima Bean, Ms.Green Beans, Mrs.Red Beans) licensed to repair it.

## Setup/Installation Requirements 

### 1. Install .NET Core 

Download .NET Core SDK from Microsoft Corp  (**[macOS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) | [Windows OS](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)**)

### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal 

### 2. Clone this [repository](https://github.com/christinereina/Factory.Solution) from GitHub

Run the following commands in your Terminal:
```
cd desktop
git clone https://github.com/christinereina/Factory.Solution
cd Wonka.Solution
```
### 3. Install the necessary dependencies to build the project
Run the following commands in your Terminal:
```
dotnet restore
dotnet build
dotnet run
```
### 4. Create the database and project tables
Run the following commands in your Terminal:
```
dotnet ef migrations add Initial
dotnet ef database update
```
### 5. Starting the Server

Initialize a local server to run the project in your browser

Run the following command in your Terminal:
```
dotnet watch run
```

If you are running the script locally, it will open the project in your browser window and shift the focus from the terminal to the browser. 

If not, you can copy and paste this address into your browser to view:

```
http://127.0.0.1:5000
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

[MIT](https://mit-license.org/)

Copyright (c) 2020 **Christine Augustine**