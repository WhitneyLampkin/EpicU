namespace SocialMediaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateScenarioTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ScenarioModels (Id, Backstory, Date, WrongAnsA, WrongAnsB, CorrectAns, SourceLink, Result, Goal, MyProperty) VALUES (1, On August 28, 1963, Martin Luther King, Jr. approached the podium near the Lincoln Memorial with something he didn’t normally need: notes. Sensing the importance of the moment, King had stayed up late the night before perfecting his speech. But as he delivered it, he came to a line that wasn’t quite right. Off to the side, the singer Mahalia Jackson shouted, “Tell them about the dream, Martin!” King paused, looked out over the crowd, and went off-script, saying, “I say to you today, my friends, even though we face the difficulties of today and tomorrow, I still have a dream.” The rest of the speech stayed on that theme and “I have a dream” went down in history as one of the most memorable phrases ever delivered., 08/28/1963, Stay on script., Have her escorted out., Follow her lead and go off script., http://www.rd.com/culture/split-second-decisions-history/, The \"I have a dream\" speech., ")
        }
        
        public override void Down()
        {
        }
    }
}
