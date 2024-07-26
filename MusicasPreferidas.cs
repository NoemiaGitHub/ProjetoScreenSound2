using System.Text.Json;
using ScreenSound04.Modelos;


namespace Screen_Sound04.Modelos;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas {  get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();

    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson() 
    {
        string Json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas

        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        Console.WriteLine($"O arquivo Json foi criado com sucesso!" +
            $"{Path.GetFullPath(nomeDoArquivo)}");
    }
}
