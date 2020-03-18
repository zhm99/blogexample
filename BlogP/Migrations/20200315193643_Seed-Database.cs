using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogP.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 36, 42, 566, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc), new DateTime(2020, 3, 15, 19, 32, 13, 235, DateTimeKind.Utc) });
        }
    }
}
