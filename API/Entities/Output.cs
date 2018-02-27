using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Entities
{
    public class TaxExemptInfo
    {
        public string TAX_EXEMPT_REASON { get; set; }
        public string TAX_EXEMPT_NUM { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS_1 { get; set; }
        public string ADDRESS_2 { get; set; }
        public string POSTAL_CODE { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string CHILD_NAME { get; set; }
    }

    public class Custom
    {
        public DateTime CustomDate5 { get; set; }
        public double CustomDecimal1 { get; set; }
        public double CustomDecimal2 { get; set; }
        public double CustomDecimal3 { get; set; }
        public double CustomDecimal4 { get; set; }
        public double CustomDecimal5 { get; set; }
        public double CustomDecimal6 { get; set; }
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag2 { get; set; }
        public bool CustomFlag3 { get; set; }
        public bool CustomFlag4 { get; set; }
        public bool CustomFlag5 { get; set; }
        public bool CustomFlag6 { get; set; }
        public int CustomNumber2 { get; set; }
        public int CustomNumber3 { get; set; }
        public int CustomNumber4 { get; set; }
        public int CustomNumber5 { get; set; }
        public int CustomNumber6 { get; set; }
        public string CustomText1 { get; set; }
        public string CustomText2 { get; set; }
        public string CustomText3 { get; set; }
        public string CustomText4 { get; set; }
        public string CustomText5 { get; set; }
        public string CustomText6 { get; set; }
    }

    public class SellInfo
    {
        public string Customer { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address1 { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Phone1 { get; set; }
        public string Email { get; set; }
        public Custom Custom { get; set; }
    }

    public class BillInfo
    {
    }

    public class ShipInfo
    {
    }

    public class ReceiptFee
    {
        public int LineNo { get; set; }
        public string ItemChargeCode { get; set; }
        public string ItemChargeType { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public double ExtPrice { get; set; }
        public double ExtPriceWithTax { get; set; }
        public string TaxCategoryCode { get; set; }
        public bool Spread { get; set; }
        public string SpreadType { get; set; }
    }

    public class DCSS
    {
        public string DCSSCode { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public string SubClass1Code { get; set; }
        public string SubClass1Name { get; set; }
    }

    public class Style
    {
        public DateTime CustomDate2 { get; set; }
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag2 { get; set; }
        public bool CustomFlag6 { get; set; }
        public string CustomLookup1 { get; set; }
        public string CustomLookup12 { get; set; }
        public string CustomLookup2 { get; set; }
        public string CustomLookup3 { get; set; }
        public string CustomLookup4 { get; set; }
        public string CustomLookup7 { get; set; }
        public int CustomNumber4 { get; set; }
        public int CustomNumber6 { get; set; }
        public string CustomText1 { get; set; }
        public string CustomText2 { get; set; }
        public string CustomText3 { get; set; }
        public string CustomText4 { get; set; }
        public string CustomText5 { get; set; }
        public string CustomText6 { get; set; }
    }

    public class Item2
    {
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag2 { get; set; }
        public string CustomText4 { get; set; }
    }

    public class ItemDetails
    {
        public int PLU { get; set; }
        public string CLU { get; set; }
        public string UPC { get; set; }
        public string StyleNo { get; set; }
        public string ItemDescription { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public DCSS DCSS { get; set; }
        public Style Style { get; set; }
        public Item2 Item { get; set; }
    }

    public class ItemFee
    {
        public int LineNo { get; set; }
        public string ItemChargeCode { get; set; }
        public string ItemChargeType { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public double ExtPrice { get; set; }
        public double ExtPriceWithTax { get; set; }
        public string TaxCategoryCode { get; set; }
        public bool Spread { get; set; }
        public int? GlobalChargeLineNo { get; set; }
    }

    public class Tax
    {
        public double TaxAmount { get; set; }
        public double TaxPercent { get; set; }
        public string DestTaxZoneCode { get; set; }
        public string TaxCategoryCode { get; set; }
        public string SourceTaxZoneCode { get; set; }
        public string TaxJurisdictionCode { get; set; }
        public bool TaxExempt { get; set; }
        public bool IsCustomTaxPercent { get; set; }
        public bool IsCustomTaxAmount { get; set; }
        public bool CustomFlag1 { get; set; }
        public int CustomNumber1 { get; set; }
        public double CustomDecimal1 { get; set; }
    }

    public class Item
    {
        public int LineNo { get; set; }
        public string ItemIdentifier { get; set; }
        public string ItemType { get; set; }
        public ItemDetails ItemDetails { get; set; }
        public double Qty { get; set; }
        public string PriceLevelCode { get; set; }
        public double InventoryPrice { get; set; }
        public double MembershipDiscount { get; set; }
        public string MembershipLevel { get; set; }
        public double SalePrice { get; set; }
        public double LineExtDiscountAmount { get; set; }
        public double LineUnitDiscountAmount { get; set; }
        public double LineDiscountPercent { get; set; }
        public double UnitAmount { get; set; }
        public double ExtAmount { get; set; }
        public double TaxExtAmount { get; set; }
        public double ItemFeesAmount { get; set; }
        public bool PricesIncludeTaxes { get; set; }
        public int OriginalReceiptNum { get; set; }
        public double CustomDecimal1 { get; set; }
        public double CustomDecimal2 { get; set; }
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag2 { get; set; }
        public int CustomNumber1 { get; set; }
        public int CustomNumber2 { get; set; }
        public List<ItemFee> ItemFees { get; set; }
        public string TaxCategoryCode { get; set; }
        public List<Tax> Taxes { get; set; }
        public string ShipMethod { get; set; }
        public string TrackingNumber { get; set; }
        public string ReturnReasonCode { get; set; }
        public bool? IsManuallyReturn { get; set; }
        public bool? TaxExempt { get; set; }
    }

    public class DepositHistory
    {
        public int LineNo { get; set; }
        public string PaymentMethod { get; set; }
        public double PaymentAmount { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string CardEnterMethod { get; set; }
        public string CardOrderId { get; set; }
        public string CardType { get; set; }
        public double CustomDecimal1 { get; set; }
        public double CustomDecimal4 { get; set; }
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag3 { get; set; }
        public int CustomNumber1 { get; set; }
        public int CustomNumber2 { get; set; }
    }

    public class Payment
    {
        public int LineNo { get; set; }
        public string PaymentMethod { get; set; }
        public double PaymentAmount { get; set; }
        public string AccountType { get; set; }
        public string PaymentProcessingRefNum { get; set; }
        public string CardEnterMethod { get; set; }
        public double CustomDecimal1 { get; set; }
        public double CustomDecimal2 { get; set; }
        public double CustomDecimal3 { get; set; }
        public double CustomDecimal4 { get; set; }
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag2 { get; set; }
        public bool CustomFlag3 { get; set; }
        public bool CustomFlag4 { get; set; }
        public int CustomNumber1 { get; set; }
        public int CustomNumber2 { get; set; }
        public int CustomNumber3 { get; set; }
        public int CustomNumber4 { get; set; }
        public List<DepositHistory> DepositHistory { get; set; }
    }

    public class SalesReceipt
    {

        public int SalesReceiptNo { get; set; }
        public DateTime RecModified { get; set; }
        public long DeviceTransactionNumber { get; set; }
        public string SalesReceiptId { get; set; }
        public string ReceiptCode { get; set; }
        public DateTime PostedDateTime { get; set; }
        public string Location { get; set; }
        public string TransactionType { get; set; }
        public string Cashier { get; set; }
        public double TotalQty { get; set; }
        public double InventoryAmount { get; set; }
        public double MembershipDiscount { get; set; }
        public double TotalDiscountAmount { get; set; }
        public double TotalTaxAmount { get; set; }
        public double TotalAmount { get; set; }
        public string MembershipLevel { get; set; }
        public string DestTaxArea { get; set; }
        public string SourceTaxArea { get; set; }
        public bool TaxExempt { get; set; }
        public TaxExemptInfo TaxExemptInfo { get; set; }
        public SellInfo SellInfo { get; set; }
        public BillInfo BillInfo { get; set; }
        public ShipInfo ShipInfo { get; set; }
        public string Notes { get; set; }
        public double CustomDecimal1 { get; set; }
        public double CustomDecimal2 { get; set; }
        public double CustomDecimal3 { get; set; }
        public double CustomDecimal4 { get; set; }
        public bool CustomFlag1 { get; set; }
        public bool CustomFlag2 { get; set; }
        public bool CustomFlag3 { get; set; }
        public bool CustomFlag4 { get; set; }
        public int CustomNumber1 { get; set; }
        public int CustomNumber2 { get; set; }
        public int CustomNumber3 { get; set; }
        public int CustomNumber4 { get; set; }
        public List<ReceiptFee> ReceiptFees { get; set; }
        public List<Item> Items { get; set; }
        public List<Payment> Payments { get; set; }
    }

    public class Response
    {
        public List<SalesReceipt> SalesReceipts { get; set; }
    }

    public class ApiDocument
    {
        public string ApiDocumentId { get; set; }
        public string Status { get; set; }
        public int TotalRecords { get; set; }
        public int RecordsCount { get; set; }
        public string ElapsedTime { get; set; }
        public Response Response { get; set; }
    }

    public class ResultObj
    {
        public ApiDocument ApiDocument { get; set; }
    }


}
