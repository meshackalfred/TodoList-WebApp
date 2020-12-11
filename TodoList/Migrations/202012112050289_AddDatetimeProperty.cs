namespace TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatetimeProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "dateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "dateTime");
        }
    }
}
