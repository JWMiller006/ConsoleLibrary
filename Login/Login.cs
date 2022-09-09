// This is a C# Login Logic Scaffolding File 
// There are certain things that are marked for change based off of context
//      And obviously the 'WriteLine' & 'ReadLine' are System.Console functions
//      which means that to change the UI IO, you should make similar functions 
//      that have the same type of logic and switch them out

using System; 
using System.Console;
using System.string;
using System.IO;
using System.IO.File;
using System.Collections;

// Root Namespace (Used in the majority of the program)
namespace normNamespace ()
{
    public class LogIn_ ()
    {
        // Main UI and User Interactions
        public static UserModel main()
        {
            private bool LogInChecker = false;
            private UserModel TempInfo;
            WriteLine("Hello there\nWelcome to the VS Code C# Console.");
            while (LogInChecker == false){
                WriteLine("Enter your credentials (Type \"Exit\" to exit):");
                WriteLine("Enter Username:");
                TempInfo.Username = Console.ReadLine();
                if (TempInfo.Username.ToLower() == "exit")
                {
                    break;
                }
                Write("Enter Password: \n\t");
                TempInfo.Password = ReadLine();
                TempInfo = LogIn.CheckLogIn(TempInfo);
                if (TempInfo.LoggedIn == true)
                {
                    return TempInfo;
                }
                else 
                {
                    Console.WriteLine("The information that you have entered is incorrect, try again");
                }
            }
            break;
        } 
    }
    // Contains Logic for Checking Login with just the 
    //      username and password in the UserModel and
    //      outputs it in terms of another UserModel
    public class LogIn ()
    {
        // Main Logic for logging in
        // Streamlined to provide the fastest time to login
        public static UserModel CheckLogIn (UserModel temp)
        {
            private string UserInfoPath = "UserInfo";
            private string UsernamePath ="UserInfo/username.txt";
            private string PasswordPath = "UserInfo/password.txt";
            private string AdminPath = "UserInfo/admin.txt";
            private string DisplayNamePath = "UserInfo/display_names.txt";
            private string FilePathPath = "UserInfo/user_file.txt";
            private int count = 0;
            private List<string> usernames = [];
            private List<string> passwords = [];
            private List<string> adminList = [];
            private List<string> DisplayNameList = [];
            private List<string> FilePathList = [];
            foreach (var line in File.ReadLines(UsernamePath))
            {
                usernames.addRange(line);
            }
            foreach (var line in File.ReadLines(PasswordPath))
            {
                passwords.addRange(line);
            }
            foreach (var line in File.ReadLines(AdminPath))
            {
                adminList.addRange(line);
            }
            foreach (var line in File.ReadLines(DisplayNamePath))
            {
                DisplayNameList.addRange(line);
            }
            foreach (var line in File.ReadLines(FilePathPath))
            {
                FilePathList.addRange(line);
            }
            foreach (var item in usernames)
            {
                count++;
                if (temp.Username == usernames[count])
                {
                    if (temp.Password == passwords[count])
                    {
                        if (adminList[count] == "true")
                        {
                            temp.Admin = true;
                        }
                        else 
                        {
                            temp.Admin = false;
                        }
                        temp.LoggedIn = true;
                        temp.DisplayName = DisplayNameList[count];
                        temp.FileRootPath = FilePathList[count];
                        return temp;
                    }
                }
            }
        }
    }
}

// This is the link to the actual program, which calls this file
//Menu.main();