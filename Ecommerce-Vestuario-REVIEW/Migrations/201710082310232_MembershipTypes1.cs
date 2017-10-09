namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypes1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, ClientePremium, DuracaoEmMes, Desconto, Nome) VALUES(2, 'true', 6, 10, 'Jana')");
            Sql("INSERT INTO MembershipTypes(Id, ClientePremium, DuracaoEmMes, Desconto, Nome) VALUES(3, 'true', 9, 20, 'Maiquinhos')");
            Sql("INSERT INTO MembershipTypes(Id, ClientePremium, DuracaoEmMes, Desconto, Nome) VALUES(4, 'false', 1, 50, 'Luka')");
            Sql("INSERT INTO MembershipTypes(Id, ClientePremium, DuracaoEmMes, Desconto, Nome) VALUES(5, 'true', 5, 60, 'Rafa Bus')");
            Sql("INSERT INTO MembershipTypes(Id, ClientePremium, DuracaoEmMes, Desconto, Nome) VALUES(6, 'false', 3, 500, 'Jean Carlos')");
        }
        
        public override void Down()
        {
        }
    }
}
