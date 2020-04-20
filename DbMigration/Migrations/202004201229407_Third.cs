namespace DbMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employees", newName: "tblEmployee");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblEmployee", newName: "Employees");
        }
    }
}
