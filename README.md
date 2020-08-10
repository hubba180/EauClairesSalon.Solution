**<h1 align = "center"> Eau Claire's Salon**


**<h3 align="center">Keep track of your network of stylists and their clients!**

<br>

**<h2 align = "center">
  <a href="#✅requirements">Requirements</a> •
  <a href="#💻setup">Setup</a> •
  <a href="#protecting-your-data">Protecting Data</a> •
  <a href="#📫 questions-and-concerns">Q's & C's</a> •
  <a href="#🔧technologies-used">Technologies</a> •
  <a href="#🐛known-bugs">Known Bugs</a> •  
  <a href="#❤️contributors">Contributors</a> •
  <a href="#📘 license">License</a>**

<br>
<h2 align = "center">

**ABOUT**

</p>

_Better description here_


## **✅REQUIREMENTS**

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)


## **💻SETUP**


copy this url to clone this project to your local system:
```html
https://github.com/hubba180/EauClairesSalon.Solution
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd ProjectName
```

Next we'll need to import the sql database by:
* Going into SQL workbench and In the _Navigator > Administration window_, select _Data Import/Restore_ 
* In _Import Options_ select _Import from Self-Contained File_.
* Under _Default Schema to be Imported To_, select the _New_ button and enter: 

```js
kyle_hubbard
```
* Click _OK_, then _Start Import_
* Make sure to update appsettings.json file with your local SQL password here:

```js
pwd=password
```

Then, install the necessary packages with the following command
```js 
dotnet restore 
```
Finally, you can start the program with this command.
```js 
dotnet run 
```

## **PROTECTING YOUR DATA**

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: commit that .gitignore file (this prevents your sensitive information from being shown to others). **⚠️DO NOT PROCEED UNTIL YOU DO!⚠️**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/entity-readme-image.png "Set up instructions")

#### Step 3: **To commit your .gitignore file enter the following commands**

```js
git add .gitignore
```
```js
git commit -m "protect data"
```

#### Step 4: **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

## **🔧Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>


## **🐛Known Bugs**

_**None as of:** 7/31/2020_

<br>


## **❤️The Author**

 [<img src="https://coding-assets.s3-us-west-2.amazonaws.com/img/kyle_hubbard.jpg" width="160px;"/><br /><sub><b>Kyle Hubbard</b></sub>](https://www.linkedin.com/in/k-j-hubbard/)<br />        


<br>

## **📘 License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Kyle Hubbard, Stickerslug Inc._**

