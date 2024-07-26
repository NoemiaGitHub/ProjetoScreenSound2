using System.Text.Json.Serialization;


namespace ScreenSound04.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };


    [JsonPropertyName("song")]
    public String? Nome { get; set; }
    [JsonPropertyName("artist")]
    public String? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public String? Genero { get; set; }

    [JsonPropertyName("key")]
    public int key { get; set; }

    public string Tonalidade
    {
        get
        {
            return tonalidades[key];

        }
    }
    

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero Musical: {Genero}");
        Console.WriteLine($"Tonalidade {Tonalidade}");
    }


}
