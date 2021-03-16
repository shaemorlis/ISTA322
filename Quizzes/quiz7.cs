using System;

namespace CSharpQuiz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is CSharp Quiz 07.");
            IFirearm Shotgun = new Shotgun();
            Shotgun.Say("shotgun", "Boom");
            IFirearm Rifle = new Rifle();
            Rifle.Say("rifle", "Bang");
            IFirearm Pistol = new Pistol();
            Pistol.Say("pistol", "Pop");
        }
        interface IFirearm
        {
            void Say(string type, string action);
        }
        private class Shotgun : IFirearm
        {
            public void Say(string type, string action)
            {
                Console.WriteLine($"I am a {type} and I go {action}");
            }
        }
        private class Rifle : IFirearm
        {
            public void Say(string type, string action)
            {
                Console.WriteLine($"I am a {type} and I go {action}");
            }
        }
        private class Pistol : IFirearm
        {
            public void Say(string type, string action)
            {
                Console.WriteLine($"I am a {type} and I go {action}");
            }
        }
    }
}
