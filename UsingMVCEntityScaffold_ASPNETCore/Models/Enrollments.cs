using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsingMVCEntityScaffold_ASPNETCore.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public partial class Enrollments
    {
        public int EnrollmentId { get; set; }
        [DisplayName("Student Name")]
        [Required(ErrorMessage = "Student is Required.")]
        public int? StudentId { get; set; }
        [DisplayName("Course Name")]
        [Required(ErrorMessage = "Course is Required.")]
        public int? CourseId { get; set; }
        [DisplayName("Start Date")]
        [Required(ErrorMessage = "Start Date is Required.")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("End Date")]
        [Required(ErrorMessage = "End Date is Required.")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [DisplayFormat(NullDisplayText = "No Grade")]
        public Grade? Grade { get; set; }

        public Courses Course { get; set; }
        public Students Student { get; set; }
    }
}
