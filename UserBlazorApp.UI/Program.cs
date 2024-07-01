using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UserBlazorApp.UI;
using UserBlazorApp.UI.Services;
using UsersBlazorApp.Data.Interfaces;
using UsersBlazorApp.Data.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7097/") });
builder.Services.AddScoped<IClientService<AspNetUsers>, UsuarioService>();

await builder.Build().RunAsync();
