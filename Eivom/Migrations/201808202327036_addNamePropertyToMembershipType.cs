namespace Eivom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNamePropertyToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
