using ScreenSoundOO.Model;

namespace ScreenSound.Model;

internal class Album : IAvaliar
{
    public static int Contador = 0;

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();


    public Album(string nome)
    {
        Nome = nome;
        Contador++;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media 
    { 
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota) ;
        }
    }

    public void AdicionarMusica(Musica musica)
    {

        musicas.Add(musica);

    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void PrintAlbum()
    {
        Console.WriteLine($"Músicas do Álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Faixa: {musica.Nome}");
        }
        Console.WriteLine($"O álbum tem duração {DuracaoTotal}");
    }
}