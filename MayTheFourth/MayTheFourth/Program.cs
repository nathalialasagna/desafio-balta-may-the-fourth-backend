using MayTheFourth.Data;
using MayTheFourth.Interfaces.Services;
using MayTheFourth.Mappings.Filme;
using MayTheFourth.Services;

var client = StarWarsApiClient.CreateHttpClient();
var starWarsApiClient = new StarWarsApiClient(client);

//await starWarsApiClient.SalvarPeopleAsync();
//await starWarsApiClient.SalvarPlanetsAsync();
//await starWarsApiClient.SalvarFilmsAsync();
//await starWarsApiClient.SalvarVehiclesAsync();
//await starWarsApiClient.SalvarStarshipsAsync();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ConfigureServices(builder);

var app = builder.Build();
ConfigureApiServices(app);

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddDbContext<MayTheFourthDataContext>();
      //builder.Services.AddScoped<IFilmeService, FilmeService>();
}

void ConfigureApiServices(WebApplication webApplication)
{
    webApplication.FilmeMapEndpoints();
}