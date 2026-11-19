# Car Insurance — ASP.NET MVC Entity Framework Assignment Part 3

This is a **coursework starter project** for classic ASP.NET MVC 5 on .NET Framework 4.8, with Entity Framework 6 and SQL Server LocalDB.

## Open in Visual Studio (Windows)

1. Install the **ASP.NET and web development** workload, including **.NET Framework 4.8 targeting pack** and **Entity Framework 6 tools**.
2. Open `CarInsurance.sln` in **Visual Studio Community** (not VS Code). This solution contains one ASP.NET MVC 5 web project; do not add the separate `WebApplication1` project.
3. Right-click the solution > **Restore NuGet Packages**. If references remain missing, use **Tools > NuGet Package Manager > Package Manager Console**, and run `Update-Package -reinstall`.
4. Ensure SQL Server Express LocalDB (`MSSQLLocalDB`) is installed.
5. Build solution, then press **F5**. Browse to `/Insuree/Create` if needed.
6. Submit a sample quote, then open `/Insuree/Admin` to see saved records.

## Quote rules

$50 base; ages <=18 +$100, 19–25 +$50, 26+ +$25; car before 2000 +$25, after 2015 +$25; Porsche +$25 and 911 Carrera +$25 more; tickets +$10 each; DUI multiplies by 1.25; full coverage multiplies by 1.50. Quote is calculated server-side and never entered on the form.

## Important

- This ZIP contains **source code only**. It has **not been compiled or run** in this environment; you must restore packages and test it in Visual Studio.
- The Admin page is **not access-controlled** and displays personal data. It is **for local coursework demonstration only**, not production deployment. Add login and role-based authorization before publishing it.
- The example uses EF6's default database initializer. LocalDB should create the database on first use. For an existing database or schema change, use EF migrations.
- No GitHub upload has been performed. Push the repository from Visual Studio after testing.
