Album albumBlonde = new Album();
albumBlonde.Nome = "Blonde";

Musica musica1 = new Musica();
musica1.Nome = "Nikes";
musica1.Duracao = 314;

Musica musica2 = new Musica();
musica2.Nome = "Ivy";
musica2.Duracao = 249;

Musica musica3 = new Musica();
musica3.Nome = "Pink + White";
musica3.Duracao = 184;

Musica musica4 = new Musica();
musica4.Nome = "Be Yourself";
musica4.Duracao = 86;

albumBlonde.AdicionarMusica(musica1);
albumBlonde.AdicionarMusica(musica2);
albumBlonde.AdicionarMusica(musica3);
albumBlonde.AdicionarMusica(musica4);

albumBlonde.ExibirMusicasDoAlbum();