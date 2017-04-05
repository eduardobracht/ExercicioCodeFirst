namespace EFCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class casting : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            DropColumn("dbo.Movies", "ID");
            CreateTable(
                "dbo.ActorMovies",
                c => new
                    {
                        ActorMovieID = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        ActorID = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActorMovieID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.ActorID)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ActorID);
            
            AddColumn("dbo.Movies", "MovieID", c => c.Int(nullable: false, identity: true));

            AddPrimaryKey("dbo.Movies", "MovieID");
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ActorMovies", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.ActorMovies", "ActorID", "dbo.Actors");
            DropIndex("dbo.ActorMovies", new[] { "MovieID" });
            DropIndex("dbo.ActorMovies", new[] { "ActorID" });
            DropPrimaryKey("dbo.Movies");
            DropColumn("dbo.Movies", "MovieID");
            DropTable("dbo.Actors");
            DropTable("dbo.ActorMovies");
            AddPrimaryKey("dbo.Movies", "ID");
        }
    }
}
