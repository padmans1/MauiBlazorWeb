using MauiBlazorWeb.Shared.UI.Interfaces;

namespace MauiBlazorWeb.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor() => "Web";

    public string GetPlatform() => Environment.OSVersion.ToString();
}
