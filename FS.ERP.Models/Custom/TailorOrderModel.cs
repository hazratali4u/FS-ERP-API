using System;
using System.Collections.Generic;

namespace FS.ERP.Models.Custom
{
    public class TailorOrderModel
    {
        public OrderModel Order { get; set; }
        public List<OrderDetailModel> OrderDetails { get; set; }
        public List<DressSizeModel> OrderDressSizes { get; set; }

        //public TailorOrderModel()
        //{
        //    this.Order = new OrderModel
        //    {
        //        CustomerCode = 1,
        //        UserCode = 1,
        //        EmpCode = 1
        //    };
        //    this.OrderDetails = new List<OrderDetailModel>
        //    {
        //        new OrderDetailModel
        //        {
        //            DressTypeCode = 1,
        //            DressStyles = new List<DressStyleModel>
        //            {
        //                new DressStyleModel
        //                {
        //                    DressTypeStyleCategoryCode = 1,
        //                    Style = "Pleats"
        //                },
        //                new DressStyleModel
        //                {
        //                    DressTypeStyleCategoryCode = 2,
        //                    Style = "Pockets"
        //                }
        //            }
        //        }
        //    };
        //    this.OrderDressSizes = new List<DressSizeModel>
        //    {
        //        new DressSizeModel
        //        {
        //            DressTypeCode = 1,
        //            DressSizeCode = 1,
        //            SizeValue = 10
        //        },
        //        new DressSizeModel
        //        {
        //            DressTypeCode = 1,
        //            DressSizeCode = 2,
        //            SizeValue = 100
        //        }
        //    };
        //}
    }
    public class OrderModel
    {
        public long OrderCode { get; set; }
        public long CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string OrderTakerEmpName { get; set; }
        public long UserCode { get; set; }
        public long EmpCode { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int RecordStatusCode { get; set; }
    }
    public class OrderDetailModel
    {
        public long OrderDetailCode { get; set; }
        public long? FabricCode { get; set; }
        public string FabricName { get; set; }
        public long? DressTypeCode { get; set; }
        public string DressTypeName { get; set; }
        public DateTime? TryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal? StitchingFee { get; set; }
        public decimal? FabricQuantity { get; set; }
        public decimal? FabricPrice { get; set; }
        public string SizeNotes { get; set; }
        public string StyleNotes { get; set; }
        public decimal? AdditionalAmount { get; set; }
        public string AddAmountRemarks { get; set; }
        public string Status { get; set; }
        public int RecordStatusCode { get; set; }
        public string ArticleCode { get; set; }
        public long MeasurementsBy { get; set; }
        public string MeasurementsByName { get; set; }
        
        public List<DressStyleModel> DressStyles { get; set; }
        public List<DressStylePrintModel> DressStylesPrint { get; set; }
        
    }
    public class DressTypeMeasurements
    {
        public long DressTypeCode { get; set; }
        public long MeasurementsBy { get; set; }
    }
    public class DressStyleModel
    {
        public long OrderDetailStyleCode { get; set; }
        public long DressTypeStyleCategoryCode { get; set; }
        public long? ParentID { get; set; }
        public string DressTypeStyleCategoryName { get; set; }
        public string Style { get; set; }
        public string StyleValue { get; set; }
        public string GroupName { get; set; }
        public int RecordStatusCode { get; set; }
    }

    public class DressStylePrintModel
    {
        public string val { get; set; }
    }
    public class DressSizeModel
    {
        public long OrderDressSizeCode { get; set; }
        public long DressTypeCode { get; set; }
        public string DressTypeName { get; set; }
        public string DressSizeName { get; set; }
        public long? DressSizeCode { get; set; }
        public decimal? SizeValue { get; set; }
        public int RecordStatusCode { get; set; }
        public int Break { get; set; }
        public long MeasurementsBy { get; set; }
        public string MeasurementsByName { get; set; }
    }

    public class TailorPaymentModel
    {
        public List<ExpenseModel> Expenses { get; set; }

        //public TailorPaymentModel()
        //{
        //    //Expenses = new List<ExpenseModel>();

        //    this.Expenses = new List<ExpenseModel>
        //    {
        //        new ExpenseModel
        //        {
        //            ExpenseCode = 0,
        //            Amount = 100,
        //            ExpenseDate = new DateTime(),
        //            ExpenseHeadCode = 1,
        //            PaymentModeCode = 3,
        //            Remarks = "testing",
        //            UserCode = 1
        //        },
        //        new ExpenseModel
        //        {
        //            ExpenseCode = 0,
        //            Amount = 150,
        //            ExpenseDate = new DateTime(),
        //            ExpenseHeadCode = 2,
        //            PaymentModeCode = 1,
        //            Remarks = "testing",
        //            UserCode = 1
        //        }
        //    };
        //}
    }

    public class ExpenseModel
    {
        public long ExpenseCode { get; set; }
        public long UserCode { get; set; }
        public long ExpenseHeadCode { get; set; }
        public DateTime ExpenseDate { get; set; }
        public long PaymentModeCode { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
    }
    public class TailorOrderSaveModel
    {
        public OrderSaveModel Order { get; set; }
        public List<OrderDetailSaveModel> OrderDetails { get; set; }
        public List<DressSizeSaveModel> OrderDressSizes { get; set; }

    }
    public class OrderSaveModel
    {
        public long OCde { get; set; }
        public long CustCde { get; set; }
        public long UCde { get; set; }
        public long ECde { get; set; }
    }
    public class OrderDetailSaveModel
    {
        public long ODetCde { get; set; }
        public long? FabCde { get; set; }
        public long? DrsTypCde { get; set; }
        public DateTime? TryDte { get; set; }
        public DateTime? DelDte { get; set; }
        public decimal? StitchFee { get; set; }
        public decimal? FabQty { get; set; }
        public decimal? FabPrc { get; set; }
        public string SizNts { get; set; }
        public string StylNts { get; set; }
        public decimal? AddAmnt { get; set; }
        public string AddAmntRem { get; set; }
        public long MesureBy { get; set; }
        public List<DressStyleSaveModel> DressStyles { get; set; }
    }
    public class DressStyleSaveModel
    {
        public long OrDetStylCde { get; set; }
        public long DrsTypStylCatCde { get; set; }
        public string Styl { get; set; }
        public string StylVal { get; set; }
    }
    public class DressSizeSaveModel
    {
        public long ODrsSizCde { get; set; }
        public long DrsTypCde { get; set; }
        public long? DrsSizCde { get; set; }
        public decimal? SizVal { get; set; }
        public long MesureBy { get; set; }
    }
}
