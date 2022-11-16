using RestSharp;
using System.Text.Json;
using System.Net;



RestClient pokeCliant = new ("https://swapi.py4e.com/api/");
RestRequest request = new ("ship/21");
RestResponse response = pokeCliant.GetAsync(request).Result;




ship p = JsonSerializer.Deserialize<ship>(response.Content);




Console.WriteLine(p.name);
Console.WriteLine(p.starship_class);

Console.WriteLine(response.StatusCode);

Console.ReadLine();
