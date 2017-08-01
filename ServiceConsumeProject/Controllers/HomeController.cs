using ServiceConsumeProject.Models;
using ServiceConsumeProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ServiceConsumeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        private PostService service = new PostService();

        public async Task<ActionResult> GetPosts()
        {
            return View("Post",
                await service.GetPostsAsync()
            );
        }
    }
}
