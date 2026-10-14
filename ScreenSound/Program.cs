Banda linkinPark = new Banda();
linkinPark.Nome = "Linkin Park";

Album albumDoLinkinPark = new Album();
albumDoLinkinPark.Nome = "Meteora";

Musica musica1 = new Musica(linkinPark);
musica1.Nome = "Numb";
musica1.Duracao = 187;

Musica musica2 = new Musica(linkinPark);
musica2.Nome = "Faint";
musica2.Duracao = 163;

albumDoLinkinPark.AdicionarMusica(musica1);
albumDoLinkinPark.AdicionarMusica(musica2);


linkinPark.AdicionarAlbum(albumDoLinkinPark);

linkinPark.EbibirDiscografia();