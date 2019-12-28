using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Common
{
    public class Enums
    {
        public enum BillingStates
        {
            Billed = 'B',
            Nulled = 'N',
            Paid = 'P',
            Quoted = 'Q',
            Converted = 'C'
        }

        public enum ExcelColumnsDef
        {
            TEXT = 1,
            DECIMAL = 2,
            INTEGER = 3,
            DATETIME = 4
        }
       

        public enum SequenceTypes
        {
            Invoices = 1,
            Sellers = 2,
            Customers = 3,
            Quotes = 4,
            Expenses = 5,
            WarehouseTransfers = 6,
            InventoryIncomes = 7,
            CustomersReturns = 8,
            SupplierReturns = 9,
            CustomerPayments = 10,
            ExpensesPayments = 11
        }
        public enum AppSections
        {
            Permissions = 1,
            CustomerRates = 2,
            Products = 3,
            CustomerPayments = 4,
            Currencies = 5,
            Taxes = 6,
            Invoices = 7,
            Quotes = 8,
            Customers = 9,
            Warehouses = 10,
            All = 11,
            Inventories=12,
            TRNControl=13,
            Expenses=14,
            BranchOffices=15,
            ExpensesPayments=16,
            Suppliers=17,
            Units=18,
            Users=19,
            PaymentTypes=20,
            CashRegisters=21,
            CashRegisterOpenings=22,
            CashRegisterOpeningsAmounts=23,
            IncomeMovements=24,
            CustomersReturns=25,
            SuppliersReturns=26,
            WarehouseTransfers=27,
            ProductUnits=28,
            Roles=29,
            Sections=30,
            Operations=31,
            Menu=32,
            Sellers=33,
            Zones=34

        }
        public enum MovementTypes
        {
            IN = 1,
            OUT = 2
        }

        public enum PaymentTypes
        {
            CASH = 1,
            CHECK = 2,
            CREDITCARD = 3,
            BANKTRANSFER=4
        }

        public enum Gender
        {
            Male = 'M',
            Female = 'F'
        }

        public enum Operations
        {
            READ = 1,
            ADD = 2,
            UPDATE = 3,
            DELETE = 4,

        }
    }
}
