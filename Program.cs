using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.IO;
using scrum_poker_app.Models;
using scrum_poker_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.Configure<ScrumPokerAppSettings>(builder.Configuration.GetSection("ScrumPoker"));

builder.Services.AddSingleton<SessionTokenService>();

var app = builder.Build();

ScrumPokerAppSettings settings = app.Configuration.Get<ScrumPokerAppSettings>();
string? databaseFilePath = settings.DbFile;

if (string.IsNullOrWhiteSpace(databaseFilePath))
    databaseFilePath = Path.Combine(builder.Environment.WebRootPath, "ScrumPoker.db");
else
    databaseFilePath = Path.IsPathFullyQualified(databaseFilePath) ? Path.GetFullPath(databaseFilePath) : Path.Combine(builder.Environment.WebRootPath, databaseFilePath);
app.Logger.LogInformation("Using database {databaseFilePath}", databaseFilePath);
builder.Services.AddDbContext<ScrumPokerContext>(opt =>
    opt.UseSqlite(new SqliteConnectionStringBuilder
{
    DataSource = string.IsNullOrWhiteSpace(databaseFilePath) ? "ScrumPoker.db" : databaseFilePath,
    ForeignKeys = true,
    Mode = File.Exists(databaseFilePath) ? SqliteOpenMode.ReadWrite : SqliteOpenMode.ReadWriteCreate
}.ConnectionString));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    // 
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");;

app.Run();
