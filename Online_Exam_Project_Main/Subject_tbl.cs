using System.ComponentModel.DataAnnotations;

namespace Online_Exam_Project_Main.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Subject_tbl
    {
        public Subject_tbl()
        {
            this.Exam_tbl = new HashSet<Exam_tbl>();
        }
        [Key]
        public int subject_id { get; set; }

        [Required(ErrorMessage = "Subject Name Required")]

        [Display(Name = "Subject Name  ")]
        public string subject_title { get; set; }
        [Required(ErrorMessage = "Subject Code Required")]

        [Display(Name = "Subject Code  ")]
        public string subject_code { get; set; }

        public virtual ICollection<Exam_tbl> Exam_tbl { get; set; }
    }
}