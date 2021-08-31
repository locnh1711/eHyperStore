using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHyperStore.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 1, 0, 25, 17, 556, DateTimeKind.Local).AddTicks(4371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 1, 0, 14, 2, 799, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"), "379727bf-ef2e-4779-adb7-1b22990beb22", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"), new Guid("42f80cce-24c7-491b-8c70-b1908c66df23") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("42f80cce-24c7-491b-8c70-b1908c66df23"), 0, "6163b766-b583-4d2a-b3e8-3cdc5e4a7ed8", new DateTime(1999, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "locnhgcs17219@fpt.edu.vn", true, "Loc", "Nguyen", false, null, "locnhgcs17219@fpt.edu.vn", "admin", "AQAAAAEAACcQAAAAELssBkBVHw7A14uDMTxp5ElcbI0fPovGcx2+RI3He9hPRH5DVc19Y2RpnfW/bChl/Q==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 0, 25, 17, 573, DateTimeKind.Local).AddTicks(8856));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("09a7bcdf-396c-4e25-b159-3f5d5beb671b"), new Guid("42f80cce-24c7-491b-8c70-b1908c66df23") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("42f80cce-24c7-491b-8c70-b1908c66df23"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 1, 0, 14, 2, 799, DateTimeKind.Local).AddTicks(5900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 1, 0, 25, 17, 556, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 1, 0, 14, 2, 812, DateTimeKind.Local).AddTicks(7301));
        }
    }
}
