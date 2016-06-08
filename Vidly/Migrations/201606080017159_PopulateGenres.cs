namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Ação')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Suspense')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Família')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comédia')");
        }
        
        public override void Down()
        {
        }
    }
}
