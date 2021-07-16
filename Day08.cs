namespace Exercise
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            int i;
            int n = int.Parse(Console.ReadLine());
            var PhoneBook = new Dictionary<string, string>();

            for (i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                string name = s[0];
                string number = s[1];

                PhoneBook.Add(name, number);
            }

            string searchName = "";
            while ((searchName = Console.ReadLine()) != null)
            {
                if (PhoneBook.ContainsKey(searchName))
                {
                    Console.WriteLine(searchName + "=" + PhoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
