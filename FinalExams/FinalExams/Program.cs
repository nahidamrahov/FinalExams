using FinalExams.DAL;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();



app.UseStaticFiles();

app.UseRouting();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});



app.MapControllerRoute
    ( name:"Default",
     pattern:"{controller=home}/{action=index}/{id?}"
    
    );


app.Run();


