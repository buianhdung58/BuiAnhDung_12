namespace BuiAnhDung_12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 50),
                        TenNhanVien = c.String(),
                        MaTinhThanh = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
