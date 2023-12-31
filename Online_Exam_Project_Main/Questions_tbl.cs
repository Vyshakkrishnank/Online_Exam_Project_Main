﻿using System.ComponentModel.DataAnnotations;

namespace Online_Exam_Project_Main.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Questions_tbl
    {
        [Key]
        public int all_qus_id { get; set; }
        [Required(ErrorMessage = "Question ID Required")]

        [Display(Name = "Question id ")]
        public Nullable<int> qus_id { get; set; }

        [Required(ErrorMessage = "Admin name Required")]

        [Display(Name = "Admin Name ")]
        public Nullable<int> admin_id { get; set; }

        [Required(ErrorMessage = "Exam name Required")]

        [Display(Name = "Exam Name ")]
        public Nullable<int> exam_id { get; set; }

        [Required(ErrorMessage = "Question Required")]

        [Display(Name = "Question Title ")]
        public string qus_title { get; set; }
        [Required(ErrorMessage = "Ans 1 Required")]

        [Display(Name = "Ans 1 ")]
        public string ans1 { get; set; }
        [Required(ErrorMessage = "Ans 2 Required")]

        [Display(Name = "Ans 2 ")]
        public string ans2 { get; set; }
        [Required(ErrorMessage = "Ans 3 Required")]

        [Display(Name = "Ans 3 ")]
        public string ans3 { get; set; }
        [Required(ErrorMessage = "Ans 4 Required")]

        [Display(Name = "Ans 4 ")]
        public string ans4 { get; set; }
        [Required(ErrorMessage = "Correct Answer Required")]

        [Display(Name = "Correct Answer ")]
        public Nullable<int> correct_ans { get; set; }
        public int selectedvalue { get; set; }
        public virtual Admin_tbl Admin_tbl { get; set; }
        public virtual Exam_tbl Exam_tbl { get; set; }
    }
}