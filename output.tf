output "app_service_url" {
  value = "https://${azurerm_windows_web_app.app.name}.azurewebsites.net"
}

