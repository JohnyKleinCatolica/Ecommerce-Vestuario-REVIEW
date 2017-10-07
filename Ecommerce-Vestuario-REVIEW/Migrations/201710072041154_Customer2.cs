namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer2 : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Pedro Pedro', '0233321', '19901001 06:34:09 PM', '20120618 05:00:01 PM')");
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Ana Paula', '75745452', '19981001 05:34:09 AM', '20120618 10:01:05 AM')");
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Letúla Amarilda', '1245454', '19901001 01:34:09 PM', '20110620 02:00:02 AM')");
			Sql("INSERT INTO Customers(Nome, CPF, DataNascimento, DataCadastro) VALUES ('Jana Kuester', '5454566', '19960321 02:14:00 AM', '20101220 11:10:30 AM')");

		}
        
        public override void Down()
        {
        }
    }
}
