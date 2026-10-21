class Episodio
{
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo { get; }

    public void AdicionarConvidados(string convidado) 
    { 
        convidados.Add(convidado);
    }

    public void ResumoCompleto()
    {
        Console.WriteLine($"Episódio: {Ordem} - {Titulo} | Duração: {Duracao} mim |" +
            $"Resumo: {Resumo} | Convidados: {string.Join(",", convidados)}");
    }
}