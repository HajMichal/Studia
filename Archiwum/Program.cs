using System;

namespace ProstyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                playWithAccount();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Coś poszło nie tak: {e.Message}");
                Console.ReadKey();
            }
        }

        static public void playWithAccount()
        {
            // Wywoływanie wszystkich operacji na koncie

            Console.ReadKey();
        }

    }
}
