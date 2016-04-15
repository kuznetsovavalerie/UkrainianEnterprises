namespace UkrainianEnterprises.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelsProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Document_ID = c.Int(),
                        Location_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Documents", t => t.Document_ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID)
                .Index(t => t.Document_ID)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Document_ID = c.Int(),
                        Department_ID = c.Int(),
                        Department_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Documents", t => t.Document_ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID1)
                .Index(t => t.Document_ID)
                .Index(t => t.Department_ID)
                .Index(t => t.Department_ID1);
            
            CreateTable(
                "dbo.Enterprises",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Website = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Type_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EnterpriseTypes", t => t.Type_ID)
                .Index(t => t.Type_ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Photo = c.String(),
                        Education = c.String(),
                        Department_ID = c.Int(),
                        Enterprise_ID = c.Int(),
                        Location_ID = c.Int(),
                        Office_ID = c.Int(),
                        Position_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .ForeignKey("dbo.Enterprises", t => t.Enterprise_ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID)
                .ForeignKey("dbo.Offices", t => t.Office_ID)
                .ForeignKey("dbo.Positions", t => t.Position_ID)
                .Index(t => t.Department_ID)
                .Index(t => t.Enterprise_ID)
                .Index(t => t.Location_ID)
                .Index(t => t.Office_ID)
                .Index(t => t.Position_ID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Address = c.String(),
                        Level = c.Int(nullable: false),
                        Enterprise_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Enterprises", t => t.Enterprise_ID)
                .Index(t => t.Enterprise_ID);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LocationID = c.Int(nullable: false),
                        Number = c.String(),
                        Title = c.String(),
                        Decription = c.String(),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EnterpriseTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EnterpriseDocuments",
                c => new
                    {
                        Enterprise_ID = c.Int(nullable: false),
                        Document_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Enterprise_ID, t.Document_ID })
                .ForeignKey("dbo.Enterprises", t => t.Enterprise_ID, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.Document_ID, cascadeDelete: true)
                .Index(t => t.Enterprise_ID)
                .Index(t => t.Document_ID);
            
            CreateTable(
                "dbo.OfficeDocuments",
                c => new
                    {
                        Office_ID = c.Int(nullable: false),
                        Document_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Office_ID, t.Document_ID })
                .ForeignKey("dbo.Offices", t => t.Office_ID, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.Document_ID, cascadeDelete: true)
                .Index(t => t.Office_ID)
                .Index(t => t.Document_ID);
            
            CreateTable(
                "dbo.EnterpriseTypeDocuments",
                c => new
                    {
                        EnterpriseType_ID = c.Int(nullable: false),
                        Document_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EnterpriseType_ID, t.Document_ID })
                .ForeignKey("dbo.EnterpriseTypes", t => t.EnterpriseType_ID, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.Document_ID, cascadeDelete: true)
                .Index(t => t.EnterpriseType_ID)
                .Index(t => t.Document_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offices", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.Documents", "Department_ID1", "dbo.Departments");
            DropForeignKey("dbo.Documents", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.Enterprises", "Type_ID", "dbo.EnterpriseTypes");
            DropForeignKey("dbo.EnterpriseTypeDocuments", "Document_ID", "dbo.Documents");
            DropForeignKey("dbo.EnterpriseTypeDocuments", "EnterpriseType_ID", "dbo.EnterpriseTypes");
            DropForeignKey("dbo.Locations", "Enterprise_ID", "dbo.Enterprises");
            DropForeignKey("dbo.Employees", "Position_ID", "dbo.Positions");
            DropForeignKey("dbo.Employees", "Office_ID", "dbo.Offices");
            DropForeignKey("dbo.OfficeDocuments", "Document_ID", "dbo.Documents");
            DropForeignKey("dbo.OfficeDocuments", "Office_ID", "dbo.Offices");
            DropForeignKey("dbo.Employees", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Departments", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Employees", "Enterprise_ID", "dbo.Enterprises");
            DropForeignKey("dbo.Employees", "Department_ID", "dbo.Departments");
            DropForeignKey("dbo.EnterpriseDocuments", "Document_ID", "dbo.Documents");
            DropForeignKey("dbo.EnterpriseDocuments", "Enterprise_ID", "dbo.Enterprises");
            DropForeignKey("dbo.Documents", "Document_ID", "dbo.Documents");
            DropForeignKey("dbo.Departments", "Document_ID", "dbo.Documents");
            DropIndex("dbo.EnterpriseTypeDocuments", new[] { "Document_ID" });
            DropIndex("dbo.EnterpriseTypeDocuments", new[] { "EnterpriseType_ID" });
            DropIndex("dbo.OfficeDocuments", new[] { "Document_ID" });
            DropIndex("dbo.OfficeDocuments", new[] { "Office_ID" });
            DropIndex("dbo.EnterpriseDocuments", new[] { "Document_ID" });
            DropIndex("dbo.EnterpriseDocuments", new[] { "Enterprise_ID" });
            DropIndex("dbo.Offices", new[] { "Department_ID" });
            DropIndex("dbo.Locations", new[] { "Enterprise_ID" });
            DropIndex("dbo.Employees", new[] { "Position_ID" });
            DropIndex("dbo.Employees", new[] { "Office_ID" });
            DropIndex("dbo.Employees", new[] { "Location_ID" });
            DropIndex("dbo.Employees", new[] { "Enterprise_ID" });
            DropIndex("dbo.Employees", new[] { "Department_ID" });
            DropIndex("dbo.Enterprises", new[] { "Type_ID" });
            DropIndex("dbo.Documents", new[] { "Department_ID1" });
            DropIndex("dbo.Documents", new[] { "Department_ID" });
            DropIndex("dbo.Documents", new[] { "Document_ID" });
            DropIndex("dbo.Departments", new[] { "Location_ID" });
            DropIndex("dbo.Departments", new[] { "Document_ID" });
            DropTable("dbo.EnterpriseTypeDocuments");
            DropTable("dbo.OfficeDocuments");
            DropTable("dbo.EnterpriseDocuments");
            DropTable("dbo.Educations");
            DropTable("dbo.EnterpriseTypes");
            DropTable("dbo.Positions");
            DropTable("dbo.Offices");
            DropTable("dbo.Locations");
            DropTable("dbo.Employees");
            DropTable("dbo.Enterprises");
            DropTable("dbo.Documents");
            DropTable("dbo.Departments");
        }
    }
}
