Album albumDoLinkinPark = new Album();
albumDoLinkinPark.Nome = "Meteora";

Musicas musica1 = new Musicas();
musica1.NomeMusica = "Numb";
musica1.Duracao = 187;

Musicas musica2 = new Musicas();
musica2.NomeMusica = "Somewhere I Belong";
musica2.Duracao = 213;

Musicas musica3 = new Musicas();
musica3.NomeMusica = "Breaking the Habit";
musica3.Duracao = 196;

Musicas musica4 = new Musicas();
musica4.NomeMusica = "Faint";
musica4.Duracao = 163;

Musicas musica5 = new Musicas();
musica5.NomeMusica = "From the Inside";
musica5.Duracao = 176;

albumDoLinkinPark.AdicionarMusica(musica1);
albumDoLinkinPark.AdicionarMusica(musica2);
albumDoLinkinPark.AdicionarMusica(musica3);
albumDoLinkinPark.AdicionarMusica(musica4);
albumDoLinkinPark.AdicionarMusica(musica5);

Banda linkinPark = new Banda();
linkinPark.NomeBanda = "Linkin Park";
linkinPark.AdicionarAlbum(albumDoLinkinPark);
linkinPark.ExibirDiscografia();