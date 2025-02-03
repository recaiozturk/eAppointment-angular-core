using DefaultAllowCorsPolicyNugetPackage;
using eAppointmentServer.Application;
using eAppointmentServer.Infrastructure;
using eAppointmentServer.WebAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddDefaultCors();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

Helper.CreateUserAsync(app).Wait();

app.Run();
