//Entrada
//A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

//Saída
//Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

using System;

class Desafio
{
    static void Main()
    {
        int lim = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < lim; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double divisao = X / Y; 
                Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}
