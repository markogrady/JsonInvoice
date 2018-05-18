using System;

public class Invoice
{
    public string InvoiceId { get; set; }

    public string SupplierName { get; set; }
    public string SupplierAddress1 { get; set; }
    public string SupplierAddress2 { get; set; }
    public string SupplierAddress3 { get; set; }
    public string SupplierAddress4 { get; set; }
    public string SupplierCity { get; set; }
    public string SupplierRegion { get; set; }
    public string SupplierPostalCode { get; set; }


    public string SalesTaxRegistrationNumber { get; set; }

    public string BillingName { get; set; }
    public string BillingAddress1 { get; set; }
    public string BillingAddress2 { get; set; }
    public string BillingAddress3 { get; set; }
    public string BillingAddress4 { get; set; }
    public string BillingCity { get; set; }
    public string BillingRegion { get; set; }
    public string BillingPostalCode { get; set; }

    public string ShippingName { get; set; }
    public string ShippingAddress1 { get; set; }
    public string ShippingAddress2 { get; set; }
    public string ShippingAddress3 { get; set; }
    public string ShippingAddress4 { get; set; }
    public string ShippingCity { get; set; }
    public string ShippingRegion { get; set; }
    public string ShippingPostalCode { get; set; }

    public string CustomerReference { get; set; }

    public decimal SubTotal { get; set; }
    public decimal TaxTotal { get; set; }
    public decimal Total { get; set; }

    public DateTime CreationDate { get; set; }
    public DateTime PaymentDueDate { get; set; }

    public int TermsDays { get; set; }

    public List<InvoiceLine> InvoiceLines { get; set; }
    public List<AdditionalProperty> InvoiceAdditionalProperties { get; set; }
}

public class InvoiceLine
{
    public string InvoiceLineId { get; set; }
    public string InvoiceId { get; set; }
    public string ItemCode { get; set; }
    public string Barcode { get; set; }
    public string Description { get; set; }
    public string AccountCategory { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitAmount { get; set; }
    public string TaxCode { get; set; }
    public decimal TaxTotal { get; set; }
    public decimal LineTotal { get; set; }
    

    public List<AdditionalProperty> InvoiceLineAdditionalProperties { get; set; }
}

public class AdditionalProperty
{
    public string Name { get; set; }
    public object Value  { get; set; }
}