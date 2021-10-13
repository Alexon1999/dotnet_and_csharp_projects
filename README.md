
# .NET (dotnet)

- before there was .NET Framework (just for windows, not open-source) after there was .NET Core (open source and 
  cross-platform) but now it's just replaced by .NET

- .NET is now cross-plateform (macos,linux,windows)
- we can develop and run on Windows, macOS, and Linux.
  
**to work with .NET:  we have to install .NET SDK (build .NET apps and it comes with a runtime), if we want to just execute .NET apps, download .NET Runtime**

- C# is a statically/strongly typed language
- C# is a compiled language,  we have to compile it and run
- your C# code is compiled to Common Intermediate Language by .NET
  
- Common Intermediate Language code can be executed on different machines(macos,linux,windows) if that machine has .NET Runtime

## Web Applications
- with .net we can create web applications (fullstack, back end (api) )
- we use Asp.net
- there are two frameworks : ASP.NET and ASP.NET Core
- ASP.NET : we can develop and run our web apps only on Windows.
- ASP.NET Core is a new one, we can develop and run our web apps on Windows, macOS, and Linux.
https://docs.microsoft.com/fr-fr/aspnet/core/fundamentals/choose-aspnet-framework?view=aspnetcore-5.0


## Create .NET API (une API web avec ASP.NET Core)
> dotnet new webapi -o TodoApi
> cd TodoApi
> dotnet run (compile your code and run)
> dotnet watch run (re-compile your code everytime your code changes and run)
> go to /TodoApi like the name of the controller : https://localhost:5001//TodoApi

## in the .NET, install packages to your projects from NuGet like in NodeJs(Javascript) we use npm (Node Package Manager)
**commands**
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer
> dotnet add package Pomelo.EntityFrameworkCore.MySql
> dotnet remove package Pomelo.EntityFrameworkCore.MySql
> Install-Package Microsoft.EntityFrameworkCore.SqlServer (is how you install via Visual Studio)

## Obtenir les outils Entity Framework Core
- Vous pouvez installer des outils pour effectuer des tâches liées à EF Core dans votre projet, comme créer et appliquer des migrations
de base de données, ou créer un modèle EF Core basé sur une base de données existante.
> dotnet tool install --global dotnet-ef
> dotnet add package Microsoft.EntityFrameworkCore.Design (is necessary for generating migrations)


## generate gitignore file
> dotnet new gitignore