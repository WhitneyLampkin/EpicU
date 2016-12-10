namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInquirerIdToHYEQuestions : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HYEQuestions", name: "Inquirer_Id", newName: "InquirerId");
            RenameIndex(table: "dbo.HYEQuestions", name: "IX_Inquirer_Id", newName: "IX_InquirerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.HYEQuestions", name: "IX_InquirerId", newName: "IX_Inquirer_Id");
            RenameColumn(table: "dbo.HYEQuestions", name: "InquirerId", newName: "Inquirer_Id");
        }
    }
}
