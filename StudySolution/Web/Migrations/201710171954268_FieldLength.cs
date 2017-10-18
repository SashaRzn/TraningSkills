namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FieldLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Books", "Author", c => c.String(maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
        }
    }
}
