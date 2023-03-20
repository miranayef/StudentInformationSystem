using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private string username;
        private string password;
        private string errorMessage;
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError actionOnError;

        public LoginValidation(string username, string password, ActionOnError actionOnError)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = actionOnError;
        }

        static public UserRoles currentUserRole
        {
            get;
            private set;
        }
        static public string currentUserUsername
        {
            get;
            private set;
        }
        public bool ValidateUserInput(ref User user)
        {
            if (username.Equals(string.Empty)) {
                errorMessage = "Username is empty";
            }
            else if (password.Equals(string.Empty))
            {
                errorMessage = "Password is empty";
            }
            else if (username.Length <= 5)
            {
                errorMessage = "Name should be longer than 5 symbols";
            }
            else if (password.Length <= 5)
            {
                errorMessage = "Password should be longer than 5 symbols";
            }

            if (errorMessage != null)
            {
                currentUserRole = UserRoles.ANONYMOUS;
                actionOnError(errorMessage);
                return false;
            }

            user = UserData.IsUserPassCorrect(username, password);

            if (user == null)
            {
                errorMessage = "Invalid username or password.";
                actionOnError(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                currentUserUsername = null;
                return false;
            }

            currentUserRole = (UserRoles)user.Role;
            currentUserUsername = user.Username;
            Logger.LogActivity("[USER] User: " + user.Username + " logged in!");
            return true;
        }
    }
}
