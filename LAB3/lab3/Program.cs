using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var grant = new Grant();
           
            var answer = "start";
            do
            {
                grant.PrintState();
                do
                {
                    Console.Write("Do you want to change grant state?(y/n): ");
                    answer = Console.ReadLine();
                    
                } while (answer != "Y" && answer != "y" && answer != "N" && answer != "n");

                if (answer == "Y" || answer == "y")
                {
                    grant.ChangeState();
                }

            } while (answer == "Y" || answer == "y");

        }
    }
}