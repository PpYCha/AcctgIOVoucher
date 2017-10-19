namespace IGPUep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteAddressInVouchher : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vouchers", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vouchers", "Address", c => c.String(maxLength: 4000));
        }
    }
}
