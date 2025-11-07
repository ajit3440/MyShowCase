# Customization Guide

## Update Content
- Edit models under `ProjectFiles/Data/*` to change section text, items, and metadata.

## Change Images
- Replace assets in `ProjectFiles/wwwroot/assets/img/*` with your images. Keep names/paths or update references in components if needed.

## Adjust Styles
- Tweak `ProjectFiles/wwwroot/assets/css/main.css` or add new stylesheets.
- Bootstrap variables/utilities are available via included vendor CSS.

## Add/Remove Sections
- Duplicate an existing section component in `ProjectFiles/Components/` and wire it into `Pages/Home.razor` (or your target page) and `Layout` as needed.
- Create matching model(s) in `ProjectFiles/Data/*` if the section needs structured data.

## Build & Deploy
```bash
# Release build
-dotnet publish ProjectFiles/MyShowCase.csproj -c Release -o ./publish
```
- Deploy `./publish/wwwroot` to your hosting.
