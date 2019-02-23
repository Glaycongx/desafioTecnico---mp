﻿using System;
using System.Collections;

namespace Inversao
{
    class Palavra : Program
    {
        public static ArrayList OrdenaMatriz(string[,] matriz)
        {
            ArrayList palavrasF = new ArrayList();
            string[] letrasF = new string[tamanho];
            string palavraF = "";
            int a = matriz.Length;

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    letrasF[j] = matriz[i, j];
                }

                foreach (var item in letrasF)
                {
                    palavraF = palavraF + item;
                    palavrasF.Add(palavraF);
                    palavraF = "";
                }
            }
            palavrasF.Sort();
          
            return palavrasF;

        }

        public static void ImprimePalavrasOrdenadas(ArrayList palavras)
        {
            foreach (var item in palavras)
            {
                if (item.Equals("")) { }
                else Console.WriteLine(item);
            }
        }

        


    }
}
