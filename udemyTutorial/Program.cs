using System;
using PointsAndLines;

namespace udemyTutorial
{


    class EntryPoint
    {
        static void Main()
        {
            User user = new User("Saba");

            Console.WriteLine(User.currentID);

            User userTwo = new User("hilla");
            Console.WriteLine(User.currentID);
            Console.WriteLine(user.id);
            Console.WriteLine(userTwo.id);

        }
    }
}
