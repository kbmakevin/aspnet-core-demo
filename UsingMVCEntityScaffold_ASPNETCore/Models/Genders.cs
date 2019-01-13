using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsingMVCEntityScaffold_ASPNETCore.Models
{
    public partial class Genders
    {
        public Genders()
        {
            Students = new HashSet<Students>();
        }

        public int GenderId { get; set; }
        [DisplayName("Gender Name")]
        [Required(ErrorMessage = "Gender Name is Required.")]
        public string GenderName { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}
