namespace HYE_SocialNetwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnswerPropToHYEAnswer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HYEAnswers", "Answer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HYEAnswers", "Answer");
        }
    }
}
