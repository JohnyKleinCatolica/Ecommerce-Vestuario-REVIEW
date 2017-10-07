namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clothes : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Vestido', 'Amarelo', 4, 'pastaTal')");
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Calça', 'Azul', 6, 'pastaTal')");
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Bermuda', 'Vermelho', 20, 'pastaTal')");
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Camisa', 'Verde', 14, 'pastaTal')");
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Blusa', 'Listras pretas e brancas', 50, 'pastaTal')");
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Conjunto', 'Mescla', 45, 'pastaTal')");
			Sql("INSERT INTO Clothes(Nome, Cor, Preco, UrlImagem) VALUES('Moletom', 'Preto', 100, 'pastaTal')");

		}

		public override void Down()
        {
        }
    }
}
