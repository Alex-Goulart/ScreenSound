class Podcast
{
    private readonly List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalDeEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} | Host: {Host}");
        foreach (var episode in episodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine(episode.AdicionarConvidados);
        }

        Console.WriteLine($"Total de Episódios: {TotalDeEpisodios}");
    }
}