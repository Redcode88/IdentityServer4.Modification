# thats What i did Eng ( Mohamed Mohsen )
1. Create a new ASP.NET Core Empty project
2. Setup a ClassLibrary project for the Database
 - Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.1
 - Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.1
3. Add and Migrate an entity with EntityFramework Core
4. Add a CoffeeShop Service and Model
5. Create and Register API Controller (CoffeeShop)
6. Add CoffeeShops to the Database
7. Register the Service in Program.cs

Part 2 - Setting up the Identity Server (Server) project
8. Add an empty ASP.NET Web Project to the Solution
9. Install IdentityServer4 Dependencies (written bellow so you can just copy-paste them in your package manager console in the Server project)
     Install-Package IdentityServer4 -Version 4.1.2
     Install-Package IdentityServer4.EntityFramework -Version 4.1.2
     Install-Package Microsoft.EntityFrameworkCore.Tools -Version 6.0.1
     Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.1
     Install-Package Microsoft.AspNetCore.Identity.UI -Version 6.0.1
     Install-Package IdentityServer4.AspNetIdentity -Version 4.1.2
     Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 6.0.1
10. Add Connection String to appsettings.json
11. Configure Program.cs
12. Create IdentityServer migrations (Default project: Server)
13. Update the IdentityServer Databases
14. Add ASP.NET Identity to the Server project 
15. Add ASP.NET Identity migrations (Server proj) and run them
     Add-Migration InitialAspNetIdentityMigration -Context AspNetIdentityDbContext
     Update-Database -Context AspNetIdentityDbContext
     Discovery Document: https://localhost:5443/.well-known/openid-configuration
16. Add IdentityServer4 Configuration and SeedData
17. Setup the IdentityServer Seeding process
     - dotnet run Server/bin/Debug/net6.0/Server /seed --project Server
18. Setup the IdentityServer authentication flow
  
19. Update IdentityServer QuickStart code
20. Setup Program.cs for integration with the QuickStart code (Server)

part 3
Creating up the Blazor Server (Client) project

1. Setup a new Blazor Server project
2. Add a new Blazor Component
3. Setup IdentityServer4 Authorization within the API
     Install-Package IdentityServer4.AccessTokenValidation -Version 3.0.1
4. Setup the Blazor Server for JWT Generation
     Install-Package IdentityModel -Version 5.2.0
5. Add a Bearer Token to a Http Request
6. Secure Blazor Server with IdentityServer4 (Authorization)

Part 4 - Secure the Client app with IdentityServer4
7. Setup Authentication and OIDC (Client)
 Install-Package Microsoft.AspNetCore.Authentication.OpenIdConnect -Version 6.0.1
 Install-Package Microsoft.AspNetCore.Components.Authorization -Version 6.0.1
8. Add a Login and Logout Razor pages
9. Add Login Redirect Blazor Component
10. Setup App.razor to enable Authorization
11. Show/Hide the NavMenu items based on Authorization
12. Authorize a Blazor component



