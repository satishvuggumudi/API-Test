using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace MovieDBAPI
{
    public class ReadJsonData
    {
        public static T GetJsonDataFromUrl<T>(string url)
        {
            T model = default(T);
            var client = new HttpClient();
            var task = client.GetAsync(url)
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<T>(jsonString.Result);

              });
            task.Wait();
            return model;
        }
    }
}
