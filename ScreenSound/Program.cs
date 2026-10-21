Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Alex");
ep1.AdicionarConvidados("Tiago");

Episodio ep2 = new(1, "Programação C#", 60);
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Marcelo");

Podcast podcast = new("Desafio Prático Programação C#", "Alura");
podcast.AdcionarEpisodio(ep1);
podcast.AdcionarEpisodio(ep2);
podcast.ExibirDetalhes();