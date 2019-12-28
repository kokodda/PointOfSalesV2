using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class LanguagesAndTranslations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ReturnDetails");

            migrationBuilder.DropColumn(
                name: "GenereId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CajaId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "MontoTax",
                table: "InvoicesTaxes",
                newName: "TaxAmount");

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Zones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Warehouses",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "LanguageCode",
                table: "Users",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Units",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "TRNsControl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Taxes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "SequencesControl",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Sellers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Sections",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Roles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "PaymentTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Operations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "MovementTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "InvoicesDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "CashRegisterId",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "InvoiceId",
                table: "CustomersPayments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "Currencies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "CashRegisters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationData",
                table: "BranchOffices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 2, nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Id = table.Column<long>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Code", x => x.Code);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Code", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "Id", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 270, DateTimeKind.Local).AddTicks(2702), 1L, null, null, null, "English", "[]" },
                    { "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 270, DateTimeKind.Local).AddTicks(3294), 1L, null, null, null, "Spanish", "[]" }
                });

            migrationBuilder.InsertData(
                table: "MovementTypes",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 257, DateTimeKind.Local).AddTicks(6848), null, null, null, "IN", "[]" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 257, DateTimeKind.Local).AddTicks(6953), null, null, null, "OUT", "[]" }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 20L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2178), null, null, null, "PaymentTypes", "[]" },
                    { 21L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2181), null, null, null, "CashRegisters", "[]" },
                    { 22L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2184), null, null, null, "CashRegisterOpenings", "[]" },
                    { 23L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2187), null, null, null, "CashRegisterOpeningsAmounts", "[]" },
                    { 24L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2190), null, null, null, "IncomeMovements", "[]" },
                    { 26L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2195), null, null, null, "SuppliersReturns", "[]" },
                    { 27L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2199), null, null, null, "WarehouseTransfers", "[]" },
                    { 29L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2205), null, null, null, "Roles", "[]" },
                    { 19L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2175), null, null, null, "Users", "[]" },
                    { 30L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2208), null, null, null, "Sections", "[]" },
                    { 31L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2211), null, null, null, "Operations", "[]" },
                    { 32L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2214), null, null, null, "Menu", "[]" },
                    { 33L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2217), null, null, null, "Sellers", "[]" },
                    { 34L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2222), null, null, null, "Zones", "[]" },
                    { 28L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2202), null, null, null, "ProductUnits", "[]" },
                    { 18L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2172), null, null, null, "Units", "[]" },
                    { 25L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2193), null, null, null, "CustomersReturns", "[]" },
                    { 16L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2164), null, null, null, "ExpensesPayments", "[]" },
                    { 2L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2096), null, null, null, "CustomerRates", "[]" },
                    { 3L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2118), null, null, null, "Products", "[]" },
                    { 4L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2121), null, null, null, "CustomerPayments", "[]" },
                    { 5L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2125), null, null, null, "Currencies", "[]" },
                    { 6L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2132), null, null, null, "Taxes", "[]" },
                    { 7L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2135), null, null, null, "Invoices", "[]" },
                    { 8L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2138), null, null, null, "Quotes", "[]" },
                    { 9L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2141), null, null, null, "Customers", "[]" },
                    { 10L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2146), null, null, null, "Warehouses", "[]" },
                    { 11L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2149), null, null, null, "All", "[]" },
                    { 12L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2152), null, null, null, "Inventories", "[]" },
                    { 13L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2155), null, null, null, "TRNControl", "[]" },
                    { 14L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2158), null, null, null, "Expenses", "[]" },
                    { 15L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2161), null, null, null, "BranchOffices", "[]" },
                    { 1L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 249, DateTimeKind.Local).AddTicks(9794), null, null, null, "Permissions", "[]" },
                    { 17L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 251, DateTimeKind.Local).AddTicks(2167), null, null, null, "Suppliers", "[]" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 3L, true, (short)3, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 253, DateTimeKind.Local).AddTicks(24), null, null, null, "CREDITCARD", "[]" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 253, DateTimeKind.Local).AddTicks(19), null, null, null, "CHECK", "[]" },
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 252, DateTimeKind.Local).AddTicks(9912), null, null, null, "CASH", "[]" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 19L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(993), null, null, null, "Users", "[]" },
                    { 20L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(999), null, null, null, "PaymentTypes", "[]" },
                    { 21L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1004), null, null, null, "CashRegisters", "[]" },
                    { 22L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1009), null, null, null, "CashRegisterOpenings", "[]" },
                    { 23L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1015), null, null, null, "CashRegisterOpeningsAmounts", "[]" },
                    { 24L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1020), null, null, null, "IncomeMovements", "[]" },
                    { 25L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1025), null, null, null, "CustomersReturns", "[]" },
                    { 26L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1030), null, null, null, "SuppliersReturns", "[]" },
                    { 27L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1036), null, null, null, "WarehouseTransfers", "[]" },
                    { 29L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1047), null, null, null, "Roles", "[]" },
                    { 30L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1052), null, null, null, "Sections", "[]" },
                    { 31L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1057), null, null, null, "Operations", "[]" },
                    { 32L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1062), null, null, null, "Menu", "[]" },
                    { 33L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1068), null, null, null, "Sellers", "[]" },
                    { 34L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1076), null, null, null, "Zones", "[]" },
                    { 28L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(1042), null, null, null, "ProductUnits", "[]" },
                    { 18L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(988), null, null, null, "Units", "[]" },
                    { 3L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(883), null, null, null, "Products", "[]" },
                    { 16L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(975), null, null, null, "ExpensesPayments", "[]" },
                    { 1L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(788), null, null, null, "Permissions", "[]" },
                    { 2L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(874), null, null, null, "CustomerRates", "[]" },
                    { 17L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(980), null, null, null, "Suppliers", "[]" },
                    { 4L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(889), null, null, null, "CustomerPayments", "[]" },
                    { 5L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(893), null, null, null, "Currencies", "[]" },
                    { 7L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(927), null, null, null, "Invoices", "[]" },
                    { 8L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(931), null, null, null, "Quotes", "[]" },
                    { 6L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(921), null, null, null, "Taxes", "[]" },
                    { 10L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(944), null, null, null, "Warehouses", "[]" },
                    { 11L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(949), null, null, null, "All", "[]" },
                    { 12L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(955), null, null, null, "Inventories", "[]" },
                    { 13L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(959), null, null, null, "TRNControl", "[]" },
                    { 14L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(964), null, null, null, "Expenses", "[]" },
                    { 15L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(969), null, null, null, "BranchOffices", "[]" },
                    { 9L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(936), null, null, null, "Customers", "[]" }
                });

            migrationBuilder.InsertData(
                table: "SequencesControl",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "NumericControl", "TranslationData" },
                values: new object[,]
                {
                    { 7L, true, (short)7, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2874), null, null, null, "InventoryIncomes", 0L, "[]" },
                    { 10L, true, (short)10, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2892), null, null, null, "CustomerPayments", 0L, "[]" },
                    { 9L, true, (short)9, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2885), null, null, null, "SupplierReturns", 0L, "[]" },
                    { 8L, true, (short)8, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2879), null, null, null, "CustomersReturns", 0L, "[]" },
                    { 6L, true, (short)6, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2869), null, null, null, "WarehouseTransfers", 0L, "[]" },
                    { 11L, true, (short)11, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2897), null, null, null, "ExpensesPayments", 0L, "[]" },
                    { 4L, true, (short)4, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2853), null, null, null, "Quotes", 0L, "[]" },
                    { 3L, true, (short)3, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2847), null, null, null, "Customers", 0L, "[]" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2837), null, null, null, "Sellers", 0L, "[]" },
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2672), null, null, null, "Invoices", 0L, "[]" },
                    { 5L, true, (short)5, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 255, DateTimeKind.Local).AddTicks(2858), null, null, null, "Expenses", 0L, "[]" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "Address", "BirthDay", "BranchOfficeId", "CashRegisterId", "CashRegisterOpenningTimeHours", "ContentType", "CreatedBy", "CreatedByName", "CreatedDate", "Email", "Gender", "Height", "ImageData", "LanguageCode", "LastName", "Mobile", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "Password", "Phone", "Size", "UserName", "WarehouseId", "Width" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), true, "", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "", new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 15, 41, 47, 258, DateTimeKind.Local).AddTicks(6761), "admin@admin.com", "M", null, null, null, "admin", "8095555555", null, null, null, "admin", "yeLiBgtdL//mX+coUwD6bw==", "8095555555", null, "admin", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LanguageCode",
                table: "Users",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_InvoiceId",
                table: "CustomersPayments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersPayments_Invoices_InvoiceId",
                table: "CustomersPayments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Languages_LanguageCode",
                table: "Users",
                column: "LanguageCode",
                principalTable: "Languages",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersPayments_Invoices_InvoiceId",
                table: "CustomersPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Languages_LanguageCode",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Users_LanguageCode",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_CustomersPayments_InvoiceId",
                table: "CustomersPayments");

            migrationBuilder.DeleteData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "MovementTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Operations",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "SequencesControl",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"));

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Zones");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "LanguageCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "TRNsControl");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Taxes");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "SequencesControl");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "PaymentTypes");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "MovementTypes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "InvoicesDetails");

            migrationBuilder.DropColumn(
                name: "CashRegisterId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "CustomersPayments");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "CashRegisters");

            migrationBuilder.DropColumn(
                name: "TranslationData",
                table: "BranchOffices");

            migrationBuilder.RenameColumn(
                name: "TaxAmount",
                table: "InvoicesTaxes",
                newName: "MontoTax");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<short>(
                name: "GenereId",
                table: "Users",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<long>(
                name: "CajaId",
                table: "Invoices",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    InvoiceCurrencyId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaymentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ReceiptNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    SellerPercentage = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Currencies_InvoiceCurrencyId",
                        column: x => x.InvoiceCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CurrencyId",
                table: "Payment",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_InvoiceCurrencyId",
                table: "Payment",
                column: "InvoiceCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_InvoiceId",
                table: "Payment",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SellerId",
                table: "Payment",
                column: "SellerId");
        }
    }
}
