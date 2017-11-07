namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProducts : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Categories");
            AddColumn("dbo.Categories", "CategoryId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "CategoryId");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            DropColumn("dbo.Categories", "CategotyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategotyId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "CategoryId");
            AddPrimaryKey("dbo.Categories", "CategotyId");
        }
    }
}
