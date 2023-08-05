using CRUDJunior.Commands;
using CRUDJunior.Commands.Handlers;
using CRUDJunior.Commands.Handlers.Contracts;
using CRUDJunior.Context;
using CRUDJunior.UniteOfWork;
using CRUDJunior.UniteOfWork.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DefaultConnetion");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CrudeContext>(options=>options.UseSqlite(connString));
builder.Services.AddTransient<IUniteOfWork, UniteOfWork>(); 
builder.Services.AddTransient< AlunoHandler, AlunoHandler >();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
