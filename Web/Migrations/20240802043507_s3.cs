﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class s3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("e990cd85-5f78-4d38-9197-630b1078a0ec"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("12ac63a8-acd2-451c-9230-c0ad03af4615"), new Guid("e3e148af-0576-466e-b783-736c0f27f989"), new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 11, 35, 7, 363, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 11, 35, 7, 363, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 11, 35, 7, 363, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 11, 35, 7, 363, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 11, 35, 7, 363, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 11, 35, 7, 363, DateTimeKind.Local).AddTicks(4608));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("12ac63a8-acd2-451c-9230-c0ad03af4615"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("e990cd85-5f78-4d38-9197-630b1078a0ec"), new Guid("e3e148af-0576-466e-b783-736c0f27f989"), new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5142));
        }
    }
}
