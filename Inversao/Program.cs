//Teste Técnico para a empresa Melhor Plano
//    Criado por: Glaycon Gomes Xavier
//    Versão: 1.0

using System;
using System.IO;

namespace Inversao
{
    class Program
    {
        public static StreamReader texto = new StreamReader("Texto.in");
        public static string frase = texto.ReadLine();
        public static int tamanho = frase.Length;
        public static string auxiliar;
        public static string[] vetorabc = new string[tamanho];

        public static string Move(string texto)
        {
            auxiliar = texto.Substring(texto.Length - 1) + texto.Substring(0, texto.Length - 1);
            frase = auxiliar;
            return auxiliar;
        }

        public static string[,] preencheMatriz(string texto)
        {
            string[,] matriz = new string[tamanho, tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++) matriz[i, j] = Move(frase);
                i = tamanho;
            }
            return matriz;
        }

        public static void imprimiMatriz(string[,] matriz)
        {
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++) Console.WriteLine(matriz[i, j]);
                i = tamanho;
            }
        }

       
        static void Main(string[] args)
        {
            string[,] matriz = new string[tamanho, tamanho];
            string sair = "";

            int opcao;
            bool testemenu;

        menu:
            // Apresentação do Programa

            do
            {
                Console.WriteLine("\n*** MENU DE PROGRAMAS ***\n");

                Console.WriteLine("\nDigite o número do programa que deseja executar: \n");

                Console.WriteLine("[ 1 ] Criar Matriz");
                Console.WriteLine("[ 2 ] Ordena Matriz");
                Console.WriteLine("[ 3 ] Criar arquivo");
                Console.WriteLine("[ 4 ] ");
                Console.WriteLine("[ 0 ] Sair");
                Console.WriteLine("-------------------------------------");

                testemenu = int.TryParse(Console.ReadLine(), out opcao);
                if (testemenu == false)
                {
                    Console.Clear();
                    Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA");
                }
            } while (testemenu == false);

            switch (opcao)
            {

                case 1:

                    Console.Clear();

                    matriz = preencheMatriz(frase);
                    imprimiMatriz(matriz);

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);
                    break;

                case 2:

                    Console.Clear();
                    matriz = preencheMatriz(frase);
                    Palavra.ImprimePalavrasOrdenadas(Palavra.OrdenaMatriz(matriz));

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);

                    break;

                case 3:

                    Console.Clear();

                    CriaArquivo.SalvaArquivo();
                //    Console.WriteLine("O arquivo foi gerado com sucesso!");
                //    StreamWriter saida = new StreamWriter("C: \\Users\\GGX_L\\Desktop\\Inversao\\Saidas\\glaycon.out");
                //    for(int i = 0; i < tamanho; i++)
                //{
                //        for (int j = 0; j < tamanho; j++)
                //        {
                //            saida.WriteLine(matriz[i, j]);
                            
                //        }               
                //    }
                    
                //    saida.Close();

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);

                    break;

                case 4:

                    Console.Clear();
                    
                    

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);

                    break;

                case 0:

                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    // Retorna ao menu e informa que o comando dado é inválido.
                    Console.WriteLine("Comando inválido. Tente novamente. \n");
                    goto menu;

            }

        }
    }
}