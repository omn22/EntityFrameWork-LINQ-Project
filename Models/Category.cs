using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_LINQ_Project.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public  ICollection<TaskItem> TaskItems { get; set;}=new List<TaskItem>();
    }
}
