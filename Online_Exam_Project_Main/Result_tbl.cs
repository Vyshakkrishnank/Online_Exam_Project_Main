namespace Online_Exam_Project_Main.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Result_tbl
    {
        [Key]
        public int result_id { get; set; }
        public Nullable<int> exam_id { get; set; }
        public Nullable<int> candidate_id { get; set; }
        public Nullable<int> total { get; set; }
        public string grade { get; set; }
        public string quality { get; set; }

        public virtual Candidate_tbl Candidate_tbl { get; set; }
        public virtual Exam_tbl Exam_tbl { get; set; }
    }
}