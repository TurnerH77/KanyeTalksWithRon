using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

public class QuoteGetter
{
	public HttpClient _client;
	public QuoteGetter(HttpClient client)
	{
		_client = client;
	}

	HttpClient client = new HttpClient();

	public string KanyeGetter()
    {
		var kanyeURL = "https://api.kanye.rest";
		var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
		var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
		return kanyeQuote;
	}

	public string RonGetter()
    {
		var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
		var ronResponse = _client.GetStringAsync(ronURL).Result;
		var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
		return ronQuote;
	}
}
