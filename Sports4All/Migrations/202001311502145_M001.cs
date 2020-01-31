namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        PostalCode = c.String(),
                        Street = c.String(),
                        CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Counties", t => t.CountyId, cascadeDelete: true)
                .Index(t => t.CountyId);
            
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        CountyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CountyId)
                .ForeignKey("dbo.Districts", t => t.DistrictId)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DistrictId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        CountyId = c.Int(nullable: false),
                        PictureId = c.Int(nullable: false),
                        UserClassification_ClassificationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Counties", t => t.CountyId)
                .ForeignKey("dbo.Pictures", t => t.PictureId)
                .ForeignKey("dbo.UserClassifications", t => t.UserClassification_ClassificationId)
                .Index(t => t.CountyId)
                .Index(t => t.PictureId)
                .Index(t => t.UserClassification_ClassificationId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        MaxPlayers = c.Int(nullable: false),
                        MaxAge = c.Int(nullable: false),
                        MinAge = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Reserves",
                c => new
                    {
                        ReserveId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        SportId = c.Int(nullable: false),
                        GroundId = c.Int(nullable: false),
                        Use_UseId = c.Int(),
                    })
                .PrimaryKey(t => t.ReserveId)
                .ForeignKey("dbo.Uses", t => t.Use_UseId)
                .ForeignKey("dbo.Grounds", t => t.GroundId)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Events", t => t.ReserveId, cascadeDelete: true)
                .Index(t => t.ReserveId)
                .Index(t => t.UserId)
                .Index(t => t.SportId)
                .Index(t => t.GroundId)
                .Index(t => t.Use_UseId);
            
            CreateTable(
                "dbo.Grounds",
                c => new
                    {
                        GroundId = c.Int(nullable: false, identity: true),
                        ParkId = c.Int(nullable: false),
                        Picture_PictureId = c.Int(),
                    })
                .PrimaryKey(t => t.GroundId)
                .ForeignKey("dbo.Pictures", t => t.Picture_PictureId)
                .ForeignKey("dbo.Parks", t => t.ParkId)
                .Index(t => t.ParkId)
                .Index(t => t.Picture_PictureId);
            
            CreateTable(
                "dbo.Parks",
                c => new
                    {
                        ParkId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Picture_PictureId = c.Int(),
                        Address_AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.ParkId)
                .ForeignKey("dbo.Pictures", t => t.Picture_PictureId)
                .ForeignKey("dbo.ParkClassifications", t => t.ParkId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .Index(t => t.ParkId)
                .Index(t => t.Picture_PictureId)
                .Index(t => t.Address_AddressId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Available = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        SportId = c.Int(nullable: false),
                        ParkId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId)
                .ForeignKey("dbo.Parks", t => t.ParkId, cascadeDelete: true)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId)
                .Index(t => t.ParkId);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        SportId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Picture_PictureId = c.Int(),
                    })
                .PrimaryKey(t => t.SportId)
                .ForeignKey("dbo.Pictures", t => t.Picture_PictureId)
                .Index(t => t.Picture_PictureId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        PictureId = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.PictureId);
            
            CreateTable(
                "dbo.Uses",
                c => new
                    {
                        UseId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        MaterialId = c.Int(nullable: false),
                        ReserveId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UseId)
                .ForeignKey("dbo.Materials", t => t.MaterialId)
                .ForeignKey("dbo.Reserves", t => t.ReserveId, cascadeDelete: true)
                .Index(t => t.MaterialId)
                .Index(t => t.ReserveId);
            
            CreateTable(
                "dbo.SportsGrounds",
                c => new
                    {
                        SportRefId = c.Int(nullable: false),
                        GroundRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SportRefId, t.GroundRefId })
                .ForeignKey("dbo.Sports", t => t.SportRefId, cascadeDelete: true)
                .ForeignKey("dbo.Grounds", t => t.GroundRefId, cascadeDelete: true)
                .Index(t => t.SportRefId)
                .Index(t => t.GroundRefId);
            
            CreateTable(
                "dbo.EventsUsers",
                c => new
                    {
                        EventRefId = c.Int(nullable: false),
                        UserRefId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.EventRefId, t.UserRefId })
                .ForeignKey("dbo.Events", t => t.EventRefId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserRefId, cascadeDelete: true)
                .Index(t => t.EventRefId)
                .Index(t => t.UserRefId);
            
            CreateTable(
                "dbo.UserEvaluations",
                c => new
                    {
                        EvaluationId = c.Int(nullable: false),
                        EvaluatorId = c.String(nullable: false, maxLength: 128),
                        EventId = c.Int(nullable: false),
                        Skill = c.Int(nullable: false),
                        FairPlay = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EvaluationId)
                .ForeignKey("dbo.Users", t => t.EvaluatorId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.EvaluatorId)
                .Index(t => t.EventId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ParkEvaluations",
                c => new
                    {
                        EvaluationId = c.Int(nullable: false),
                        EvaluatorId = c.String(nullable: false, maxLength: 128),
                        EventId = c.Int(nullable: false),
                        Quality = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ParkId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluationId)
                .ForeignKey("dbo.Users", t => t.EvaluatorId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.Parks", t => t.ParkId)
                .Index(t => t.EvaluatorId)
                .Index(t => t.EventId)
                .Index(t => t.ParkId);
            
            CreateTable(
                "dbo.UserClassifications",
                c => new
                    {
                        ClassificationId = c.Int(nullable: false),
                        Points = c.Double(nullable: false),
                        Ratio = c.Double(nullable: false),
                        FairplayAverage = c.Double(nullable: false),
                        SkillAverage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ClassificationId);
            
            CreateTable(
                "dbo.ParkClassifications",
                c => new
                    {
                        ClassificationId = c.Int(nullable: false),
                        Points = c.Double(nullable: false),
                        Ratio = c.Double(nullable: false),
                        QualityAverage = c.Double(nullable: false),
                        PriceAverage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ClassificationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParkEvaluations", "ParkId", "dbo.Parks");
            DropForeignKey("dbo.ParkEvaluations", "EventId", "dbo.Events");
            DropForeignKey("dbo.ParkEvaluations", "EvaluatorId", "dbo.Users");
            DropForeignKey("dbo.UserEvaluations", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserEvaluations", "EventId", "dbo.Events");
            DropForeignKey("dbo.UserEvaluations", "EvaluatorId", "dbo.Users");
            DropForeignKey("dbo.Parks", "Address_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "CountyId", "dbo.Counties");
            DropForeignKey("dbo.Users", "UserClassification_ClassificationId", "dbo.UserClassifications");
            DropForeignKey("dbo.Users", "PictureId", "dbo.Pictures");
            DropForeignKey("dbo.EventsUsers", "UserRefId", "dbo.Users");
            DropForeignKey("dbo.EventsUsers", "EventRefId", "dbo.Events");
            DropForeignKey("dbo.Reserves", "ReserveId", "dbo.Events");
            DropForeignKey("dbo.Reserves", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reserves", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Reserves", "GroundId", "dbo.Grounds");
            DropForeignKey("dbo.Grounds", "ParkId", "dbo.Parks");
            DropForeignKey("dbo.Parks", "ParkId", "dbo.ParkClassifications");
            DropForeignKey("dbo.Reserves", "Use_UseId", "dbo.Uses");
            DropForeignKey("dbo.Uses", "ReserveId", "dbo.Reserves");
            DropForeignKey("dbo.Uses", "MaterialId", "dbo.Materials");
            DropForeignKey("dbo.Materials", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Sports", "Picture_PictureId", "dbo.Pictures");
            DropForeignKey("dbo.Parks", "Picture_PictureId", "dbo.Pictures");
            DropForeignKey("dbo.Grounds", "Picture_PictureId", "dbo.Pictures");
            DropForeignKey("dbo.SportsGrounds", "GroundRefId", "dbo.Grounds");
            DropForeignKey("dbo.SportsGrounds", "SportRefId", "dbo.Sports");
            DropForeignKey("dbo.Materials", "ParkId", "dbo.Parks");
            DropForeignKey("dbo.Users", "CountyId", "dbo.Counties");
            DropForeignKey("dbo.Counties", "DistrictId", "dbo.Districts");
            DropIndex("dbo.ParkEvaluations", new[] { "ParkId" });
            DropIndex("dbo.ParkEvaluations", new[] { "EventId" });
            DropIndex("dbo.ParkEvaluations", new[] { "EvaluatorId" });
            DropIndex("dbo.UserEvaluations", new[] { "UserId" });
            DropIndex("dbo.UserEvaluations", new[] { "EventId" });
            DropIndex("dbo.UserEvaluations", new[] { "EvaluatorId" });
            DropIndex("dbo.EventsUsers", new[] { "UserRefId" });
            DropIndex("dbo.EventsUsers", new[] { "EventRefId" });
            DropIndex("dbo.SportsGrounds", new[] { "GroundRefId" });
            DropIndex("dbo.SportsGrounds", new[] { "SportRefId" });
            DropIndex("dbo.Uses", new[] { "ReserveId" });
            DropIndex("dbo.Uses", new[] { "MaterialId" });
            DropIndex("dbo.Sports", new[] { "Picture_PictureId" });
            DropIndex("dbo.Materials", new[] { "ParkId" });
            DropIndex("dbo.Materials", new[] { "SportId" });
            DropIndex("dbo.Parks", new[] { "Address_AddressId" });
            DropIndex("dbo.Parks", new[] { "Picture_PictureId" });
            DropIndex("dbo.Parks", new[] { "ParkId" });
            DropIndex("dbo.Grounds", new[] { "Picture_PictureId" });
            DropIndex("dbo.Grounds", new[] { "ParkId" });
            DropIndex("dbo.Reserves", new[] { "Use_UseId" });
            DropIndex("dbo.Reserves", new[] { "GroundId" });
            DropIndex("dbo.Reserves", new[] { "SportId" });
            DropIndex("dbo.Reserves", new[] { "UserId" });
            DropIndex("dbo.Reserves", new[] { "ReserveId" });
            DropIndex("dbo.Users", new[] { "UserClassification_ClassificationId" });
            DropIndex("dbo.Users", new[] { "PictureId" });
            DropIndex("dbo.Users", new[] { "CountyId" });
            DropIndex("dbo.Counties", new[] { "DistrictId" });
            DropIndex("dbo.Addresses", new[] { "CountyId" });
            DropTable("dbo.ParkClassifications");
            DropTable("dbo.UserClassifications");
            DropTable("dbo.ParkEvaluations");
            DropTable("dbo.UserEvaluations");
            DropTable("dbo.EventsUsers");
            DropTable("dbo.SportsGrounds");
            DropTable("dbo.Uses");
            DropTable("dbo.Pictures");
            DropTable("dbo.Sports");
            DropTable("dbo.Materials");
            DropTable("dbo.Parks");
            DropTable("dbo.Grounds");
            DropTable("dbo.Reserves");
            DropTable("dbo.Events");
            DropTable("dbo.Users");
            DropTable("dbo.Districts");
            DropTable("dbo.Counties");
            DropTable("dbo.Addresses");
        }
    }
}
