namespace Sports4All.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M002 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "Picture_PictureId", newName: "PictureId");
            RenameIndex(table: "dbo.Users", name: "IX_Picture_PictureId", newName: "IX_PictureId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "IX_PictureId", newName: "IX_Picture_PictureId");
            RenameColumn(table: "dbo.Users", name: "PictureId", newName: "Picture_PictureId");
        }
    }
}
