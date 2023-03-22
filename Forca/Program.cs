using static System.Net.Mime.MediaTypeNames;

namespace JogoDaForca
{
    class Forca
    {
        static void Main(string[] args)
        {
            String[] palavras = { "abacate", "avião", "banana", "balão", "caqui", "chuva", "daenerys", "damasco", "dromedário", "elefante", "esquimó", "feijão", "florianópolis", "forró", "gelatina", "gelo", "herói", "hospital", "igreja", "iglu", "jalapão", "jamylle", "kaiena", "kiwi", "leia", "lua", "luke", "luz", "marreco", "martelo", "naboo", "navio", "nuvem", "ovelha", "ovo", "presunto", "prisma", "quasimodo", "queijo", "rei", "riacho", "sacripanta", "skywalker", "sol", "tatooine", "torresmo", "trem", "urso", "uva", "vendaval", "vinho", "waffle", "whovian", "xadrex", "xarope", "xerox", "yakisoba", "yogurt", "zebra", "zumbi" };
            Random aleatorio = new Random();

            string palavraAleatoriaEscolhida = palavras[aleatorio.Next(palavras.Length)];

            Console.WriteLine($"Testando: a palavra escolhida é: {palavraAleatoriaEscolhida}");
        }
    }
}