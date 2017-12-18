namespace TreeViewMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriesModel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        ParentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CategoriesModel");
        }
    }
}
