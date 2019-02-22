using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversao
{
    class CriaArquivo:Program
    {
        public static string[,] matriz = new string[tamanho, tamanho];

        public static void SalvaArquivo()
        {
            string[] ultimaLetra = new string[tamanho];
            matriz = preencheMatriz(frase);
            Console.WriteLine("O arquivo foi gerado com sucesso!");
            StreamWriter saida = new StreamWriter("C: \\Users\\GGX_L\\Desktop\\Inversao\\Saidas\\encode4.out");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    ultimaLetra[i] = matriz[i, j];
                    saida.WriteLine(ultimaLetra[i]);

                }
            }

            saida.Close();
            //return teste;
        }

        public static void PegaUltimaLetra()
        {
            string[] ultimaLetra = new string[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    ultimaLetra[i] = matriz[i, matriz.Length];
            

                }

                Console.WriteLine(ultimaLetra);
            }
        }


    }
}
