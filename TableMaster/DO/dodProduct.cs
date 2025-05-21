using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class dodProduct
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public int? UnitPrice { get; set; }
        public int? Cost { get; set; }
        public string ProductStatus { get; set; }

        public string Pimage { get; set; }
        public string CategoryName { get; set; }  // 這是從 Category 表來的屬性
        public int StockQuantity { get; set; }  // 這是從 Stock 表來的屬性
        public bool IsDeleted { get; set; }

        public static List<dodProduct> GetdodProductListFromDataTable(DataTable dt)
        {
            List<dodProduct> lsdodProduct = new List<dodProduct>();
            foreach (DataRow row in dt.Rows)
            {
                dodProduct product = new dodProduct
                {
                    ProductID = row.Field<string>("ProductID"), // 替換為你的欄位名稱
                    ProductName = row.Field<string>("ProductName"), // 替換為你的欄位名稱
                    CategoryID = row.Field<string>("CategoryID"), // 替換為你的欄位名稱
                    UnitPrice = row.IsNull("UnitPrice") ? (int?)null : row.Field<int>("UnitPrice"), // 處理 null
                    Cost = row.IsNull("Cost") ? (int?)null : row.Field<int>("Cost"), // 處理 null
                    //ProductStatus = row.Field<string>("PStatus"), // 替換為你的欄位名稱
                    Pimage = row.IsNull("PImage")?null:row.Field<string>("PImage"),
                    //StockQuantity = row.IsNull("StockQuantity") ? 0 : row.Field<int>("StockQuantity"),
                    //CategoryName = row.Field<string>("CategoryName"),
                    IsDeleted  = row.Field<bool>("IsDeleted")
                };

                lsdodProduct.Add(product);
            }
            return lsdodProduct;
        }
    }
}
