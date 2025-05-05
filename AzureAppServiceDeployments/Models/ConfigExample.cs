namespace AzureAppServiceDeployments.Models;

public class ConfigExample
{
    public string ConnectionString { get; set; }
    public string BlobConnectionString { get; set; }
    public string JwtSignGuid { get; set; }
    public string EmailServiceApiKey { get; set; }
}
