namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkShopFirstDayApplications : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkShopFirstDayApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Profession = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkShopFirstDayApplications");
        }
    }
}
