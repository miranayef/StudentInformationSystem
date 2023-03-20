using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserLogin
{
    public class User
    {
        public String Username
            { get; set; }
        public String Password
            { get; set;}
        public String FakNum
            { get; set;}
        public Int32 Role
            { get; set;}
        public DateTime CreateTime
            { get; set;}
        public DateTime ValidToDate
            { get; set;}

        public User(string username, string password, string fakNum, int role, DateTime creationDate, DateTime validToDate)
        {
            Username = username;
            Password = password;
            FakNum = fakNum;
            Role = role;
            CreateTime = creationDate;
            ValidToDate = validToDate;
        }

        public override string ToString()
        {
            return "User: " + Username + " with UID: " + FakNum + " deactivation date: " + ValidToDate;
        }
    }
}
