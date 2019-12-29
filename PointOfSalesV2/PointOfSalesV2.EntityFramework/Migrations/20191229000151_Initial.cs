using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PointOfSalesV2.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchOffices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchOffices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Code = table.Column<string>(maxLength: 3, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsLocalCurrency = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "MovementTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Code = table.Column<short>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpeningsAmounts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Order = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningsAmounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Code = table.Column<short>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Controllers = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SequencesControl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Code = table.Column<short>(nullable: false),
                    NumericControl = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequencesControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CardId = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TRNsControl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: false),
                    Type = table.Column<string>(maxLength: 2, nullable: true),
                    Sequence = table.Column<long>(nullable: false),
                    NumericControl = table.Column<long>(nullable: false),
                    Quantity = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRNsControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashRegisters",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    LocationId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(maxLength: 3, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashRegisters_BranchOffices_LocationId",
                        column: x => x.LocationId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditNotes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    OriginInvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    AppliedInvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    Applied = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreditNotes_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Price2 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Price3 = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    DetailsClass = table.Column<string>(nullable: true),
                    IsService = table.Column<bool>(nullable: false),
                    IsCompositeProduct = table.Column<bool>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    Existence = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleSections",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    SectionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleSections_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleSections_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectionOperations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    SectionId = table.Column<long>(nullable: false),
                    OperationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionOperations_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectionOperations_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    SupplierId = table.Column<long>(nullable: false),
                    ExpenseReference = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ReturnedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    GivenAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    TRN = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Expenses_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpensesPayments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    ExpenseCurrencyId = table.Column<long>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    ExpenseReference = table.Column<string>(maxLength: 50, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OutstandingAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensesPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpensesPayments_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpensesPayments_Currencies_ExpenseCurrencyId",
                        column: x => x.ExpenseCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpensesPayments_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuppliersBalances",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuppliersBalances_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersBalances_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    CardId = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    ZoneId = table.Column<long>(nullable: true),
                    ComissionRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ComissionByProduct = table.Column<bool>(nullable: false),
                    FixedComission = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CashRegisterOpenings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    CashRegisterId = table.Column<long>(nullable: false),
                    LocationId = table.Column<long>(nullable: false),
                    OpeningDate = table.Column<DateTime>(nullable: false),
                    MaxClosureDate = table.Column<DateTime>(nullable: false),
                    ClosureDate = table.Column<DateTime>(nullable: false),
                    OpeningDetails = table.Column<string>(nullable: true),
                    ClosureDetails = table.Column<string>(nullable: true),
                    TotalPaymentsAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OpeningClosureDifference = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    State = table.Column<string>(nullable: false),
                    TotalOpeningAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalClosureAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashRegisterOpenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpenings_CashRegisters_CashRegisterId",
                        column: x => x.CashRegisterId,
                        principalTable: "CashRegisters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpenings_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CashRegisterOpenings_BranchOffices_LocationId",
                        column: x => x.LocationId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    TranslationData = table.Column<string>(nullable: true),
                    CardId = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceDueDays = table.Column<long>(nullable: false),
                    BillingAmountLimit = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CreditAmountLimit = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AssignedWarehouseId = table.Column<long>(nullable: true),
                    ZoneId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    TRNType = table.Column<string>(maxLength: 50, nullable: true),
                    TRNControlId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Warehouses_AssignedWarehouseId",
                        column: x => x.AssignedWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_TRNsControl_TRNControlId",
                        column: x => x.TRNControlId,
                        principalTable: "TRNsControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    LanguageCode = table.Column<string>(maxLength: 2, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    Mobile = table.Column<string>(maxLength: 15, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    UserName = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    ContentType = table.Column<string>(maxLength: 15, nullable: true),
                    Width = table.Column<double>(nullable: true),
                    Height = table.Column<double>(nullable: true),
                    Size = table.Column<double>(nullable: true),
                    BranchOfficeId = table.Column<long>(nullable: true),
                    CashRegisterId = table.Column<long>(nullable: true),
                    WarehouseId = table.Column<long>(nullable: true),
                    CashRegisterOpenningTimeHours = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_CashRegisters_CashRegisterId",
                        column: x => x.CashRegisterId,
                        principalTable: "CashRegisters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    WarehouseId = table.Column<long>(nullable: false),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventory_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inventory_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventoryEntries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryEntries_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTaxes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTaxes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductTaxes_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuppliersReturns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SupplierId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuppliersReturns_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitProductsEquivalences",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    Equivalence = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitProductsEquivalences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitProductsEquivalences_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitProductsEquivalences_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WarehousesMovements",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    WarehouseId = table.Column<long>(nullable: false),
                    LocationId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    UnitId = table.Column<long>(nullable: false),
                    MovementType = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousesMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_BranchOffices_LocationId",
                        column: x => x.LocationId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesMovements_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WarehousesTransfers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    OrigingId = table.Column<long>(nullable: false),
                    DestinyId = table.Column<long>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    UnitId = table.Column<long>(nullable: false),
                    OriginId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehousesTransfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Warehouses_DestinyId",
                        column: x => x.DestinyId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Warehouses_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WarehousesTransfers_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTaxes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ExpenseId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseTaxes_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseTaxes_Expenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseTaxes_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersBalance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersBalance_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersBalance_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    ZoneId = table.Column<long>(nullable: false),
                    DocumentNumber = table.Column<string>(maxLength: 50, nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerId = table.Column<long>(nullable: true),
                    WarehouseId = table.Column<long>(nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CashRegisterId = table.Column<long>(nullable: true),
                    ReturnedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ReceivedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AppliedCreditNoteAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NRC = table.Column<string>(maxLength: 100, nullable: true),
                    BranchOfficeId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TRN = table.Column<string>(maxLength: 50, nullable: true),
                    TRNType = table.Column<string>(maxLength: 2, nullable: true),
                    TRNControlId = table.Column<long>(nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    State = table.Column<string>(nullable: false),
                    BillingDate = table.Column<DateTime>(nullable: true),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_BranchOffices_BranchOfficeId",
                        column: x => x.BranchOfficeId,
                        principalTable: "BranchOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_TRNsControl_TRNControlId",
                        column: x => x.TRNControlId,
                        principalTable: "TRNsControl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserOperation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationId = table.Column<long>(nullable: false),
                    SectionId = table.Column<long>(nullable: false),
                    Controllers = table.Column<string>(nullable: true),
                    SectionName = table.Column<string>(nullable: true),
                    OperationName = table.Column<string>(nullable: true),
                    OperationViewName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersClaims",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(maxLength: 100, nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompositeProducts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    BaseProductId = table.Column<long>(nullable: false),
                    BaseProductUnitId = table.Column<long>(nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompositeProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_Products_BaseProductId",
                        column: x => x.BaseProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_UnitProductsEquivalences_BaseProductUnitId",
                        column: x => x.BaseProductUnitId,
                        principalTable: "UnitProductsEquivalences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompositeProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersPayments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    InvoiceCurrencyId = table.Column<long>(nullable: false),
                    PaymentTypeId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OutstandingAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Sequence = table.Column<string>(maxLength: 50, nullable: true),
                    CheckbookNumber = table.Column<string>(maxLength: 50, nullable: true),
                    SellerId = table.Column<long>(nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    InvoiceId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Currencies_InvoiceCurrencyId",
                        column: x => x.InvoiceCurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersPayments_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersReturns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersReturns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersReturns_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoicesDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    SellerRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Free = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    BeforeTaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Comments = table.Column<string>(maxLength: 200, nullable: true),
                    PrincipalCurrencyAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    WarehouseId = table.Column<long>(nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CreditNoteAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ParentId = table.Column<long>(nullable: true),
                    UnitId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoicesDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesDetails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoicesTaxes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    CurrencyId = table.Column<long>(nullable: false),
                    TaxId = table.Column<long>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoicesTaxes_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesTaxes_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoicesTaxes_Taxes_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    PaymentId = table.Column<long>(nullable: false),
                    InvoiceId = table.Column<long>(nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OwedAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    BillingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersReturnDetails",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedByName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<Guid>(nullable: true),
                    ModifiedByName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductoId = table.Column<long>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Reference = table.Column<string>(maxLength: 50, nullable: true),
                    InvoiceNumber = table.Column<string>(maxLength: 50, nullable: true),
                    WarehouseId = table.Column<long>(nullable: true),
                    TaxesAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    Defective = table.Column<bool>(nullable: false),
                    UnitId = table.Column<long>(nullable: true),
                    CustomerReturnId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersReturnDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_CustomersReturns_CustomerReturnId",
                        column: x => x.CustomerReturnId,
                        principalTable: "CustomersReturns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_Products_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersReturnDetails_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Code", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "Id", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { "EN", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(1323), 1L, null, null, null, "English", "[]" },
                    { "ES", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(2239), 2L, null, null, null, "Spanish", "[]" }
                });

            migrationBuilder.InsertData(
                table: "MovementTypes",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 912, DateTimeKind.Local).AddTicks(3539), null, null, null, "IN", "[]" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 912, DateTimeKind.Local).AddTicks(3644), null, null, null, "OUT", "[]" }
                });

            migrationBuilder.InsertData(
                table: "Operations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 6L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8056), null, null, null, "READPAGED", "[]" },
                    { 5L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8040), null, null, null, "READALL", "[]" },
                    { 4L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8034), null, null, null, "DELETE", "[]" },
                    { 7L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8062), null, null, null, "ALL", "[]" },
                    { 2L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(7949), null, null, null, "ADD", "[]" },
                    { 1L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 903, DateTimeKind.Local).AddTicks(9140), null, null, null, "READ", "[]" },
                    { 3L, true, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 905, DateTimeKind.Local).AddTicks(8026), null, null, null, "UPDATE", "[]" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1665), null, null, null, "CASH", "[]" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1838), null, null, null, "CHECK", "[]" },
                    { 3L, true, (short)3, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1848), null, null, null, "CREDITCARD", "[]" },
                    { 4L, true, (short)4, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 908, DateTimeKind.Local).AddTicks(1854), null, null, null, "BANKTRANSFER", "[]" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Active", "Controllers", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "TranslationData" },
                values: new object[,]
                {
                    { 25L, true, "Invoice,Product,InvoiceDetail,Customer", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5154), null, null, null, "CustomersReturns", "[]" },
                    { 20L, true, "PaymentType", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5032), null, null, null, "PaymentTypes", "[]" },
                    { 21L, true, "CashRegister,BranchOffice", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5054), null, null, null, "CashRegisters", "[]" },
                    { 22L, true, "CashRegister,User,CashRegisterOpening", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5077), null, null, null, "CashRegisterOpenings", "[]" },
                    { 23L, true, "CashRegister,User,CashRegisterOpening", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5100), null, null, null, "CashRegisterOpeningsAmounts", "[]" },
                    { 24L, true, "Supplier,Product,Tax,User", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5130), null, null, null, "IncomeMovements", "[]" },
                    { 26L, true, "Supplier,Expense,Tax,Currency", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5177), null, null, null, "SuppliersReturns", "[]" },
                    { 34L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5370), null, null, null, "Zones", "[]" },
                    { 28L, true, "Product,Unit,", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5224), null, null, null, "ProductUnits", "[]" },
                    { 29L, true, "Role", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5247), null, null, null, "Roles", "[]" },
                    { 30L, true, "Section", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5270), null, null, null, "Sections", "[]" },
                    { 31L, true, "Operation", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5299), null, null, null, "Operations", "[]" },
                    { 32L, true, "", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5322), null, null, null, "Menu", "[]" },
                    { 33L, true, "Seller,Zone,BranchOffice", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5346), null, null, null, "Sellers", "[]" },
                    { 19L, true, "User,BranchOffice,Warehouse,CashRegister", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5002), null, null, null, "Users", "[]" },
                    { 27L, true, "BranchOffice,Warehouse,User,Product,Unit", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5201), null, null, null, "WarehouseTransfers", "[]" },
                    { 18L, true, "Unit", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4979), null, null, null, "Units", "[]" },
                    { 16L, true, "Supplier,BranchOffice,User,Currency,Tax", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4929), null, null, null, "ExpensesPayments", "[]" },
                    { 3L, true, "Product,ProductTax", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4609), null, null, null, "Products", "[]" },
                    { 1L, true, "User,UserClaims,Role,RoleSection,Section,SectionOperation", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(1243), null, null, null, "Permissions", "[]" },
                    { 2L, true, "Customer,CustomerRate", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4560), null, null, null, "CustomerRates", "[]" },
                    { 17L, true, "Supplier", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4952), null, null, null, "Suppliers", "[]" },
                    { 4L, true, "Customer,CustomerPayment", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4633), null, null, null, "CustomerPayments", "[]" },
                    { 5L, true, "Currency", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4656), null, null, null, "Currencies", "[]" },
                    { 7L, true, "Invoice,InvoiceDetail,TRNControl,Unit,UnitProductEquivalence,Seller,BranchOffice,Warehouse,CreditNote,Currency,Customer,Inventory,PaymentType", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4705), null, null, null, "Invoices", "[]" },
                    { 8L, true, "Invoice,InvoiceDetail,Unit,UnitProductEquivalence,Seller,Currency,Customer", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4735), null, null, null, "Quotes", "[]" },
                    { 6L, true, "Taxe", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4683), null, null, null, "Taxes", "[]" },
                    { 10L, true, "BranchOffice,Warehouse", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4784), null, null, null, "Warehouses", "[]" },
                    { 11L, true, "*", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4808), null, null, null, "All", "[]" },
                    { 12L, true, "Inventory,Product,BranchOffice,Warehouse,Supplier", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4831), null, null, null, "Inventories", "[]" },
                    { 13L, true, "TRNControl", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4855), null, null, null, "TRNControl", "[]" },
                    { 14L, true, "Supplier,Expense,Tax,ExpenseTax,Currency", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4884), null, null, null, "Expenses", "[]" },
                    { 15L, true, "BranchOffice,Warehouse", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4906), null, null, null, "BranchOffices", "[]" },
                    { 9L, true, "Customer,BranchOffice,Warehouse,TRNControl,Zone", new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4758), null, null, null, "Customers", "[]" }
                });

            migrationBuilder.InsertData(
                table: "SequencesControl",
                columns: new[] { "Id", "Active", "Code", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "NumericControl", "TranslationData" },
                values: new object[,]
                {
                    { 7L, true, (short)7, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6429), null, null, null, "InventoryIncomes", 0L, "[]" },
                    { 10L, true, (short)10, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6440), null, null, null, "CustomerPayments", 0L, "[]" },
                    { 9L, true, (short)9, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6435), null, null, null, "SupplierReturns", 0L, "[]" },
                    { 8L, true, (short)8, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6432), null, null, null, "CustomersReturns", 0L, "[]" },
                    { 6L, true, (short)6, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6425), null, null, null, "WarehouseTransfers", 0L, "[]" },
                    { 11L, true, (short)11, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6443), null, null, null, "ExpensesPayments", 0L, "[]" },
                    { 4L, true, (short)4, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6415), null, null, null, "Quotes", 0L, "[]" },
                    { 3L, true, (short)3, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6411), null, null, null, "Customers", 0L, "[]" },
                    { 2L, true, (short)2, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6406), null, null, null, "Sellers", 0L, "[]" },
                    { 1L, true, (short)1, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6278), null, null, null, "Invoices", 0L, "[]" },
                    { 5L, true, (short)5, new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 910, DateTimeKind.Local).AddTicks(6418), null, null, null, "Expenses", 0L, "[]" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Active", "Address", "BirthDay", "BranchOfficeId", "CashRegisterId", "CashRegisterOpenningTimeHours", "ContentType", "CreatedBy", "CreatedByName", "CreatedDate", "Email", "Gender", "Height", "ImageData", "LanguageCode", "LastName", "Mobile", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Name", "Password", "Phone", "Size", "UserName", "WarehouseId", "Width" },
                values: new object[] { new Guid("8a2fdd4a-e702-482c-f181-08d7015e3521"), true, "", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 0, "", new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 920, DateTimeKind.Local).AddTicks(2584), "admin@admin.com", "M", null, null, null, "admin", "8095555555", null, null, null, "admin", "yeLiBgtdL//mX+coUwD6bw==", "8095555555", null, "admin", null, null });

            migrationBuilder.InsertData(
                table: "LanguageKeys",
                columns: new[] { "LanguageCode", "Key", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "LanguageId", "ModifiedBy", "ModifiedByName", "ModifiedDate", "Value" },
                values: new object[,]
                {
                    { "EN", "unitNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(4168), 1L, null, null, null, "Unit does not exist." },
                    { "ES", "ok_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8739), 2L, null, null, null, "Operation completed successfully." },
                    { "ES", "error_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8744), 2L, null, null, null, "Error: Could not completed the current operation. " },
                    { "ES", "cannotUpdatePayment_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8749), 2L, null, null, null, "Cannot update payment. " },
                    { "ES", "invalidInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8755), 2L, null, null, null, "Invalid invoice." },
                    { "ES", "owedAmountOutdated_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8761), 2L, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "ES", "invoicePaid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8766), 2L, null, null, null, "Invoice is already paid." },
                    { "ES", "paymentNotValid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8771), 2L, null, null, null, "Payment is not valid." },
                    { "ES", "emptyInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8778), 2L, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "ES", "creditLimitReached_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8784), 2L, null, null, null, "Credit limit reached. Cannot continue." },
                    { "ES", "trnNotAvailable_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8789), 2L, null, null, null, "TRN is not available." },
                    { "ES", "outOfStock_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8794), 2L, null, null, null, "Product is out of stock." },
                    { "ES", "notExistingClass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8801), 2L, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "ES", "warehouseError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8806), 2L, null, null, null, "Warehouse does not exist." },
                    { "ES", "creditNoteNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8811), 2L, null, null, null, "Credit note does not exist. " },
                    { "ES", "creditNoteApplied_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8819), 2L, null, null, null, "Credit note is already applied." },
                    { "ES", "differentCurrency_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8823), 2L, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "ES", "amountIsGreater_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8828), 2L, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "ES", "productNeedsUnits_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8833), 2L, null, null, null, "Product needs at least one unit." },
                    { "ES", "productNeedsPrimaryUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8837), 2L, null, null, null, "Product needs one primary unit." },
                    { "ES", "cannotEraseUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8842), 2L, null, null, null, "Cannot erase product unit." },
                    { "ES", "cannotDeleteTax_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8844), 2L, null, null, null, "Cannot delete product tax. " },
                    { "ES", "cannotRemoveBaseProduct_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8850), 2L, null, null, null, "Cannot remove base product." },
                    { "ES", "sequenceError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8854), 2L, null, null, null, "Sequence Error." },
                    { "ES", "parentUnitDoesntExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8733), 2L, null, null, null, "Parent unit does not exist." },
                    { "ES", "unitNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8720), 2L, null, null, null, "Unit does not exist." },
                    { "ES", "defWarehouseNotExit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8797), 2L, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "EN", "cannotRemoveBaseProduct_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8282), 1L, null, null, null, "Cannot remove base product." },
                    { "EN", "sequenceError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8289), 1L, null, null, null, "Sequence Error." },
                    { "EN", "parentUnitDoesntExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8051), 1L, null, null, null, "Parent unit does not exist." },
                    { "EN", "ok_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8128), 1L, null, null, null, "Operation completed successfully." },
                    { "EN", "error_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8136), 1L, null, null, null, "Error: Could not completed the current operation. " },
                    { "EN", "cannotUpdatePayment_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8142), 1L, null, null, null, "Cannot update payment. " },
                    { "EN", "invalidInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8154), 1L, null, null, null, "Invalid invoice." },
                    { "EN", "owedAmountOutdated_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8161), 1L, null, null, null, "Owed amount is outdated. please try update and try again." },
                    { "EN", "paymentNotValid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8167), 1L, null, null, null, "Payment is not valid." },
                    { "EN", "emptyInvoice_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8175), 1L, null, null, null, "Invoice doesn't have any details. Cannot be empty." },
                    { "EN", "creditLimitReached_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8181), 1L, null, null, null, "Credit limit reached. Cannot continue." },
                    { "EN", "trnNotAvailable_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8186), 1L, null, null, null, "TRN is not available." },
                    { "EN", "outOfStock_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8192), 1L, null, null, null, "Product is out of stock." },
                    { "EN", "invoicePaid_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8164), 1L, null, null, null, "Invoice is already paid." },
                    { "EN", "defWarehouseNotExit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8195), 1L, null, null, null, "Defective warehouse does not exist. Please create one with 'DEF' as code first. " },
                    { "EN", "notExistingClass_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8201), 1L, null, null, null, "Cannot process this product/Service. Class does not exist." },
                    { "EN", "warehouseError_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8207), 1L, null, null, null, "Warehouse does not exist." },
                    { "EN", "creditNoteNotExist_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8212), 1L, null, null, null, "Credit note does not exist. " },
                    { "EN", "creditNoteApplied_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8220), 1L, null, null, null, "Credit note is already applied." },
                    { "EN", "differentCurrency_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8227), 1L, null, null, null, "Currencies are different. You can only apply the same currency. " },
                    { "EN", "amountIsGreater_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8257), 1L, null, null, null, "Credit note amount is greater than invoice amount." },
                    { "EN", "productNeedsUnits_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8263), 1L, null, null, null, "Product needs at least one unit." },
                    { "EN", "productNeedsPrimaryUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8267), 1L, null, null, null, "Product needs one primary unit." },
                    { "EN", "cannotEraseUnit_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8272), 1L, null, null, null, "Cannot erase product unit." },
                    { "EN", "cannotDeleteTax_msg", true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 933, DateTimeKind.Local).AddTicks(8278), 1L, null, null, null, "Cannot delete product tax. " }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 183L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5122), null, null, null, 7L, 23L },
                    { 182L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5115), null, null, null, 6L, 23L },
                    { 181L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5112), null, null, null, 5L, 23L },
                    { 180L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5110), null, null, null, 4L, 23L },
                    { 179L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5107), null, null, null, 3L, 23L },
                    { 173L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5089), null, null, null, 5L, 22L },
                    { 177L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5103), null, null, null, 1L, 23L },
                    { 175L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5093), null, null, null, 7L, 22L },
                    { 174L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5091), null, null, null, 6L, 22L },
                    { 172L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5086), null, null, null, 4L, 22L },
                    { 185L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5133), null, null, null, 1L, 24L },
                    { 178L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5105), null, null, null, 2L, 23L },
                    { 186L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5135), null, null, null, 2L, 24L },
                    { 199L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5170), null, null, null, 7L, 25L },
                    { 188L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5139), null, null, null, 4L, 24L },
                    { 189L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5141), null, null, null, 5L, 24L },
                    { 190L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5144), null, null, null, 6L, 24L },
                    { 191L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5146), null, null, null, 7L, 24L },
                    { 193L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5157), null, null, null, 1L, 25L },
                    { 194L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5159), null, null, null, 2L, 25L },
                    { 195L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5161), null, null, null, 3L, 25L },
                    { 196L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5163), null, null, null, 4L, 25L },
                    { 197L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5166), null, null, null, 5L, 25L },
                    { 198L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5168), null, null, null, 6L, 25L },
                    { 201L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5180), null, null, null, 1L, 26L },
                    { 171L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5084), null, null, null, 3L, 22L },
                    { 187L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5137), null, null, null, 3L, 24L },
                    { 170L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5082), null, null, null, 2L, 22L },
                    { 140L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4988), null, null, null, 4L, 18L },
                    { 167L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5070), null, null, null, 7L, 21L },
                    { 138L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4983), null, null, null, 2L, 18L },
                    { 139L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4986), null, null, null, 3L, 18L },
                    { 202L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5182), null, null, null, 2L, 26L },
                    { 141L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4991), null, null, null, 5L, 18L },
                    { 142L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4993), null, null, null, 6L, 18L },
                    { 143L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4996), null, null, null, 7L, 18L },
                    { 145L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5005), null, null, null, 1L, 19L },
                    { 146L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5012), null, null, null, 2L, 19L },
                    { 147L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5014), null, null, null, 3L, 19L },
                    { 148L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5019), null, null, null, 4L, 19L },
                    { 149L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5021), null, null, null, 5L, 19L },
                    { 150L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5023), null, null, null, 6L, 19L },
                    { 169L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5079), null, null, null, 1L, 22L },
                    { 151L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5025), null, null, null, 7L, 19L },
                    { 154L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5037), null, null, null, 2L, 20L },
                    { 155L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5039), null, null, null, 3L, 20L },
                    { 156L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5041), null, null, null, 4L, 20L },
                    { 157L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5043), null, null, null, 5L, 20L },
                    { 158L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5045), null, null, null, 6L, 20L },
                    { 159L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5048), null, null, null, 7L, 20L },
                    { 161L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5057), null, null, null, 1L, 21L },
                    { 162L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5058), null, null, null, 2L, 21L },
                    { 163L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5061), null, null, null, 3L, 21L },
                    { 164L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5063), null, null, null, 4L, 21L },
                    { 165L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5065), null, null, null, 5L, 21L },
                    { 166L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5067), null, null, null, 6L, 21L },
                    { 153L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5034), null, null, null, 1L, 20L },
                    { 203L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5185), null, null, null, 3L, 26L },
                    { 233L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5272), null, null, null, 1L, 30L },
                    { 205L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5189), null, null, null, 5L, 26L },
                    { 241L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5301), null, null, null, 1L, 31L },
                    { 242L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5303), null, null, null, 2L, 31L },
                    { 243L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5306), null, null, null, 3L, 31L },
                    { 244L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5308), null, null, null, 4L, 31L },
                    { 245L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5311), null, null, null, 5L, 31L },
                    { 246L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5313), null, null, null, 6L, 31L },
                    { 247L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5316), null, null, null, 7L, 31L },
                    { 249L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5325), null, null, null, 1L, 32L },
                    { 250L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5327), null, null, null, 2L, 32L },
                    { 251L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5330), null, null, null, 3L, 32L },
                    { 252L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5332), null, null, null, 4L, 32L },
                    { 253L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5334), null, null, null, 5L, 32L },
                    { 239L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5292), null, null, null, 7L, 30L },
                    { 254L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5337), null, null, null, 6L, 32L },
                    { 257L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5350), null, null, null, 1L, 33L },
                    { 258L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5353), null, null, null, 2L, 33L },
                    { 259L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5355), null, null, null, 3L, 33L },
                    { 260L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5357), null, null, null, 4L, 33L },
                    { 261L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5360), null, null, null, 5L, 33L },
                    { 262L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5362), null, null, null, 6L, 33L },
                    { 263L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5364), null, null, null, 7L, 33L },
                    { 265L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5372), null, null, null, 1L, 34L },
                    { 266L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5374), null, null, null, 2L, 34L },
                    { 267L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5377), null, null, null, 3L, 34L },
                    { 268L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5379), null, null, null, 4L, 34L },
                    { 269L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5381), null, null, null, 5L, 34L },
                    { 255L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5339), null, null, null, 7L, 32L },
                    { 204L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5187), null, null, null, 4L, 26L },
                    { 238L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5289), null, null, null, 6L, 30L },
                    { 236L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5284), null, null, null, 4L, 30L },
                    { 206L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5192), null, null, null, 6L, 26L },
                    { 207L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5194), null, null, null, 7L, 26L },
                    { 209L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5203), null, null, null, 1L, 27L },
                    { 210L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5205), null, null, null, 2L, 27L },
                    { 211L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5208), null, null, null, 3L, 27L },
                    { 212L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5210), null, null, null, 4L, 27L },
                    { 213L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5212), null, null, null, 5L, 27L },
                    { 214L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5215), null, null, null, 6L, 27L },
                    { 215L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5217), null, null, null, 7L, 27L },
                    { 217L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5226), null, null, null, 1L, 28L },
                    { 218L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5229), null, null, null, 2L, 28L },
                    { 219L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5231), null, null, null, 3L, 28L },
                    { 237L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5287), null, null, null, 5L, 30L },
                    { 220L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5234), null, null, null, 4L, 28L },
                    { 222L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5238), null, null, null, 6L, 28L },
                    { 223L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5241), null, null, null, 7L, 28L },
                    { 225L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5249), null, null, null, 1L, 29L },
                    { 226L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5252), null, null, null, 2L, 29L },
                    { 227L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5254), null, null, null, 3L, 29L },
                    { 228L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5256), null, null, null, 4L, 29L },
                    { 229L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5259), null, null, null, 5L, 29L },
                    { 230L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5261), null, null, null, 6L, 29L },
                    { 231L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5264), null, null, null, 7L, 29L },
                    { 137L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4981), null, null, null, 1L, 18L },
                    { 234L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5280), null, null, null, 2L, 30L },
                    { 235L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5282), null, null, null, 3L, 30L },
                    { 221L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5236), null, null, null, 5L, 28L },
                    { 135L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4972), null, null, null, 7L, 17L },
                    { 106L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4889), null, null, null, 2L, 14L },
                    { 133L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4967), null, null, null, 5L, 17L },
                    { 35L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4667), null, null, null, 3L, 5L },
                    { 36L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4669), null, null, null, 4L, 5L },
                    { 37L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4671), null, null, null, 5L, 5L },
                    { 38L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4675), null, null, null, 6L, 5L },
                    { 39L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4677), null, null, null, 7L, 5L },
                    { 41L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4685), null, null, null, 1L, 6L },
                    { 42L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4688), null, null, null, 2L, 6L },
                    { 43L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4690), null, null, null, 3L, 6L },
                    { 44L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4693), null, null, null, 4L, 6L },
                    { 45L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4695), null, null, null, 5L, 6L },
                    { 46L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4697), null, null, null, 6L, 6L },
                    { 47L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4699), null, null, null, 7L, 6L },
                    { 34L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4665), null, null, null, 2L, 5L },
                    { 49L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4708), null, null, null, 1L, 7L },
                    { 51L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4712), null, null, null, 3L, 7L },
                    { 52L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4714), null, null, null, 4L, 7L },
                    { 53L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4723), null, null, null, 5L, 7L },
                    { 54L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4726), null, null, null, 6L, 7L },
                    { 55L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4728), null, null, null, 7L, 7L },
                    { 57L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4738), null, null, null, 1L, 8L },
                    { 58L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4740), null, null, null, 2L, 8L },
                    { 59L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4742), null, null, null, 3L, 8L },
                    { 60L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4744), null, null, null, 4L, 8L },
                    { 61L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4747), null, null, null, 5L, 8L },
                    { 62L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4749), null, null, null, 6L, 8L },
                    { 63L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4752), null, null, null, 7L, 8L },
                    { 50L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4710), null, null, null, 2L, 7L },
                    { 65L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4762), null, null, null, 1L, 9L },
                    { 33L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4662), null, null, null, 1L, 5L },
                    { 30L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4648), null, null, null, 6L, 4L },
                    { 1L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(2192), null, null, null, 1L, 1L },
                    { 2L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4402), null, null, null, 2L, 1L }
                });

            migrationBuilder.InsertData(
                table: "SectionOperations",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedByName", "CreatedDate", "ModifiedBy", "ModifiedByName", "ModifiedDate", "OperationId", "SectionId" },
                values: new object[,]
                {
                    { 3L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4458), null, null, null, 3L, 1L },
                    { 4L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4461), null, null, null, 4L, 1L },
                    { 5L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4466), null, null, null, 5L, 1L },
                    { 6L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4473), null, null, null, 6L, 1L },
                    { 7L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4476), null, null, null, 7L, 1L },
                    { 9L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4582), null, null, null, 1L, 2L },
                    { 10L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4584), null, null, null, 2L, 2L },
                    { 11L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4589), null, null, null, 3L, 2L },
                    { 12L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4591), null, null, null, 4L, 2L },
                    { 13L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4593), null, null, null, 5L, 2L },
                    { 31L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4650), null, null, null, 7L, 4L },
                    { 14L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4596), null, null, null, 6L, 2L },
                    { 17L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4612), null, null, null, 1L, 3L },
                    { 18L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4614), null, null, null, 2L, 3L },
                    { 19L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4616), null, null, null, 3L, 3L },
                    { 20L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4620), null, null, null, 4L, 3L },
                    { 21L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4623), null, null, null, 5L, 3L },
                    { 22L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4625), null, null, null, 6L, 3L },
                    { 23L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4627), null, null, null, 7L, 3L },
                    { 25L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4636), null, null, null, 1L, 4L },
                    { 26L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4638), null, null, null, 2L, 4L },
                    { 27L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4640), null, null, null, 3L, 4L },
                    { 28L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4643), null, null, null, 4L, 4L },
                    { 29L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4645), null, null, null, 5L, 4L },
                    { 15L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4598), null, null, null, 7L, 2L },
                    { 134L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4969), null, null, null, 6L, 17L },
                    { 66L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4765), null, null, null, 2L, 9L },
                    { 68L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4770), null, null, null, 4L, 9L },
                    { 103L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4876), null, null, null, 7L, 13L },
                    { 105L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4886), null, null, null, 1L, 14L },
                    { 270L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5383), null, null, null, 6L, 34L },
                    { 107L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4891), null, null, null, 3L, 14L },
                    { 108L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4894), null, null, null, 4L, 14L },
                    { 109L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4896), null, null, null, 5L, 14L },
                    { 110L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4898), null, null, null, 6L, 14L },
                    { 111L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4900), null, null, null, 7L, 14L },
                    { 113L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4909), null, null, null, 1L, 15L },
                    { 114L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4911), null, null, null, 2L, 15L },
                    { 115L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4913), null, null, null, 3L, 15L },
                    { 116L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4915), null, null, null, 4L, 15L },
                    { 102L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4874), null, null, null, 6L, 13L },
                    { 117L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4917), null, null, null, 5L, 15L },
                    { 119L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4922), null, null, null, 7L, 15L },
                    { 121L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4931), null, null, null, 1L, 16L },
                    { 122L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4934), null, null, null, 2L, 16L },
                    { 123L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4936), null, null, null, 3L, 16L },
                    { 124L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4938), null, null, null, 4L, 16L },
                    { 125L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4940), null, null, null, 5L, 16L },
                    { 126L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4943), null, null, null, 6L, 16L },
                    { 127L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4945), null, null, null, 7L, 16L },
                    { 129L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4957), null, null, null, 1L, 17L },
                    { 130L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4959), null, null, null, 2L, 17L },
                    { 131L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4962), null, null, null, 3L, 17L },
                    { 132L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4964), null, null, null, 4L, 17L },
                    { 118L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4920), null, null, null, 6L, 15L },
                    { 67L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4767), null, null, null, 3L, 9L },
                    { 101L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4872), null, null, null, 5L, 13L },
                    { 99L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4867), null, null, null, 3L, 13L },
                    { 69L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4772), null, null, null, 5L, 9L },
                    { 70L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4775), null, null, null, 6L, 9L },
                    { 71L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4777), null, null, null, 7L, 9L },
                    { 73L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4786), null, null, null, 1L, 10L },
                    { 74L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4789), null, null, null, 2L, 10L },
                    { 75L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4793), null, null, null, 3L, 10L },
                    { 76L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4796), null, null, null, 4L, 10L },
                    { 77L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4798), null, null, null, 5L, 10L },
                    { 78L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4800), null, null, null, 6L, 10L },
                    { 79L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4802), null, null, null, 7L, 10L },
                    { 81L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4811), null, null, null, 1L, 11L },
                    { 82L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4813), null, null, null, 2L, 11L },
                    { 100L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4869), null, null, null, 4L, 13L },
                    { 83L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4815), null, null, null, 3L, 11L },
                    { 85L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4820), null, null, null, 5L, 11L },
                    { 86L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4822), null, null, null, 6L, 11L },
                    { 87L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4824), null, null, null, 7L, 11L },
                    { 89L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4833), null, null, null, 1L, 12L },
                    { 90L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4836), null, null, null, 2L, 12L },
                    { 91L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4838), null, null, null, 3L, 12L },
                    { 92L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4841), null, null, null, 4L, 12L },
                    { 93L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4843), null, null, null, 5L, 12L },
                    { 94L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4845), null, null, null, 6L, 12L },
                    { 95L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4848), null, null, null, 7L, 12L },
                    { 97L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4863), null, null, null, 1L, 13L },
                    { 98L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4865), null, null, null, 2L, 13L },
                    { 84L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(4817), null, null, null, 4L, 11L },
                    { 271L, true, new Guid("00000000-0000-0000-0000-000000000000"), "admin", new DateTime(2019, 12, 28, 20, 1, 50, 919, DateTimeKind.Local).AddTicks(5385), null, null, null, 7L, 34L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_CashRegisterId",
                table: "CashRegisterOpenings",
                column: "CashRegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_CurrencyId",
                table: "CashRegisterOpenings",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisterOpenings_LocationId",
                table: "CashRegisterOpenings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CashRegisters_LocationId",
                table: "CashRegisters",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_BaseProductId",
                table: "CompositeProducts",
                column: "BaseProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_BaseProductUnitId",
                table: "CompositeProducts",
                column: "BaseProductUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_CurrencyId",
                table: "CompositeProducts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompositeProducts_ProductId",
                table: "CompositeProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditNotes_CurrencyId",
                table: "CreditNotes",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AssignedWarehouseId",
                table: "Customers",
                column: "AssignedWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CurrencyId",
                table: "Customers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TRNControlId",
                table: "Customers",
                column: "TRNControlId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ZoneId",
                table: "Customers",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersBalance_CurrencyId",
                table: "CustomersBalance",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersBalance_CustomerId",
                table: "CustomersBalance",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_CurrencyId",
                table: "CustomersPayments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_CustomerId",
                table: "CustomersPayments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_InvoiceCurrencyId",
                table: "CustomersPayments",
                column: "InvoiceCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_InvoiceId",
                table: "CustomersPayments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPayments_SellerId",
                table: "CustomersPayments",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_CustomerId",
                table: "CustomersReturnDetails",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_CustomerReturnId",
                table: "CustomersReturnDetails",
                column: "CustomerReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_ProductoId",
                table: "CustomersReturnDetails",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturnDetails_WarehouseId",
                table: "CustomersReturnDetails",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersReturns_InvoiceId",
                table: "CustomersReturns",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_BranchOfficeId",
                table: "Expenses",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CurrencyId",
                table: "Expenses",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_SupplierId",
                table: "Expenses",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_CurrencyId",
                table: "ExpensesPayments",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_ExpenseCurrencyId",
                table: "ExpensesPayments",
                column: "ExpenseCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensesPayments_SupplierId",
                table: "ExpensesPayments",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTaxes_CurrencyId",
                table: "ExpenseTaxes",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTaxes_ExpenseId",
                table: "ExpenseTaxes",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTaxes_TaxId",
                table: "ExpenseTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductId",
                table: "Inventory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UnitId",
                table: "Inventory",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_WarehouseId",
                table: "Inventory",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_ProductId",
                table: "InventoryEntries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_SupplierId",
                table: "InventoryEntries",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_UnitId",
                table: "InventoryEntries",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryEntries_WarehouseId",
                table: "InventoryEntries",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BranchOfficeId",
                table: "Invoices",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CurrencyId",
                table: "Invoices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SellerId",
                table: "Invoices",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_TRNControlId",
                table: "Invoices",
                column: "TRNControlId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ZoneId",
                table: "Invoices",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_InvoiceId",
                table: "InvoicesDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_ProductId",
                table: "InvoicesDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesDetails_UnitId",
                table: "InvoicesDetails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesTaxes_CurrencyId",
                table: "InvoicesTaxes",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesTaxes_InvoiceId",
                table: "InvoicesTaxes",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesTaxes_TaxId",
                table: "InvoicesTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_InvoiceId",
                table: "PaymentDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CurrencyId",
                table: "Products",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTaxes_ProductId",
                table: "ProductTaxes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTaxes_TaxId",
                table: "ProductTaxes",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSections_RoleId",
                table: "RoleSections",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleSections_SectionId",
                table: "RoleSections",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOperations_OperationId",
                table: "SectionOperations",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOperations_SectionId",
                table: "SectionOperations",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_ZoneId",
                table: "Sellers",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersBalances_CurrencyId",
                table: "SuppliersBalances",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersBalances_SupplierId",
                table: "SuppliersBalances",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_ProductId",
                table: "SuppliersReturns",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_SupplierId",
                table: "SuppliersReturns",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_UnitId",
                table: "SuppliersReturns",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SuppliersReturns_WarehouseId",
                table: "SuppliersReturns",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitProductsEquivalences_ProductId",
                table: "UnitProductsEquivalences",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitProductsEquivalences_UnitId",
                table: "UnitProductsEquivalences",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperation_UserId",
                table: "UserOperation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchOfficeId",
                table: "Users",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CashRegisterId",
                table: "Users",
                column: "CashRegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LanguageCode",
                table: "Users",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WarehouseId",
                table: "Users",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClaims_UserId",
                table: "UsersClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_BranchOfficeId",
                table: "Warehouses",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_LocationId",
                table: "WarehousesMovements",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_ProductId",
                table: "WarehousesMovements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_UnitId",
                table: "WarehousesMovements",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesMovements_WarehouseId",
                table: "WarehousesMovements",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_DestinyId",
                table: "WarehousesTransfers",
                column: "DestinyId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_OriginId",
                table: "WarehousesTransfers",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_ProductId",
                table: "WarehousesTransfers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehousesTransfers_UnitId",
                table: "WarehousesTransfers",
                column: "UnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashRegisterOpenings");

            migrationBuilder.DropTable(
                name: "CompositeProducts");

            migrationBuilder.DropTable(
                name: "CreditNotes");

            migrationBuilder.DropTable(
                name: "CustomersBalance");

            migrationBuilder.DropTable(
                name: "CustomersPayments");

            migrationBuilder.DropTable(
                name: "CustomersReturnDetails");

            migrationBuilder.DropTable(
                name: "ExpensesPayments");

            migrationBuilder.DropTable(
                name: "ExpenseTaxes");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "InventoryEntries");

            migrationBuilder.DropTable(
                name: "InvoicesDetails");

            migrationBuilder.DropTable(
                name: "InvoicesTaxes");

            migrationBuilder.DropTable(
                name: "LanguageKeys");

            migrationBuilder.DropTable(
                name: "MovementTypes");

            migrationBuilder.DropTable(
                name: "OpeningsAmounts");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "ProductTaxes");

            migrationBuilder.DropTable(
                name: "RoleSections");

            migrationBuilder.DropTable(
                name: "SectionOperations");

            migrationBuilder.DropTable(
                name: "SequencesControl");

            migrationBuilder.DropTable(
                name: "SuppliersBalances");

            migrationBuilder.DropTable(
                name: "SuppliersReturns");

            migrationBuilder.DropTable(
                name: "UserOperation");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UsersClaims");

            migrationBuilder.DropTable(
                name: "WarehousesMovements");

            migrationBuilder.DropTable(
                name: "WarehousesTransfers");

            migrationBuilder.DropTable(
                name: "UnitProductsEquivalences");

            migrationBuilder.DropTable(
                name: "CustomersReturns");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "CashRegisters");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "TRNsControl");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "BranchOffices");
        }
    }
}
