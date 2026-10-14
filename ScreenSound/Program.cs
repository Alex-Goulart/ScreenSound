Banda evanescence = new Banda("Evanescence");

Album albumevanescence = new Album("Fallen");

Musica musica1 = new Musica(evanescence, "Bring Me to Life")
{
    Duracao = 242,
    Disponivel = true,
};

Musica musica2 = new Musica(evanescence, "My Immortal")
{
    Duracao = 264,
    Disponivel = true,
};

albumevanescence.AdicionarMusica(musica1);
albumevanescence.AdicionarMusica(musica2);
evanescence.AdicionarAlbum(albumevanescence);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumevanescence.ExibirMusicasDoAlbum();
evanescence.ExibirDiscografia();