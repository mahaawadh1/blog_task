using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class moresaples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 2, "Travel Blog", "https://www.mytravel.tips" },
                    { 3, "Tech Blog", "https://www.mytech.info" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
