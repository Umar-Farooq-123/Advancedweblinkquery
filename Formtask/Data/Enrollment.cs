using System.ComponentModel.DataAnnotations;

namespace Formtask.Data
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public int Sid { get; set; }
        public Class Class { get; set; }
        public List<Mark> Mark { get; set; }
    }
}