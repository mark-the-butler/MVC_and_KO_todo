using System.Collections.Generic;
using System.Web.Mvc;
using TodoWithMVC_And_KO.Models;

namespace TodoWithMVC_And_KO.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTodo(string toDo)
        {
            var toDos = new ToDoViewModel();

            var toDoList = toDos.ToDosList = new List<string>();
            toDoList.Add(toDo);
            return Redirect("./ToDo/Index");
        }
    }
}