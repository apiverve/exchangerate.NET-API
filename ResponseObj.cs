using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("currency1")]
    public string currency1 { get; set; }

    [JsonProperty("currency2")]
    public string currency2 { get; set; }

    [JsonProperty("exchangeRate")]
    public string exchangeRate { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
