using System.Collections.Generic;
namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    public int StudentId { get; set; }
    public string Description { get; set; }
    public string AdmissionDate { get; set; }

    public ICollection<CourseStudent> Courses { get; }
  }
}