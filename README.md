# MyShowCase

A personal portfolio/showcase site built with Blazor, featuring modular sections (Hero, About, Services, Skills, Portfolio, Resume, Testimonials, FAQ, Contact) and a clean, responsive UI.

## Prerequisites
- .NET SDK 8.0 (or compatible)
- Node.js (optional, only if you plan to rebuild vendor assets)

## Getting Started

```bash
# Restore dependencies
dotnet restore

# Build
dotnet build

# Run (development)
dotnet run --project ProjectFiles/MyShowCase.csproj
```

The app will print a local URL (e.g., http://localhost:5000). Open it in your browser.

## Project Structure

- `ProjectFiles/` — Blazor app source
  - `Components/` — Section components like `HeroSection.razor`, `AboutSection.razor`, etc.
  - `Data/` — Strongly typed models for each section
  - `Layout/` — Layouts, header, footer, and navigation
  - `Pages/` — Page-level components (e.g., `Home.razor`)
  - `wwwroot/` — Static assets (CSS/JS/images/vendor)
  - `Program.cs`, `_Imports.razor`, `App.razor` — App bootstrap and global imports
- `MyShowCase.csproj`, `MyShowCase.sln` — Project and solution files

See more details in `docs/structure.md`.

## Features

- Modular, easily customizable sections
- Responsive layout with Bootstrap
- Animations and UI enhancements via AOS, GLightbox, Swiper, and more

See `docs/features.md` for a quick tour.

## Customization

- Update section content in the corresponding models under `ProjectFiles/Data/*`
- Adjust styles in `ProjectFiles/wwwroot/assets/css/main.css` or add your own
- Swap images under `ProjectFiles/wwwroot/assets/img/*`

See `docs/customization.md` for step-by-step guidance.

## Scripts & Assets

Vendor libraries are vendored in `ProjectFiles/wwwroot/assets/vendor/`. If you need to update or rebuild front-end assets, do so there or replace with newer versions.

## Build & Publish

```bash
# Release build
dotnet publish ProjectFiles/MyShowCase.csproj -c Release -o ./publish
```

Deploy the contents of `./publish/wwwroot` to any static host or serve via your preferred hosting setup.

## License

Add your license terms here.

