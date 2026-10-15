class Episodio
{
    private List<string> convidados = new();
    public Episodio(int numero, string titulo, int duracao, string resumo)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
        Resumo = resumo;
    }

    public int Numero { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string Resumo { get; set; }

    public void AdicionarConvidados(string convidado) 
    { 
        convidados.Add(convidado);
    }

    public void ResumoCompleto()
    {
        Console.WriteLine($"Episódio: {Numero} - {Titulo} | Duração: {Duracao} mim |" +
            $"Resumo: {Resumo} | Convidados: {string.Join("," convidados)}");
    }
}