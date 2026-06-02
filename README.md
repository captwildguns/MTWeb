# MT Web

Blazor WebAssembly conversion of Student Transportation (Traversa) pages, built with
[`TylerTechnologies.Transportation.Components`](https://github.com/tyler-technologies/transportation-components).

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Access to Tyler Tech JFrog Artifactory (for NuGet packages)

## NuGet Authentication

Set environment variables before restoring:

```powershell
$env:NuGetPackageSourceCredentials_Artifactory    = "Username=<user>;Password=<token>;ValidAuthenticationTypes=Basic"
$env:NuGetPackageSourceCredentials_ArtifactoryLGD = "Username=<user>;Password=<token>;ValidAuthenticationTypes=Basic"
```

## Run locally

```shell
dotnet run --project src/MTWeb
```

Then open http://localhost:5000 in your browser.

## Project structure

```
src/MTWeb/
├── Layout/            # StxAppLayout shell
├── Pages/
│   └── TylerDrive/
│       └── Setup/     # 8 setup tab pages (General, Inspections, Messaging,
│                      #   Motion Lock, Navigation, ALK Copilot, Ridership,
│                      #   Time Tracking)
├── Models/            # C# models mirroring the original ViewModels
└── wwwroot/           # Static assets, index.html
```

## Component rules

- Use `Stx*` from `transportation-components` wherever a component exists
- Fall back to `Forge*` from `Tyler.Forge.Blazor` when no `Stx` equivalent exists
- Never write raw HTML/CSS workarounds for things a Forge component can do

## API wiring

Each tab's `HandleSave()` has a `// TODO:` comment pointing to the original Traversa
controller endpoint. Wire these up once a backend is available.
