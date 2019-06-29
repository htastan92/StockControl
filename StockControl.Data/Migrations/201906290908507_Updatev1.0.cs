namespace StockControl.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatev10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personels", "IdentityNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personels", "IdentityNumber", c => c.Int(nullable: false));
        }
    }
}
