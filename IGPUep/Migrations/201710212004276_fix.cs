namespace IGPUep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vouchers", "DateTime2", c => c.DateTime());
            AddColumn("dbo.Vouchers", "DateTim3", c => c.DateTime());
            AddColumn("dbo.Vouchers", "AFName", c => c.String(maxLength: 4000));
            AddColumn("dbo.Vouchers", "AMName", c => c.String(maxLength: 4000));
            AddColumn("dbo.Vouchers", "ALName", c => c.String(maxLength: 4000));
            AddColumn("dbo.Vouchers", "AJobPosition", c => c.String(maxLength: 4000));
            AddColumn("dbo.Vouchers", "PName", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vouchers", "PName");
            DropColumn("dbo.Vouchers", "AJobPosition");
            DropColumn("dbo.Vouchers", "ALName");
            DropColumn("dbo.Vouchers", "AMName");
            DropColumn("dbo.Vouchers", "AFName");
            DropColumn("dbo.Vouchers", "DateTim3");
            DropColumn("dbo.Vouchers", "DateTime2");
        }
    }
}
