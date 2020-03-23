using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
    {
        public Course()
        {
            this.Students = new HashSet<CourseItem>();
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CourseItem> Students { get; set; }
    }
}