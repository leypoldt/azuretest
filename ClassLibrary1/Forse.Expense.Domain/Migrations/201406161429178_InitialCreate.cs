namespace Forse.Expense.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category_Id = c.Int(),
                        Expense_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.Category_Id)
                .ForeignKey("dbo.ExpenseItems", t => t.Expense_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Expense_Id);
            
            CreateTable(
                "dbo.ExpenseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(),
                        Owner = c.String(),
                        State = c.Int(nullable: false),
                        RedjectMessage = c.String(),
                        IsFiled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenseLines", "Expense_Id", "dbo.ExpenseItems");
            DropForeignKey("dbo.ExpenseLines", "Category_Id", "dbo.ExpenseCategories");
            DropIndex("dbo.ExpenseLines", new[] { "Expense_Id" });
            DropIndex("dbo.ExpenseLines", new[] { "Category_Id" });
            DropTable("dbo.ExpenseItems");
            DropTable("dbo.ExpenseLines");
            DropTable("dbo.ExpenseCategories");
        }
    }
}
