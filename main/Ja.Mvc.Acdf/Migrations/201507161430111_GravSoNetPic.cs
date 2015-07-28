namespace Ja.Mvc.Acdf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GravSoNetPic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UseGravatar", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "UseSocialNetworkPicture", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UseSocialNetworkPicture");
            DropColumn("dbo.AspNetUsers", "UseGravatar");
        }
    }
}
