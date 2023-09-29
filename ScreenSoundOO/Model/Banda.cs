using ScreenSound.Model;
using ScreenSoundOO.Model;

namespace ScreenSound.Model;

internal class Banda : IAvaliar
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public List<Album> Albuns => albuns;


    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public double Media 
    {  
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public string? Resumo { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }
    
    public void PrintDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");

        foreach(Album album in albuns) 
        {

            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");

        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}   