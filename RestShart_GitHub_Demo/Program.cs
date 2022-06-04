

using RestSharp;
using System;

var client = new RestClient("https://api.githug.com");

var request = new RestRequest("/repos/{user}/{repo}/issues/{id}");


request.AddUrlSegment("user", "AlexBratanov");
request.AddUrlSegment("repo", "Postman");
request.AddUrlSegment("id", 4);


var response = await client.ExecuteAsync(request);

Console.WriteLine("STATUS CODE " + response.StatusCode);
Console.WriteLine("BODY: " + response.Content);
