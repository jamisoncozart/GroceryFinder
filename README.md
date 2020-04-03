# Grocery Finder
### By **Jamison Cozart**  April 3rd 2020

API for local grocery stores in your area to find information on store hours, delivery details, and other essential information for retrieving your necessities.

## Specifications 

### user stories:

|Behavior|Input|Output|
|:-:|:-:|:-:|
||||

### API Endpoints

STORES
```
GET /api/stores
POST /api/stores
GET /api/stores/{storeId}
PUT /api/stores/{storeId}
DELETE /api/stores/{storeId}
```

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

## Technologies Used

* C#
* .NET webAPI Framework 2.2
<!-- * Newtonsoft.Json -->
* Git


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at 
* jamisoncozart@gmail.com

## License

Licensed under the MIT license.

&copy; 2020 - Jamison Cozart