using APIContagem;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSingleton<Contador>();

builder.Services.AddCors();

var app = builder.Build();

app.MapOpenApi();

app.UseAuthorization();

app.MapControllers();

app.Run();