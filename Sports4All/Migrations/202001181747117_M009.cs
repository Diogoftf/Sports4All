namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M009 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parks", "Quality", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parks", "Quality");
        }



    }
}
