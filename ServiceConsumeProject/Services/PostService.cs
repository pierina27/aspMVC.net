using Newtonsoft.Json;
using ServiceConsumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ServiceConsumeProject.Services
{
    public class PostService
    {
        readonly string uri = "https://jsonplaceholder.typicode.com/posts";
        public async Task<List<PostModel>> GetPostsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {

                return JsonConvert.DeserializeObject<List<PostModel>>(
                    await httpClient.GetStringAsync(uri)
                );
            }
        }
    }
}