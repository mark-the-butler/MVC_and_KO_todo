using System.Web.Mvc;

namespace TodoWithMVC_And_KO.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        public ActionResult Index()
        {
            return View();
        }
    }
}