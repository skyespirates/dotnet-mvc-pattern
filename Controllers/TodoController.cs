using demo_app.Repository;
using demo_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_app.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoRepository _repository;
        public TodoController() 
        {
            _repository = new TodoRepository();
        }
        public IActionResult Index()
        {
            var items = _repository.GetAll();
            return View(items);
        }

        [HttpPost]
        public IActionResult Create(TodoModel item)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
