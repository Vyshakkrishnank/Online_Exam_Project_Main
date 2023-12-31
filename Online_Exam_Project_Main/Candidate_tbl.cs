﻿using System.ComponentModel.DataAnnotations;

namespace Online_Exam_Project_Main.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Candidate_tbl
    {
        public Candidate_tbl()
        {
            this.Result_tbl = new HashSet<Result_tbl>();
        }
        [Key]
        public int candidate_id { get; set; }
        [Required(ErrorMessage = "Name Required")]

        [Display(Name = "Candidate Name ")]
        public string candidate_name { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password ")]
        public string candidate_password { get; set; }
        [Required(ErrorMessage = "Email Required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email ")]
        public string candidate_email { get; set; }
        [Required(ErrorMessage = "Contact Required")]

        [Display(Name = "Contact ")]
        public Nullable<decimal> candidate_contact { get; set; }

        [Required(ErrorMessage = "Institution Required")]

        [Display(Name = "Institution ")]
        public string candidate_institution { get; set; }

        public virtual ICollection<Result_tbl> Result_tbl { get; set; }
    }
}