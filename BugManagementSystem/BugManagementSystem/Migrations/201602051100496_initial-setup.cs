namespace BugManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bugs",
                c => new
                    {
                        BugID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Project = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Priority = c.String(nullable: false),
                        AssignedTo = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.BugID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        PriorityID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PriorityID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StatusID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.Employees");
            DropTable("dbo.Priorities");
            DropTable("dbo.Categories");
            DropTable("dbo.Projects");
            DropTable("dbo.Bugs");
        }
    }
}
