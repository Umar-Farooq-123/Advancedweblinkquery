using System.ComponentModel.DataAnnotations;

namespace Formtask.Data
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string Fname { get; set; }
        public int DeptId { get; set; }
        public string Standing { get; set; }
        public List<Class> Class { get; set; }
    }
}
