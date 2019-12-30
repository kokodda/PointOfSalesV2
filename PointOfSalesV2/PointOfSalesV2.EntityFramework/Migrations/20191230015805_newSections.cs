using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class newSections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SectionId",
                table: "UserOperation",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "SectionId",
                table: "SectionOperations",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 647, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 646, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 646, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 628, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 628, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 622, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 623, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 625, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 36L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5604), null, null, null, "WarehouseMovements", "[]" },
                    { 35L, true, "Users,Role,UserRole", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5585), null, null, null, "UserRoles", "[]" }
                });

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 627, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 29, 21, 58, 3, 635, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 273L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5591), null, null, null, 1L, 35L },
                    { 274L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5593), null, null, null, 2L, 35L },
                    { 275L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5594), null, null, null, 3L, 35L },
                    { 276L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5595), null, null, null, 4L, 35L },
                    { 277L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5597), null, null, null, 5L, 35L },
                    { 278L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5598), null, null, null, 6L, 35L },
                    { 279L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5600), null, null, null, 7L, 35L },
                    { 281L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5605), null, null, null, 1L, 36L },
                    { 282L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5607), null, null, null, 2L, 36L },
                    { 283L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5608), null, null, null, 3L, 36L },
                    { 284L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5610), null, null, null, 4L, 36L },
                    { 285L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5611), null, null, null, 5L, 36L },
                    { 286L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5613), null, null, null, 6L, 36L },
                    { 287L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 29, 21, 58, 3, 634, DateTimeKind.Local).AddTicks(5614), null, null, null, 7L, 36L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.AlterColumn<long>(
                name: "SectionId",
                table: "UserOperation",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SectionId",
                table: "SectionOperations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "EN", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "amountIsGreater_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotDeleteTax_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotEraseUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotRemoveBaseProduct_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "cannotUpdatePayment_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditLimitReached_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteApplied_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "creditNoteNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "defWarehouseNotExit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "differentCurrency_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "emptyInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "error_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invalidInvoice_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "invoicePaid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "notExistingClass_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "ok_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "outOfStock_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "owedAmountOutdated_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "parentUnitDoesntExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "paymentNotValid_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsPrimaryUnit_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "productNeedsUnits_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "sequenceError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "trnNotAvailable_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "unitNotExist_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "LanguageKeys",
                keyColumns: new[] { "LanguageCode", "Key" },
                keyValues: new object[] { "ES", "warehouseError_msg" },
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 912, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 912, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 903, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 124L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 125L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 126L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 127L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 129L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 130L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 131L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 132L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 133L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 134L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 135L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 137L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 138L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 139L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 140L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 141L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 142L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 143L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 145L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 146L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 147L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 148L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 149L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 150L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 151L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 153L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 154L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 155L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 156L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 157L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 158L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 159L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 161L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 162L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 163L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 164L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 165L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 166L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 167L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 169L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 170L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 171L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 172L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 173L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 174L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 175L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 177L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 178L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 179L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 180L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 181L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 182L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 183L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 185L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 186L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 187L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 188L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 189L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 190L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 191L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 193L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 194L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 195L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 196L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 197L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 198L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 199L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 201L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 202L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 203L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 204L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 205L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 206L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 207L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 209L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 210L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 211L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 212L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 213L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 214L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 215L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 217L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 218L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 219L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 220L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 221L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 222L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 223L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 225L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 226L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 227L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 228L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 229L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 230L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 231L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 233L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 234L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 235L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 236L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 237L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 238L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 239L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 241L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 242L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 243L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 244L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 245L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 246L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 247L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 249L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 250L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 251L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 252L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 253L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 254L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 255L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 257L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 258L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 259L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 260L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 261L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 262L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 263L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 265L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 266L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 267L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 268L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 269L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 270L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "SectionOperations",
                keyColumn: "Id",
                keyValue: 271L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 20, 1, 50, 920, DateTimeKind.Local).AddTicks(2584));
        }
    }
}
