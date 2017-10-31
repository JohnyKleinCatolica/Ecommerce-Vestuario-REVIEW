namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredSimpleDatas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "DataCadastro", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DataCadastro", c => c.DateTime());
            AlterColumn("dbo.Customers", "DataNascimento", c => c.DateTime());
        }
    }
}
