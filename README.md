# App launcher

- Build the app by writing the scheme of the msi (installable pack) in Launch.cs.
- Also write the name of the exe file(in install.cs), in this case we are considering install.exe .
- Create an MSI installable using advance installer and put it on the website using advance installer with registry and URL scheme.
- Build install.exe as a web based installer with the help of advance installer (https://www.advancedinstaller.com/user-guide/qa-web-installation.html)
- Put the URL of MSI installer while building exe in advance installer.
- Put the install.exe and the applauncher exe in the same folder and Zip it.
- Create an Html page and deployed it on web(gitub.io or netlify) and put the Url on webbrowser(from tool box)in visual studio in desiger to show the special message like update has arrived etc to the user. In this way programmer can change the message they want to show which gives them a huge liberty. 
- Note - setup file, exe and msi are to build as it to be asked what files the user want to be install first and what is the name of URL registry user want to have. Load.html has been provied but client needs to provide the message they want to show apart from "update has arrived" and link should be put in the webbrowser in designer of visual C#.

## Tech Used 

- Visual C#
- Advance installer (Visual studio plugin as well as application)(in this case i have used application)
