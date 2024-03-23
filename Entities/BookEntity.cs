using System.Text.Json.Serialization;

namespace Library.Entities;

public class BookEntity
{
    public enum GenderType
    {
        Unknown,
        Ficção,
        Romance,
        Mistério,
    }

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    //[JsonConverter(typeof(GenderType))]
    public GenderType Gender { get; set; } = GenderType.Unknown;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
