namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Maiquinhos Paulo', '56546565', '19901001 10:34:09 AM', '20120618 02:00:11 PM')");
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Fabrício Pedro', '96595461', '19800115 02:04:02 PM', '20120828 03:00:11 PM')");

		}
        
        public override void Down()
        {
        }
    }
}
