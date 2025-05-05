##########################################################################
# RESOURCE GROUP
##########################################################################

resource "azurerm_resource_group" "public" {
  location = "northeurope"
  name     = "rg-web-app-deploy-${var.prefix}"
}

##########################################################################
# APP SERVICE WINDOWS
##########################################################################

resource "azurerm_service_plan" "windows" {
  name                = "asp-windows-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name

  os_type  = "Windows"
  sku_name = "P0v3"
}

resource "azurerm_windows_web_app" "app" {
  name                = "ase-windows-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  service_plan_id     = azurerm_service_plan.windows.id

  app_settings = {
    WEBSITE_ENABLE_SYNC_UPDATE_SITE = "true"
    WEBSITE_RUN_FROM_PACKAGE        = "1"
  }

  site_config {}
}

##########################################################################
# APP SERVICE LINUX
##########################################################################

resource "azurerm_service_plan" "linux" {
  name                = "asp-linux-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name

  os_type  = "Linux"
  sku_name = "P0v3"
}

resource "azurerm_linux_web_app" "app" {
  name                = "ase-linux-${var.prefix}"
  location            = azurerm_resource_group.public.location
  resource_group_name = azurerm_resource_group.public.name
  service_plan_id     = azurerm_service_plan.linux.id

  app_settings = {
    WEBSITE_ENABLE_SYNC_UPDATE_SITE = "true"
    WEBSITE_RUN_FROM_PACKAGE        = "1"
  }

  site_config {
    application_stack {
      dotnet_version = "6.0"
    }
  }
}

##########################################################################
# DEPLOYMENT SLOTS LINUX
##########################################################################

resource "azurerm_linux_web_app_slot" "staging" {
  name           = "staging"
  app_service_id = azurerm_linux_web_app.app.id

  app_settings = {
    WEBSITE_ENABLE_SYNC_UPDATE_SITE = "true"
    WEBSITE_RUN_FROM_PACKAGE        = "1"
  }

  site_config {
    application_stack {
      dotnet_version = "6.0"
    }
  }
}
