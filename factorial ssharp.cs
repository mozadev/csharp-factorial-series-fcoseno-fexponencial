using System;

namespace Luis
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            n = ingresan();
            x = ingresax();
            double fcos = FCos(n, x);
            double fExpo = FExpo(n, x);
            String fcoss = fcos.ToString();
            String fexpo = fExpo.ToString();
            Console.WriteLine("FCos: "+ fcoss);
            Console.WriteLine("FExpo: " + fexpo);
        }
        static int ingresan()
        {
            int n;
            Console.WriteLine("Ingrese n: ");
            n = int.Parse(Console.ReadLine());

            return n;
        }

        static int ingresax()
        {
            int x;
            Console.WriteLine("Ingrese x: ");
            x = int.Parse(Console.ReadLine()) ;

            return x;
        }


        static int funcionfactorial(int n)
        {
            int result = 1;
            for (int i = 1; i < n; i++)
                result = result * i;
            return result;
        }


        static double FCos(int n, int x)
        {
            double suma = 0;
            for (int i = 1; i <= n; i++)
                suma = suma +Math.Pow(-1,i)* Math.Pow(x, 2*i) / (funcionfactorial(2*i));

            return 1+suma;

        }


        static double FExpo(int n, int x)
        {
            double suma = 0;
            for (int i = 1; i <= n; i++)
                suma = suma + Math.Pow(x, i) / (funcionfactorial(i));

            return 1+suma;

        }


    }
}
