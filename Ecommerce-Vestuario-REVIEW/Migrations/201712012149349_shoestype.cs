namespace Ecommerce_Vestuario_REVIEW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shoestype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shoes", "ShoesType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shoes", "ShoesType");
        }
    }
}
