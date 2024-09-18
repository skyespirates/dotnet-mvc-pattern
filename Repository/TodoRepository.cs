using System.Collections.Generic;
using System.Linq;
using demo_app.Models;


namespace demo_app.Repository
{
    public class TodoRepository
    {
        private static List<TodoModel> _todoItems = new List<TodoModel>();
        private static int _nextId = 1;

        public List<TodoModel> GetAll()
        {
            return _todoItems;
        }

        public void Add(TodoModel item)
        {
            item.Id = _nextId++;
            _todoItems.Add(item);
        }

        public void Delete(int id)
        {
            var item = _todoItems.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _todoItems.Remove(item);
            }
        }
    }
}
