class Episodios
{
    List<Episodios> convidados = new List<Episodios>();

    public Episodios(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao})";

    public void AdicionarConvidado(Episodios convidado)
    {
        convidados.Add(convidado);
    }
}