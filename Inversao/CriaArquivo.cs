using System;
using System.IO;
using System.Collections;

namespace Inversao
{
    class CriaArquivo : Program
    {
        public static string[,] matriz = new string[tamanho, tamanho];
        public static int aux2 = 0;
        public static ArrayList ultimasLetras = new ArrayList();


        public static ArrayList matrizParaAL(string[,] matriz)
        {

            string aux = "";
            int novoTamanho = 0;
            StreamWriter saida = new StreamWriter("C: \\Users\\GGX_L\\Desktop\\Inversao\\Saidas\\encode" + aux2++ + ".out");

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {

                    aux = matriz[i, j];
                    if (aux != "")
                    {
                        novoTamanho = aux.Length;
                        string letter = aux.Substring(novoTamanho - 1);
                        ultimasLetras.Add(letter);
                    }
                }
                i = tamanho;

            }

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++) { }
                saida.Write(ultimasLetras[i]);
            }
            saida.Close();
            Console.WriteLine("O arquivo foi gerado com sucesso!");
            return ultimasLetras;
            
        }        
    }
}


