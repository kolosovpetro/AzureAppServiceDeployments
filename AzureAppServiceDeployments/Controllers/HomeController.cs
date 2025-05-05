using System.Diagnostics;
using System.Reflection;
using AzureAppServiceDeployments.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureAppServiceDeployments.Controllers;

public class HomeController : Controller
{
    private readonly Config _config;

    public HomeController(Config config)
    {
        _config = config;
    }

    public IActionResult Index()
    {
        ViewBag.ConnectionString = _config.ConnectionString;
        ViewBag.BlobConnectionString = _config.BlobConnectionString;
        ViewBag.JwtSignGuid = _config.JwtSignGuid;
        ViewBag.EmailServiceApiKey = _config.EmailServiceApiKey;
        ViewBag.DeployedFromCiAgent = _config.DeployedFromCiAgent;
        ViewBag.Version = _config.Version;
        ViewBag.Slot = _config.Slot;

        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.ConnectionString = _config.ConnectionString;
        ViewBag.BlobConnectionString = _config.BlobConnectionString;
        ViewBag.JwtSignGuid = _config.JwtSignGuid;
        ViewBag.EmailServiceApiKey = _config.EmailServiceApiKey;
        ViewBag.DeployedFromCiAgent = _config.DeployedFromCiAgent;
        ViewBag.Version = _config.Version;
        ViewBag.Slot = _config.Slot;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
