using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserDirectory.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class AddDateOfBirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Customer",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: "31 Mar 1980");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: "09 Aug 1958");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: "18 Sep 1963");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: "14 Aug 1979");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfBirth",
                value: "12 May 1955");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfBirth",
                value: "15 Feb 1981");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfBirth",
                value: "18 May 1956");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfBirth",
                value: "16 Jan 1989");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfBirth",
                value: "14 Aug 1976");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfBirth",
                value: "22 Sep 1953");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfBirth",
                value: "16 May 1985");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfBirth",
                value: "13 Dec 1954");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfBirth",
                value: "03 Jan 1982");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfBirth",
                value: "06 Aug 1985");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfBirth",
                value: "12 Sep 1971");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfBirth",
                value: "12 Mar 1955");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfBirth",
                value: "18 May 1976");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateOfBirth",
                value: "03 Sep 1968");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateOfBirth",
                value: "13 Sep 1989");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateOfBirth",
                value: "24 Jan 1978");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Customer");
        }
    }
}
