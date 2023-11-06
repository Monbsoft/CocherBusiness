# CocherBusiness
Cocher Business is an open-source .NET enterprise management system based on microservices architecture. It is heavily inspired by the [.NET Microservices: Architecture for Containerized .NET Applications](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/) book, as well as its companion reference application [eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers).



## Configuring the sample to use SQL Server

* Install the EF tool: 

    ```
    dotnet tool install --global dotnet-ef
    ```

* Migrate the database:


    ```
    dotnet ef migrations add InitialCreate --context cocherdbcontext -p ../CocherBusiness.Infrastructure/CocherBusiness.Infrastructure.csproj -s CocherBusiness.Web.csproj -o Data/Migrations
    ```    

* Update SQL Server database:

    ```
    dotnet ef database update -c cocherdbcontext -p ../CocherBusiness.Infrastructure/CocherBusiness.Infrastructure.csproj -s  CocherBusiness.Web.csproj
    ```

## Credit

- [[.NET Microservices: Architecture for Containerized .NET Applications](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/)],
- [[dotnet-architecture / eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers)], Cross-platform .NET sample microservices and container based application that runs on Linux Windows and macOS. Powered by .NET Core 3.1, Docker Containers and Azure Kubernetes Services. Supports Visual Studio, VS for Mac and CLI based environments with Docker CLI, dotnet CLI, VS Code or any other code editor. 
- Jason Taylor, [[jasontaylordev / CleanArchitecture](https://github.com/jasontaylordev/CleanArchitecture)], Clean Architecture Solution Template for Angular 10 and .NET 5.
