using System.Collections.Generic;
using System.Web.Mvc;

namespace TodoWithMVC_And_KO.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        public ActionResult Index()
        {
            return View("Index", new List<string>());
        }

        [HttpPost]
        public ActionResult AddTodo(string toDo)
        {
            var toDoList = new List<string> {toDo};
            return View("Index", toDoList);
        }
    }
}