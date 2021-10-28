using System;
using static System.Console;

namespace tarefa
{
    class Program
    {
        static void Main(string[] args)
        {
                        ;
            WriteLine("Digite o numero da tabuada");
            double num = Convert.ToInt32(ReadLine());

            string[] tabuada =  new string[10];

            for (int i = 1; i <= 10; i++)
            {
                 double r = num * i; 
                 WriteLine(num + "x" +  i + "=" + r );
            }   


        }
    }
}
