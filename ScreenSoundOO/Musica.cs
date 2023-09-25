class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        
        if(Disponivel)
        { 
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Disponível no plano plus");
        }
    }
}