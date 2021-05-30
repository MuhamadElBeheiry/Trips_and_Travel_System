namespace trips_and_travel_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TripsAndTravelDBv10 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserSavedPosts", name: "PostId", newName: "SavedPostId");
            RenameIndex(table: "dbo.UserSavedPosts", name: "IX_PostId", newName: "IX_SavedPostId");
            CreateTable(
                "dbo.TravelerDislikedPosts",
                c => new
                    {
                        TravelerId = c.Int(nullable: false),
                        DislikedPostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TravelerId, t.DislikedPostId })
                .ForeignKey("dbo.Users", t => t.TravelerId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.DislikedPostId, cascadeDelete: true)
                .Index(t => t.TravelerId)
                .Index(t => t.DislikedPostId);
            
            CreateTable(
                "dbo.TravelerLikedPosts",
                c => new
                    {
                        TravelerId = c.Int(nullable: false),
                        LikedPostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TravelerId, t.LikedPostId })
                .ForeignKey("dbo.Users", t => t.TravelerId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.LikedPostId, cascadeDelete: true)
                .Index(t => t.TravelerId)
                .Index(t => t.LikedPostId);
            
            AddColumn("dbo.FAQs", "postId", c => c.Int(nullable: false));
            AddColumn("dbo.FAQs", "travelerId", c => c.Int(nullable: false));
            CreateIndex("dbo.FAQs", "postId");
            CreateIndex("dbo.FAQs", "travelerId");
            AddForeignKey("dbo.FAQs", "postId", "dbo.Posts", "PostId", cascadeDelete: true);
            AddForeignKey("dbo.FAQs", "travelerId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FAQs", "travelerId", "dbo.Users");
            DropForeignKey("dbo.FAQs", "postId", "dbo.Posts");
            DropForeignKey("dbo.TravelerLikedPosts", "LikedPostId", "dbo.Posts");
            DropForeignKey("dbo.TravelerLikedPosts", "TravelerId", "dbo.Users");
            DropForeignKey("dbo.TravelerDislikedPosts", "DislikedPostId", "dbo.Posts");
            DropForeignKey("dbo.TravelerDislikedPosts", "TravelerId", "dbo.Users");
            DropIndex("dbo.TravelerLikedPosts", new[] { "LikedPostId" });
            DropIndex("dbo.TravelerLikedPosts", new[] { "TravelerId" });
            DropIndex("dbo.TravelerDislikedPosts", new[] { "DislikedPostId" });
            DropIndex("dbo.TravelerDislikedPosts", new[] { "TravelerId" });
            DropIndex("dbo.FAQs", new[] { "travelerId" });
            DropIndex("dbo.FAQs", new[] { "postId" });
            DropColumn("dbo.FAQs", "travelerId");
            DropColumn("dbo.FAQs", "postId");
            DropTable("dbo.TravelerLikedPosts");
            DropTable("dbo.TravelerDislikedPosts");
            RenameIndex(table: "dbo.UserSavedPosts", name: "IX_SavedPostId", newName: "IX_PostId");
            RenameColumn(table: "dbo.UserSavedPosts", name: "SavedPostId", newName: "PostId");
        }
    }
}
