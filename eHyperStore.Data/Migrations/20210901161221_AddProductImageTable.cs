using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHyperStore.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 1, 0, 25, 17, 556, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 1, 0, 25, 17, 556, DateTimeKind.Local).AddTicks(4371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"),
                column: "ConcurrencyStamp",
                value: "379727bf-ef2e-4779-adb7-1b22990beb22");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("42f80cce-24c7-491b-8c70-b1908c66df23"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6163b766-b583-4d2a-b3e8-3cdc5e4a7ed8", "AQAAAAEAACcQAAAAELssBkBVHw7A14uDMTxp5ElcbI0fPovGcx2+RI3He9hPRH5DVc19Y2RpnfW/bChl/Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 0, 25, 17, 573, DateTimeKind.Local).AddTicks(8856));
        }
    }
}
