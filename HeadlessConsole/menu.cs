// This file controls the logic to the main menu 

using System; 
using System.Console;
using System.string;
using System.IO;
using System.IO.File;
using System.Collections;
using namespace JWMiller;
using namespace JWMiller.Transform;

namespace normNamespace 
{
    public class Menu ()
    {
        // Defining Constant Variables
        // This section is used for words related to a certain command (listed above list)
        //      Add to the list if you think there is something that should also be added, 
        //      just make sure that it isn't already another command.  Also know that there
        //      is the ability to install more commands (currently being added), so the 
        //      alternate method of adding to these lists is to write an install file and 
        //      install said file
        // Shutdown commands
        const List<string> sd_list = ["exit", "shutdown", "shut down", "e", "sd"];
        // Logout Commands 
        const List<string> lo_list = ["log out", "logout", "l", "|0", "log"];
        // Help Commands
        const List<string> helpList = ["help", "h", "assist"];
        // Admin Help file path
        const string AdminHelp = "Main Files/Help Files/AdminHelp.txt";
        // Normal Help file path
        const string NormalHelp = "Main Files/Help Files/Help.txt";
        // README file path
        const string ReadMePath = "README";
        // Main Controller When Logged Out 
        public static void main ()
        {
            private UserModel User = CheckLogIn.main();
            Menu.menu(User);
        }
        // Main Headless UI Once Logged In
        public static void menu (UserModel UserInfo)
        {
            // Define Variables
            private string input;
            // Current Local Base Count (LBC) Variable
            private int count;
            // Current Boolean that is used to check if the user wants to continue
            // (The difference between logging out and shutting down)
            private bool contBool = true;
            private int wrong = 0;
            WriteLine("Welcome " + UserInfo.DisplayName);
            WriteLine("You have successfully logged in to you account");
            while (UserInfo.LoggedIn) // While the user is logged in, this section repeats
            {
                // Main logic controller, add options by adding logic lists or installing new file
                input = Console.ReadLine();
                // Main System Commands
                input = input.ToLower();
                if (sd_list.Contains(input))
                {
                    wrong = 0;
                    // Shutdown commands
                    UserInfo = new UserModel();
                    contBool = false;
                    break;
                }
                else if (lo_list.Contains(input))
                {
                    // Log Out commands
                    UserInfo = new UserModel();
                    contBool = true;
                    wrong = 0;
                    break;
                }
                // User Assistance Commands
                else if (helpList.Contains(input))
                {
                    // Display User Help 
                    if (UserInfo.Admin)
                    {
                        // Admin Help
                        WriteLine(ListToString(FileToList(AdminHelp), "\n", "\n\n"));
                    }
                    WriteLine(ListToString(FileToList(NormalHelp), "\n", "\n\n"));
                    WriteLine(ListToString(FileToList(ReadMePath), "\n", "\n\n"))
                    wrong = 0;
                }
                // 
                else if ()
                {

                }
                // Automatic Calling of the Help Command
                else 
                {
                    // What occurs when the user typed commands that are not 
                    //      recognized
                    wrong += 1;
                    if ((wrong >= 3) && (wrong < 5))
                    {
                        WriteLine("Enter \"help\" to see commands");
                    }
                    if (wrong >= 5)
                    {
                        WriteLine(ListToString(FileToList(NormalHelp), "\n", "\n\n"));
                    }
                }
            }
            if (contBool)
            {
                // If Logging Out
                Menu.main();
            }
            else 
            {
                // If Shutting Down
                break;
            }
        }
    }
}