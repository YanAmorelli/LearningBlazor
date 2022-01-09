using System.ComponentModel.DataAnnotations;

namespace LearningBlazor.Data
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentAge { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
}