using System;
using PointsAndLines;

namespace udemyTutorial
{


    class EntryPoint
    {
        static void Main()
        {
            User user = new User("Saba");
            user.Password = 5;

            Console.WriteLine(user.Username);
        }
    }
}
