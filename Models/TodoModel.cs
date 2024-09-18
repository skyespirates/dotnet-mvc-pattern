using System.ComponentModel.DataAnnotations;

namespace demo_app.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

    }
}
