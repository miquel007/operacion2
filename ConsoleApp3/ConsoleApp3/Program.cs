using System;

namespace ConsoleApp3
{
    class Program
    {
        //Programa per llegir numeros per pantalla i fer operacions
        static void Main(string[] args)
        {


            Console.WriteLine("Escrive un numero");
            string Ntrap = Console.ReadLine();
            int num1 = Convert.ToInt32(Ntrap);

            Console.WriteLine("Escrive un numero no entero");
            string Mtrap = Console.ReadLine();
            double num2 = Convert.ToDouble(Mtrap);

            Console.WriteLine("Escriva una letra");
            string Ptrap = Console.ReadLine();
            char num3 = Convert.ToChar(Ptrap);

            double op1 = num1 + num2;
            double op2 = num2 - num1;
            int op3 = Convert.ToInt32(num3);


            Console.WriteLine("Variable N = " + num1);
            Console.WriteLine("Variable A = " + num2);
            Console.WriteLine("Variable C = " + num3);
            Console.WriteLine("{0} + {1} = {2} ", num1,num2,op1);
            Console.WriteLine("{0} - {1} = {2} ", num2, num1, op2);
            Console.WriteLine("Valor numerico del caracter {0} = {1} ", num3,op3);



        }
    }
}
