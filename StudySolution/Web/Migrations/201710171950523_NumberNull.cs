namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Number", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Number", c => c.Int(nullable: false));
        }
    }
}
