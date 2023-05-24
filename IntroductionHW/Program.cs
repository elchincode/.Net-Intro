var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

//builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "deafult",
    pattern : "{controller=home}/{action=index}/{id?}"
    );

app.Run();
