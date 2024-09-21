Artista frankOcean = new Artista("Frank Ocean");

Album albumBlonde = new Album("Blonde");

frankOcean.AdicionarAlbum(albumBlonde);

Musica musica1 = new Musica(frankOcean, "Nikes")
{
    Duracao = 314,
};

Musica musica2 = new Musica(frankOcean, "Ivy")
{
    Duracao = 249,
};

Musica musica3 = new Musica(frankOcean, "Pink + White")
{
    Duracao = 184,
};

Musica musica4 = new Musica(frankOcean, "Be Yourself")
{
    Duracao = 86,
};

Musica musica5 = new Musica(frankOcean, "Solo")
{
    Duracao = 257,
};

Musica musica6 = new Musica(frankOcean, "Skyline To")
{
    Duracao = 184,
};

Musica musica7 = new Musica(frankOcean, "Self Control")
{
    Duracao = 249,
};

Musica musica8 = new Musica(frankOcean, "Good Guy")
{
    Duracao = 66,
};

Musica musica9 = new Musica(frankOcean, "Nights")
{
    Duracao = 307,
};

Musica musica10 = new Musica(frankOcean, "Solo (Reprise)") 
{
    Duracao = 78,
};

Musica musica11 = new Musica(frankOcean, "Pretty Sweet") 
{ 
    Duracao = 158,
};

Musica musica12 = new Musica(frankOcean, "Facebook Story")
{
    Duracao = 68,
};

Musica musica13 = new Musica(frankOcean, "Close To You") 
{
    Duracao = 85,
};

Musica musica14 = new Musica(frankOcean, "White Ferrari")
{
    Duracao = 248,
};

Musica musica15 = new Musica(frankOcean, "Seigfried")
{
    Duracao = 334,
};

Musica musica16 = new Musica(frankOcean, "Godspeed")
{
    Duracao = 177,
};

Musica musica17 = new Musica(frankOcean, "Futura Free")
{
    Duracao = 564,
};

albumBlonde.AdicionarMusica(musica1);
albumBlonde.AdicionarMusica(musica2);
albumBlonde.AdicionarMusica(musica3);
albumBlonde.AdicionarMusica(musica4);
albumBlonde.AdicionarMusica(musica5);
albumBlonde.AdicionarMusica(musica6);
albumBlonde.AdicionarMusica(musica7);
albumBlonde.AdicionarMusica(musica8);
albumBlonde.AdicionarMusica(musica9);
albumBlonde.AdicionarMusica(musica10);
albumBlonde.AdicionarMusica(musica11);
albumBlonde.AdicionarMusica(musica12);
albumBlonde.AdicionarMusica(musica13);
albumBlonde.AdicionarMusica(musica14);
albumBlonde.AdicionarMusica(musica15);
albumBlonde.AdicionarMusica(musica16);
albumBlonde.AdicionarMusica(musica17);

musica1.ExibirFichaTecnica();
albumBlonde.ExibirMusicasDoAlbum();
frankOcean.ExibirDiscografia();

Podcast balela = new Podcast("Balela", "ZeROBADASS");

Episodio balela001 = new Episodio(001, "O COMEÇO DE ALGO MUITO DAORA - BALELA #001", 45);
Episodio balela002 = new Episodio(002, "SAIR DA ZONA DE CONFORTO É BOM? - BALELA #002", 68);
Episodio balela006 = new Episodio(006, "MOUNT FALANDO BALELA - BALELA #006", 63);

balela.AdicionarEpisodio(balela001);

balela.AdicionarEpisodio(balela002);

balela.AdicionarEpisodio(balela006);
balela006.AdicionarConvidados("Mount");

balela.ExibirDetalhes();