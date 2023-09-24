class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
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


