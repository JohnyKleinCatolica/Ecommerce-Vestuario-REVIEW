namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer1 : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Johny Klein', '21254523', '19970615 08:34:09 AM', '20120618 08:03:31 PM')");
		}
        
        public override void Down()
        {
        }
    }
}
