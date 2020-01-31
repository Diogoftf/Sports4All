namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grounds", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grounds", "Price");
        }
    }
}
