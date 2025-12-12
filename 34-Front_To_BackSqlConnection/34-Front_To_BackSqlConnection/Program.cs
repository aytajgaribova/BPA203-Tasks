using System;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppContext>(opt =>
opt.UseSqlServer("server=SAMA;database=ProniaBPA203DB;trusted_connection=true;trustServerCertificate=true"));

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization()

app.MapControllerRoute(
    name: default,
    pattern: "{controller=home}/{action=index}/{id?}"
    );


app.Run();

