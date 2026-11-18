# Car Insurance — ASP.NET MVC 5 Assignment Part 3

This project implements the Car Insurance quote assignment using classic ASP.NET MVC 5, .NET Framework 4.8, Entity Framework 6, and SQL Server LocalDB.

## Implemented assignment requirements

- Calculates quotes on the server in `Controllers/InsureeController.cs`.
- Starts each quote at $50 per month.
- Applies the age additions for 18 and under, 19–25, and 26 and older.
- Applies the vehicle-year additions for years before 2000 and after 2015.
- Adds the Porsche surcharge and the additional Porsche 911 Carrera surcharge.
- Adds $10 for each speeding ticket.
- Applies the DUI and full-coverage percentage increases.
- Does not display or accept a Quote input on `Views/Insuree/Create.cshtml`. The server calculates and saves the quote.
- Provides `Views/Insuree/Admin.cshtml`, listing each saved quote with first name, last name, email address, and monthly quote.

## Open and run in Visual Studio on Windows

1. Open `CarInsurance.sln` in Visual Studio Community. This is a classic ASP.NET MVC 5 project; use Visual Studio with the **ASP.NET and web development** workload.
2. Ensure the **.NET Framework 4.8 targeting pack** and SQL Server Express LocalDB are installed.
3. Right-click the solution and select **Restore NuGet Packages**. If required, open Package Manager Console and run `Update-Package -reinstall`.
4. Select **Build > Build Solution**.
5. Press **F5** to run the application. Open `/Insuree/Create` if the quote form does not appear automatically.
6. Submit a test quote. Then open `/Insuree/Admin` to see the saved record.

## Quote calculation order

The controller adds the fixed charges first, then multiplies the subtotal by 1.25 when the applicant has a DUI and by 1.50 for full coverage. If both apply, both multipliers apply sequentially. The final quote is rounded to two decimal places.

## Important notes

- This environment does not have the Windows .NET Framework/MSBuild toolchain, so the project could not be compiled or launched here. Restore NuGet packages, build, and run it in Visual Studio on Windows before submitting.
- `/Insuree/Admin` is a coursework demonstration page and is not protected by administrator authentication. Do not deploy it publicly without adding authentication and administrator-only authorization, because it displays personal information.
- The project uses Entity Framework 6 with SQL Server LocalDB. The database is created on first use; existing databases may require migrations if the model changes.
- The GitHub upload is not performed by this ZIP preparation. Push the tested project to your own GitHub repository and submit that repository URL.
