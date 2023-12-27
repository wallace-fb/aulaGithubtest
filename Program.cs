namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite número a serem somados");

            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"0 resultado da soma é {Soma(n1,n2)}");


            Console.WriteLine("Aperte enter para finalizar o progrma");

            Console.WriteLine();
            

            
        }

        public static int Soma (int n1, int n2)
        {
            return n1 + n2; 
        
        
        }


    }
}
