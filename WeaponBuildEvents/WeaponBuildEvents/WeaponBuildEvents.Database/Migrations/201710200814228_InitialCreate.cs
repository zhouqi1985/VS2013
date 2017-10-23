namespace WeaponBuildEvents.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RankListTop20",
                c => new
                    {
                        RankId = c.Int(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        AvatarId = c.Long(nullable: false),
                        AreaId = c.Int(nullable: false),
                        AvatarName = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RankId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RankListTop20");
        }
    }
}
