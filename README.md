
<a name="readme"></a>

## About The Project

### Built With

* [![ASP.NETLogo](https://www.memos.cz/wp-content/uploads/2023/03/asp.net_logo.png)](https://dotnet.microsoft.com/en-us/apps/aspnet)

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites
1. Install dotnet
  *For Windows (run in CMD as ADMINISTRATOR) 
    ```sh
    @"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"
    choco install dotnet
    ```
  *For Linux
    ```sh
    ./dotnet-install.sh --channel 8.0
    ```
2. Install SQL server Database engine
   Tady jsem v botě.

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/bolwer12345/GjkEvent.git
   cd ./GjkEvent
   ```
2. Add necesary DB-related packages
   ```sh
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   dotnet add package Microsoft.Data.SqlClient
   ```
 3. Install additional tools
   ```sh
   dotnet tool install --global dotnet-ef
   dotnet add package Microsoft.EntityFrameworkCore.Design
   ```
4. Set up database
   ```sh
   dotnet ef migrations add InitialModel
   dotnet ef database update
   ```
4. Add package to generate QR codes
   ```sh
   dotnet add package QRCoder
   ```
   
### Execution
```sh
   dotnet run --environment production
   ```

### Author
Good Luck
