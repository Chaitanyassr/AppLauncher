# App launcher

- Build the app by writing the scheme of the msi (installable pack) in Launch.cs.
- Also write the name of the exe file(in install.cs), in this case we are considering install.exe .
- Create an MSI installable using advance installer and put it on the website using advance installer with registry and URL scheme.
- Build install.exe as a web based installer with the help of advance installer (https://www.advancedinstaller.com/user-guide/qa-web-installation.html)
- Put the URL of MSI installer while building exe in advance installer.
- Put the install.exe and the applauncher exe in the same folder and Zip it.
- Note - setup file, exe and msi are to build as it to be asked what files the user want to be install first.
