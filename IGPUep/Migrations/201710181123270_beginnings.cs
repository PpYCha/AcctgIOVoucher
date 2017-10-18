namespace IGPUep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class beginnings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vouchers",
                c => new
                    {
                        VoucherID = c.Int(nullable: false, identity: true),
                        FundCluster = c.String(maxLength: 4000),
                        DVNumber = c.String(maxLength: 4000),
                        ModeOfPayment = c.String(maxLength: 4000),
                        TinOrEmployeeNumber = c.String(maxLength: 4000),
                        OrsOrBurs = c.String(maxLength: 4000),
                        Address = c.String(maxLength: 4000),
                        Particulars = c.String(maxLength: 4000),
                        Amount = c.String(maxLength: 4000),
                        MFOPAP = c.String(maxLength: 4000),
                        AccountTitle = c.String(maxLength: 4000),
                        UacsCode = c.String(maxLength: 4000),
                        Credit = c.String(maxLength: 4000),
                        Debit = c.String(maxLength: 4000),
                        JevNumber = c.String(maxLength: 4000),
                        DateTIme1 = c.DateTime(),
                    })
                .PrimaryKey(t => t.VoucherID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vouchers");
        }
    }
}
