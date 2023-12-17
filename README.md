
<a name="readme"></a>

## About The Project

### Built With

* [![ASP.NETLogo](https://www.memos.cz/wp-content/uploads/2023/03/asp.net_logo.png)](https://dotnet.microsoft.com/en-us/apps/aspnet)

<!-- GETTING STARTED -->
## Getting Started

### Prerequisites
*For Windows (run in CMD as ADMINISTRATOR)
  ```sh
  @"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe" -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"
  choco install dotnet
  ```
*For Linux
  ```sh
  ./dotnet-install.sh --channel 8.0
  ```

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/bolwer12345/GjkEvent.git
   cd ./GjkEvent
   ```
2. Set up database
   ```sh
   dotnet ef migrations add InitialModel
   dotnet ef database update
   ```
   
### Execution
```sh
   dotnet run --environment production
   ```

### Author
Good Luck
