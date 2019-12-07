namespace AppG2.Migrations.ContactContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StudentId = c.String(),
                        FullName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Gender = c.Int(nullable: false),
                        PlaceOfBirth = c.String(),
                        Major = c.Int(nullable: false),
                        scoreVHCD = c.Decimal(precision: 18, scale: 2),
                        scoreVHHD = c.Decimal(precision: 18, scale: 2),
                        scoreCoHoc = c.Decimal(precision: 18, scale: 2),
                        scoreQuangHoc = c.Decimal(precision: 18, scale: 2),
                        scoreDien = c.Decimal(precision: 18, scale: 2),
                        scoreHatNhan = c.Decimal(precision: 18, scale: 2),
                        scoreSQL = c.Decimal(precision: 18, scale: 2),
                        scoreCSharp = c.Decimal(precision: 18, scale: 2),
                        scorePascal = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
