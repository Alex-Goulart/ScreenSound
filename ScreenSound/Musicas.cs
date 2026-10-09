class Musicas
{
    public string NomeMusica { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; } // duração em segundos
    public bool Disponivel { get; set; }// indica se a música está disponível para reprodução 

    public string DescriçãoResumida => $"A Musica {NomeMusica} pertencea a banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if(Disponivel)
        {
            Console.WriteLine("Disponível no seu plano");
        }
        else
        {
            Console.WriteLine("Indisponível no seu plano adquira o plano+");
        }
    }
}