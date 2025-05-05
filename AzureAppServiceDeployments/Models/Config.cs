namespace AzureAppServiceDeployments.Models;

public class Config
{
    public string ConnectionString { get; set; }
    public string BlobConnectionString { get; set; }
    public string JwtSignGuid { get; set; }
    public string EmailServiceApiKey { get; set; }
    public string DeployedFromCiAgent { get; set; }
    public string Version { get; set; }
    public string Slot { get; set; }
}
