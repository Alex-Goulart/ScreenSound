class Banda 
{
    private List<Album> albuns = new List<Album>();
    public string NomeBanda { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia() 
    {
        Console.WriteLine($"Discografia da banda {NomeBanda}:");
        foreach (Album album in albuns) 
        { 
            Console.WriteLine($"Album: {album.Nome} (Duração: {album.DuracaoTotal})");
        }

    }
}