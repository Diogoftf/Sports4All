namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M010 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        idClassification = c.Int(nullable: false, identity: true),
                        rankClassification = c.Int(nullable: false),
                        points = c.Double(nullable: false),
                        racio = c.Double(nullable: false),
                        fairplayAverage = c.Double(nullable: false),
                        skillAverage = c.Double(nullable: false),
                        userId_Username = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.idClassification)
                .ForeignKey("dbo.Users", t => t.userId_Username)
                .Index(t => t.userId_Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classifications", "userId_Username", "dbo.Users");
            DropIndex("dbo.Classifications", new[] { "userId_Username" });
            DropTable("dbo.Classifications");
        }
    }
}
