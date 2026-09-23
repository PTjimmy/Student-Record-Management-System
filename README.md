# Student Record Management System (ASP.NET MVC 5, .NET Framework)

A small mini project demonstrating ASP.NET MVC on the .NET Framework: page
navigation, Razor views, model validation, and basic CRUD functionality.
Data is stored in-memory (no database setup required).

## Pages (6 total)

| # | Page                 | URL                       | Purpose                                  |
|---|----------------------|---------------------------|-------------------------------------------|
| 1 | Home                 | `/` or `/Home/Index`      | Landing page, links to everything         |
| 2 | About                | `/Home/About`             | Info about the project                    |
| 3 | Contact              | `/Home/Contact`           | Contact form (GET + POST, validation)     |
| 4 | Student List         | `/Students/Index`         | Table of all students                     |
| 5 | Add Student          | `/Students/Create`        | Form to add a new student (Create)        |
| 6 | Student Details/Edit | `/Students/Details/{id}`, `/Students/Edit/{id}` | View, edit, delete a student |

## Requirements

- Windows with **Visual Studio 2019 or 2022** (Community edition is fine)
- Workload: "ASP.NET and web development"
- .NET Framework 4.7.2 targeting pack (installed automatically by the workload)

## How to open and run

1. Copy the `MiniProjectMVC` folder anywhere on your Windows machine.
2. Open `MiniProjectMVC.csproj` by double-clicking it, or in Visual Studio:
   **File → Open → Project/Solution** → select `MiniProjectMVC.csproj`.
3. Visual Studio will prompt to restore NuGet packages (listed in
   `packages.config`) — let it do so, or right-click the project in
   **Solution Explorer → Restore NuGet Packages**.
4. Press **F5** (or click "IIS Express") to build and run.
5. Your browser will open to the Home page automatically.

If you'd rather not deal with NuGet restore, you can instead create a new
**ASP.NET Web Application (.NET Framework) → MVC** project in Visual Studio
(which sets up all MVC references for you) and then copy the `Controllers`,
`Models`, and `Views` folders from this project into it, overwriting the
defaults.

## Project structure

```
MiniProjectMVC/
├── Controllers/
│   ├── HomeController.cs        (Index, About, Contact)
│   └── StudentsController.cs    (Index, Details, Create, Edit, Delete)
├── Models/
│   ├── Student.cs                (entity + validation attributes)
│   ├── ContactModel.cs           (contact form model)
│   └── StudentRepository.cs      (in-memory "database")
├── Views/
│   ├── Shared/_Layout.cshtml     (nav bar + shared page chrome)
│   ├── Home/ (Index, About, Contact)
│   └── Students/ (Index, Details, Create, Edit)
├── App_Start/ (RouteConfig, BundleConfig, FilterConfig)
├── Global.asax / Global.asax.cs
├── Web.config
└── packages.config
```

## Extending it

- **Persistence:** Swap `StudentRepository` for Entity Framework + SQL
  Server LocalDB to persist data across restarts.
- **Authentication:** Add ASP.NET Identity if you need login/roles.
- **Styling:** All CSS currently lives inline in `_Layout.cshtml` to avoid
  any external dependency — feel free to pull in Bootstrap via NuGet instead.
