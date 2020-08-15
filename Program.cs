using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            PropriedadeLados propriedadeLados = new PropriedadeLados();
            Console.WriteLine("Digite o primeiro lado do triângulo:");
            propriedadeLados.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado do triângulo:");
            propriedadeLados.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado do triângulo:");
            propriedadeLados.c = Convert.ToDouble(Console.ReadLine());
            if (Verification.Verify(propriedadeLados))
                Console.WriteLine("É um triângulo.");
            else
                Console.WriteLine("NÃO é um triângulo.");
            
        }
    }
}
