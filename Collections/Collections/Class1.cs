using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Class1
    {
        // 1.1 Reverse with queue
        public static Queue<int> ReverseWithQueue(int[] Arr)
        {
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> reverseQueue = new Queue<int>();
            foreach(int x in Arr)
                queue.Enqueue(x);

            foreach (int x in queue)
                stack.Push(x);

            foreach (int x in stack)
                reverseQueue.Enqueue(x);

              foreach(int x in reverseQueue)
                   Console.WriteLine(x);
               Console.ReadKey(); 

            return reverseQueue;
        }

        // 1.2 Reverse with list
        public static List<int> ReverseWithList(int[] Arr)
        {
            List<int> list = new List<int>();
            foreach (int x in Arr)
                list.Add(x);
            List<int> reverseList = Enumerable.Reverse(list).ToList();

            foreach (int x in reverseList)
                Console.WriteLine(x);
            Console.ReadKey(); 

            return reverseList;
        }

        // 1.3 Reverse with dictionary
        public static IEnumerable<KeyValuePair<int, int>> ReverseWithDict(int[] Arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int x in Arr)
                dict.Add(Array.IndexOf(Arr, x), x);

            Dictionary<int, int> reverseDict = new Dictionary<int, int>();
            foreach (var x in dict)
            {
                if (!reverseDict.ContainsKey(x.Value))
                {
                    reverseDict.Add(x.Value, x.Key);
                }
            }

            var InverseDict = reverseDict.Reverse();

             Console.WriteLine(String.Join(", ", InverseDict));
              Console.ReadKey(); 
          
           return InverseDict;
        }
    }
}
