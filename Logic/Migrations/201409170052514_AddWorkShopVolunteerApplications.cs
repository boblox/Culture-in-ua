namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkShopVolunteerApplications : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkShopVolunteerApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        SocialNetworkUrl = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Profession = c.String(nullable: false),
                        EnglishLevel = c.Int(nullable: false),
                        WorkTimeRange = c.String(nullable: false),
                        VolunteeringMotivation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkShopVolunteerApplications");
        }
    }
}
