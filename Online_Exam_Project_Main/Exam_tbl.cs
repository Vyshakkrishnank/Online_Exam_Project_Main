﻿using System.ComponentModel.DataAnnotations;

namespace Online_Exam_Project_Main.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Exam_tbl
    {
        public Exam_tbl()
        {
            this.Questions_tbl = new HashSet<Questions_tbl>();
            this.Result_tbl = new HashSet<Result_tbl>();
        }
        [Key]
        public int exam_id { get; set; }

        [Required(ErrorMessage = "Exam Name Required")]

        [Display(Name = "Subject Name ")]
        public Nullable<int> subject_id { get; set; }
        [Required(ErrorMessage = "Exam title Required")]

        [Display(Name = "Exam Name ")]
        public string exam_title { get; set; }

        public virtual Subject_tbl Subject_tbl { get; set; }
        public virtual ICollection<Questions_tbl> Questions_tbl { get; set; }
        public virtual ICollection<Result_tbl> Result_tbl { get; set; }
    }
}