using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Online_Exam_Project_Main.Models
{
    public partial class Admin_tbl
    {
        public Admin_tbl()
        {
            this.Questions_tbl = new HashSet<Questions_tbl>();
        }
        [Key]
        public int admin_id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [Display(Name = "Admin Name")]
        public string admin_name { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string admin_password { get; set; }

        public virtual ICollection<Questions_tbl> Questions_tbl { get; set; }
    }
}
