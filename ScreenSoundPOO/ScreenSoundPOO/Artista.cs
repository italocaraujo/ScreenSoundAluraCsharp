class Artista
{   
    private List<Album> albums = new List<Album>();

    public Artista (string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public void AdicionarAlbum(Album album) 
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"{album.Nome} ({album.DuracaoTotal})");

            Console.WriteLine(); // Imprime uma linha em branco para melhorar a formatação da saída
        }
    }
}