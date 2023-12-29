using Formtask.Data;
using System.ComponentModel.DataAnnotations;

namespace Formtask.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Sname { get; set; }
        public string Major { get; set; }
        public int Age { get; set; }
        public List<Enrollment> Enrollment { get; set; }
    }
}
