﻿namespace ScreenSound.Model;

class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {

        musicas.Add(musica);

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