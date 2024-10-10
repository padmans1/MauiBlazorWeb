namespace MauiBlazorWeb.Shared;

using MauiBlazorWeb.Shared.Implementations;
using MauiBlazorWeb.Shared.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

public static class Extensions
{
    public static void AddHttpClientFactory(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient<IHttpClientFactory>(client =>
        {
            client.Timeout = TimeSpan.FromMinutes(5);
            client.BaseAddress = new Uri(configuration["Api:Platform:BaseUrl"] ?? string.Empty);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        });
        services.AddHttpClient(
        configuration.GetValue<string>("PlatformConfig:KSHHttpName")!,
        client =>
        {
            // Set the base address of the named client.
            client.BaseAddress = new Uri(configuration.GetValue<string>("PlatformConfig:BaseURL")!);

        });
    }
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountManagement, AccountManagement>();
    }
}
