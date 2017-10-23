namespace IGPUep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteAddress : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Addresses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Zone = c.String(maxLength: 4000),
                        Baranggay = c.String(maxLength: 4000),
                        Municipality = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.AddressID);
            
        }
    }
}
