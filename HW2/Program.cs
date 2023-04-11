using HW2.Mamagements;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IManagementCars, ManagementCars>();

var app = builder.Build();

app.Map("/", () => "Welcome to Managements Cars app! :) ");
app.Map("/name", HandleCarName);
app.Map("/engine", HandleCarEngine);
app.Map("/age", HandleCarAge);


app.Run();

static Task HandleCarName(HttpContext context, IManagementCars managementCars)
{
    return context.Response.WriteAsync($"Car name = {managementCars.GetCarName()}");
}

static Task HandleCarEngine(HttpContext context, IManagementCars managementCars)
{
    return context.Response.WriteAsync($"Car engine = {managementCars.GetCarEngine()}");
}

static Task HandleCarAge(HttpContext context, IManagementCars managementCars)
{
    return context.Response.WriteAsync($"Car age = {managementCars.GetCarAge()}");
}