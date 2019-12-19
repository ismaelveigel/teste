using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;
using System.Globalization;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe o tamanho da matriz, linhas colunas");
            string[] values = Console.ReadLine().Split(' ');
            int n = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            int[,] matriz = new int[n, m];
            Console.WriteLine("Digite 3 valores separados por espaço");
            for (int i = 0; i < n; i++) {
                String[] valores = Console.ReadLine().Split(' ');  
                for (int j = 0; j < m; j++) {
                    matriz[i,j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Informe o valor a ser buscado");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] == x) {
                        if (i < n) { 
                            Console.WriteLine("Down : " + matriz[i+1,j]);
                        }
                        if (j > 0){
                            Console.WriteLine("Left : " + matriz[i, j - 1]);
                        }
                        if (j < m) {
                            Console.WriteLine("rigth : " + matriz[i,j+1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up : " + matriz[i-1,j]);
                        }
                    }
                }
            }


        }
    }
}