using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiceConsumeProject.Models
{
    public class PostModel
    {
        [Required]
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("userId")]
        public string userId { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("body")]
        public string body { get; set; }
    }

    public class PostsModel
    {
        [JsonProperty("posts")]
        public List<PostModel> Posts { get; set; }
    }
}