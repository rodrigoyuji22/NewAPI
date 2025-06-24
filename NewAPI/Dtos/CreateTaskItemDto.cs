using System.Text.Json.Serialization;

namespace NewAPI.Dtos;

public class CreateTaskItemDto
{
    [JsonPropertyName("title")]
    public string  Title { get; set; } = string.Empty;
    [JsonPropertyName("description")]
    public string Description { get; set; } =  string.Empty;
}