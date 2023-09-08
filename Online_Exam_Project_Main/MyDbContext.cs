using System;
using System.Collections.Generic;
using System.Data.Entity;
using Online_Exam_Project_Main.Models;

namespace Online_Exam_Project_Main
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("Server=MS005;Database=Exam_Quiz;Trusted_Connection=True;")
        {
            // Constructor logic, if needed
        }
    
        public DbSet<Admin_tbl> Admin_tbl { get; set; }
        public DbSet<Candidate_tbl> Candidate_tbl { get; set; }
        public DbSet<Exam_tbl> Exam_tbl { get; set; }
        public DbSet<Questions_tbl> Questions_tbl { get; set; }
        public DbSet<Result_tbl> Result_tbl { get; set; }
        public DbSet<Subject_tbl> Subject_tbl { get; set; }
        // Other configurations, if needed
    }
}
