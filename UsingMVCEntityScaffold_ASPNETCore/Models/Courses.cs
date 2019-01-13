using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsingMVCEntityScaffold_ASPNETCore.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Enrollments = new HashSet<Enrollments>();
        }

        public int CourseId { get; set; }
        [DisplayName("Course Name")]
        [Required(ErrorMessage = "Course Name is Required.")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Credits is Required.")]
        public string Credits { get; set; }

        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
