using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1, entrada2;
            double peso, altura, IMC;

            Console.WriteLine("--Calcule seu IMC--");
            Console.WriteLine();
            Console.Write("Sua altura(m): ");
            entrada1= Console.ReadLine();
            Console.Write("Seu peso(kg): ");
            entrada2= Console.ReadLine();

            peso= Convert.ToDouble(entrada2);
            altura= Convert.ToDouble(entrada1);

            IMC= peso/(Math.Pow(altura,2));

            Console.Beep();
            Console.WriteLine($"IMC: {IMC} kg/m²");
        }
    }
}
