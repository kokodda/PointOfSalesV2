using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Common
{
    public class Enums
    {
        public enum BillingStates 
        {
        Billed='B',
        Nulled='N',
        Paid='P',
        Quoted='Q',
        Converted='C'
        }

        public enum SequenceTypes 
        {
        Invoices=1,
        Sellers=2,
        Customers=3,
        Quotes=4,
        Expenses=5,
        WarehouseTransfers=6,
        InventoryIncomes=7,
        CustomersReturns=8,
        SupplierReturns=9,
        CustomerPayments=10,
        ExpensesPayments=11
        }

        public enum MovementTypes 
        {
        IN=1,
        OUT=2
        }

        public enum PaymentTypes 
        {
        CASH=1,
        CHECK=2,
        CREDITCARD=3
        }
    }
}
