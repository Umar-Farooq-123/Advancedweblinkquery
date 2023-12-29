using System.ComponentModel.DataAnnotations;

namespace Formtask.Data
{
    public class Mark
    {
        [Key]
        public int MarkId { get; set; }
        public int Score { get; set; }
        public int Sid { get; set; }
        public int Cid { get; set; }
    }
}
