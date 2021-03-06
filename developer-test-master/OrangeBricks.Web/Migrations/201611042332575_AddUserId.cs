namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "OfferedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "OfferedBy");
        }
    }
}
