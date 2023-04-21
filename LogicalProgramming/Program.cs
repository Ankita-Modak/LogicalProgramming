using LogicalProgramming.Vending_Machine;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run-");
            Console.WriteLine("1. Vending Machine");
            Console.WriteLine("2. Reverse No.");
            Console.WriteLine("3. Fibonacci Series");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    vendingmc vendingmc = new vendingmc();
                    vendingmc.GetNotes();
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;

            }
        }
    }
}