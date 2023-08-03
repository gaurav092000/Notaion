namespace AdmissionForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emps", "EmployeName", c => c.String(nullable: false));
            AlterColumn("dbo.Emps", "EmployeeGender", c => c.String(nullable: false));
            AlterColumn("dbo.Emps", "EmployeEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Emps", "EmployePassWord", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emps", "EmployePassWord", c => c.String());
            AlterColumn("dbo.Emps", "EmployeEmail", c => c.String());
            AlterColumn("dbo.Emps", "EmployeeGender", c => c.String());
            AlterColumn("dbo.Emps", "EmployeName", c => c.String());
        }
    }
}
