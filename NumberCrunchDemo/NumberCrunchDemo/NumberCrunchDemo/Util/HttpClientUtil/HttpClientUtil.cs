using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunchDemo.Util.HttpClientUtil
{
  public class HttpClientUtil
  {
    public static async Task<HttpResponseMessage> PostAsync(string url, object content)
    {

      var json = JsonConvert.SerializeObject(content);
      var data = new StringContent(json, Encoding.UTF8, "application/json");

      using var client = new HttpClient();

      var response = await client.PostAsync(url, data);
      return response;
    }

  }
}
