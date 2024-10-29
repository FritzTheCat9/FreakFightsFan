Console.WriteLine("Welcome to feature generator");

Console.WriteLine("Enter feature name:");
var generatedFeatureName = Console.ReadLine();

Console.WriteLine("[Info] - Generating CRUD files");
GenerateFiles(generatedFeatureName);

Console.WriteLine($"[Info] - '{generatedFeatureName}' CRUD files have been successfully generated");
return;

void GenerateFiles(string featureName)
{
    const string configurationsPath = "../../../../FreakFightsFan.Api/Data/Configurations";
    Directory.SetCurrentDirectory(configurationsPath);
    var configText =
        $$"""
          using FreakFightsFan.Api.Data.Entities;
          using Microsoft.EntityFrameworkCore;
          using Microsoft.EntityFrameworkCore.Metadata.Builders;

          namespace FreakFightsFan.Api.Data.Configurations
          {
              public class {{featureName}}Configuration : IEntityTypeConfiguration<{{featureName}}>
              {
                  public void Configure(EntityTypeBuilder<{{featureName}}> builder)
                  {
                      builder.HasKey(x => x.Id);
                  }
              }
          }

          """;
    var filePath = $"{featureName}Configuration.cs";
    File.WriteAllText(filePath, configText);

    const string entitiesPath = "../Entities";
    Directory.SetCurrentDirectory(entitiesPath);
    var entitiesText =
        $$"""
          namespace FreakFightsFan.Api.Data.Entities
          {
              public class {{featureName}} : Entity
              {
                  public string Name { get; set; }
              }
          }

          """;
    File.WriteAllText($"{featureName}.cs", entitiesText);

    const string repositoriesPath = "../Repositories";
    Directory.SetCurrentDirectory(repositoriesPath);
    var repositoryText =
        $$"""
          using FreakFightsFan.Api.Data.Database;
          using FreakFightsFan.Api.Data.Entities;
          using Microsoft.EntityFrameworkCore;

          namespace FreakFightsFan.Api.Data.Repositories
          {
              public interface I{{featureName}}Repository
              {
                  IQueryable<{{featureName}}> AsQueryable();
                  Task<IEnumerable<{{featureName}}>> GetAll();
                  Task<{{featureName}}> Get(int id);
                  Task<int> Create({{featureName}} {{featureName.ToLower()}});
                  Task Update({{featureName}} {{featureName.ToLower()}});
                  Task Delete({{featureName}} {{featureName.ToLower()}});
              }
          
              public class {{featureName}}Repository : I{{featureName}}Repository
              {
                  private readonly AppDbContext _dbContext;
          
                  public {{featureName}}Repository(AppDbContext dbContext)
                  {
                      _dbContext = dbContext;
                  }
          
                  public IQueryable<{{featureName}}> AsQueryable() => _dbContext.{{featureName}}s.AsQueryable();
          
                  public async Task<IEnumerable<{{featureName}}>> GetAll() => await _dbContext.{{featureName}}s.ToListAsync();
          
                  public async Task<{{featureName}}> Get(int id) => await _dbContext.{{featureName}}s.FirstOrDefaultAsync(x => x.Id == id);
          
                  public async Task<int> Create({{featureName}} {{featureName.ToLower()}})
                  {
                      await _dbContext.AddAsync({{featureName.ToLower()}});
                      await _dbContext.SaveChangesAsync();
                      return {{featureName.ToLower()}}.Id;
                  }
          
                  public async Task Update({{featureName}} {{featureName.ToLower()}})
                  {
                      _dbContext.Update({{featureName.ToLower()}});
                      await _dbContext.SaveChangesAsync();
                  }
          
                  public async Task Delete({{featureName}} {{featureName.ToLower()}})
                  {
                      _dbContext.Remove({{featureName.ToLower()}});
                      await _dbContext.SaveChangesAsync();
                  }
              }
          }

          """;
    File.WriteAllText($"{featureName}Repository.cs", repositoryText);

    const string featuresPath = "../../Features";
    Directory.SetCurrentDirectory(featuresPath);
    Directory.CreateDirectory($"{featureName}s");

    const string commandsPath = "Commands";
    Directory.CreateDirectory($"{featureName}s/{commandsPath}");

    const string extensionsPath = "Extensions";
    Directory.CreateDirectory($"{featureName}s/{extensionsPath}");

    const string queriesPath = "Queries";
    Directory.CreateDirectory($"{featureName}s/{queriesPath}");

    Directory.SetCurrentDirectory($"{featureName}s/{commandsPath}");
    var createText =
        $$"""
          using Carter;
          using FluentValidation;
          using FreakFightsFan.Api.Abstractions;
          using FreakFightsFan.Api.Data.Entities;
          using FreakFightsFan.Api.Data.Repositories;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Requests;
          using MediatR;

          namespace FreakFightsFan.Api.Features.{{featureName}}s.Commands
          {
              public static class Create{{featureName}}
              {
                  public class Command : IRequest<int>
                  {
                      public string Name { get; set; }
                  }
          
                  public class Validator : AbstractValidator<Command>
                  {
                      public Validator()
                      {
                          RuleFor(x => x.Name)
                              .NotEmpty();
                      }
                  }
          
                  public class Handler : IRequestHandler<Command, int>
                  {
                      private readonly I{{featureName}}Repository _{{featureName.ToLower()}}Repository;
                      private readonly IClock _clock;
          
                      public Handler(I{{featureName}}Repository {{featureName.ToLower()}}Repository, IClock clock)
                      {
                          _{{featureName.ToLower()}}Repository = {{featureName.ToLower()}}Repository;
                          _clock = clock;
                      }
          
                      public async Task<int> Handle(Command command, CancellationToken cancellationToken)
                      {
                          var {{featureName.ToLower()}} = new {{featureName}}
                          {
                              Id = 0,
                              Created = _clock.Current(),
                              Modified = _clock.Current(),
                              Name = command.Name,
                          };
          
                          return await _{{featureName.ToLower()}}Repository.Create({{featureName.ToLower()}});
                      }
                  }
              }
          
              public class Create{{featureName}}Endpoint : ICarterModule
              {
                  public void AddRoutes(IEndpointRouteBuilder app)
                  {
                      app.MapPost("/api/{{featureName.ToLower()}}s", async (
                          Create{{featureName}}Request create{{featureName}}Request,
                          IMediator mediator,
                          CancellationToken cancellationToken) =>
                          {
                              var command = new Create{{featureName}}.Command()
                              {
                                  Name = create{{featureName}}Request.Name,
                              };
          
                              int {{featureName.ToLower()}}Id = await mediator.Send(command, cancellationToken);
                              return Results.CreatedAtRoute("Get{{featureName}}", new { id = {{featureName.ToLower()}}Id });
                          })
                          .WithTags("{{featureName}}s");
                  }
              }
          }

          """;
    File.WriteAllText($"Create{featureName}.cs", createText);

    var deleteText =
        $$"""
          using Carter;
          using FluentValidation;
          using FreakFightsFan.Api.Data.Repositories;
          using FreakFightsFan.Shared.Exceptions;
          using MediatR;

          namespace FreakFightsFan.Api.Features.{{featureName}}s.Commands
          {
              public static class Delete{{featureName}}
              {
                  public class Command : IRequest<Unit>
                  {
                      public int Id { get; set; }
                  }
          
                  public class Validator : AbstractValidator<Command>
                  {
          
                  }
          
                  public class Handler : IRequestHandler<Command, Unit>
                  {
                      private readonly I{{featureName}}Repository _{{featureName.ToLower()}}Repository;
          
                      public Handler(I{{featureName}}Repository {{featureName.ToLower()}}Repository)
                      {
                          _{{featureName.ToLower()}}Repository = {{featureName.ToLower()}}Repository;
                      }
          
                      public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
                      {
                          var {{featureName.ToLower()}} = await _{{featureName.ToLower()}}Repository.Get(command.Id) ?? throw new MyNotFoundException();
                          await _{{featureName.ToLower()}}Repository.Delete({{featureName.ToLower()}});
                          return Unit.Value;
                      }
                  }
              }
          
              public class Delete{{featureName}}Endpoint : ICarterModule
              {
                  public void AddRoutes(IEndpointRouteBuilder app)
                  {
                      app.MapDelete("/api/{{featureName.ToLower()}}s/{id}", async (
                          int id,
                          IMediator mediator,
                          CancellationToken cancellationToken) =>
                          {
                              var command = new Delete{{featureName}}.Command() { Id = id };
                              return Results.Ok(await mediator.Send(command, cancellationToken));
                          })
                          .WithTags("{{featureName}}s");
                  }
              }
          }

          """;
    File.WriteAllText($"Delete{featureName}.cs", deleteText);

    var updateText =
        $$"""
          using Carter;
          using FluentValidation;
          using FreakFightsFan.Api.Abstractions;
          using FreakFightsFan.Api.Data.Repositories;
          using FreakFightsFan.Shared.Exceptions;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Requests;
          using MediatR;

          namespace FreakFightsFan.Api.Features.{{featureName}}s.Commands
          {
              public static class Update{{featureName}}
              {
                  public class Command : IRequest<Unit>
                  {
                      public int Id { get; set; }
                      public string Name { get; set; }
                  }
          
                  public class Validator : AbstractValidator<Command>
                  {
                      public Validator()
                      {
                          RuleFor(x => x.Name)
                              .NotEmpty();
                      }
                  }
          
                  public class Handler : IRequestHandler<Command, Unit>
                  {
                      private readonly I{{featureName}}Repository _{{featureName.ToLower()}}Repository;
                      private readonly IClock _clock;
          
                      public Handler(I{{featureName}}Repository {{featureName.ToLower()}}Repository, IClock clock)
                      {
                          _{{featureName.ToLower()}}Repository = {{featureName.ToLower()}}Repository;
                          _clock = clock;
                      }
          
                      public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
                      {
                          var {{featureName.ToLower()}} = await _{{featureName.ToLower()}}Repository.Get(command.Id) ?? throw new MyNotFoundException();
                          {{featureName.ToLower()}}.Modified = _clock.Current();
                          {{featureName.ToLower()}}.Name = command.Name;
          
                          await _{{featureName.ToLower()}}Repository.Update({{featureName.ToLower()}});
                          return Unit.Value;
                      }
                  }
              }
          
              public class Update{{featureName}}Endpoint : ICarterModule
              {
                  public void AddRoutes(IEndpointRouteBuilder app)
                  {
                      app.MapPut("/api/{{featureName.ToLower()}}s/{id}", async (
                          int id,
                          Update{{featureName}}Request update{{featureName}}Request,
                          IMediator mediator,
                          CancellationToken cancellationToken) =>
                          {
                              var command = new Update{{featureName}}.Command()
                              {
                                  Id = id,
                                  Name = update{{featureName}}Request.Name,
                              };
          
                              return Results.Ok(await mediator.Send(command, cancellationToken));
                          })
                          .WithTags("{{featureName}}s");
                  }
              }
          }

          """;
    File.WriteAllText($"Update{featureName}.cs", updateText);

    Directory.SetCurrentDirectory($"../{extensionsPath}");
    var extensionsText =
        $$"""
          using FreakFightsFan.Api.Data.Entities;
          using FreakFightsFan.Api.Features.{{featureName}}s.Queries;
          using FreakFightsFan.Shared.Abstractions;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Responses;
          using System.Linq.Expressions;

          namespace FreakFightsFan.Api.Features.{{featureName}}s.Extensions
          {
              public static class {{featureName}}sExtensions
              {
                  public static {{featureName}}Dto ToDto(this {{featureName}} {{featureName.ToLower()}})
                  {
                      return new {{featureName}}Dto
                      {
                          Id = {{featureName.ToLower()}}.Id,
                          Created = {{featureName.ToLower()}}.Created,
                          Modified = {{featureName.ToLower()}}.Modified,
                          Name = {{featureName.ToLower()}}.Name,
                      };
                  }
          
                  public static IQueryable<{{featureName}}> Filter{{featureName}}s(this IQueryable<{{featureName}}> {{featureName.ToLower()}}s, GetAll{{featureName}}s.Query query)
                  {
                      var searchTerm = query.SearchTerm.ToLower().Trim();
                      if (!string.IsNullOrWhiteSpace(searchTerm))
                      {
                          {{featureName.ToLower()}}s = {{featureName.ToLower()}}s.Where(x =>
                              x.Name.ToLower().Contains(searchTerm));
                      }
                      return {{featureName.ToLower()}}s;
                  }
          
                  public static IQueryable<{{featureName}}> Sort{{featureName}}s(this IQueryable<{{featureName}}> {{featureName.ToLower()}}s, GetAll{{featureName}}s.Query query)
                  {
                      return query.SortOrder switch
                      {
                          SortOrder.Ascending => {{featureName.ToLower()}}s.OrderBy(Get{{featureName}}SortProperty(query)),
                          SortOrder.Descending => {{featureName.ToLower()}}s.OrderByDescending(Get{{featureName}}SortProperty(query)),
                          SortOrder.None => {{featureName.ToLower()}}s,
                          _ => {{featureName.ToLower()}}s,
                      };
                  }
          
                  private static Expression<Func<{{featureName}}, object>> Get{{featureName}}SortProperty(GetAll{{featureName}}s.Query query)
                  {
                      return query.SortColumn.ToLowerInvariant() switch
                      {
                          "name" => {{featureName.ToLower()}} => {{featureName.ToLower()}}.Name,
                          _ => {{featureName.ToLower()}} => {{featureName.ToLower()}}.Name,
                      };
                  }
              }
          }

          """;
    File.WriteAllText($"{featureName}sExtensions.cs", extensionsText);

    Directory.SetCurrentDirectory($"../{queriesPath}");
    var getAllText =
        $$"""
          using Carter;
          using FluentValidation;
          using FreakFightsFan.Api.Abstractions;
          using FreakFightsFan.Api.Data.Repositories;
          using FreakFightsFan.Api.Features.{{featureName}}s.Extensions;
          using FreakFightsFan.Shared.Abstractions;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Requests;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Responses;
          using MediatR;

          namespace FreakFightsFan.Api.Features.{{featureName}}s.Queries
          {
              public static class GetAll{{featureName}}s
              {
                  public class Query : IRequest<PagedList<{{featureName}}Dto>>, IPagedQuery, ISortedQuery
                  {
                      public int Page { get; set; }
                      public int PageSize { get; set; }
                      public string SortColumn { get; set; }
                      public SortOrder SortOrder { get; set; }
                      public string SearchTerm { get; set; }
                  }
          
                  public class Validator : AbstractValidator<Query>
                  {
          
                  }
          
                  public class Handler : IRequestHandler<Query, PagedList<{{featureName}}Dto>>
                  {
                      private readonly I{{featureName}}Repository _{{featureName.ToLower()}}Repository;
          
                      public Handler(I{{featureName}}Repository {{featureName.ToLower()}}Repository)
                      {
                          _{{featureName.ToLower()}}Repository = {{featureName.ToLower()}}Repository;
                      }
          
                      public async Task<PagedList<{{featureName}}Dto>> Handle(Query query, CancellationToken cancellationToken)
                      {
                          var {{featureName.ToLower()}}sQuery = _{{featureName.ToLower()}}Repository.AsQueryable();
          
                          {{featureName.ToLower()}}sQuery = {{featureName.ToLower()}}sQuery.Filter{{featureName}}s(query);
                          {{featureName.ToLower()}}sQuery = {{featureName.ToLower()}}sQuery.Sort{{featureName}}s(query);
          
                          var {{featureName.ToLower()}}sPagedList = PageListExtensions<{{featureName}}Dto>.Create(
                              {{featureName.ToLower()}}sQuery.Select(x => x.ToDto()),
                              query.Page,
                              query.PageSize);
          
                          return await Task.FromResult({{featureName.ToLower()}}sPagedList);
                      }
                  }
              }
          
              public class GetAll{{featureName}}sEndpoint : ICarterModule
              {
                  public void AddRoutes(IEndpointRouteBuilder app)
                  {
                      app.MapPost("/api/{{featureName.ToLower()}}s/all", async (
                          GetAll{{featureName}}sRequest getAll{{featureName}}sRequest,
                          IMediator mediator,
                          CancellationToken cancellationToken) =>
                          {
                              var query = new GetAll{{featureName}}s.Query()
                              {
                                  Page = getAll{{featureName}}sRequest.Page,
                                  PageSize = getAll{{featureName}}sRequest.PageSize,
                                  SortOrder = getAll{{featureName}}sRequest.SortOrder,
                                  SortColumn = getAll{{featureName}}sRequest.SortColumn,
                                  SearchTerm = getAll{{featureName}}sRequest.SearchTerm,
                              };
          
                              return Results.Ok(await mediator.Send(query, cancellationToken));
                          })
                          .WithTags("{{featureName}}s");
                  }
              }
          }

          """;
    File.WriteAllText($"GetAll{featureName}s.cs", getAllText);

    var getText =
        $$"""
          using Carter;
          using FluentValidation;
          using FreakFightsFan.Api.Data.Repositories;
          using FreakFightsFan.Api.Features.{{featureName}}s.Extensions;
          using FreakFightsFan.Shared.Exceptions;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Responses;
          using MediatR;

          namespace FreakFightsFan.Api.Features.{{featureName}}s.Queries
          {
              public static class Get{{featureName}}
              {
                  public class Query : IRequest<{{featureName}}Dto>
                  {
                      public int Id { get; set; }
                  }
          
                  public class Validator : AbstractValidator<Query>
                  {
          
                  }
          
                  public class Handler : IRequestHandler<Query, {{featureName}}Dto>
                  {
                      private readonly I{{featureName}}Repository _{{featureName.ToLower()}}Repository;
          
                      public Handler(I{{featureName}}Repository {{featureName.ToLower()}}Repository)
                      {
                          _{{featureName.ToLower()}}Repository = {{featureName.ToLower()}}Repository;
                      }
          
                      public async Task<{{featureName}}Dto> Handle(Query query, CancellationToken cancellationToken)
                      {
                          var {{featureName.ToLower()}} = await _{{featureName.ToLower()}}Repository.Get(query.Id) ?? throw new MyNotFoundException();
                          return {{featureName.ToLower()}}.ToDto();
                      }
                  }
              }
          
              public class Get{{featureName}}Endpoint : ICarterModule
              {
                  public void AddRoutes(IEndpointRouteBuilder app)
                  {
                      app.MapGet("/api/{{featureName.ToLower()}}s/{id}", async (
                          int id,
                          IMediator mediator,
                          CancellationToken cancellationToken) =>
                          {
                              var query = new Get{{featureName}}.Query() { Id = id };
                              return Results.Ok(await mediator.Send(query, cancellationToken));
                          })
                          .WithName("Get{{featureName}}")
                          .WithTags("{{featureName}}s");
                  }
              }
          }

          """;
    File.WriteAllText($"Get{featureName}.cs", getText);

    const string servicesPath = "../../../../FreakFightsFan.Blazor/Services";
    Directory.SetCurrentDirectory(servicesPath);

    var httpServiceText =
        $$"""
          using FreakFightsFan.Shared.Abstractions;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Requests;
          using FreakFightsFan.Shared.Features.{{featureName}}s.Responses;

          namespace FreakFightsFan.Blazor.Services
          {
              public interface I{{featureName}}HttpService
              {
                  Task<PagedList<{{featureName}}Dto>> GetAll{{featureName}}s(GetAll{{featureName}}sRequest getAll{{featureName}}sRequest);
                  Task<{{featureName}}Dto> Get{{featureName}}(int id);
                  Task Create{{featureName}}(Create{{featureName}}Request create{{featureName}}Request);
                  Task Update{{featureName}}(Update{{featureName}}Request update{{featureName}}Request);
                  Task Delete{{featureName}}(int id);
              }
          
              public class {{featureName}}HttpService : I{{featureName}}HttpService
              {
                  private readonly IHttpService _httpService;
                  private readonly string _url = "api/{{featureName.ToLower()}}s";
          
                  public {{featureName}}HttpService(IHttpService httpService)
                  {
                      _httpService = httpService;
                  }
          
                  public async Task<PagedList<{{featureName}}Dto>> GetAll{{featureName}}s(GetAll{{featureName}}sRequest getAll{{featureName}}sRequest)
                  {
                      return await _httpService.Post<GetAll{{featureName}}sRequest, PagedList<{{featureName}}Dto>>(_url + "/all", getAll{{featureName}}sRequest);
                  }
          
                  public async Task<{{featureName}}Dto> Get{{featureName}}(int id)
                  {
                      return await _httpService.Get<{{featureName}}Dto>(_url + id);
                  }
          
                  public async Task Create{{featureName}}(Create{{featureName}}Request create{{featureName}}Request)
                  {
                      await _httpService.Post(_url, create{{featureName}}Request);
                  }
          
                  public async Task Update{{featureName}}(Update{{featureName}}Request update{{featureName}}Request)
                  {
                      await _httpService.Put(_url + "/" + update{{featureName}}Request.Id, update{{featureName}}Request);
                  }
          
                  public async Task Delete{{featureName}}(int id)
                  {
                      await _httpService.Delete(_url + "/" + id);
                  }
              }
          }

          """;
    File.WriteAllText($"{featureName}HttpService.cs", httpServiceText);

    const string pagesPath = "../Pages";
    Directory.SetCurrentDirectory(pagesPath);
    Directory.CreateDirectory($"{featureName}");

    Directory.SetCurrentDirectory($"{featureName}");

    var createDialogText =
        $$"""
          @inject I{{featureName}}HttpService {{featureName}}HttpService
          @inject IExceptionHandler ExceptionHandler

          <MudForm Model="Create{{featureName}}Request" @ref="@form" Validation="ValidateValue">
              <MudDialog DefaultFocus="DefaultFocus.LastChild">
                  <DialogContent>
                      <MudTextField Label="Name" @bind-Value="Create{{featureName}}Request.Name" For="@(() => Create{{featureName}}Request.Name)"></MudTextField>
                  </DialogContent>
                  <DialogActions>
                      <MudButton OnClick="Cancel">Cancel</MudButton>
                      <MudButton OnClick="HandleValidSubmit" Color="Color.Primary">Create</MudButton>
                  </DialogActions>
              </MudDialog>
          </MudForm>

          @code {
              [CascadingParameter] MudDialogInstance MudDialog { get; set; }
              [Parameter] public Create{{featureName}}Request Create{{featureName}}Request { get; set; } = new Create{{featureName}}Request();
          
              private Dictionary<string, List<string>> validationErrors = new Dictionary<string, List<string>>();
              private MudForm form;
          
              private void Cancel() => MudDialog.Cancel();
          
              private async Task HandleValidSubmit()
              {
                  try
                  {
                      await {{featureName}}HttpService.Create{{featureName}}(Create{{featureName}}Request);
                      MudDialog.Close(DialogResult.Ok(true));
                  }
                  catch (MyValidationException validationException)
                  {
                      validationErrors = validationException.Errors;
                      await form.Validate();
                  }
                  catch (Exception ex)
                  {
                      ExceptionHandler.HandleExceptions(ex);
                  }
              }
          
              private Func<object, string, List<string>> ValidateValue => (model, propertyName) =>
              {
                  if (!validationErrors.ContainsKey(propertyName))
                      validationErrors.Add(propertyName, new List<string>());
          
                  return validationErrors[propertyName];
              };
          }

          """;
    File.WriteAllText($"Create{featureName}Dialog.razor", createDialogText);

    var featurePageText =
        $$"""
          @page "/{{featureName.ToLower()}}s"
          @inject IExceptionHandler ExceptionHandler
          @inject I{{featureName}}HttpService {{featureName}}HttpService
          @inject IDialogService DialogService
          @inject NavigationManager NavigationManager

          <PageTitle>{{featureName}}s</PageTitle>

          <MudTable ServerData="@(new Func<TableState, Task<TableData<{{featureName}}Dto>>>(ServerReload))"
                    Dense="true" Hover="true" @ref="table">
              <ToolBarContent>
                  <MudText Typo="Typo.h6">{{featureName}}s</MudText>
                  <MudIconButton Icon="@Icons.Material.Filled.Add" Size="Size.Small" OnClick="@(() => Create{{featureName}}())"></MudIconButton>
                  <MudSpacer />
                  <MudTextField T="string" ValueChanged="@(searchText => OnSearch(searchText))" Placeholder="Search" Adornment="Adornment.Start"
                                AdornmentIcon="@Icons.Material.Filled.Search" IconSize="Size.Medium"></MudTextField>
              </ToolBarContent>
              <HeaderContent>
                  <MudTh><MudTableSortLabel SortLabel="name" T="{{featureName}}Dto">Name</MudTableSortLabel></MudTh>
                  <MudTh><MudText>Actions</MudText></MudTh>
              </HeaderContent>
              <RowTemplate>
                  <MudTd DataLabel="Name">@context.Name</MudTd>
                  <MudTd>
                      <MudIconButton Icon="@Icons.Material.Filled.Edit" Size="Size.Small" OnClick="@(() => Update{{featureName}}(@context))"></MudIconButton>
                      <MudIconButton Icon="@Icons.Material.Filled.Delete" Size="Size.Small" OnClick="@(() => Delete{{featureName}}(@context.Id))"></MudIconButton>
                  </MudTd>
              </RowTemplate>
              <NoRecordsContent>
                  <MudText>No matching records found</MudText>
              </NoRecordsContent>
              <LoadingContent>
                  <MudText>Loading...</MudText>
              </LoadingContent>
              <PagerContent>
                  <MudTablePager />
              </PagerContent>
          </MudTable>

          @code {
              private MudTable<{{featureName}}Dto> table;
              private string searchString = "";
              public PagedList<{{featureName}}Dto> {{featureName}}sPagedList { get; set; }
          
              private async Task<TableData<{{featureName}}Dto>> ServerReload(TableState state)
              {
                  var getAll{{featureName}}sRequest = new GetAll{{featureName}}sRequest
                      {
                          Page = state.Page + 1,
                          PageSize = state.PageSize,
                          SortColumn = state.SortLabel,
                          SortOrder = ((SortOrder)state.SortDirection),
                          SearchTerm = searchString,
                      };
          
                  try
                  {
                      {{featureName}}sPagedList = await {{featureName}}HttpService.GetAll{{featureName}}s(getAll{{featureName}}sRequest);
                  }
                  catch (Exception ex)
                  {
                      ExceptionHandler.HandleExceptions(ex);
                      return new TableData<{{featureName}}Dto>() { TotalItems = 0, Items = new List<{{featureName}}Dto>() };
                  }
          
                  return new TableData<{{featureName}}Dto>()
                      {
                          TotalItems = {{featureName}}sPagedList.TotalCount,
                          Items = {{featureName}}sPagedList.Items
                      };
              }
          
              private void OnSearch(string searchText)
              {
                  searchString = searchText;
                  table.ReloadServerData();
              }
          
              private async Task Delete{{featureName}}(int id)
              {
                  try
                  {
                      await {{featureName}}HttpService.Delete{{featureName}}(id);
                      await table.ReloadServerData();
                  }
                  catch (Exception ex)
                  {
                      ExceptionHandler.HandleExceptions(ex);
                  }
              }
          
              private async Task Update{{featureName}}({{featureName}}Dto {{featureName.ToLower()}}Dto)
              {
                  var dialogOptions = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
                  var parameters = new DialogParameters<Update{{featureName}}Dialog>();
                  parameters.Add(x => x.Update{{featureName}}Request, new Update{{featureName}}Request
                      {
                          Id = {{featureName.ToLower()}}Dto.Id,
                          Name = {{featureName.ToLower()}}Dto.Name,
                      });
          
                  var update{{featureName}}Dialog = await DialogService.ShowAsync<Update{{featureName}}Dialog>("Update {{featureName}}", parameters, dialogOptions);
                  var result = await update{{featureName}}Dialog.Result;
                  if (!result.Canceled)
                      await table.ReloadServerData();
              }
          
              private async Task Create{{featureName}}()
              {
                  var dialogOptions = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
                  var parameters = new DialogParameters<Create{{featureName}}Dialog>();
                  parameters.Add(x => x.Create{{featureName}}Request, new Create{{featureName}}Request());
          
                  var create{{featureName}}Dialog = await DialogService.ShowAsync<Create{{featureName}}Dialog>("Create {{featureName}}", parameters, dialogOptions);
                  var result = await create{{featureName}}Dialog.Result;
                  if (!result.Canceled)
                      await table.ReloadServerData();
              }
          }

          """;
    File.WriteAllText($"{featureName}.razor", featurePageText);

    var updateDialogText =
        $$"""
          @inject I{{featureName}}HttpService {{featureName}}HttpService
          @inject IExceptionHandler ExceptionHandler

          <MudForm Model="Update{{featureName}}Request" @ref="@form" Validation="ValidateValue">
              <MudDialog DefaultFocus="DefaultFocus.LastChild">
                  <DialogContent>
                      <MudTextField Label="Name" @bind-Value="Update{{featureName}}Request.Name" For="@(() => Update{{featureName}}Request.Name)"></MudTextField>
                  </DialogContent>
                  <DialogActions>
                      <MudButton OnClick="Cancel">Cancel</MudButton>
                      <MudButton OnClick="HandleValidSubmit" Color="Color.Primary">Update</MudButton>
                  </DialogActions>
              </MudDialog>
          </MudForm>

          @code {
              [CascadingParameter] MudDialogInstance MudDialog { get; set; }
              [Parameter] public Update{{featureName}}Request Update{{featureName}}Request { get; set; } = new Update{{featureName}}Request();
          
              private Dictionary<string, List<string>> validationErrors = new Dictionary<string, List<string>>();
              private MudForm form;
          
              private void Cancel() => MudDialog.Cancel();
          
              private async Task HandleValidSubmit()
              {
                  try
                  {
                      await {{featureName}}HttpService.Update{{featureName}}(Update{{featureName}}Request);
                      MudDialog.Close(DialogResult.Ok(true));
                  }
                  catch (MyValidationException validationException)
                  {
                      validationErrors = validationException.Errors;
                      await form.Validate();
                  }
                  catch (Exception ex)
                  {
                      ExceptionHandler.HandleExceptions(ex);
                  }
              }
          
              private Func<object, string, List<string>> ValidateValue => (model, propertyName) =>
              {
                  if (!validationErrors.ContainsKey(propertyName))
                      validationErrors.Add(propertyName, new List<string>());
          
                  return validationErrors[propertyName];
              };
          }

          """;
    File.WriteAllText($"Update{featureName}Dialog.razor", updateDialogText);

    const string sharedFeaturesPath = "../../../FreakFightsFan.Shared/Features";
    Directory.SetCurrentDirectory(sharedFeaturesPath);
    Directory.CreateDirectory($"{featureName}s");
    Directory.CreateDirectory($"{featureName}s/Requests");
    Directory.CreateDirectory($"{featureName}s/Responses");

    var createRequestText =
        $$"""
          namespace FreakFightsFan.Shared.Features.{{featureName}}s.Requests
          {
              public class Create{{featureName}}Request
              {
                  public string Name { get; set; }
              }
          }

          """;
    File.WriteAllText($"{featureName}s/Requests/Create{featureName}Request.cs", createRequestText);

    var getAllRequestText =
        $$"""
          using FreakFightsFan.Shared.Abstractions;

          namespace FreakFightsFan.Shared.Features.{{featureName}}s.Requests
          {
              public class GetAll{{featureName}}sRequest
              {
                  public int Page { get; set; }
                  public int PageSize { get; set; }
                  public string SortColumn { get; set; }
                  public SortOrder SortOrder { get; set; }
                  public string SearchTerm { get; set; }
              }
          }

          """;
    File.WriteAllText($"{featureName}s/Requests/GetAll{featureName}sRequest.cs", getAllRequestText);

    var updateRequestText =
        $$"""
          namespace FreakFightsFan.Shared.Features.{{featureName}}s.Requests
          {
              public class Update{{featureName}}Request
              {
                  public int Id { get; set; }
                  public string Name { get; set; }
              }
          }


          """;
    File.WriteAllText($"{featureName}s/Requests/Update{featureName}Request.cs", updateRequestText);

    var dtoText =
        $$"""
          namespace FreakFightsFan.Shared.Features.{{featureName}}s.Responses
          {
              public class {{featureName}}Dto
              {
                  public int Id { get; set; }
                  public DateTime Created { get; set; }
                  public DateTime Modified { get; set; }
          
                  public string Name { get; set; }
              }
          }


          """;
    File.WriteAllText($"{featureName}s/Responses/{featureName}Dto.cs", dtoText);
}