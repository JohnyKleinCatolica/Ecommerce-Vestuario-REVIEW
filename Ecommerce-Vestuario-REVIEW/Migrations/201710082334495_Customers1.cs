namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Nome, CPF, InscritroNewletter, DataNascimento, DataCadastro, MembershipTypeId) VALUES('Janaíne', '554564', 'true', '19951130 01:20:42 PM', '20151101 03:15:11 PM', 2)");
            Sql("INSERT INTO Customers(Nome, CPF, InscritroNewletter, DataNascimento, DataCadastro, MembershipTypeId) VALUES('Johny', '445454', 'true', '19901001 11:50:10 AM', '20171201 01:00:01 AM', 3)");
            Sql("INSERT INTO Customers(Nome, CPF, InscritroNewletter, DataNascimento, DataCadastro, MembershipTypeId) VALUES('Diego', '1235654', 'false', '19901001 06:59:50 PM', '20120101 09:30:02 PM', 4)");
            Sql("INSERT INTO Customers(Nome, CPF, InscritroNewletter, DataNascimento, DataCadastro, MembershipTypeId) VALUES('Kate', '989562', 'true', '19901001 05:11:36 PM', '20110901 11:55:06 AM', 5)");
            Sql("INSERT INTO Customers(Nome, CPF, InscritroNewletter, DataNascimento, DataCadastro, MembershipTypeId) VALUES('Luquenas', '3266445', 'false', '19901001 10:37:19 AM', '20120501 12:03:12 AM', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
