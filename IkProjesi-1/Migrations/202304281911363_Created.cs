namespace IkProjesi_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Created : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personel16", "ActiveOn", c => c.DateTime());
            AddColumn("dbo.Personel16", "ActivetedBy", c => c.Int());
            AddColumn("dbo.Personel16", "Reserved1", c => c.String());
            AddColumn("dbo.Personel16", "Reserved2", c => c.String());
            AddColumn("dbo.Unvan", "ActiveOn", c => c.DateTime());
            AddColumn("dbo.Unvan", "ActivetedBy", c => c.Int());
            AddColumn("dbo.Unvan", "Reserved1", c => c.String());
            AddColumn("dbo.Unvan", "Reserved2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Unvan", "Reserved2");
            DropColumn("dbo.Unvan", "Reserved1");
            DropColumn("dbo.Unvan", "ActivetedBy");
            DropColumn("dbo.Unvan", "ActiveOn");
            DropColumn("dbo.Personel16", "Reserved2");
            DropColumn("dbo.Personel16", "Reserved1");
            DropColumn("dbo.Personel16", "ActivetedBy");
            DropColumn("dbo.Personel16", "ActiveOn");
        }
    }
}
