using System;
using System.Collections.Generic;

namespace ListNotes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>(){1,2,3,4};
			foreach (var num in numbers)
			{
				Console.WriteLine("Intial List: " + num);
			}


            //Add
            numbers.Add(1);
			foreach (var num in numbers)
			{
				Console.WriteLine("List after Add method: " + num);			
            }
        


            //AddRange
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var num in numbers) 
            {
                Console.WriteLine(num);
            }

            //IndexOF - gets the first instance (begins at the beginning)
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            //LastIndexOf - gets the last instance (begins at the end)
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("Count: " + numbers.Count);

            //Remove - removes first instance
            numbers.Remove(1);
			foreach (var num in numbers)
			{
				Console.WriteLine(num);
			}

            for (var i = 0; i < numbers.Count;i++)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var num in numbers) 
            {
                Console.WriteLine(num);
            }


            //Clear
            numbers.Clear();
			Console.WriteLine("Count: " + numbers.Count);




		}
    }
}
