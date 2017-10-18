namespace IGPUep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_id : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payees",
                c => new
                    {
                        PayeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 4000),
                        MiddleName = c.String(maxLength: 4000),
                        LastName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.PayeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payees");
        }
    }
}
