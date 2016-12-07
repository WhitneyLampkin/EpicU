namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyToHYEQuestion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HYEQuestions", "Inquirer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.HYEQuestions", new[] { "Inquirer_Id" });
            RenameColumn(table: "dbo.HYEQuestions", name: "Inquirer_Id", newName: "InquirerId");
            AlterColumn("dbo.HYEQuestions", "InquirerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.HYEQuestions", "InquirerId");
            AddForeignKey("dbo.HYEQuestions", "InquirerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HYEQuestions", "InquirerId", "dbo.AspNetUsers");
            DropIndex("dbo.HYEQuestions", new[] { "InquirerId" });
            AlterColumn("dbo.HYEQuestions", "InquirerId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.HYEQuestions", name: "InquirerId", newName: "Inquirer_Id");
            CreateIndex("dbo.HYEQuestions", "Inquirer_Id");
            AddForeignKey("dbo.HYEQuestions", "Inquirer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
