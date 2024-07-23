namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = [1, 2, 3, 4, 5, 6, 7];
            // LINQ to iterate

            // query syntax
            // from range_variable in collection/array
            // select range_variable
            var list = from x in num
                       select x;
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
            var evennumbers = from x in num
                              where x % 2 == 0
                              select x;
            Console.WriteLine("even numbers");
            foreach (var x in evennumbers) 
                Console.WriteLine(x);

            var oddnyumbers= from x in num
                             where x%2!=0
                             select x;
            Console.WriteLine("odd numbers");
            foreach (var x in oddnyumbers)
                Console.WriteLine(x);

            int sum = (from x in num
                      select x).Sum();
            Console.WriteLine("SUm is  " + sum);

            int max = (from x in num
                       select x).Max();
            Console.WriteLine(max);

            List<string> names = new List<string>()
                {
               "ajay sood",
               "deepak kumar",
               "ravi kapoor",
               "meena devi",
               "lalita devi"
           };

            var listnames = from x in names
                            select x;

            foreach(string name1 in listnames)
                Console.WriteLine(name1);

            var found = (from x in names
                         where x.Contains("ravi kapoor")
                         select x);
           
            // Linq uses 2 ways to execute Query
            // Eager Loading
            // Lazy Loading

            // Lazy loading

            var nums = (from x in names
                        select x);
            
            // eager loading
            var nums1 = (from x in names
                        select x).ToList();


            // search a name in a list

            var name = (from x in names 
                        where x.Contains("ravi kapoor")
                       select x).FirstOrDefault();
            if (name != null)
                Console.WriteLine("name is " + name);
            else
                Console.WriteLine("no name");

            // Method Syntax
            var num2 = num.ToList();

            var names2 = names.ToList();

            // find name 
            var namefound = names.FirstOrDefault(x => x.Contains("ravi kapoor"));

            var evennumn = num.Where(x=>x%2==0).ToList();


        
        }
        
    }
}