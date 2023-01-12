HttpClient httpClient = new HttpClient();
Console.WriteLine("Bad");

var otherSite = await httpClient.GetStringAsync("https://www.google.com.tr");
var otherSite2 = await httpClient.GetStringAsync("https://www.bing.com.tr");
Console.WriteLine($"{otherSite}");
Console.WriteLine($"{otherSite2}");

Console.WriteLine("Good");

var otherSite3 = httpClient.GetStringAsync("https://www.google.com.tr");
var otherSite4 = httpClient.GetStringAsync("https://www.bing.com.tr");

//other works........

await otherSite3;
await otherSite4;

Console.WriteLine($"{otherSite3.Result}");
Console.WriteLine($"{otherSite4.Result}");

Console.ReadLine();