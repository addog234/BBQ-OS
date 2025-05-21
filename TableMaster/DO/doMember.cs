using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableMaster.DO
{
    public class doMember
    {
        public class dodMember
        {
            public string MemberID { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public int? Points { get; set; }  // 使用可空型別
            public DateTime? Birthdate { get; set; }  // 使用可空型別
            public string Status { get; set; }
            public static List<dodMember> GetdodMemberListFromDataTable(DataTable dt)
            {
                List<dodMember> lsdodMember = new List<dodMember>();
                foreach (DataRow row in dt.Rows)
                {
                    dodMember member = new dodMember
                    {
                        MemberID = row.Field<string>("MemberID"), // 替換為你的欄位名稱
                        Name = row.Field<string>("MemName"), // 替換為你的欄位名稱
                        Phone = row.IsNull("MemPhone") ? null : row.Field<string>("MemPhone"), // 處理 null
                        Address = row.IsNull("MemAddress") ? null : row.Field<string>("MemAddress"), // 處理 null
                        Email = row.IsNull("MemEmail") ? null : row.Field<string>("MemEmail"), // 處理 null
                        Points = row.IsNull("Points") ? (int?)null : row.Field<int>("Points"), // 處理 null
                        Birthdate = row.IsNull("MemBirthdate") ? (DateTime?)null : row.Field<DateTime>("MemBirthdate"), // 處理 null
                        Status = row.Field<string>("MStatus") // 替換為你的欄位名稱
                    };

                    lsdodMember.Add(member);
                }
                return lsdodMember;
            }
        }
    }
}
