using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCode
{
    class RevisedCode
    {   /// <summary>
    /// outputs a prompt for input and returns the input string
    /// </summary>
    /// <param name="prompt"></param>
    /// <returns></returns>
        public static string Readstring(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine(">> ");
            return Console.ReadLine();
        }
        /// <summary>
        /// return length of the longest list in dictionary
        /// </summary>
        /// <param name="tasks"></param>
        /// <returns></returns>
        static int Maxlength(Dictionary<string, List<string>> tasks)
        {
            return tasks.Values.Max(list => list.Count);
        }

        static void PrintTasks(Dictionary<string, List<string>> tasks)
        {
            int max = Maxlength(tasks);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 12) + "CATEGORIES");
            Console.WriteLine(new string(' ', 10) + new string(' ', 94));
            Console.WriteLine("{0,10}|", "Item #");
            foreach (var category in tasks.Keys)
            {
                Console.Write("{0,30}|", category);
            }
            Console.WriteLine();
            Console.WriteLine(new string(' ', 10) + new string('-', 94));
            for(int i = 0; i<max; i++)
            {
                Console.Write("{0,10}", i + 1);
                foreach(var list in tasks.Values)
                {
                    if (list.Count > 1)
                    {
                        Console.Write("{0,30}", list[i]);
                    }                        
                    else
                    {
                        Console.Write("{0,30}", "N/A");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void main(string[] args)
        {
            var tasks = new Dictionary<string, List<string>>();
            tasks["Personal"] = new List<string>();
            tasks["Works"] = new List<string>();
            tasks["Family"] = new List<string>();

            string category;
            string task;

            while (true)
            {
                Console.Clear();
                PrintTasks(tasks);

                category = Readstring("\nWhich category do you want to place " +
                    "a new task? Type \'Personal\', \'Work\', \'Family\', or \'Quit\'  ");
                if (category.ToLower() == "Quit")
                    break;

                task = Readstring("Describe your task below (max. 30 symbols)");
                if (task.Length >30)
                {
                    task = task.Substring(0, 30);
                }
                try
                {
                    tasks[category].Add(task);
                }
                catch (ArgumentException)
                {
                    continue;  // IF CATEGORY IS NOT PRESENT, add no task;
                }
            }
        }
    }
}
