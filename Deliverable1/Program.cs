namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");

            string stg = "Hello, World! (2)";
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);


            Console.WriteLine("Enter the user's age ");
            //int age = Convert.ToInt32(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);
        }   
    }
}