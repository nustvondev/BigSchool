namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Data_Course_Category : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into categories(Id,Name) values (1,'Development')");
            Sql("Insert into categories(Id,Name) values (2,'Business')");
            Sql("Insert into categories(Id,Name) values (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
