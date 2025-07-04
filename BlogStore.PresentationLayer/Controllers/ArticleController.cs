using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ArtcileDetail(int id)
        {
            return View();
        }
    }
}
