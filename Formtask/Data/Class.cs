using System.ComponentModel.DataAnnotations;

namespace Formtask.Data
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int Fid { get; set; }
        public List<Enrollment> Enrollment { get; set; }
        public Faculty Faculty { get; set; }
    }
}
