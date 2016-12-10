namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAnswerModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HYEAnswers", name: "QId", newName: "QuestionId");
            RenameColumn(table: "dbo.HYEAnswers", name: "RespondingUser_Id", newName: "ResponderId");
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_QId", newName: "IX_QuestionId");
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_RespondingUser_Id", newName: "IX_ResponderId");
            DropPrimaryKey("dbo.HYEAnswers");
            AddPrimaryKey("dbo.HYEAnswers", new[] { "QuestionId", "ResponderId" });
            DropColumn("dbo.HYEAnswers", "Id");
            DropColumn("dbo.HYEAnswers", "UserResponse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HYEAnswers", "UserResponse", c => c.Boolean(nullable: false));
            AddColumn("dbo.HYEAnswers", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.HYEAnswers");
            AddPrimaryKey("dbo.HYEAnswers", "Id");
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_ResponderId", newName: "IX_RespondingUser_Id");
            RenameIndex(table: "dbo.HYEAnswers", name: "IX_QuestionId", newName: "IX_QId");
            RenameColumn(table: "dbo.HYEAnswers", name: "ResponderId", newName: "RespondingUser_Id");
            RenameColumn(table: "dbo.HYEAnswers", name: "QuestionId", newName: "QId");
        }
    }
}
