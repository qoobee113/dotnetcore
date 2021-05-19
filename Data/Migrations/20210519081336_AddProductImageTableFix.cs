using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddProductImageTableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductIamges_Products_ProductId",
                table: "ProductIamges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductIamges",
                table: "ProductIamges");

            migrationBuilder.RenameTable(
                name: "ProductIamges",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductIamges_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "fbcffc90-46b1-432e-bc8a-86b5e26fca0a");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df5fd210-9e24-43a4-88a6-d0494194d779", "AQAAAAEAACcQAAAAEHi7PtbvTxlC0fbgF12UXgdyKpWiGcQUQwRUY9O9C30QpY1SclU8v7p3oIUvQTFanw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 15, 13, 35, 626, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductIamges");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductIamges",
                newName: "IX_ProductIamges_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductIamges",
                table: "ProductIamges",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "52b67efc-5da5-41df-8489-191a36b0aeea");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21bc77e4-182c-43a5-af56-4685d8bb4173", "AQAAAAEAACcQAAAAEOE1bw5ZuzhmlI+DndrYqcP7c97V+gyBxEUZva/9UK1D8tN5Fptr1FToT2s6O3TkWw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 19, 15, 10, 35, 226, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductIamges_Products_ProductId",
                table: "ProductIamges",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
