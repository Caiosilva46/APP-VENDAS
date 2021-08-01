using System;
using vendas.Classes;

namespace vendas
{
    class Program
    {
        static HqRepositorio repositorio = new HqRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        InserirHqs();
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":

                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Livros / Hqs LTDA agradece!!");
            Console.ReadLine();

        }

        private static void ListarHqs()
        {
            Console.WriteLine("Listar Livros / Hq's");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma item cadastrado !");
                return;
            }

            foreach (var hqs in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", hqs.retornoId(), hqs.value._Titulo);
            }
        }

        private static void InserirHqs()
        {
            Console.WriteLine("Inserir novo produto");

            foreach (int i in Enum.GetValues(typeof(Classificacao)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
            }

            Console.Write("Digite a classificação do produto: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo do Livro ou HQ: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digie a data de lançamento do produto: ");
            int entradaLancamento = int.Parse(Console.ReadLine());

            Console.Write("Digite a biografia do Livro ou HQ: ");
            string entradaDescricao = Console.ReadLine();


            Hqs novaHq = new Hqs(Id: repositorio.ProximoId(), classificacao: (Classificacao)entradaClassificacao, _Titulo: entradaTitulo, Lancamento: entradaLancamento, Descricao: entradaDescricao);

            repositorio.Inserir(novaHq);

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("********** TUDO SOBRE HQ's / Livros **********");
            Console.WriteLine("Informe por favor: ");
            Console.WriteLine("1 - Listar Livros/Hq's");
            Console.WriteLine("2 - Inserir Livros ou Hq's");
            Console.WriteLine("3 - Atualizar Livros e Hq's");
            Console.WriteLine("4 - Excluir itens");
            Console.WriteLine("5 - Visualizar itens cadastrados");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

