namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reserves", "ReserveId", "dbo.Events");
            DropForeignKey("dbo.Uses", "ReserveId", "dbo.Reserves");
            AddForeignKey("dbo.Reserves", "ReserveId", "dbo.Events", "EventId", cascadeDelete: true);
            AddForeignKey("dbo.Uses", "ReserveId", "dbo.Reserves", "ReserveId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uses", "ReserveId", "dbo.Reserves");
            DropForeignKey("dbo.Reserves", "ReserveId", "dbo.Events");
            AddForeignKey("dbo.Uses", "ReserveId", "dbo.Reserves", "ReserveId");
            AddForeignKey("dbo.Reserves", "ReserveId", "dbo.Events", "EventId");
        }
    }
}
