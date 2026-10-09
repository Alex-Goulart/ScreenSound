class Album
{
    private List<Musicas> musicas = new List<Musicas>();
    public String Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musicas musica)
    {
        musicas.Add(musica);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Nome do álbum: {Nome}");
        Console.WriteLine("Músicas:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.NomeMusica}");
        }
        Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos");
    }
}