namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideDBConventions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HYEAnswers", "RespondingUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.HYEAnswers", new[] { "RespondingUser_Id" });
            AlterColumn("dbo.HYEAnswers", "RespondingUser_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.HYEQuestions", "Question", c => c.String(nullable: false));
            CreateIndex("dbo.HYEAnswers", "RespondingUser_Id");
            AddForeignKey("dbo.HYEAnswers", "RespondingUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HYEAnswers", "RespondingUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.HYEAnswers", new[] { "RespondingUser_Id" });
            AlterColumn("dbo.HYEQuestions", "Question", c => c.String());
            AlterColumn("dbo.HYEAnswers", "RespondingUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.HYEAnswers", "RespondingUser_Id");
            AddForeignKey("dbo.HYEAnswers", "RespondingUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
