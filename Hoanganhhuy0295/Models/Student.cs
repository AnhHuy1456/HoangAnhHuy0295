using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hoanganhhuy0295.Models
{
    public class Student
    {
        [Key]
        public string Masinhvien { get; set; }
        public string Hoten { get; set; }
        public string Tuoi { get; set; }
    }
}