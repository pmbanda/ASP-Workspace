namespace KOKC_Web_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movies", "Genre", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 60));
        }
    }
}
