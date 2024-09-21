﻿class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios { get; private set; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        TotalEpisodios++;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.");
    }
}