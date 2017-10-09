namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, ClientePremium, DuracaoEmMes, Desconto, Nome) VALUES(1, 'false', 2, 100, 'Johny')");
        }
        
        public override void Down()
        {
        }
    }
}
