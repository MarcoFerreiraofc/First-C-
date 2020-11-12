using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome"); 
            string a = Console.ReadLine(); 
            Console.WriteLine("Bem vindo: " + a);

        
            Console.WriteLine("Digite o primeiro numero");  
            int numero1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Digite o segundo numero");
            int numero2 = int.Parse(Console.ReadLine()); 

            int resultado = numero1 + numero2; 

            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
        }
    }
}
