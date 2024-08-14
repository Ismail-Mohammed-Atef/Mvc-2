using System.ComponentModel.DataAnnotations.Schema;

namespace Depi_MVC.Models
{
    public class CourseResults
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }

        public virtual Course Course { get; set; }

        [ForeignKey("Trainee")]

        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
