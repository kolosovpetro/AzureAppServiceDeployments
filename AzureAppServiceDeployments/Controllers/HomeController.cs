using System.Diagnostics;
using System.Reflection;
using AzureAppServiceDeployments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureAppServiceDeployments.Controllers;

public class HomeController : Controller
{
    private readonly ConfigExample _configExample;

    public HomeController(ConfigExample configExample)
    {
        _configExample = configExample;
    }

    public IActionResult Index()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;

        if (version != null)
        {
            var assemblyVersion = version.ToString();
            ViewBag.Message = $"Your application description page. Version: {assemblyVersion}";
        }

        ViewBag.ConnectionString = _configExample.ConnectionString;
        ViewBag.BlobConnectionString = _configExample.BlobConnectionString;
        ViewBag.JwtSignGuid = _configExample.JwtSignGuid;
        ViewBag.EmailServiceApiKey = _configExample.EmailServiceApiKey;

        return View();
    }

    public IActionResult Privacy()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;

        if (version != null)
        {
            var assemblyVersion = version.ToString();
            ViewBag.Message = $"Your application description page. Version: {assemblyVersion}";
        }

        ViewBag.ConnectionString = _configExample.ConnectionString;
        ViewBag.BlobConnectionString = _configExample.BlobConnectionString;
        ViewBag.JwtSignGuid = _configExample.JwtSignGuid;
        ViewBag.EmailServiceApiKey = _configExample.EmailServiceApiKey;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
