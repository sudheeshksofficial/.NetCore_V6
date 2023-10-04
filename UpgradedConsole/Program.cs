// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
*/
using System;



namespace UpgradedConsole
{

    /*class Program
    {
        public string? Name;
        public string? Description { get; set; }

        //int const c= a + b;

        //int d = 1;
        //int const c= d + b;

        public static void Main()
        {
            const int  a = 10;
            const int b = 20; // correct
            int d = 1;
*//*            const int c = d + b;*//*

            Program obj = new()
            {
                Name = "test",
                Description = "test"
            };
            Subclass sb = new();
            sb.Value = 786;
            Console.WriteLine(sb.Value.ToString());
        }
    }*/


    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of entries : ");
            int temp = int.Parse(Console.ReadLine());

            Railway railwayObject = new();

            List<Railway> railwayObjectList = new();

            for (int i = 1; i <= temp; i++)
            {
                Console.WriteLine("train id : ");
                int tempid = int.Parse(Console.ReadLine());
                Console.WriteLine("train number : ");
                int tempNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter trian name : ");
                string? tempName = Console.ReadLine();
                Console.WriteLine("Train start date : ");
                DateTime start = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Train end date : ");
                DateTime end = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter scheduling name : ");
                string? tempschedule = Console.ReadLine();

                railwayObjectList.Add(new Railway(tempid, tempNumber, tempName, start, end, tempschedule));

            }

            Subclass obj= new Subclass();
            obj.Operation(railwayObjectList);

        } 
    }

    
}