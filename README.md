# Grocery Finder
### By **Jamison Cozart**  April 3rd 2020

**C# .NET core Web API backend with JavaScript Front-End**

API for local grocery stores in your area to find information on store hours, delivery details, and other essential information for retrieving your necessities.

## Specifications 

### API Endpoints

|Method|Route|Response|
|:-:|:-:|:-:|
| GET | /api/stores | Show all stores with key information for each |
| POST | /api/stores | Create new store | <-- Requires JSON store object sent in body of request
| GET | /api/stores/{storeId} | Show all details about specific store |
| PUT | /api/stores/{storeId} | Edit information on already existing store |
| DELETE | /api/stores/{storeId} | Delete a specific store |

#### Swagger and NSwag were used to auto-generate API Endpoint documentation for ease of use
_For interactive documentation of API Endpoints, follow the **Installation + Setup** instructions and visit `http://localhost:5000/`_

## Getting Started

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

### Install MySQL and MySQL Workbench

#### on macOS:
_Download the MySQL Community Server DMG File [here](https://dev.mysql.com/downloads/file/?id=484914). Follow along with the installer until you reach the configuration page. Once you've reached Configuration, set the following options (or user default if not specified):_
* use legacy password encryption
* set password (and change the password field in appsettings.json file of this repository to match your password)
* click finish
* open Terminal and enter the command ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` if using Git Bash.
* Verify MySQL installation by opening Terminal and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. If you gain access to the MySQL command line, installation is complete. An error (e.g., -bash: mysql: command not found) indicates something went wrong.

_Download MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391). Install MySQL Workbench to Applications folder. Open MySQL Workbench and select Local instance 3306 server, then enter the password you set. If it connects, you're all set._

#### on Windows:
_Download the MySQL Web Installer [here](https://dev.mysql.com/downloads/file/?id=484919) and follow along with the installer. Click "Yes" if prompted to update, and accept license terms._
* Choose Custom setup type
* When prompted to Select Products and Features, choose the following: MySQL Server (Will be under MySQL Servers) and MySQL Workbench (Will be under Applications)
* Select Next, then Execute. Wait for download and installation (can take a few minutes)
* Advance through Configuration as follows:
  - High Availability set to Standalone.
  - Defaults are OK under Type and Networking.
  - Authentication Method set to Use Legacy Authentication Method.
  - Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  - Unselect Configure MySQL Server as a Windows Service.
* Complete installation process

_Add the MySQL environment variable to the System PATH. Instructions for Windows 10:_
* Open the Control Panel and visit _System > Advanced System Settings > Environment Variables..._
* Select _PATH..._, click _Edit..._, then _Add_.
* Add the exact location of your MySQL installation and click _OK_. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)
* Verify installation by opening Windows PowerShell and entering the command ``mysql -uroot -p{your password here, omitted brackets}``. It's working correctly if you gain access to the MySQL command line. Exit MySQL by entering the command ``exit``.
* Open MySQL Workbench and select Local instance 3306 server (may be named differently). Enter the password you set, and if it connects, you're all set.

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing + Setup

1. Clone the repository:
    ```
    git clone https://github.com/jamisoncozart/GroceryFinder
    ```

2. Navigate to the root directory:
    ```
    cd GroceryFinder/GroceryFinder
    ```

2. Restore all dependencies:
    ```
    dotnet restore
    ```

3. Run migrations to update local DB:
    ```
    dotnet ef database update
    ```

3. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```

5. Open the index.html page in your browswer of choice
    ```
    cd ..
    start GroceryFinderFrontEnd/index.html
    ```

## Technologies Used

* C#
* .NET webAPI Framework 2.2
* Entity Framework Core 2.2
* MySQL + MySQL Workbench version 8.0.15
* JavaScript
* Swagger + NSwag
* CSS
* HTML
* Bootstrap
* Git


## Known Bugs
I have not rigged up functionality for the Add New Store button yet, but everything else works.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at 
* jamisoncozart@gmail.com

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart
