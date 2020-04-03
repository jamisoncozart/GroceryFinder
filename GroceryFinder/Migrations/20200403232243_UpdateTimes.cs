using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryFinder.Migrations
{
    public partial class UpdateTimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "CloseHour",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "CloseHour",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "CloseHour",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "CloseHour",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "CloseHour",
                value: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "CloseHour",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "CloseHour",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "CloseHour",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "CloseHour",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "CloseHour",
                value: 20);
        }
    }
}
