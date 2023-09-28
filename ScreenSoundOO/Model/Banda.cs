using ScreenSound.Model;

namespace ScreenSound.Model;

internal class Banda
{
    private List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();  

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

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    
    public void PrintDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");

        foreach(Album album in albums) 
        {

            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");

        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}   