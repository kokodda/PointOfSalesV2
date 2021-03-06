using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PointOfSalesV2.Entities;
using PointOfSalesV2.EntityFramework;
using System;
using System.Linq;

public class MainDataContext : DbContext
{
    private readonly IHttpContextAccessor _HttpContextAccessor;

    //private bool CanUseSessionContext { get; set; }
    //public ComplaintDataContext()
    //{
    //    CanUseSessionContext = true;
    //}

    public MainDataContext(DbContextOptions<MainDataContext> options, IHttpContextAccessor httpContextAccessor)
        : base(options)
    {
        _HttpContextAccessor = httpContextAccessor;

        //CanUseSessionContext = true;
    }
    #region Tables

    public virtual DbSet<CashRegister> CashRegisters { get; set; }
    public virtual DbSet<LanguageKey> LanguageKeys { get; set; }
    public virtual DbSet<CashRegisterOpening> CashRegisterOpenings { get; set; }
    public virtual DbSet<CustomerPayment> CustomersPayments { get; set; }
    public virtual DbSet<CompositeProduct> CompositeProducts { get; set; }
    public virtual DbSet<CreditNote> CreditNotes { get; set; }
    public virtual DbSet<Currency> Currencies { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerBalance> CustomersBalance { get; set; }
    public virtual DbSet<CustomerReturn> CustomersReturns { get; set; }
    public virtual DbSet<CustomerReturnDetail> CustomersReturnDetails { get; set; }
    public virtual DbSet<Expense> Expenses { get; set; }
    public virtual DbSet<ExpenseTax> ExpenseTaxes { get; set; }
    public virtual DbSet<ExpensesPayment> ExpensesPayments { get; set; }
    public virtual DbSet<InventoryEntry> InventoryEntries { get; set; }
    public virtual DbSet<Invoice> Invoices { get; set; }
    public virtual DbSet<InvoiceDetail> InvoicesDetails{ get; set; }
    public virtual DbSet<InvoiceTax> InvoicesTaxes { get; set; }
    public virtual DbSet<BranchOffice> BranchOffices { get; set; }
    public virtual DbSet<MovementType> MovementTypes { get; set; }
    public virtual DbSet<OpeningAmount> OpeningsAmounts { get; set; }
    public virtual DbSet<PaymentType> PaymentTypes { get; set; }
    public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductTax> ProductTaxes { get; set; }
    public virtual DbSet<ReturnDetail> ReturnDetails { get; set; }
    public virtual DbSet<Seller> Sellers { get; set; }
    public virtual DbSet<SequenceControl> SequencesControl { get; set; }
    public virtual DbSet<SupplierReturn> SuppliersReturns { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }
    public virtual DbSet<Language> Languages { get; set; }
    public virtual DbSet<SupplierBalance> SuppliersBalances { get; set; }
    public virtual DbSet<Tax> Taxes { get; set; }
    public virtual DbSet<TRNControl> TRNsControl { get; set; }
    public virtual DbSet<Unit> Units { get; set; }
    public virtual DbSet<UnitProductEquivalence> UnitProductsEquivalences { get; set; }
    public virtual DbSet<Warehouse> Warehouses { get; set; }
    public virtual DbSet<WarehouseMovement> WarehousesMovements { get; set; }
    public virtual DbSet<Inventory> Inventory { get; set; }
    public virtual DbSet<WarehouseTransfer> WarehousesTransfers { get; set; }
    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<Section> Sections { get; set; }
    public virtual DbSet<SectionOperation> SectionOperations { get; set; }
    public virtual DbSet<Operation> Operations { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<RoleSection> RoleSections { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserClaims> UsersClaims { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }




    #endregion



    #region Connection String 

    protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
    {

    }

    #endregion

    #region Fluent API

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>()
          .HasMany(p => p.InvoiceDetails)
          .WithOne(d=>d.Invoice).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Language>().HasIndex(x=>x.Code).IsUnique();
        modelBuilder.Entity<Language>().HasKey( x => x.Code).HasName("Code");
        modelBuilder.Entity<Product>()
         .HasMany(p => p.Taxes)
         .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Product>()
        .HasMany(p => p.ProductUnits)
        .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Product>()
        .HasMany(p => p.BaseCompositeProducts)
        .WithOne(d => d.Product).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>().Property(x => x.UserId).HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<LanguageKey>().HasKey(o => new { o.LanguageCode, o.Key });


        foreach (var property in modelBuilder.Model.GetEntityTypes()
          .SelectMany(t => t.GetProperties())
          .Where(p => p.ClrType == typeof(decimal)))
        {
            property.SetColumnType("decimal(18, 2)");
        }

        var cascadeFKs = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetForeignKeys())
                        .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (var fk in cascadeFKs)
            fk.DeleteBehavior = DeleteBehavior.Restrict;
        ModelBuilderExtensions.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    #endregion

    #region Save Changes
    public override int SaveChanges()
    {
        // Get the entries that are auditable
        var auditableEntitySet = ChangeTracker.Entries<ICommonData>();

        if (auditableEntitySet != null)
        {

            DateTime currentDate = DateTime.Now;

            // Audit set the audit information foreach record
            foreach (var auditableEntity in auditableEntitySet.Where(c => c.State == EntityState.Added || c.State == EntityState.Modified))
            {
                if (auditableEntity.State == EntityState.Added)
                {
                    auditableEntity.Entity.CreatedDate = currentDate;
                }

                auditableEntity.Entity.ModifiedDate = currentDate;
            }
        }

        return base.SaveChanges();
    }

    #endregion

    #region Session Context



    #endregion
}
