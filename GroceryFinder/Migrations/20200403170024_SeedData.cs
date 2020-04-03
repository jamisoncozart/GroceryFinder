using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryFinder.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "City", "CloseHour", "Delivery", "Description", "Name", "OpenHour" },
                values: new object[,]
                {
                    { 1, "Beaverton", 22, false, "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks.", "FredMeyers", 7 },
                    { 2, "Beaverton", 22, false, "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks.", "Winco", 7 },
                    { 3, "Beaverton", 19, false, "The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks.", "Trader Joe's", 9 },
                    { 4, "Beaverton", 21, false, "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks.", "Grocery Outlet", 8 },
                    { 5, "Beaverton", 20, false, "Provides some services like ordering your groceries online and at-store pickup where they load the groceries in your car for you. The store is taking precautions to maintain social distancing with tape marking people's positions to stand while they wait in line for checkout. Cashiers wear masks.", "New Seasons", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5);
        }
    }
}
