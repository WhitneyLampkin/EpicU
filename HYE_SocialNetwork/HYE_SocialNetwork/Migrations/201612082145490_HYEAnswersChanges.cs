namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HYEAnswersChanges : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HYEAnswers", name: "Id", newName: "HYEQuestionId");
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_Id", newName: "IX_HYEQuestionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_HYEQuestionId", newName: "IX_Id");
            RenameColumn(table: "dbo.HYEAnswers", name: "HYEQuestionId", newName: "Id");
        }
    }
}
