# carAPI (Simple CRUD API with .NET CORE 3.1)

> A Simple CRUD API in .NET CORE 3.1 and SQL Sever that showcase the implementation of some concept such as:

    - Repository
    - Depedency Injection
    - Entity Framework
    - Automapper
    - DTO

To use this code. Add a file called **appsettings.json** in root folder with the following content

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings":
  {
    "CarConnection":"Server=<YOUR SERVER>;Database=<DB NAME>;User ID=<YOUR USER ID>;Password=<YOUR PASSWORD>;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}


```
