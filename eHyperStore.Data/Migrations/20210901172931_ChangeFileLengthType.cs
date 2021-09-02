using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHyperStore.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"),
                column: "ConcurrencyStamp",
                value: "8257c90f-0708-4822-b363-166449ff1d85");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("42f80cce-24c7-491b-8c70-b1908c66df23"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "658b4988-08be-4034-b582-b45f23526347", "AQAAAAEAACcQAAAAEChxFsRv5ZNAJ8ODy0T47PbpyN5q+uDWAgMfsEuLdxil/c/fBk+rAQzHjteR5UhNfQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 2, 0, 29, 30, 152, DateTimeKind.Local).AddTicks(1892));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"),
                column: "ConcurrencyStamp",
                value: "39af6473-b973-406e-8b92-2d5c6d7b55dd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("42f80cce-24c7-491b-8c70-b1908c66df23"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e178089-9bcd-47ef-86bd-cbbdc59577fe", "AQAAAAEAACcQAAAAEFBzEkA+wZLRSxnliuYYjY3oyOZDgf3Al7RFqSCTZlqgC+daUPBetJYhSkVuGo16Tg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 23, 12, 20, 114, DateTimeKind.Local).AddTicks(6709));
        }
    }
}
