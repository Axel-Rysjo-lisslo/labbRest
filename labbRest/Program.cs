using RestSharp;
using System.Text.Json;
using System.Net;



RestClient pokeCliant = new ("https://pokeapi.co/api/v2/");
RestRequest request = new ("pokemon/10634");
RestResponse response = pokeCliant.GetAsync(request).Result;




if(response.StatusCode == HttpStatusCode.OK)
{
Console.WriteLine(p.name);
Console.WriteLine(p.weight);
pokemon p = JsonSerializer.Deserialize<pokemon>(response.Content);

}
 else
 {
   Console.WriteLine("NO,thats wrong!"); 
 }

Console.WriteLine(response.StatusCode);

Console.ReadLine();
