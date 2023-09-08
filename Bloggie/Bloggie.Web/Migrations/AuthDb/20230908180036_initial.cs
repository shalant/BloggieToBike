using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79223ca5-9a6b-4254-9cf8-5857390521f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ad0610-b2ad-47e8-93a6-c0f8fb3f479d", "AQAAAAEAACcQAAAAEDaePj03UeCBlWGcE/g84Iyp1JUJ+ZkC/yT+BIXKjojZZj0RM+m0AcnHjoo5kw8OPg==", "0d3cfaf0-f550-424a-841e-15ea895f28a3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79223ca5-9a6b-4254-9cf8-5857390521f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83b07c1-c0bd-4b1d-923d-b85f189c916b", "AQAAAAEAACcQAAAAEKU5gliJCNx8eKXpdWiP+JlrWEche5u6XnV9fBJgWvPkZQKlSnwA+YdbrOcpCe/Nww==", "44e7dee7-3b7b-4c80-884a-c9f9854cd923" });
        }
    }
}
