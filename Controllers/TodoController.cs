using demo_app.Repository;
using demo_app.Models;
using Microsoft.AspNetCore.Mvc;
using demo_app.Data;
using Microsoft.EntityFrameworkCore;

namespace demo_app.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoRepository _repository;
        private readonly TodoContext _context;

        public TodoController(TodoContext context) 
        {
            _repository = new TodoRepository();
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var items = await _context.Todos.ToListAsync();
            return View(items);

        }

        [HttpPost]
        public IActionResult Create(TodoModel item)
        {
            if (ModelState.IsValid)
            {
                _context.Todos.Add(item);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
