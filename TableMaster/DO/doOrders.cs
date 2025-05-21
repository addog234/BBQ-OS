using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class doOrders
    {
        public string OrderID { get; set; }                     // 訂單編號
        public string MemberID { get; set; }                    // 會員編號
        public DateTime OrderDate { get; set; }                 // 訂單日期
        public string Status { get; set; }                       // 訂單狀態
        public string EmployeeID { get; set; }                   // 建單人 (可空)
        public int TotalPriceBeforeDiscount { get; set; }   // 折扣前的總價
        public int TotalPriceAfterDiscount { get; set; } //折扣後的總價

        public string TableNumber { get; set; } // TableNumber
        public static List<doOrders> GetdodOrderListFromDataTable(DataTable dt)
        {
            List<doOrders> lsdodOrder = new List<doOrders>();
            foreach (DataRow row in dt.Rows)
            {
                doOrders order = new doOrders
                {
                    OrderID = row.Field<string>("OrderID"), // 替換為你的欄位名稱
                    MemberID = row.Field<string>("MemberID"), // 替換為你的欄位名稱
                    OrderDate = row.Field<DateTime>("OrderDate"), // 替換為你的欄位名稱
                    Status = row.Field<string>("OStatus"), // 替換為你的欄位名稱
                    EmployeeID = row.IsNull("EmployeeID") ? null : row.Field<string>("EmployeeID"), // 處理 null
                    TableNumber = row.Field<string>("TableNumber"),
                    TotalPriceBeforeDiscount = row.Field<int>("TotalPriceBeforeDiscount"), // 替換為你的欄位名稱
                    TotalPriceAfterDiscount = row.Field<int>("TotalPriceAfterDiscount") // 替換為你的欄位名稱
                };

                lsdodOrder.Add(order);
            }
            return lsdodOrder;
        }
    }
}
