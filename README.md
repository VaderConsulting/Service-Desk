# Service Desk

VB.NET Windows Forms WinExe from the Empired era that lodges a service-desk problem while filling user and computer details from the environment and Active Directory. On load it reads `USERNAME`, `USERDOMAIN`, `COMPUTERNAME` and `LOGONSERVER`, then queries AD (`System.DirectoryServices` plus `ActiveDs.ADSystemInfo`) for display name, phone, mobile, company, user and computer groups, AD site, and IP addresses. The window title is **Empired Service Desk - Problem lodgement** and the form shows the Empired logo (`Empired Transparent.png`).

**Source last updated:** 2008-02-27  
**Language:** VB.NET  
**Target:** Visual Studio 2008 / .NET 2.0  
**Output:** WinExe

## How to open

Open `Service Desk.sln` in Visual Studio.

## License

MIT License. Copyright (c) 2026 VaderConsulting. See `LICENSE`. Originally written for Empired; the Empired name remains in the window title and logo.
