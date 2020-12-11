namespace TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGuidProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "UsedGuid", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "UsedGuid");
        }
    }
}
