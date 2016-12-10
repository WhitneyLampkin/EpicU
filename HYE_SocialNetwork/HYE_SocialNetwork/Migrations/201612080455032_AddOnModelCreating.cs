namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOnModelCreating : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HYEAnswers", "QuestionId", "dbo.HYEQuestions");
            AddForeignKey("dbo.HYEAnswers", "QuestionId", "dbo.HYEQuestions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HYEAnswers", "QuestionId", "dbo.HYEQuestions");
            AddForeignKey("dbo.HYEAnswers", "QuestionId", "dbo.HYEQuestions", "Id", cascadeDelete: true);
        }
    }
}
