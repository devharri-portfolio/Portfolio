using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortfolioUI;
using PortfolioUI.Services.Email;
using PortfolioUI.Services.GoogleCaptcha;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IGoogleCaptchaService,GoogleCaptchaService>();
builder.Services.AddTransient<IEmailService, EmailService>();

await builder.Build().RunAsync();

