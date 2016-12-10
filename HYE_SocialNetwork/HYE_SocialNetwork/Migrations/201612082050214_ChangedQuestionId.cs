namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedQuestionId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HYEAnswers", name: "QuestionId", newName: "Id");
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_QuestionId", newName: "IX_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_Id", newName: "IX_QuestionId");
            RenameColumn(table: "dbo.HYEAnswers", name: "Id", newName: "QuestionId");
        }
    }
}
