using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirintoGamer
{
    class Program
    {   // Título do jogo
        static string tituloDoJogo = "Jogo de Labirinto";

        static string[,] labirinto = new string[8, 16]
        {
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },
            {"#","#","#","#","#","#","#","#","#"," "," "," "," "," ","#","#" },
            {"#","#","#","#"," "," "," ","#","#"," ","#","#","#"," ","#","#" },
            {"#"," "," "," "," ","#"," ","#","#"," ","#"," "," "," ","#","#" },
            {"#"," ","#","#","#","#"," "," "," "," ","#"," ","#","#"," ","F" },
            {"#"," ","#","#","#","#","#","#","#","#","#"," "," "," "," ","#" },
            {"#","#","#","#","#","#","#","#","#","#","#","#","#","#","#","#" },

        };

        static string jogador = "^";
        static int posLinha = 6;
        static int posColuna = 1;

        static void Main(string[] args)
        {
            // Título do jogo
            Console.Title = tituloDoJogo;

            bool fimDeJogo = false;

            // exibindo o jogador no labirinto
            labirinto[6, 1] = jogador;

            while (!fimDeJogo)
            {
                Console.Clear();
                // Linha do labirinto
                for (int linha = 0; linha < 8; linha++)
                {
                    // Coluna
                    for (int coluna = 0; coluna < 16; coluna++)
                    {
                        Console.Write(labirinto[linha, coluna]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Para onde você deseja ir?");
                Console.WriteLine("> W = Cima");
                Console.WriteLine("> A = Esquerda");
                Console.WriteLine("> S = Baixo");
                Console.WriteLine("> D = Direita");
                Console.Write("Meu comando é :");

                string comando = Console.ReadLine().ToUpper();

                // Instruções de movimento
                if (comando == "W")
                {
                    if (labirinto[posLinha - 1, posColuna] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posLinha--;
                    }
                    else
                    {
                        fimDeJogo = true;
                    }
                }
                else if (comando == "A")
                {
                    if (labirinto[posLinha, posColuna - 1] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posColuna--;
                    }
                    else
                    {
                        fimDeJogo = true;
                    }
                }
                else if (comando == "S")
                {
                    if (labirinto[posLinha + 1, posColuna] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posLinha++;
                    }
                    else
                    {
                        fimDeJogo = true;
                    }
                }
                else if (comando == "D")
                {
                    if (labirinto[posLinha, posColuna + 1] != "#")
                    {
                        labirinto[posLinha, posColuna] = " ";
                        posColuna++;
                    }
                    else
                    {
                        fimDeJogo = true;
                    }
                }
                

                labirinto[posLinha, posColuna] = jogador;

                if(labirinto[5, 15] == jogador)
                {
                    fimDeJogo = true;
                }

            }

            if (labirinto[5, 15] == jogador)
            {
                Console.Clear();
                Console.WriteLine("PARABÉNS!!! VOCÊ CHEGOU AO FIM DO LABIRINTO!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("GAME OVER!");
            }

            Console.WriteLine("Tecle ENTER para finalizar.");
            Console.ReadKey();
        }
    }
}
