namespace IGPUep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Igpss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IGPs",
                c => new
                    {
                        IGPsID = c.Int(nullable: false, identity: true),
                        IGPsName = c.String(maxLength: 4000),
                        IGPsZone = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.IGPsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IGPs");
        }
    }
}
