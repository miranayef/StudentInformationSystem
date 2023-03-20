using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            authView();
            baseNavigationView();
        }

        static void baseNavigationView()
        {
            switch (LoginValidation.currentUserRole)
            {
                case UserRoles.STUDENT:
                    Console.WriteLine("Logged in as a Student!");
                    break;
                case UserRoles.ADMIN:
                    Console.WriteLine("Logged in as an Admin!");
                    adminNavigationView();
                    break;
            }
        }

        static void adminNavigationView()
        {
            int option = -1;
            while (option < 0 || option > 5)
            {
                Console.WriteLine("Choose option: ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Change role of user");
                Console.WriteLine("2. Change date of activity of user");
                Console.WriteLine("3. Get list of Users");
                Console.WriteLine("4. View log details");
                Console.WriteLine("5. Current log");
                option = Convert.ToInt32(Console.ReadLine());
            }

            string username;
            switch (option) {
                case 0:
                    return;
                case 1:
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Role: ");
                    int role = Convert.ToInt32(Console.ReadLine());
                    UserData.AssignUserRole(username, (UserRoles) role);
                    break;
                case 2:
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Date (DD/MM/YR): ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    UserData.SetUserActiveUntill(username, date);
                    break;
                case 4:
                    IEnumerable<string> logActivities = Logger.GetAllLogActivities();
                    foreach (string line in logActivities)
                    {
                        Console.WriteLine(line);
                    }
                    break;
                case 5:
                    Console.Write("Filter: ");
                    string filter = Console.ReadLine();
                    List<string> currentLogActivities = Logger.GetCurrentSessionActivities(filter);
                    foreach (string activity in currentLogActivities)
                    {
                        Console.WriteLine(activity);
                    }
                    break;

            }
            adminNavigationView();
        }
        
        static User authView()
        {
            User newUser = null;
            while (newUser == null)
            {
                Console.Write("Username:");
                string username = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine();
                LoginValidation validator = new LoginValidation(username, password, handleLoginFail);
                if (!validator.ValidateUserInput(ref newUser))
                {
                    newUser = null;
                }
            }
            return newUser;
        }

        static void handleLoginFail(string errorMsg)
        {
            Console.WriteLine("Login failed: " + errorMsg + " Retry...");
        }
    }
}
