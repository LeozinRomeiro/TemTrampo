using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using TemTrampo.Components;
using TemTrampo.Data;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<MudLocalizer, DictionaryMudLocalizer>();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMudServices();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao") ?? throw new InvalidOperationException("Connection string não informada.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
