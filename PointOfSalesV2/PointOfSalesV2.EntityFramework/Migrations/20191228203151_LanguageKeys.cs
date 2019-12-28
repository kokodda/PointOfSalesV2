using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class LanguageKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LanguageKeys",
                columns: table => new
                {
                    LanguageCode = table.Column<string>(maxLength: 2, nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageKeys", x => new { x.LanguageCode, x.Key });
                    table.ForeignKey(
                        name: "FK_LanguageKeys_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "LanguageCode", "Key", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Value" },
                values: new object[,]
                {
                    { "EN", "unitNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 354, DateTimeKind.Local).AddTicks(8794), 1L, null, null, null, "Unit does not exist." },
                    { "ES", "ok_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2117), 2L, null, null, null, "Operation completed successfully." },
                    { "ES", "error_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2119), 2L, null, null, null, "Error: Could not completed the current operation. " },
                    { "ES", "cannotUpdatePayment_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2120), 2L, null, null, null, "Cannot update payment. " },
                    { "ES", "invalidInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2123), 2L, null, null, null, "Invalid invoice." },
                    { "ES", "owedAmountOutdated_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2125), 2L, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "ES", "invoicePaid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2126), 2L, null, null, null, "Invoice is already paid." },
                    { "ES", "paymentNotValid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2128), 2L, null, null, null, "Payment is not valid." },
                    { "ES", "emptyInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2130), 2L, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "ES", "creditLimitReached_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2132), 2L, null, null, null, "Credit limit reached. Cannot continue." },
                    { "ES", "trnNotAvailable_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2134), 2L, null, null, null, "TRN is not available." },
                    { "ES", "outOfStock_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2136), 2L, null, null, null, "Product is out of stock." },
                    { "ES", "defWarehouseNotExit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2137), 2L, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "ES", "notExistingClass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2139), 2L, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "ES", "warehouseError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2141), 2L, null, null, null, "Warehouse does not exist." },
                    { "ES", "creditNoteNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2142), 2L, null, null, null, "Credit note does not exist. " },
                    { "ES", "creditNoteApplied_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2145), 2L, null, null, null, "Credit note is already applied." },
                    { "ES", "differentCurrency_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2146), 2L, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "ES", "amountIsGreater_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2148), 2L, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "ES", "productNeedsUnits_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2150), 2L, null, null, null, "Product needs at least one unit." },
                    { "ES", "productNeedsPrimaryUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2152), 2L, null, null, null, "Product needs one primary unit." },
                    { "ES", "cannotEraseUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2153), 2L, null, null, null, "Cannot erase product unit." },
                    { "ES", "cannotDeleteTax_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2155), 2L, null, null, null, "Cannot delete product tax. " },
                    { "ES", "cannotRemoveBaseProduct_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2156), 2L, null, null, null, "Cannot remove base product." },
                    { "ES", "parentUnitDoesntExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2116), 2L, null, null, null, "Parent unit does not exist." },
                    { "ES", "sequenceError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2158), 2L, null, null, null, "Sequence Error." },
                    { "ES", "unitNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(2110), 2L, null, null, null, "Unit does not exist." },
                    { "EN", "cannotRemoveBaseProduct_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1901), 1L, null, null, null, "Cannot remove base product." },
                    { "EN", "parentUnitDoesntExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1787), 1L, null, null, null, "Parent unit does not exist." },
                    { "EN", "ok_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1837), 1L, null, null, null, "Operation completed successfully." },
                    { "EN", "error_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1840), 1L, null, null, null, "Error: Could not completed the current operation. " },
                    { "EN", "cannotUpdatePayment_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1843), 1L, null, null, null, "Cannot update payment. " },
                    { "EN", "invalidInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1850), 1L, null, null, null, "Invalid invoice." },
                    { "EN", "owedAmountOutdated_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1853), 1L, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "EN", "invoicePaid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1856), 1L, null, null, null, "Invoice is already paid." },
                    { "EN", "paymentNotValid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1858), 1L, null, null, null, "Payment is not valid." },
                    { "EN", "emptyInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1862), 1L, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "EN", "creditLimitReached_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1865), 1L, null, null, null, "Credit limit reached. Cannot continue." },
                    { "EN", "trnNotAvailable_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1867), 1L, null, null, null, "TRN is not available." },
                    { "EN", "outOfStock_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1869), 1L, null, null, null, "Product is out of stock." },
                    { "EN", "defWarehouseNotExit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1872), 1L, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "EN", "notExistingClass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1874), 1L, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "EN", "warehouseError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1877), 1L, null, null, null, "Warehouse does not exist." },
                    { "EN", "creditNoteNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1880), 1L, null, null, null, "Credit note does not exist. " },
                    { "EN", "creditNoteApplied_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1884), 1L, null, null, null, "Credit note is already applied." },
                    { "EN", "differentCurrency_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1886), 1L, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "EN", "amountIsGreater_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1889), 1L, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "EN", "productNeedsUnits_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1891), 1L, null, null, null, "Product needs at least one unit." },
                    { "EN", "productNeedsPrimaryUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1893), 1L, null, null, null, "Product needs one primary unit." },
                    { "EN", "cannotEraseUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1896), 1L, null, null, null, "Cannot erase product unit." },
                    { "EN", "cannotDeleteTax_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1898), 1L, null, null, null, "Cannot delete product tax. " },
                    { "EN", "sequenceError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 16, 31, 50, 355, DateTimeKind.Local).AddTicks(1915), 1L, null, null, null, "Sequence Error." }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 354, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2019, 12, 28, 16, 31, 50, 354, DateTimeKind.Local).AddTicks(7585), 2L });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 342, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 342, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 334, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 335, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 337, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 337, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 337, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 337, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 339, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 340, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 16, 31, 50, 343, DateTimeKind.Local).AddTicks(7281));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguageKeys");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "EN",
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 947, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "ES",
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2019, 12, 28, 15, 45, 14, 948, DateTimeKind.Local).AddTicks(148), 1L });

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 937, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 937, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 930, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 931, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 934, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 934, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 934, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 934, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 936, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"),
                column: "CreatedDate",
                value: new DateTime(2019, 12, 28, 15, 45, 14, 938, DateTimeKind.Local).AddTicks(4689));
        }
    }
}
