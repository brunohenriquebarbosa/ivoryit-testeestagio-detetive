using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();
            var encontrou = false;
            var criminoso = 1;
            var local = 1;
            var arma = 1;

            // Formula uma nova teoria enquanto o que foi perguntado for diferente do que a testemunha viu.
            while (!encontrou)
            {
                int retorno = testemunha.Interrogar(criminoso, local, arma);
                if (retorno == 1)
                {
                    criminoso++;
                }
                else if (retorno == 2)
                {
                    local++;
                }
                else if (retorno == 3)
                {
                    arma++;
                }
                else if (retorno == 0)
                {
                    encontrou = true;
                }
            }

            Dicionario dicionario = new Dicionario();
            string nomeCriminoso = dicionario.BuscaCriminoso(criminoso);
            string descricaoLocal = dicionario.BuscaLocal(local);
            string tipoArma = dicionario.BuscaArma(arma);

            Console.WriteLine($"DADOS DO CRIME {Environment.NewLine}");
            Console.WriteLine($"Nome do criminoso: {nomeCriminoso}");
            Console.WriteLine($"Local do crime: {descricaoLocal}");
            Console.WriteLine($"Arma utilizada: {tipoArma} {Environment.NewLine}");
            Console.WriteLine("Número de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
            Console.ReadKey();
        }

    }
}
