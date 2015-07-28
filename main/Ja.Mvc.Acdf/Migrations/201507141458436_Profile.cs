namespace Ja.Mvc.Acdf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Profile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "FirstYearSchool", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastYearSchool", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastClass", c => c.String());
            AddColumn("dbo.AspNetUsers", "ActualCity", c => c.String());
            AddColumn("dbo.AspNetUsers", "ActualCountry", c => c.String());
            AddColumn("dbo.AspNetUsers", "AvatarUrl", c => c.String());
            AddColumn("dbo.AspNetUsers", "RegistrationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegistrationDate");
            DropColumn("dbo.AspNetUsers", "AvatarUrl");
            DropColumn("dbo.AspNetUsers", "ActualCountry");
            DropColumn("dbo.AspNetUsers", "ActualCity");
            DropColumn("dbo.AspNetUsers", "LastClass");
            DropColumn("dbo.AspNetUsers", "LastYearSchool");
            DropColumn("dbo.AspNetUsers", "FirstYearSchool");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
