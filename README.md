# FSA_EMRS : Fr. Simpliciano Academy Electrical Medical Record System (Sample)
This is an application I made for my 10th Grade Project. It is ***not*** being used at my school. This application was created for educational purposes only.

## About project status
This project is not being maintained. I have uploaded the source files here for documentating the progression of my career. I have no plans of continuing this project as I think past me has done a sufficient job in the development of this application for his skill level back then. 

## Download
To download and install the application, do the following steps:
1. Go to the "Releases" tab of this Github repository.
2. Download the "FSA_EMRS_v1_0_0_0_Setup.zip" file.
3. Extract the downloaded ZIP file.
4. Run the "setup.exe" file to install the application.

**Note:** This application requires Microsoft .NET Framework v4.8 to work.

## About admin accounts
The application tries to load user accounts from the AppData/Accounts folder on the user's desktop. The application creates this folder on first startup and when it doesn't find any user account files inside the directory, it shows a pop-up claiming that there are no user accounts to load. This behavior is normal.

The application doesn't actually have any hardcoded admin login credentials. In order to see the admin functionality, you need to create an admin account first.

In order to create an admin account, do the following steps:
1. If you haven't already, download the application source code by cloning the repository.
2. Go to SubPage_register2.vb then make sure that on line 59, isAdmin is being set to true.
3. Run the application and create a user account through the register form. The account created by this will have admin privileges.
4. You can now close the application or continue using it.