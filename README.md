# AI Quiz Generator (AWT Project Quiz Wizard)

This repository contains a collection of Java GUI applications built using the Abstract Window Toolkit (AWT) as part of the MCA Academic Curriculum. Each demo showcases practical uses of AWT components in building interactive applications.

## Languages & Technologies Used

- **HTML** (~87.1%) – Used primarily for structuring GUI-related content or documentation.  
- **C#** (~10.5%) – Likely used alongside AWT-style logic within the demos or project structure.  
- **CSS** (~2.4%) – Used for styling HTML components.

## Project Overview

- Demonstrates AWT concepts such as frames, panels, layout managers (FlowLayout, BorderLayout, GridLayout, etc.), dialogs, menus, event handling (ActionListener,  WindowListener, etc.), and custom graphics.
- Well-organized source code files for each concept or mini-project.
- Ideal for learning AWT fundamentals or academic reference.

## Project Structure

/QuizWizard
/Controllers # ASP.NET Core MVC or API controllers
/Models # Domain and DTO models
/Services # AI integration, quiz generation, parsing logic
/Views # Razor views (if using MVC)
/wwwroot # JS, CSS, images, client-side code
/Data # EF Core DbContext & migrations (optional)
appsettings.json # Configuration (API keys, DB connection strings)

## Prerequisites

- .NET SDK (6.0, 7.0, or the target SDK your project uses)  
- Visual Studio 2022 / 2023 or VS Code with C# extensions  
- (Optional) SQL Server / LocalDB if using EF Core persistence  
- AI API credentials (e.g., Google Gemini API key or other provider) — store securely in `appsettings.json` or environment variables

## How to Run

1. **Clone this repository:**
git clone https://github.com/mayurmakwana6199/MCA_AWT_Project.git

2. **Restore dependencies and build:**
dotnet restore
dotnet build

3. **Add your configuration:**
Put API keys and DB connection strings in appsettings.Development.json or set environment variables.
Example appsettings.Development.json keys:

{
  "AIService": {
    "ApiKey": "API_KEY",
    "Endpoint": "https://api.example.com/generate"
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=QuizWizardDB;Trusted_Connection=True;"
  }
}

5. **Run the application:**
dotnet run

## Contributing

Pull requests are welcome! If you find issues or want to add more AWT demos/examples, feel free to fork and create a pull request.

## License

This project is open-source for educational purposes.
