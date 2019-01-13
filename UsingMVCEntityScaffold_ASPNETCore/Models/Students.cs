using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsingMVCEntityScaffold_ASPNETCore.Models
{
    public enum Status
    {
        Undergraduate, Postgraduate, PhD, Suspended
    }

    public partial class Students
    {
        public Students()
        {
            Enrollments = new HashSet<Enrollments>();
        }

        public int StudentId { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required.")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required.")]
        public string LastName { get; set; }
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is Required.")]
        [DataType(DataType.Date)]
        public DateTime? Dob { get; set; }
        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is Required.")]
        public int? GenderId { get; set; }
        [DisplayName("Registration Date")]
        [Required(ErrorMessage = "Registration Date is Required.")]
        [DataType(DataType.Date)]
        public DateTime? RegistrationDate { get; set; }
        [DisplayFormat(NullDisplayText = "No Status")]
        public Status? Status { get; set; }

        public Genders Gender { get; set; }
        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
