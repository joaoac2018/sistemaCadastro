using System;

namespace sistemacadastro.Classes
{
    class Program
    {
        static anuncioRepositorio repositorio = new anuncioRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarAnuncio();
                        break;
                    case "2":
                        InserirAnuncio();
                        break;
                    case "3":
                        AtualizarAnuncio();
                        break;
                    case "4":
                        ExcluirAnuncio();
                        break;
                    case "5":
                        VisualizarAnuncio();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
         private static void ExcluirAnuncio()
		{
			Console.Write("Digite o id do anuncio: ");
			int indiceAnuncio = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceAnuncio);
		}
        private static void VisualizarAnuncio()
		{
			Console.Write("Digite o id do anuncio: ");
			int indiceAnuncio = int.Parse(Console.ReadLine());

			var anuncios = repositorio.RetornaPorId(indiceAnuncio);

			Console.WriteLine(anuncios);
		}
        private static void AtualizarAnuncio()
		{
			Console.Write("Digite o id do anuncio: ");
			int Id = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			
			Console.Write("Digite o nome do anuncio: ");
			string nomeAnuncio = Console.ReadLine();

			Console.Write("Digite o nome do cliente: ");
			string nomeCliente = Console.ReadLine();

			Console.Write("Digite a data de inicio: ");
			string dataInicio = Console.ReadLine();

			Console.Write("Digite a data de termino: ");
			string dataTermino = Console.ReadLine();
            
            Console.Write("Digite o valor do investimento: ");
			double investimentoPorDia =double.Parse(Console.ReadLine());

			Anuncios atualizaAnuncio = new Anuncios(Id: Id,
										nomeAnuncio: nomeAnuncio,
										nomeCliente: nomeCliente,
										dataInicio: dataInicio,
										dataTermino: dataTermino,
                                        investimentoPorDia: investimentoPorDia);

			repositorio.Atualizar(Id, atualizaAnuncio);
		}

        private static void ListarAnuncio()
        {
            Console.WriteLine("Lista de Anuncios");
            var lista = repositorio.lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhum anuncio cadastrado.");
                Console.ReadLine();
                return;
            }

            foreach (var anuncios in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", anuncios.retornaid(), anuncios.retornanuncio());
            }
            Console.ReadLine();
            
        }

        private static void InserirAnuncio()
        {
            Console.WriteLine("Inserir um novo anuncio");
            
			Console.Write("Informe o nome do anuncio: ");
			string nomeAnuncio = Console.ReadLine();

			Console.Write("Informe o nome do cliente: ");
			string  nomeCliente = Console.ReadLine();

			Console.Write("Informe a data de inicio do anuncio: ");
			string dataInicio = Console.ReadLine();

			Console.Write("Informe a data de termino do anuncio: ");
			string dataTermino = Console.ReadLine();

            Console.Write("Informe o valor do investimento: ");
			double investimentoPorDia = double.Parse(Console.ReadLine());

			Anuncios novoAnuncio = new Anuncios(repositorio.ProximoId(),
										nomeAnuncio: nomeAnuncio,
										nomeCliente: nomeCliente,
										dataInicio: dataInicio,
										dataTermino: dataTermino,
                                        investimentoPorDia: investimentoPorDia);

			repositorio.Insere(novoAnuncio);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Seja bem vindo ao sistema de cadastro de anuncios!!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Listar anuncios");
            Console.WriteLine("2- Inserir novo anuncio");
            Console.WriteLine("3- Atualizar anuncio");
            Console.WriteLine("4- Excluir anuncio");
            Console.WriteLine("5- Visualizar anuncio");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }

        
    }
}
