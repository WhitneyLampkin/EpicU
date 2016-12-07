namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HYEAnswers", "QId", c => c.Int(nullable: false));
            CreateIndex("dbo.HYEAnswers", "QId");
            AddForeignKey("dbo.HYEAnswers", "QId", "dbo.HYEQuestions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HYEAnswers", "QId", "dbo.HYEQuestions");
            DropIndex("dbo.HYEAnswers", new[] { "QId" });
            DropColumn("dbo.HYEAnswers", "QId");
        }
    }
}
