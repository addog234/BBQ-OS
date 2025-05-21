using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DBO
{
    public class dboQuery
    {
        public static DataTable SqlQuery(string strSql)
        {
            // 定義用於連接資料庫的連接字串，包含資料來源、資料庫名稱和整合安全性
            string connectionString = @"Data Source=.;Initial Catalog=BBQ10;Integrated Security=True";

            // 初始化一個新的 DataTable 物件，用來儲存查詢結果
            DataTable dataTable = new DataTable();

            // 使用 SqlConnection 來建立與資料庫的連接
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 開啟資料庫連接
                connection.Open();

                // 將傳入的 SQL 查詢字串賦值給 query 變數
                string query = strSql; // 替換為你的資料表名稱

                // 使用 SqlDataAdapter 來填充 DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // 將查詢結果填充到 dataTable 物件中
                    adapter.Fill(dataTable);
                }
            } // 這裡會自動釋放 SqlDataAdapter 和 SqlConnection 資源

            // 返回填充了資料的 DataTable 物件
            return dataTable;
        }
    }
}
