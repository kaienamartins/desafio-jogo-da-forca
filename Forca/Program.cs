using System;
using System.Text.RegularExpressions;

namespace jogoDaForca
{
    class Forca
    {
        static void Main(string[] args)
        {
            string[] palavras = { "abacate", "amora", "banana", "brigadeiro", "caqui", "chuva", "daenerys", "damasco", "dinossauro", "elefante", "esquilo", "feijoada", "floripa", "gelatina", "gelo", "halloween", "hospital", "igreja", "iglu", "javali", "jamylle", "kaiena", "kiwi", "leia", "lua", "luke", "luz", "marreco", "martelo", "naboo", "navio", "nuvem", "ovelha", "ovo", "presunto", "prisma", "quasimodo", "queijo", "rei", "riacho", "sacripanta", "skywalker", "sol", "tatooine", "torresmo", "trem", "urso", "uva", "vendaval", "vinho", "waffle", "whovian", "xadrex", "xarope", "xerox", "yakisoba", "yogurt", "zebra", "zumbi" };
            
            Random aleatorio = new Random();
            //para fazer com que a escolha da palavra seja aleatória
            string palavraAleatoriaEscolhida = palavras[aleatorio.Next(palavras.Length)];

            char[] palavraConvertida = palavraAleatoriaEscolhida.ToCharArray(); //tranforma a palavra em char

            char[] palavraDoJogo = new char[palavraConvertida.Length]; 

            int i = 0;

            while (i < palavraConvertida.Length) //muda a palavra deixando ela tracejada e exibe no terminal
            {
                palavraDoJogo[i] = '-';
                Console.Write(palavraDoJogo[i]);
                i++;
            }

            bool acertou = false; // pra controloar o while e só muda pra true quando acertar todas as palavras
            List<char> tentativas = new List<char>(); // array pra armazenar as letras que foram usadas

            while (!acertou)
            {
                Console.Write("\nDigite uma letra: ");
                string paraUsarNoChar = Console.ReadLine(); //variavel criada pra poder usar o char depois, pois dava erro de compilação

                char letraDigitada = paraUsarNoChar[0];
    

                if (!tentativas.Contains(letraDigitada))
                {
                    tentativas.Add(letraDigitada);   //colocar a letra dentro de tentativas
                    bool letra = false; //pra verificar se a palavra tá contida na palavra aleatoria escolhida

                    for (int k = 0; k < palavraAleatoriaEscolhida.Length; k++)
                    {
                        if (letraDigitada == palavraAleatoriaEscolhida[k]) // verifica se a letra que foi digitada está presente
                        {
                            palavraDoJogo[k] = letraDigitada; // indice de palavra do jogo é igual a letra digitada
                            letra = true; //letra contida, mudou pra true
                        }
                    }

                    if (letra) //se tiver a letra então o jogador recebe a mensagem
                    {
                        Console.WriteLine("Tem essa letra mesmo");
                    }
                    else //se não tiver a letra mensagem de erro
                    {
                        Console.WriteLine("Errou! (Faustão's voice). Não tem essa letra não");
                    }
                    Console.WriteLine(palavraDoJogo); // vai printando a palavra na tela
                    if (!palavraDoJogo.Contains('-')) // se não tiver mais nenhum traço a palavra já foi completada
                    {
                        acertou = true; //acertou todas as letras, mudou pra tru
                        Console.WriteLine($"Parabéns, você acertou a palavra! Era {palavraAleatoriaEscolhida}");
                    }
                }
                else
                {
                    Console.WriteLine("Você já tentou essa letra antes. Tente outra letra."); //letra já digitada
                }
            }
        }
    } 
}