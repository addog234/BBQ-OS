using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class dodOrderDetail
    {
        public int OrderDetailID { get; set; }        // 訂單明細編號
        public string OrderID { get; set; }            // 訂單編號
        public string ProductID { get; set; }          // 產品編號
        public string ProductName { get; set; }          // 產品編號
        public int Quantity { get; set; }              // 產品數量
        public int UnitPrice { get; set; }         // 單價
        public static List<dodOrderDetail> GetdodOrderDetailListFromDataTable(DataTable dt)
        {
            List<dodOrderDetail> lsdodOrderDetail = new List<dodOrderDetail>();
            foreach (DataRow row in dt.Rows)
            {
                dodOrderDetail orderDetail = new dodOrderDetail
                {
                   //OrderDetailID = row.Field<int>("OrderDetailID"), // 替換為你的欄位名稱
                    OrderID = row.Field<string>("OrderID"), // 替換為你的欄位名稱
                    ProductName = row.Field<string>("ProductName"), // 替換為你的欄位名稱
                    Quantity = row.Field<int>("Quantity"), // 替換為你的欄位名稱
                    UnitPrice = row.Field<int>("UnitPrice") // 替換為你的欄位名稱
                };

                lsdodOrderDetail.Add(orderDetail);
            }
            return lsdodOrderDetail;
        }
    }
}
