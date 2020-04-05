# Kroma's Cops 'n' Robbers

A SA:MP Cops 'n' Robbers gamemode written using SampSharp

## Getting Started

### Prerequisites

* Visual Studio 2019
* SampSharp
* SA:MP server package

### Running the server

* Clone repo
* Extract SA:MP server package to same folder as repo
* Extract SampSharp files to same folder as repo
* Copy `server.cfg.example` and rename to `server.cfg` (replace existing file if needed)
* Edit `server.cfg` and change `rcon_password` value
* Run `samp-server.exe`
* Open `src/KromaCnR/KromaCnR.sln` in Visual Studio
* Create a new file under `KromaCnR` called `appsettings.json`
* Copy contents of `appsettings.json.example` to `appsettings.json` and paste your MongoDB connection string
* Run in Visual Studio