namespace TutorOnline.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Adress = c.String(),
                        phone = c.String(),
                        Description = c.String(),
                        imageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Adress = c.String(),
                        phone = c.String(),
                        Description = c.String(),
                        imageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        Teacher_ID = c.Int(nullable: false),
                        Student_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_ID, t.Student_ID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Student_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherStudents", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.TeacherStudents", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.TeacherStudents", new[] { "Student_ID" });
            DropIndex("dbo.TeacherStudents", new[] { "Teacher_ID" });
            DropTable("dbo.TeacherStudents");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
