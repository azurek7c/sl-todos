using System.Text.Json.Serialization;

namespace api.Models
{
  public class TodoResponse
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("done")]
    public bool Done { get; set; }
  }
}
