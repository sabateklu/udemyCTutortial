using System;

namespace PointsAndLines
{
    class User
    {
        private string username;
        private int password;

        public int Password {
            set
            {
                if (value > 4 && value < 10)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("oops, this is not a valid password! Please use a password  between 4 and 10");
                }
            }
        }

        public string Username
        {
            get
            {
                return "The username is " + username;
            }
        }


        public User()
        {

        }

        public User(string username)
        {
            this.username = username;
     
        }
    }
}
