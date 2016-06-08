namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'A��o')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Suspense')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Fam�lia')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Com�dia')");
        }
        
        public override void Down()
        {
        }
    }
}
