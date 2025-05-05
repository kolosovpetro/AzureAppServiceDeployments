##########################################################################
# RESOURCE GROUP
##########################################################################

resource "azurerm_resource_group" "public" {
  location = "northeurope"
  name     = "rg-web-app-deploy-${var.prefix}"
}

##########################################################################
# APP SERVICE
##########################################################################

resource "azurerm_service_plan" "asp" {
  name                = "asp-prod-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name

  os_type  = "Windows"
  sku_name = "B1"
}

resource "azurerm_windows_web_app" "app" {
  name                = "ase-prod-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  service_plan_id     = azurerm_service_plan.asp.id

  app_settings = {
    WEBSITE_ENABLE_SYNC_UPDATE_SITE = "true"
    WEBSITE_RUN_FROM_PACKAGE        = "1"
  }

  site_config {}
}
