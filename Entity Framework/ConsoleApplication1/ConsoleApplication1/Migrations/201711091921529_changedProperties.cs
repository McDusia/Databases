namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedProperties : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_CompanyName", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_CompanyName" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CompanyName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Description", c => c.String(maxLength: 255));
            AlterColumn("dbo.Orders", "Customer_CompanyName", c => c.String(maxLength: 255));
            AddPrimaryKey("dbo.Customers", "CompanyName");
            CreateIndex("dbo.Orders", "Customer_CompanyName");
            AddForeignKey("dbo.Orders", "Customer_CompanyName", "dbo.Customers", "CompanyName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Customer_CompanyName", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_CompanyName" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Orders", "Customer_CompanyName", c => c.String(maxLength: 128));
            AlterColumn("dbo.Customers", "Description", c => c.String());
            AlterColumn("dbo.Customers", "CompanyName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Customers", "CompanyName");
            CreateIndex("dbo.Orders", "Customer_CompanyName");
            AddForeignKey("dbo.Orders", "Customer_CompanyName", "dbo.Customers", "CompanyName");
        }
    }
}
