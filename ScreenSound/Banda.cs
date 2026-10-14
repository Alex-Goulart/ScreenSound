class Banda 
{
    private List<Album> albuns = new List<Album>();

    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void EbibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}: ");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} (Duração: {album.DuracaoTotal})");
            album.ExibirMusicasDoAlbum();
            Console.WriteLine();
        }
    }
}