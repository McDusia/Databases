namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCustomerClass : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CompanyName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Customers", "CompanyName");
            DropColumn("dbo.Customers", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CompanyName", c => c.String());
            AddPrimaryKey("dbo.Customers", "CustomerId");
        }
    }
}
