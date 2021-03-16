using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> myStrStack = new Stack<string>();
            Queue<String> myStrQueue = new Queue<string>();
            Dictionary<String, int> myDictionary = new Dictionary<string, int>();

            myStrStack.Push("One");
            myStrStack.Push("Two");
            myStrStack.Push("Three");

            myStrQueue.Enqueue("One");
            myStrQueue.Enqueue("Two");
            myStrQueue.Enqueue("Three");

            myDictionary.Add("One",1);
            myDictionary.Add("Two",2);
            myDictionary.Add("Three",3);


            Console.WriteLine("This is C Sharp quiz 9");

            Console.WriteLine("Here is the stack");
            foreach (string item in myStrStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Here is the queue");
            foreach (string item in myStrQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Here is the dictionary");
            foreach (KeyValuePair<string,int> keyValPair in myDictionary)
            {   
                Console.WriteLine("{0} {1}", keyValPair.Key, keyValPair.Value);
            }

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();

        }
    }
}
