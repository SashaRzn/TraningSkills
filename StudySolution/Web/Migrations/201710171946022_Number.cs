namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Number : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Number");
        }
    }
}
