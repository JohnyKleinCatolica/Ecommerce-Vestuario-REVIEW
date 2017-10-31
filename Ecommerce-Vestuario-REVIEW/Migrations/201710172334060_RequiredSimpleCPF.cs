namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredSimpleCPF : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CPF", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CPF", c => c.String());
        }
    }
}
