namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clothes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cor = c.String(),
                        Preco = c.Double(nullable: false),
                        UrlImagem = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Clothes");
        }
    }
}
