namespace Online_Exam_Project_Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin_tbl",
                c => new
                    {
                        admin_id = c.Int(nullable: false, identity: true),
                        admin_name = c.String(nullable: false),
                        admin_password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.admin_id);
            
            CreateTable(
                "dbo.Questions_tbl",
                c => new
                    {
                        all_qus_id = c.Int(nullable: false, identity: true),
                        qus_id = c.Int(nullable: false),
                        admin_id = c.Int(nullable: false),
                        exam_id = c.Int(nullable: false),
                        qus_title = c.String(nullable: false),
                        ans1 = c.String(nullable: false),
                        ans2 = c.String(nullable: false),
                        ans3 = c.String(nullable: false),
                        ans4 = c.String(nullable: false),
                        correct_ans = c.Int(nullable: false),
                        selectedvalue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.all_qus_id)
                .ForeignKey("dbo.Admin_tbl", t => t.admin_id, cascadeDelete: true)
                .ForeignKey("dbo.Exam_tbl", t => t.exam_id, cascadeDelete: true)
                .Index(t => t.admin_id)
                .Index(t => t.exam_id);
            
            CreateTable(
                "dbo.Exam_tbl",
                c => new
                    {
                        exam_id = c.Int(nullable: false, identity: true),
                        subject_id = c.Int(nullable: false),
                        exam_title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.exam_id)
                .ForeignKey("dbo.Subject_tbl", t => t.subject_id, cascadeDelete: true)
                .Index(t => t.subject_id);
            
            CreateTable(
                "dbo.Result_tbl",
                c => new
                    {
                        result_id = c.Int(nullable: false, identity: true),
                        exam_id = c.Int(),
                        candidate_id = c.Int(),
                        total = c.Int(),
                        grade = c.String(),
                        quality = c.String(),
                    })
                .PrimaryKey(t => t.result_id)
                .ForeignKey("dbo.Candidate_tbl", t => t.candidate_id)
                .ForeignKey("dbo.Exam_tbl", t => t.exam_id)
                .Index(t => t.exam_id)
                .Index(t => t.candidate_id);
            
            CreateTable(
                "dbo.Candidate_tbl",
                c => new
                    {
                        candidate_id = c.Int(nullable: false, identity: true),
                        candidate_name = c.String(nullable: false),
                        candidate_password = c.String(nullable: false),
                        candidate_email = c.String(nullable: false),
                        candidate_contact = c.Decimal(nullable: false, precision: 18, scale: 2),
                        candidate_institution = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.candidate_id);
            
            CreateTable(
                "dbo.Subject_tbl",
                c => new
                    {
                        subject_id = c.Int(nullable: false, identity: true),
                        subject_title = c.String(nullable: false),
                        subject_code = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.subject_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exam_tbl", "subject_id", "dbo.Subject_tbl");
            DropForeignKey("dbo.Result_tbl", "exam_id", "dbo.Exam_tbl");
            DropForeignKey("dbo.Result_tbl", "candidate_id", "dbo.Candidate_tbl");
            DropForeignKey("dbo.Questions_tbl", "exam_id", "dbo.Exam_tbl");
            DropForeignKey("dbo.Questions_tbl", "admin_id", "dbo.Admin_tbl");
            DropIndex("dbo.Result_tbl", new[] { "candidate_id" });
            DropIndex("dbo.Result_tbl", new[] { "exam_id" });
            DropIndex("dbo.Exam_tbl", new[] { "subject_id" });
            DropIndex("dbo.Questions_tbl", new[] { "exam_id" });
            DropIndex("dbo.Questions_tbl", new[] { "admin_id" });
            DropTable("dbo.Subject_tbl");
            DropTable("dbo.Candidate_tbl");
            DropTable("dbo.Result_tbl");
            DropTable("dbo.Exam_tbl");
            DropTable("dbo.Questions_tbl");
            DropTable("dbo.Admin_tbl");
        }
    }
}
