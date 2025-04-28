using HangingQueries.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IService, Service>();
builder.Services.AddScoped<IOtherService>(sp => new OtherService(sp.GetRequiredService<IService>())); 

builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
