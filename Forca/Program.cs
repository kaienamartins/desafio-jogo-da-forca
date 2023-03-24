using System;

namespace jogoDaForca
{
    class Forca
    {
        static void Main(string[] args)
        {
            string[] palavras = { "abacate", "amora", "banana", "brigadeiro", "caqui", "chuva", "daenerys", "damasco", "dinossauro", "elefante", "esquilo", "feijoada", "floripa", "gelatina", "gelo", "halloween", "hospital", "igreja", "iglu", "javali", "jamylle", "kaiena", "kiwi", "leia", "lua", "luke", "luz", "marreco", "martelo", "naboo", "navio", "nuvem", "ovelha", "ovo", "presunto", "prisma", "quasimodo", "queijo", "rei", "riacho", "sacripanta", "skywalker", "sol", "tatooine", "torresmo", "trem", "urso", "uva", "vendaval", "vinho", "waffle", "whovian", "xadrex", "xarope", "xerox", "yakisoba", "yogurt", "zebra", "zumbi" };
            Random aleatorio = new Random();

            string palavraAleatoriaEscolhida = palavras[aleatorio.Next(palavras.Length)];

            char[] palavraConvertida = palavraAleatoriaEscolhida.ToCharArray();

            char[] palavraDoJogo = new char[palavraConvertida.Length];

            int i = 0;

            while (i < palavraConvertida.Length)
            {
                palavraDoJogo[i] = '-';
                Console.Write(palavraDoJogo[i]);
                i++;
            }

            bool acertou = false;
            List<char> tentativas = new List<char>();

            while (!acertou)
            {
                Console.Write("\nDigite uma letra: ");
                string paraUsarNoChar = Console.ReadLine();

                char letraDigitada = paraUsarNoChar[0];
    

                if (!tentativas.Contains(letraDigitada))
                {
                    tentativas.Add(letraDigitada);
                    bool letra = false;

                    for (int k = 0; k < palavraAleatoriaEscolhida.Length; k++)
                    {
                        if (letraDigitada == palavraAleatoriaEscolhida[k])
                        {
                            palavraDoJogo[k] = letraDigitada;
                            letra = true;
                        }
                    }

                    if (letra)
                    {
                        Console.WriteLine("Tem essa letra mesmo");
                    }
                    else
                    {
                        Console.WriteLine("Errou! (Faustão's voice). Não tem essa letra não");
                    }
                    Console.WriteLine(palavraDoJogo);
                    if (!palavraDoJogo.Contains('-'))
                    {
                        acertou = true;
                        Console.WriteLine($"Parabéns, você acertou a palavra! Era {palavraAleatoriaEscolhida}");
                    }
                }
                else
                {
                    Console.WriteLine("Você já tentou essa letra antes. Tente outra letra.");
                }
            }
            
        }
    } 
}