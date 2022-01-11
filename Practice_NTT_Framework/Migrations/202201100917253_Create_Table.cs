namespace Practice_NTT_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        NameClass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
