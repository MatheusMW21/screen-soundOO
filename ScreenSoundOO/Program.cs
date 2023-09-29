using ScreenSound.Model;
using ScreenSoundOO.View;


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

// criando dicionário para os menus
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new RegistrarBanda());
opcoes.Add(2, new RegistrarAlbum());
opcoes.Add(3, new MostrarBanda());
opcoes.Add(4, new AvaliarBanda());
opcoes.Add(5, new AvaliarAlbum());
opcoes.Add(6, new ExibirDetalhes());
opcoes.Add(-1, new MenuSair());


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
     Console.WriteLine("Digite 5 para avaliar um ábum");
     Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
     Console.WriteLine("Digite -1 para sair");

     Console.Write("\nDigite a sua opção: ");
     string opcaoEscolhida = Console.ReadLine()!;
     int opcaoMenu = int.Parse(opcaoEscolhida);

     if (opcoes.ContainsKey(opcaoMenu))
     {
         Menu menu = opcoes[opcaoMenu];
         menu.Executar(bandasRegistradas);
         if (opcaoMenu > 0) ExibirOpcoesDoMenu();
         
     }
     else
     {
         Console.WriteLine("Opção Inválida");
     }
 }
ExibirOpcoesDoMenu();
