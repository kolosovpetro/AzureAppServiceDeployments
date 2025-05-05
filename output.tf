output "app_service_windows_url" {
  value = "https://${azurerm_windows_web_app.app.name}.azurewebsites.net"
}

output "app_service_linux_url" {
  value = "https://${azurerm_linux_web_app.app.name}.azurewebsites.net"
}

