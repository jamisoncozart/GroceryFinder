# Grocery Finder
### By **Jamison Cozart**  April 3rd 2020

API for local grocery stores in your area to find information on store hours, delivery details, and other essential information for retrieving your necessities.

## Specifications 

### API Endpoints

|Method|Route|Response|
|:-:|:-:|:-:|:-:|
| GET | /api/stores | Show all stores with key information for each |
| POST | /api/stores | Create new store | <-- Requires JSON store object sent in body of request
| GET | /api/stores/{storeId} | Show all details about specific store |
| PUT | /api/stores/{storeId} | Edit information on already existing store |
| DELETE | /api/stores/{storeId} | Delete a specific store |

_For interactive documentation of API Endpoints, follow the **Installation + Setup** instructions and visit `http://localhost:5000/`_

## Getting Started

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
* MySQL
* JavaScript
* CSS
* HTML
* Bootstrap
* Git


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at 
* jamisoncozart@gmail.com

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart