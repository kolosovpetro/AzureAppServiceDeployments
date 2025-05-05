# Azure AppService Deploy using Github Actions

Deploy azure app service using github actions

## Variables transform

- `ConfigExample.ConnectionString` | `Server=localhost,1433;Database=MANGO_DEV;User Id=sa;Password=x2yiJt!Fs;TrustServerCertificate=true;`
- `ConfigExample.BlobConnectionString` | `AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;`
- `ConfigExample.JwtSignGuid` | `00b01c41-074a-4949-85dc-31658e2e2a8c`
- `ConfigExample.EmailServiceApiKey` | `aba2e8bf-5cda-4f76-b579-f145290f7a2d`

## GitHub Actions

- https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel
- https://github.com/GitTools/actions/blob/main/docs/examples/github/gitversion/setup.md
- https://github.com/devops-actions/variable-substitution
- https://github.com/actions/upload-artifact
- https://github.com/actions/download-artifact
- https://github.com/Azure/webapps-deploy
