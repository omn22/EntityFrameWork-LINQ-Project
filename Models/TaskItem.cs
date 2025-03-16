using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_LINQ_Project.Models
{
    public enum TaskStatus
    {
        Pending,
        In_Progress,
        Completed
    }
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        private string _priority = "Low"; // Default value

        public string Priority
        {
            get => _priority;
            set
            {
                if (value == "Low" || value == "Medium" || value == "High")//check for input
                    _priority = value;
                else
                    _priority = "Low"; 
            }
        }

        public TaskStatus Status { get; set; } // Pending, In Progress, Completed 
        [ForeignKey("User")]
        public int? userId { get; set; } = null!;
        public User user { get; set; }
        public int categoryId { get; set; }
        public Category category { get; set; }

    }
}
