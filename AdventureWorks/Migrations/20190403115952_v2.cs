using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdventureWorks.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "AccountNumber", "FirstName", "LastName", "MiddleName", "Title" },
                values: new object[] { 1, null, "Faisal", "Khanani", null, "Mr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "AccountNumber", "FirstName", "LastName", "MiddleName", "Title" },
                values: new object[] { 2, null, "Khurram", "Rafi", null, "Mr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "AccountNumber", "FirstName", "LastName", "MiddleName", "Title" },
                values: new object[] { 3, null, "Sona", "Kanwal", null, "Ms." });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "SalesOrdersId", "AccountNumber", "Amount", "Comment", "CustomerId", "DueDate", "OrderDate", "PurchaseOrderNumber", "RevisionNumber", "SalesOrderNumber", "ShipDate", "Status" },
                values: new object[] { 1, null, 5m, null, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "SalesOrdersId", "AccountNumber", "Amount", "Comment", "CustomerId", "DueDate", "OrderDate", "PurchaseOrderNumber", "RevisionNumber", "SalesOrderNumber", "ShipDate", "Status" },
                values: new object[] { 2, null, 10m, null, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "SalesOrdersId", "AccountNumber", "Amount", "Comment", "CustomerId", "DueDate", "OrderDate", "PurchaseOrderNumber", "RevisionNumber", "SalesOrderNumber", "ShipDate", "Status" },
                values: new object[] { 3, null, 15m, null, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrdersId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrdersId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrdersId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);
        }
    }
}
