﻿namespace Sports4All.Migrations
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
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Counties", t => t.CountyId)
                .Index(t => t.CountyId);
            
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
                        Price = c.Double(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        SportId = c.Int(nullable: false),
                        GroundId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReserveId)
                .ForeignKey("dbo.Grounds", t => t.GroundId)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Events", t => t.ReserveId)
                .Index(t => t.ReserveId)
                .Index(t => t.UserId)
                .Index(t => t.SportId)
                .Index(t => t.GroundId);
            
            CreateTable(
                "dbo.Grounds",
                c => new
                    {
                        GroundId = c.Int(nullable: false),
                        ParkId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroundId)
                .ForeignKey("dbo.Pictures", t => t.GroundId)
                .ForeignKey("dbo.Parks", t => t.ParkId)
                .Index(t => t.GroundId)
                .Index(t => t.ParkId);
            
            CreateTable(
                "dbo.Parks",
                c => new
                    {
                        ParkId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ParkId)
                .ForeignKey("dbo.Pictures", t => t.ParkId)
                .ForeignKey("dbo.Addresses", t => t.ParkId)
                .Index(t => t.ParkId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        PictureId = c.Int(nullable: false, identity: true),
                        PicdtureBody = c.String(),
                        User_Username = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PictureId)
                .ForeignKey("dbo.Users", t => t.User_Username)
                .Index(t => t.User_Username);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        SportId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SportId)
                .ForeignKey("dbo.Pictures", t => t.SportId)
                .Index(t => t.SportId);
            
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
                "dbo.GroundEvaluations",
                c => new
                    {
                        EvaluationId = c.Int(nullable: false),
                        EvaluatorId = c.String(nullable: false, maxLength: 128),
                        EventId = c.Int(nullable: false),
                        Quality = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        GroundId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluationId)
                .ForeignKey("dbo.Users", t => t.EvaluatorId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.Grounds", t => t.GroundId)
                .Index(t => t.EvaluatorId)
                .Index(t => t.EventId)
                .Index(t => t.GroundId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroundEvaluations", "GroundId", "dbo.Grounds");
            DropForeignKey("dbo.GroundEvaluations", "EventId", "dbo.Events");
            DropForeignKey("dbo.GroundEvaluations", "EvaluatorId", "dbo.Users");
            DropForeignKey("dbo.UserEvaluations", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserEvaluations", "EventId", "dbo.Events");
            DropForeignKey("dbo.UserEvaluations", "EvaluatorId", "dbo.Users");
            DropForeignKey("dbo.Parks", "ParkId", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "CountyId", "dbo.Counties");
            DropForeignKey("dbo.Pictures", "User_Username", "dbo.Users");
            DropForeignKey("dbo.EventsUsers", "UserRefId", "dbo.Users");
            DropForeignKey("dbo.EventsUsers", "EventRefId", "dbo.Events");
            DropForeignKey("dbo.Reserves", "ReserveId", "dbo.Events");
            DropForeignKey("dbo.Reserves", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reserves", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Reserves", "GroundId", "dbo.Grounds");
            DropForeignKey("dbo.Grounds", "ParkId", "dbo.Parks");
            DropForeignKey("dbo.Sports", "SportId", "dbo.Pictures");
            DropForeignKey("dbo.SportsGrounds", "GroundRefId", "dbo.Grounds");
            DropForeignKey("dbo.SportsGrounds", "SportRefId", "dbo.Sports");
            DropForeignKey("dbo.Parks", "ParkId", "dbo.Pictures");
            DropForeignKey("dbo.Grounds", "GroundId", "dbo.Pictures");
            DropForeignKey("dbo.Users", "CountyId", "dbo.Counties");
            DropForeignKey("dbo.Counties", "DistrictId", "dbo.Districts");
            DropIndex("dbo.GroundEvaluations", new[] { "GroundId" });
            DropIndex("dbo.GroundEvaluations", new[] { "EventId" });
            DropIndex("dbo.GroundEvaluations", new[] { "EvaluatorId" });
            DropIndex("dbo.UserEvaluations", new[] { "UserId" });
            DropIndex("dbo.UserEvaluations", new[] { "EventId" });
            DropIndex("dbo.UserEvaluations", new[] { "EvaluatorId" });
            DropIndex("dbo.EventsUsers", new[] { "UserRefId" });
            DropIndex("dbo.EventsUsers", new[] { "EventRefId" });
            DropIndex("dbo.SportsGrounds", new[] { "GroundRefId" });
            DropIndex("dbo.SportsGrounds", new[] { "SportRefId" });
            DropIndex("dbo.Sports", new[] { "SportId" });
            DropIndex("dbo.Pictures", new[] { "User_Username" });
            DropIndex("dbo.Parks", new[] { "ParkId" });
            DropIndex("dbo.Grounds", new[] { "ParkId" });
            DropIndex("dbo.Grounds", new[] { "GroundId" });
            DropIndex("dbo.Reserves", new[] { "GroundId" });
            DropIndex("dbo.Reserves", new[] { "SportId" });
            DropIndex("dbo.Reserves", new[] { "UserId" });
            DropIndex("dbo.Reserves", new[] { "ReserveId" });
            DropIndex("dbo.Users", new[] { "CountyId" });
            DropIndex("dbo.Counties", new[] { "DistrictId" });
            DropIndex("dbo.Addresses", new[] { "CountyId" });
            DropTable("dbo.GroundEvaluations");
            DropTable("dbo.UserEvaluations");
            DropTable("dbo.EventsUsers");
            DropTable("dbo.SportsGrounds");
            DropTable("dbo.Sports");
            DropTable("dbo.Pictures");
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
