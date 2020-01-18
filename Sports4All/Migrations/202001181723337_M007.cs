namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M007 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parks", "Description", c => c.String());
            DropColumn("dbo.Events", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Description", c => c.String());
            DropColumn("dbo.Parks", "Description");
        }
    }
}
