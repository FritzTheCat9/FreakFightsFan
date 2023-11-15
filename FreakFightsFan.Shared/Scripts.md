
## Entity Framework Core Migrations

Remember to change ***MIGRATION_NAME*** 
``` 
cd C:\Users\bartl\source\repos\FreakFightsFan\FreakFightsFan.Api
dotnet ef migrations add MIGRATION_NAME -o ./Data/Migrations --startup-project ../FreakFightsFan.Api
dotnet ef database update
```

## FreakFightsFan.FeatureGenerator

CLI app used to generate simple CRUD code in folders for a named feature
1. Generate feature code with FeatureGenerator (select FreakFightsFan.FeatureGenerator for a starting project). Enter a name for a new featue.
2. Add new entity DbSet to "AppDbContext.cs" file
``` 
public DbSet<Fighter> Fighters { get; set; }
```
3. Register new repository in "DataExtensions.cs" file
``` 
services.AddScoped<IFighterRepository, FighterRepository>();
```
4. Register new HttpService in "Program.cs" file in "FreakFightsFan.Blazor" project
``` 
builder.Services.AddScoped<IFighterHttpService, FighterHttpService>();
```
5. Add link to a page in "NavMenu.razor" file if needed
``` 
<MudNavLink Href="/fighters" Match="NavLinkMatch.Prefix">Fighters</MudNavLink>
```
6. Add responses and requests using statements to "_Imports.razor" file
``` 
@using FreakFightsFan.Shared.Features.Fighters.Requests
@using FreakFightsFan.Shared.Features.Fighters.Responses
```
