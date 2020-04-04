# Master AnimalShelterInterface
### By **Keturah Howard**  April 3rd 2020

ASP.NET core MVC application to create an interface to interact with the [MasterAnimalShelter](https://github.com/KeturahDev/MasterAnimalShelter) Api.
This Application is about an animal shelter where but with a twist- These animals are more powerful than you and when you adopt you are submitting to serve them through life! Wha-oh! Very fun. View the pre-existing legends, and then go ahead an add some of your own!

## Specifications 

### user stories:

* As a user, I want to be able to GET all Animals.
* As a user, I want to be able to GET details of Animals (type, personality, gender, age, availability status, mainatainance level).
* As a user, I want to be able to POST Animals.
* As a user, I want to be able to PUT Animals.
* As a user, I want to be able to Delete Animals.


## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

In terminal, located in your desktop directory...

1. Clone the repository:
    ```
    git clone https://github.com/KeturahDev/AnimalShelterInterface.Solution.git
    ```

2. Open repo in VSCode - Do so manually, or type into terminal:
    ```
    Code AnimalShelterInterface.Solution
    ```

### Application Setup

**Please first follow along with the API set up found [here](https://github.com/KeturahDev/MasterAnimalShelter)**

3. Change into the root directory 
    ```
    cd AnimalShelterInterface
    ```
2. Restore all dependencies:
    ```
    dotnet restore
    ```
3. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
 ### Opening the Program
 
 open the **localhost:5010** link that shows in the terminal, and enjoy!


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Newtonsoft.Json
* Git
* Entity Framework Core
* Swashbuckle 5.2.1
* Pomelo.EntityFrameworkCore.MySql 2.2.1
* MySqlConnector

## External Assets
* MySqlWorkBench
* Postman


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at 
* keturah.dev@gmail.com.


## License

Licensed under the MIT license.

&copy; 2020 Keturah Howard.
