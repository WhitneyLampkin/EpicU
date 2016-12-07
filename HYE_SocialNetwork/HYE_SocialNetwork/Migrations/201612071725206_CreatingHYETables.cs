namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingHYETables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HYEAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        UserResponse = c.Boolean(nullable: false),
                        Exposed = c.Int(),
                        RespondingUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.RespondingUser_Id)
                .Index(t => t.RespondingUser_Id);
            
            CreateTable(
                "dbo.HYEQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Question = c.String(),
                        Liked = c.Int(),
                        Inquirer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Inquirer_Id)
                .Index(t => t.Inquirer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HYEQuestions", "Inquirer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.HYEAnswers", "RespondingUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.HYEQuestions", new[] { "Inquirer_Id" });
            DropIndex("dbo.HYEAnswers", new[] { "RespondingUser_Id" });
            DropTable("dbo.HYEQuestions");
            DropTable("dbo.HYEAnswers");
        }
    }
}
