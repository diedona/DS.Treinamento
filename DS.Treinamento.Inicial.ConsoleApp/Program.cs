using DS.Treinamento.Inicial.Dominio;
using System;

namespace DS.Treinamento.Inicial.StringsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string meuNome = "Diego Doná";

            // concatenação simples (desencorajado)
            Console.WriteLine("Seja bem vindo, " + meuNome + "!");

            // usando métodos da classe string (mais elegante)
            Console.WriteLine(string.Concat("Seja bem vindo, ", meuNome, "!"));

            // operador $ (dolar)
            Console.WriteLine($"Seja bem vindo, {meuNome}!");

            // --------------------
            Console.WriteLine();
            // --------------------

            // o que acontece se concatenarmos outros tipos à string?
            bool ativo = true;
            object obj = new object();
            Cliente cliente = new Cliente() { Id = 1, Nome = "Josisvaldo", DataDeNascimento = DateTime.Now }; // c# inline initialization
            Loja loja = new Loja() { Id = 1, Nome = "Loja da Cleide" }; //c# inline initialization
            Produto produto = new Produto() { Id = 1, Nome = "Verde Piscina" }; //c# inline initialization

            Console.WriteLine($"bool/Boolean: {ativo}");
            Console.WriteLine($"object/Object: {obj}");
            Console.WriteLine($"Cliente: {cliente}");
            Console.WriteLine($"Loja: {loja}");
            Console.WriteLine($"Produto: {produto}");

            // --------------------
            // Tudo que for convertido para string invoca o método .ToString()!
            // Por que a Loja mostra um resultado diferente??????
            // - c# tostring override
            // - olhar código das classes Dominio
            // --------------------

            // --------------------
            Console.WriteLine();
            // --------------------

            // sabia que comparar strings é perigoso?

            string nome = "tatiane";
            if (nome == "tatiane")
            {
                Console.WriteLine("Funciona neste contexto, mas não é adequado para todos");
            }

            if (nome.Equals("tatiane"))
            {
                Console.WriteLine("Padrão apropriado usando .Equals!");
            }

            string joao = "JOãO";
            if (joao.Contains("Ã"))
            {
                Console.WriteLine("Nunca vai cair aqui :(");
            }

            if (joao.Contains("Ã", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("IGNORE CASE! Agora caiu.");
            }

            // entretanto, cuidado com NULL...
            string tabefe = null;
            try
            {
                if (tabefe.Equals("OUCH"))
                {
                    // dummy
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, caiu na exceção!");
            }

            // vale a pena validar antes...
            bool stringVazia = string.IsNullOrEmpty(tabefe);
            if ((!stringVazia) && tabefe.Equals("OUCH"))
            {
                // dummy
            }
            else
            {
                Console.WriteLine("Evitamos a exceção!");
            }
            // geralmente acumulamos em 1 linha:
            // if ((!string.IsNullOrEmpty(tabefe)) && tabefe.Equals("OUCH"))
        }
    }
}
