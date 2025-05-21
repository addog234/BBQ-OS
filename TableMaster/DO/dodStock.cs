using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class dodStock
    {
        public string ProductID { get; set; }  // 商品編號
        public int StockQuantity { get; set; }  // 庫存數量
        public string Status { get; set; }      // 狀態
        public static List<dodStock> GetdodStockListFromDataTable(DataTable dt)
        {
            List<dodStock> lsdodStock = new List<dodStock>();
            foreach (DataRow row in dt.Rows)
            {
                dodStock stock = new dodStock
                {
                    ProductID = row.Field<string>("ProductID"), // 替換為你的欄位名稱
                    StockQuantity = row.Field<int>("StockQuantity"), // 替換為你的欄位名稱
                    Status = row.Field<string>("Status") // 替換為你的欄位名稱
                };

                lsdodStock.Add(stock);
            }
            return lsdodStock;
        }
    }
}
