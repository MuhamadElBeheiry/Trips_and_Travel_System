namespace trips_and_travel_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FAQs",
                c => new
                    {
                        FAQId = c.Int(nullable: false, identity: true),
                        question = c.String(),
                        answer = c.String(),
                    })
                .PrimaryKey(t => t.FAQId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        agencyId = c.Int(nullable: false),
                        title = c.String(),
                        details = c.String(),
                        tripDestination = c.String(),
                        tripImage = c.String(),
                        tripPrice = c.Int(nullable: false),
                        tripDate = c.DateTime(nullable: false),
                        postDate = c.DateTime(nullable: false),
                        accepted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Users", t => t.agencyId)
                .Index(t => t.agencyId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        phone = c.String(),
                        photo = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserSavedPosts",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.PostId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "agencyId", "dbo.Users");
            DropForeignKey("dbo.UserSavedPosts", "PostId", "dbo.Posts");
            DropForeignKey("dbo.UserSavedPosts", "UserId", "dbo.Users");
            DropIndex("dbo.UserSavedPosts", new[] { "PostId" });
            DropIndex("dbo.UserSavedPosts", new[] { "UserId" });
            DropIndex("dbo.Posts", new[] { "agencyId" });
            DropTable("dbo.UserSavedPosts");
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.FAQs");
        }
    }
}
