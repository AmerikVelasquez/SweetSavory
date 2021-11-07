# SweetSavory
#### by Amerik Velasquez
#### SweetSavory
## technology used

* C#
* MySQL
* EntityCore Framework
* .Net 5.0 
* AspNet Core




## Description
A C# application that allows pierrs to market the sweet and savory treat. This is a many to many relationship between treats and flavors.

## Setup
1. Download .NET 5.0 SDK for Windows:https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer

1. Download .NET 5.0 SDK for Mac: https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer

2. clone the repository by entering this in the command line : `git clone https://github.com/AmerikVelasquez/HairSalon` 
3. open the repository in editor  
4. download dotnet entityframework by running the command `dotnet tool install --global dotnet-ef --version 5.0.10` in the terminal
5. run the command `dotnet ef database update` in the terminal
## Setup for appsettings.json
1. in your terminal cd into the file SweetSavory
2. create the file by typing in `touch appsettings.json` into the terminal 
3. input the following code below where it says password means the password for MySql workbench that you have set up and uid is the user id you've set up in MySql workbench
4. 
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=amerik_velasquez;uid=[userid];pwd=[Password];"
  }
}
```  

5. after that is complete to run the application cd into SweetSavory and imput `dotnet run` in your terminal 
6. when it finishes you should see `Now listenin on: http://localhost:5000 ` CTRL click that and view the application in the browser

## Making changes to the Models
1. make the changes you would like to make
2. type in dotnet ef migrations add add[whatever you add]. into the terminal
3. run dotnet ef database update in the terminal

## Known Bugs
no known bugs
## License
This is under the GNU GPLv3
## Contact Information
Amerik Velasquez : amerik.velasquez22@gmail.com