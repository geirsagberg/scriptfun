#! "netcoreapp2.1"
#r "nuget: Flurl.Http, 2.4.0"
using Flurl.Http;

Console.WriteLine("Enter your name:");
var name = Console.ReadLine();

Console.WriteLine("Enter Airtable API Key (ask Geir):");
var apiKey = Console.ReadLine();

await "https://api.airtable.com/v0/appMZJ3wFzoTglNjV/Calls%20home"
  .WithOAuthBearerToken(apiKey)
  .PostJsonAsync(new {
    fields = new {
      Name = name
    }
  });

Console.WriteLine("Good job!");