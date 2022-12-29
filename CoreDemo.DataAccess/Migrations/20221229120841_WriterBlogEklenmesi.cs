using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDemo.Project.DataAccess.Migrations
{
    public partial class WriterBlogEklenmesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterId",
                table: "Blogs",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writer_WriterId",
                table: "Blogs",
                column: "WriterId",
                principalTable: "Writer",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writer_WriterId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_WriterId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Blogs");
        }
    }
}
