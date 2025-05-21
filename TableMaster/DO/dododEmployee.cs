using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class dododEmployee
    {
        public string EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string Position { get; set; }
        public string Permission { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ResignDate { get; set; } // 使用可空型別
        public static List<dododEmployee> GetdododEmployeeListFromDataTable(DataTable dt)
        {
            List<dododEmployee> lsdododEmployee = new List<dododEmployee>();
            foreach (DataRow row in dt.Rows)
            {
                dododEmployee employee = new dododEmployee
                {
                    EmployeeID = row.Field<string>("EmployeeID"), // 替換為你的欄位名稱
                    EmpName = row.Field<string>("EmpName"), // 替換為你的欄位名稱
                    Position = row.Field<string>("Position"), // 替換為你的欄位名稱
                    Permission = row.Field<string>("Permission"), // 替換為你的欄位名稱
                    Password = row.Field<string>("EmpPassword"), // 替換為你的欄位名稱
                    Phone = row.Field<string>("EmpPhone"), // 替換為你的欄位名稱
                    Address = row.Field<string>("EmpAddress"), // 替換為你的欄位名稱
                    Email = row.Field<string>("EmpEmail"), // 替換為你的欄位名稱
                    HireDate = row.Field<DateTime>("HireDate"), // 替換為你的欄位名稱
                    ResignDate = row.IsNull("ResignDate") ? (DateTime?)null : row.Field<DateTime>("ResignDate") // 處理 null
                };

                lsdododEmployee.Add(employee);
            }
            return lsdododEmployee;
        }
    }
}
