namespace QuizAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adddata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerID = c.Int(nullable: false, identity: true),
                        QuestionID = c.Int(nullable: false),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.AnswerID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryText = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                        QuestionType = c.String(),
                        Answer = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionID);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        QuizID = c.Int(nullable: false, identity: true),
                        QuizType = c.String(),
                        CategoryID = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.QuizID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quizs");
            DropTable("dbo.Questions");
            DropTable("dbo.Categories");
            DropTable("dbo.Answers");
        }
    }
}
