using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADOnet.EF_core;

public class Course
{
    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CourseId { get; set; }
    public string Title { get; set; }
    
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    
    public ICollection<CourseStudent> CourseStudents { get; set; }
}