using System;

namespace microwave
{
    class microwave
    {
        static void Main(string[] args)
        {
            int items, time;
            Console.WriteLine("How Many items would you want to heating: ");
            items = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How long do you want to heating time: ");
            time = Convert.ToInt32(Console.ReadLine());

            if (items == 1)
            {
                Console.WriteLine("The heating time is" + " " + time.ToString());
            }
            else if (items == 2)
            {
                Console.WriteLine("The heating time is" + " " + ((time / 2) + time).ToString());

            }
            else if (items == 3)
            {
                Console.WriteLine("The heating time is" + " " + ((time * 2).ToString()));
            }
            else
            {
                Console.WriteLine("Not recommended to heating three more items");
            }
            Console.ReadLine();
        }
    }
}
