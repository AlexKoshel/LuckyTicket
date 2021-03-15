using System;

namespace Lucky_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {           
                Console.Write("Enter ticket number =>");
                var inputString =Console.ReadLine();
                inputString = Validation.TicketValidation(inputString);
                if (inputString != null)
                {
                    if (!Process.GetLucky(inputString))
                    {
                        Console.WriteLine("False");
                    } 
                    else
                    {
                        Console.WriteLine("True");
                    }
                }
                Console.WriteLine("Enter correct ticket number");

            } while (true);
        }
    }
}