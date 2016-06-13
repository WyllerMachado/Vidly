namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesToPt : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pague Como Usar' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Mensal' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Trimestral' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Anual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
