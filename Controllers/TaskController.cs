using demo_app.Repository;
using Microsoft.AspNetCore.Mvc;

namespace demo_app.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskRepository _repository;

        public TaskController()
        {
            _repository = new TaskRepository();
        }
        public IActionResult Index()
        {
            var task = _repository.GetTask();
            return View(task);
        }
    }
}
