namespace DataCrmPi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Adress = c.String(nullable: false, maxLength: 20),
                        PhoneNumber = c.Int(nullable: false),
                        CIN = c.String(maxLength: 8),
                        Email = c.String(),
                        Password = c.String(maxLength: 100),
                        UserName = c.String(),
                        Salary = c.Int(),
                        Position = c.String(),
                        PointOfSaleId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.PointOfSales", t => t.PointOfSaleId, cascadeDelete: true)
                .Index(t => t.PointOfSaleId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                        Client_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Users", t => t.Client_UserId)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId)
                .Index(t => t.Client_UserId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                        Client_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Users", t => t.Client_UserId)
                .Index(t => t.Client_UserId);
            
            CreateTable(
                "dbo.Reactions",
                c => new
                    {
                        ReactionId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReactionId)
                .ForeignKey("dbo.Users", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.PointOfSales",
                c => new
                    {
                        PointOfSaleId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        State = c.String(),
                        Name = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PointOfSaleId);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        ResourcesId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        PointOfSaleId = c.Int(nullable: false),
                        State = c.String(),
                        Employee_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ResourcesId)
                .ForeignKey("dbo.Users", t => t.Employee_UserId)
                .ForeignKey("dbo.PointOfSales", t => t.PointOfSaleId, cascadeDelete: true)
                .Index(t => t.PointOfSaleId)
                .Index(t => t.Employee_UserId);
            
            CreateTable(
                "dbo.TeleProspections",
                c => new
                    {
                        TeleProspectionId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        State = c.String(),
                        Description = c.String(),
                        Priority = c.String(),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeleProspectionId)
                .ForeignKey("dbo.Users", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeleProspections", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Resources", "PointOfSaleId", "dbo.PointOfSales");
            DropForeignKey("dbo.Resources", "Employee_UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "PointOfSaleId", "dbo.PointOfSales");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Reactions", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Reactions", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Posts", "Client_UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "Client_UserId", "dbo.Users");
            DropIndex("dbo.TeleProspections", new[] { "ClientId" });
            DropIndex("dbo.Resources", new[] { "Employee_UserId" });
            DropIndex("dbo.Resources", new[] { "PointOfSaleId" });
            DropIndex("dbo.Reactions", new[] { "PostId" });
            DropIndex("dbo.Reactions", new[] { "ClientId" });
            DropIndex("dbo.Posts", new[] { "Client_UserId" });
            DropIndex("dbo.Comments", new[] { "Client_UserId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Users", new[] { "PointOfSaleId" });
            DropTable("dbo.TeleProspections");
            DropTable("dbo.Resources");
            DropTable("dbo.PointOfSales");
            DropTable("dbo.Reactions");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Users");
        }
    }
}
