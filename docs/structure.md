# Project Structure

```
ProjectFiles/
  Components/            # UI sections (e.g., HeroSection.razor, AboutSection.razor)
  Data/                  # Strongly typed models per section
  Layout/                # Layouts, header, footer, navigation
  Pages/                 # Page-level components (e.g., Home.razor)
  wwwroot/               # Static assets (CSS/JS/images/vendor)
  App.razor              # Root component
  _Imports.razor         # Global using/imports
  Program.cs             # App startup
MyShowCase.csproj        # Project file
MyShowCase.sln           # Solution file
```

- Components use models from `Data/*` to render dynamic content.
- Global styles live under `wwwroot/assets/css/main.css` and `wwwroot/css/app.css`.
- Vendor libraries are in `wwwroot/assets/vendor/*`.
