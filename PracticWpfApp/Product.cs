//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticWpfApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductArticleNumberID { get; set; }
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public int UnitsID { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductSupplierID { get; set; }
        public int ProductManufacturerID { get; set; }
        public decimal ProductCost { get; set; }
        public Nullable<byte> ProductDiscountAmount { get; set; }
        public Nullable<byte> ProductDiscountAmountMax { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPhoto { get; set; }
    }
}
