using demo_app.Models;
using System.Reflection.Metadata.Ecma335;

namespace demo_app.Repository
{
    public class TaskRepository
    {
        public static TaskModel _taskModel = new TaskModel { Title = "Hello World"};
        
        public TaskModel GetTask()
        {
            return _taskModel;
        }
    }
}
