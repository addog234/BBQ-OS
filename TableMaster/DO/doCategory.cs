using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class doCategory
    {
       
       
            public string CategoryID { get; set; } // 類別編號
            public string CategoryName { get; set; } // 類別名稱

        public static List<doCategory> GetCategoryListFromDataTable(DataTable dt)
        {
            List<doCategory> categoryList = new List<doCategory>();
            foreach (DataRow row in dt.Rows)
            {
                doCategory category = new doCategory
                {
                    CategoryID = row.Field<string>("CategoryID"), // 替換為你的欄位名稱
                    CategoryName = row.Field<string>("CategoryName") // 替換為你的欄位名稱
                };

                categoryList.Add(category);
            }
            return categoryList;
        }

    }
}
