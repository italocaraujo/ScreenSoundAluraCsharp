﻿class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Tracklist do álbum {Nome}: ");
        Console.WriteLine();

        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }

        Console.WriteLine($"\nDuração do álbum: {DuracaoTotal}");
        Console.WriteLine(); // Imprime uma linha em branco para melhorar a formatação da saída
    }
}