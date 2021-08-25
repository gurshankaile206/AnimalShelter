# Animal Shelter API 

## Description 

This is a Web API for a pretend Animal Shelter. It lists available animals and each Animals Information. It includes CRUD functionality.

## Technologies Used

This project was built using: 

* ASP.NET 5.0
* ASP.NET CORE MVC
* POSTMAN 
* API VERSIONING 
* ENTITY FRAMEWORK CORE
* C#

## Installation Instructions

* Download and Install .NET 5 SDK onto your local machine

* Clone this Repository to your local machine and open it in Vscode

* Navigate to the ``` AnimalShelter ``` directory

* Install the the required dependencies using the command ``` dotnet restore ``` in your terminal

* Create an appsettings.json in the ``` AnimalShelter ``` directory to link your database 

* Paste the following code into the ``` appsettings.json ``` file. 

```

{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE_NAME_HERE};uid={USERNAME_NAME_HERE};pwd={YOUR_PASSWORD_HERE};"
  }
}

```

* Fill in the requred Information into the ``` appsettings.json ``` file. 

* Now you'll run the following commands to build the database 

* Run ``` dotnet ef migrations add Initial ``` to the build Migrations Folder

* Run ``` dotnet ef database update ``` to implement the database

* Run ``` dotnet watch run ``` to launch the web app into your browser local server

## Instructions to test API 

* Download ``` Postman ``` to interact with API

* Using the GET/POST/DELETE/PUT you can interact with the API

## License Information 

__MIT__

## Contact

Contact me at gurshankaile206@gmail.com
