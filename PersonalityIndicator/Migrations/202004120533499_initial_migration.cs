namespace PersonalityIndicator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        KeyNumber = c.Int(nullable: false, identity: true),
                        QuestionNumber = c.Int(nullable: false),
                        Questions = c.String(),
                    })
                .PrimaryKey(t => t.KeyNumber);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        KeyNumber = c.Int(nullable: false, identity: true),
                        AnswerNumber = c.Int(nullable: false),
                        Answers = c.String(),
                    })
                .PrimaryKey(t => t.KeyNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Answers");
            DropTable("dbo.Questions");
        }
    }
}
