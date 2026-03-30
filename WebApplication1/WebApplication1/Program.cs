var builder = WebApplication.CreateBuilder(args);
//add services to the container
// ioC container

builder.Services.AddControllersWithViews();



var app = builder.Build();

app.MapDefaultControllerRoute();


app.UseStaticFiles();



// app.MapGet("/", () => "Hello World!");
// app.MapGet("/Bye", () => "Bye World!");

app.Run();