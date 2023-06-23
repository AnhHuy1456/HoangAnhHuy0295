using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoanganhhuy0295.Models
{
    public class Employee
    {
        [Key]
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public string Masinhvien { get; set; }
    }
}