<br>
<p align="center">
  <u><big>||  <b>MessageBoard API</b>  ||</big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
    <a href="https://github.com/Magofna68">
        <img src="https://avatars.githubusercontent.com/u/80496559?v=4">
    </a>
<p align="center">Changing the world one line of code at a time.</p>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/Magofna68">
            <strong>Magofna68</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/Magofna68/MessageBoard.Solution/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/Magofna68/MessageBoard.Solution.svg?style=plastic">
        </a>
        ¨
        <a href="https://github.com/Magofna68/MessageBoard.Solution/stargazers">
            <img src="https://img.shields.io/github/license/Magofna68/PierresTreats.Solution?style=plastic">
        </a>
        ¨
        <a href="https://github.com/Magofna68/MessageBoard.Solution/issues">
            <img src="https://img.shields.io/github/last-commit/Magofna68/MessageBoard.Solution?style=plastic">
        </a>
        ¨
        <a href="https://linkedin.com/in/Magofna68">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p>    
</p>

<p align="center">
  <small>Initiated June 10th, 2021.</small>
</p>

<!-- Project Links -->

------------------------------

## 🌐 About the Project
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mollis auctor euismod. Aliquam fermentum, nibh eget semper tincidunt, risus velit viverra mi, ac tincidunt erat lectus id orci.
### 📖 Description
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mollis auctor euismod. Aliquam fermentum, nibh eget semper tincidunt, risus velit viverra mi, ac tincidunt erat lectus id orci.

<!-- ### 🦠 Known Bugs -->


### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [Entity Framework Core v2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger: SquashBuckle v5.6.3](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## Installation Requirements:

### 1) Install .NET Core
* On macOS:
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10:
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

### 2) Install dotnet script
 * Enter the command ``dotnet tool install -g dotnet-script`` in Terminal/PowerShell.

### 3) MySQL Workbench 
#### (or other database to host data) and enter secure password:
 * [Downloaded Here](https://dev.mysql.com/downloads/workbench/).

### 4) Install Postman
* [Download and install Postman](https://www.postman.com/downloads/).

### 5) VS Code

  * i) Code Editor:
     * [Download Here](https://www.npmjs.com/)
  * ii) Download and install into applications folder


## Setup:

  #### i) Cloning

  1) Navigate to project directory
  2) Click the green 'Clone or download' button to copy URL.
  3) Navigate to local repository to host the file.
  4) Use the following command to clone the repository to your local device: 
  * $ git clone '___*Copied URL*___'
  5) Run the following command to enter project: 
  - $ cd '___*Copied URL*___'

  #### ii) AppSettings

  1) Create a new file in the project directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file and update fields in brackets:
  
  ```
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=[3306];database=[project_api];uid=root;pwd=[YourPassword];"
    }
  ```

  #### iii) Database
  1) Navigate to project directory
  2) Run the command `dotnet ef database update` to locally generate database using Entity Framework Core.

  #### Launch the API
  1) Navigate to project directory
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
#### i) To launch the project API with Swashbuckle, run the following command in the Terminal:
`dotnet run`
 #### ii) Click on / hard code the following URL into your browser: `http://localhost:5000/swagger`
________________________________________________
________________________________________________

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query w/ swagger:
```
https://localhost:5000/swagger/index.html
```

#### Sample JSON Response
```
{
    "Id": 14,
    "Name": "John Doe",
    "Street Address": "1111 Epicodus ln NE",
    "City": "Portland",
    "State": "Oregon"
    "Age: "34",
}
```

..........................................................................................

------------------------------

### 🤝 Contribution Info:

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Brandon Magofna](https://www.linkedin.com/in/magofna/) | [Magofna68](https://github.com/LunsfordSpace) |  [Magofna68@gmail.com](mailto:Magofna68@gmail.com) |

------------------------------

