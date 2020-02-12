using DS.Treinamento.Inicial.Dominio;
using System;
using System.Globalization;

namespace DS.Treinamento.Inicial.ArrayConsoleApp
{
    class Program
    {
        private const int QUANTIDADE_MAXIMA = 9874;

        static void Main(string[] args)
        {
            Console.WriteLine("Vamos cadastrar alguns clientes.");
            Cliente[] clientes = new Cliente[QUANTIDADE_MAXIMA];

            for (int i = 0; i < QUANTIDADE_MAXIMA; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine(); // ReadLine retorna string, tudo fácil!
                Console.Write("Data de nascimento: (DD/MM/YYYY) ");
                string dataDeNascimentoString = Console.ReadLine();

                // ----------
                // Como converter de string para DateTime?
                // ----------

                DateTime dataDeNascimento = DateTime.ParseExact(dataDeNascimentoString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // ----------
                // Se a data for inválida, vai "crashar" o app... Como evitar?
                // - c# try parse
                // ----------

                // criamos um novo cliente e alocamos na posição i do array
                clientes[i] = new Cliente() { Id = (i + 1), Nome = nome, DataDeNascimento = dataDeNascimento };

                // isso é equivalente a:
                // Cliente cliente = new Cliente() { Id = (i + 1), Nome = nome, DataDeNascimento = dataDeNascimento };
                // clientes[i] = cliente;

                Console.WriteLine();
                Console.Write("Continuar cadastro? (S/N)");

                // vamos comparar direto o retorno do método ao invés de armazenar a referencia em outra variável
                if(Console.ReadLine().Contains("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                // é equivalente a:
                // string resposta = Console.ReadLine();
                // if(resposta.Contains("n"...
            }
        }
    }
}
