## Docker containers links
- Api https (swagger): 
	https://localhost:5001
- Api http (swagger):  
	http://localhost:5000
- MSSQL database:
	Host: localhost 
	Port: 1433 
	Database/Schema: FreakFightsFan
	Username: sa
	Password: Password1!
	Server: freakfightsfan.database
- Seq logs
	http://localhost:8081

## Entity Framework Core Migrations
Remember to change ***MIGRATION_NAME*** 
``` 
cd C:\Users\bartl\source\repos\FreakFightsFan\FreakFightsFan.Api
dotnet ef migrations add MIGRATION_NAME -o ./Data/Migrations --startup-project ../FreakFightsFan.Api
dotnet ef database update
```

## Update docker-compose.yaml
``` 
cd C:\Users\bartl\source\repos\FreakFightsFan
docker compose up -d
docker ps
``` 

## .http files bug
1. Open %temp% folder
2. Close Visual Studio 2022
3. Delete "vs-dotnet-interactive" folder
4. .http files should work

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

## Angular commands
1. Download node.js (https://nodejs.org/en/download)
```
node -v
``` 
2. Install Angular CLI
```
npm install -g @angular/cli
ng version
``` 
3. Create Angular Application
```
ng new freak-fights-fan
```
If any problems to run above command try this:
Remove ng.ps1 from the directory C:\Users\%username%\AppData\Roaming\npm\
Then try clearing the npm cache at C:\Users\%username%\AppData\Roaming\npm-cache\
```
cd .\freak-fights-fan\
```
4. Serve and open app
```
ng serve --open
http://localhost:4200/
```
5. Install Angular Material
```
ng add @angular/material
```