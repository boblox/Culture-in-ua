namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkShopApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Country = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Profession = c.String(nullable: false),
                        EnglishLevel = c.Int(nullable: false),
                        OrganizationName = c.String(nullable: false),
                        LegalStatus = c.Int(nullable: false),
                        OrganizationInfo = c.String(nullable: false),
                        ParticipantsNumber = c.Int(nullable: false),
                        Motivation1 = c.String(),
                        Motivation2 = c.String(),
                        Motivation3 = c.String(),
                        Motivation4 = c.String(),
                        Motivation5 = c.String(),
                        Motivation6 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkShopApplications");
        }
    }
}
