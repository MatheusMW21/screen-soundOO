class Musica 
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
        Console.WriteLine($"Duração: {duracao}");
        
        if(disponivel)
        { 
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Disponível no plano plus");
        }
    }

}


