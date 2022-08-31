using InspireCoders.Application;
using InspireCoders.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var AllowInspireCodersClient = "_allowInspireCodersClient";

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowInspireCodersClient,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:8080",
                                              "http://localhost:4200");
                      });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UsePathBase(new PathString("/api"));

app.UseRouting();

app.UseCors(AllowInspireCodersClient);

app.UseAuthorization();

app.MapControllers();

app.Run();
