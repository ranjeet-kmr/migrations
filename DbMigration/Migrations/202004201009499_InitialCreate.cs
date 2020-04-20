namespace DbMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        FirstLastName = c.String(),
                        Gender = c.String(),
                        Salary = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
