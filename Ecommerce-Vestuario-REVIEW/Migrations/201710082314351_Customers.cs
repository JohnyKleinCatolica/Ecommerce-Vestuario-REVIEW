namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Nome, CPF, InscritroNewletter, DataNascimento, DataCadastro, MembershipTypeId) VALUES('Janaíne', '554564', 'true', '19901001 10:34:09 AM', '20141001 03:05:11 PM', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
