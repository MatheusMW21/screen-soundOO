class Podcast
{
    List<Episodios> episodios = new List<Episodios>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; set; }
    public string Host { get; set; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodios ep)
    {
        episodios.Add(ep);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");

        foreach (Episodios episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.");
    }
}