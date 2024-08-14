namespace Depi_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<CourseResults> CourseResults { get; set; }

    }
}
