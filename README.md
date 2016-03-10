# ITPedia
A Web Application. Updated to ASP.NET MVC5.
> Please note this was an old application we at HubIT club accepted to contribute at. And the difficulties we faced was from the poor code design. Yet, it was a good 'real world' challenge.

## Recommended Developer Tools
- We recommend to open this project using the free [Visual Studio Community](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx) IDE. This was the IDE with wich the MVC 4 was updated to MVC 5. Microsoft Visual studio is notorious for fucking it up. In this case with importing project to different IDE versions. E.g. I spend like a full fucking working day without results. Finally I updated the MVC 4 to MVC 5 in order to be able for the IDE to properly load the Web.config settings. If you are a Windows person responsible for those stuff shame on you. Love live JetBrains and [ReSharper](https://www.jetbrains.com/resharper/).
- If possible install [ReSharper](https://www.jetbrains.com/resharper/). 
- Use Git control version system. [Learn it in 15 minutes](https://try.github.io/levels/1/challenges/1)
  - [Commit often](https://sethrobertson.github.io/GitBestPractices/).
  - Write your commit message in the [imperative](https://robots.thoughtbot.com/5-useful-tips-for-a-better-commit-message): "Fix bug" and not "Fixed bug" or "Fixes bug."
## Installation
> I assume you have opened this project using Visual Studio Community IDE.  

1. Allow NuGet to restore packages.
 - Open NuGet (Tools -> NuGet Package Manager -> Package Manager Console)
 - Press 'Restore' button. If you are not able to find this button [execute](https://docs.nuget.org/consume/reinstalling-packages) the below command on the package manager console: `Update-Package –reinstall`
2. Build solution. `Ctrl + Shift + B`
3. Right click on project located in the solution explorer -> View -> View  in Browser (your  favorite browser)
- If you encounter errors like with the database server, e.g. " A network-related or instance-specific error occurred while establishing a connection to SQL Server.", then you probably need to install a [sql server](https://www.microsoft.com/en/server-cloud/products/sql-server-editions/sql-server-express.aspx)


## Contributors
> Please add your author name on this list for your contributions, as well as on the code as needed. [Open Source/Free contribution Culture](http://www.webweavertech.com/costin/archives/000320.html)  

- Uknown
- Rizart Dokollari <r.dokollari@gmail.com>
- Antony Kalogeropoulos <anthony.kalogeropoulos@gmail.com>
