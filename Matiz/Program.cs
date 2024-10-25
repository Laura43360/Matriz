
        using System;
        using BibliotecaMatriz;
class Program
{ 
        static void Main()
        {
            int linhas, cols;
            Console.WriteLine("**** Matrizes ****");
            Console.WriteLine("Qtde de linhas e colunas:");
            linhas = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[linhas, cols]; // criando
            Console.WriteLine("Gerando dados para a matriz:");
            Matriz.gera(matrix);
            Console.WriteLine("Dados da matriz:");
            Matriz.mostra(matrix);
            Console.ReadKey();
        }

}


