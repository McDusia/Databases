namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToOrderClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Date");
        }
    }
}
