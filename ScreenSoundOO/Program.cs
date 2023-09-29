using ScreenSound.Model;
using ScreenSoundOO.View;

internal class Program
{
    private static void Main(string[] args)
    {
        // instanciando bandas
        Banda beatles = new("The Beatles");
        Banda nirvana = new("Nirvana");
        Banda blackSabbath = new("Black Sabbath");
        Banda misfits = new("Misfits");

        // adicionando notas
        beatles.AdicionarNota(new Avaliacao(10));
        nirvana.AdicionarNota(new Avaliacao(9));
        blackSabbath.AdicionarNota(new Avaliacao(9));
        misfits.AdicionarNota(new Avaliacao(9));

        // adicionando no dicionário
        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(beatles.Nome, beatles);
        bandasRegistradas.Add(nirvana.Nome, nirvana);
        bandasRegistradas.Add(blackSabbath.Nome, blackSabbath);
        bandasRegistradas.Add(misfits.Nome, misfits);


        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda registrar = new();
                    registrar.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 2:
                    RegistrarAlbum registrarAlbum = new();
                    registrarAlbum.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 3:
                    MostrarBanda mostrarBanda = new();
                    mostrarBanda.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 4:
                    AvaliarBanda avaliar = new();
                    avaliar.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 5:
                    ExibirDetalhes menu = new ExibirDetalhes();
                    menu.Executar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case -1:
                    MenuSair menuSair = new();
                    menuSair.Executar(bandasRegistradas);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
              
        ExibirOpcoesDoMenu();
    }
}