
namespace ConsoleAppSkillfactory
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(3, 0));
            Console.WriteLine(Factorial(20));


            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }

        static void Echo(string str, int deep)
        {
            string modif = str;
            if(modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            
            
            if (deep > 1) {
                Echo(modif, deep - 1); 
            }
        }
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if(pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N,--pow);
                }
            }
        }

    
    }
}
