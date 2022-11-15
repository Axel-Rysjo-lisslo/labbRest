using System.Text.Json.Serialization;


public class pokemon
{

    [JsonPropertyName("name")]
public string name { get; set; }
[JsonPropertyName("weihgt")]
public int weight { get; set; }
[JsonPropertyName("is_default")]
public bool   { get; set; }         

    
}
