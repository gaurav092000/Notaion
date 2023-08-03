namespace AdmissionForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        EmployeId = c.Int(nullable: false, identity: true),
                        EmployeName = c.String(),
                        EmployeAge = c.Int(nullable: false),
                        EmployeeGender = c.String(),
                        EmployeEmail = c.String(),
                        EmployePassWord = c.String(),
                    })
                .PrimaryKey(t => t.EmployeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emps");
        }
    }
}
