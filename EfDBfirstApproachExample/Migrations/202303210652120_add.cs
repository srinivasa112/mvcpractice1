namespace EfDBfirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "add");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "add", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
