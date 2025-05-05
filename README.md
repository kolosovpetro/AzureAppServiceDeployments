# Azure AppService Deploy using GitHub Actions

Azure App Service deployments using GitHub Actions and Azure Pipelines.
This repository contains CI/CD pipeline implementations for deploying .NET applications
to Azure App Services on both Windows and Linux,
including blue-green deployments and rollback strategies.

## Features

- **GitHub Actions for:**
    - Windows App Service deployment
    - Linux App Service deployment
    - Pull request validation
- **Azure Pipelines for:**
    - Building .NET application
    - Windows App Service deployment
    - Linux App Service deployment
    - Blue-green deployment with rollback
- **Infrastructure as Code using Terraform**
    - Azure App Service (Windows & Linux)

## Azure Pipelines

- [Azure Web App Deploy Task](https://learn.microsoft.com/en-us/azure/devops/pipelines/tasks/reference/azure-rm-web-app-deployment-v4?view=azure-pipelines)

## GitHub Actions

- [Azure App Service Deployment using GitHub Actions](https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel)
- [GitVersion GitHub Action](https://github.com/GitTools/actions/blob/main/docs/examples/github/gitversion/setup.md)
- [Variable Substitution](https://github.com/devops-actions/variable-substitution)
- [Upload Artifact](https://github.com/actions/upload-artifact)
- [Download Artifact](https://github.com/actions/download-artifact)
- [Azure WebApps Deploy Action](https://github.com/Azure/webapps-deploy)

## Changelog Summary

- Added CI/CD with GitHub Actions and Azure Pipelines
- Implemented infrastructure with Terraform including App Services and slots
- Enabled blue-green deployments with rollback capabilities
- Integrated GitVersion and NuGet configuration
- Applied semantic versioning and changelog standards
