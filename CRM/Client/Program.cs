using Blazored.Modal;
using CRM.Client;
using CRM.Client.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using CRM.Client.Shared;
using CRM.Client.Components.States;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredModal();
builder.Services.AddSingleton<CustomerStateService>();


builder.Services.AddHttpClient("CRM.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CRM.ServerAPI"));
builder.Services.AddApiAuthorization();
builder.Services.AddSyncfusionBlazor();

//builder.Services.AddSingleton<CustomerRepo>();

await builder.Build().RunAsync();
