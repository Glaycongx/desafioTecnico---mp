using System;
using System.IO;

namespace Inversao
{
    class CriaArquivo : Program
    {
        public static string[,] matriz = new string[tamanho, tamanho];

        public static void SalvaArquivo()
        {
            string[] ultimaLetra = new string[tamanho];
            matriz = preencheMatriz(frase);
            Console.WriteLine("O arquivo foi gerado com sucesso!");
            StreamWriter saida = new StreamWriter("C: \\Users\\GGX_L\\Desktop\\Inversao\\Saidas\\encode.out");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    ultimaLetra[i] = matriz[i, j];
                    saida.WriteLine(ultimaLetra[i]);

                }
            }

                saida.Close();
                
            }
        }
    }


