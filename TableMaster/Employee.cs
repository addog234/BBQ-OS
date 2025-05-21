using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TableMaster.DBO;

namespace TableMaster
{
    public partial class Employee : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "BBQ10";
            scsb.IntegratedSecurity = true;
            GlobaLVar.strDBConnectionString = scsb.ConnectionString.ToString();
            dgvEmployee.ReadOnly = true;
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            讀取員工資料庫();
            cbSearch.Items.Add("員工編號");
            cbSearch.Items.Add("姓名");
            cbSearch.Items.Add("電話");
            cbSearch.Items.Add("地址");
            cbSearch.Items.Add("職位");
            cbSearch.Items.Add("權限");
            cbSearch.Items.Add("email");
            cbSearch.Items.Add("到職日期");
            cbSearch.Items.Add("離職日期");
            cbSearch.SelectedIndex = 0;
        }
        void 讀取員工資料庫()
        {
            using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                con.Open();
                string strSQL = @"SELECT 
                            EmployeeID as '員工編號', 
                            EmpName as '姓名', 
                            Position as '職位', 
                            Permission as '權限',
                            EmpPassword as '密碼',
                            EmpPhone as '電話',
                            EmpAddress as '地址',
                            EmpEmail as '電子郵件',
                            HireDate as '到職日期',
                            ResignDate as '離職日期'
                        FROM dEmployees 
                        WHERE IsDeleted = 0";

                using (SqlCommand sqlcommand = new SqlCommand(strSQL, con))
                {
                    using (SqlDataReader reader = sqlcommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dgvEmployee.DataSource = dataTable;

                        // 調整欄位寬度
                        foreach (DataGridViewColumn col in dgvEmployee.Columns)
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                    }
                }
            }
        }

        private void btnINsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmName.Text))
            {
                MessageBox.Show("員工姓名為必填欄位，請輸入!");
                return; // 停止執行
            }

            if (string.IsNullOrWhiteSpace(txtEmPosition.Text))
            {
                MessageBox.Show("職位為必填欄位，請輸入!");
                return;
            }

            using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                con.Open();
                txtEmpID.ReadOnly = true;
                string Empid = GenerateEmployeeID();
                string strSQL = "INSERT INTO dEmployees (EmployeeID,EmpName, Position, Permission,EmpPassword,EmpPhone,EmpAddress,EmpEmail,HireDate,ResignDate) VALUES (@EmployeeID,@EmpName, @Position,@Permission,@EmpPassword,@EmpPhone,@EmpAddress,@EmpEmail,@HireDate,@ResignDate);";
                using (SqlCommand sqlcommand = new SqlCommand(strSQL, con))

                {
                    sqlcommand.Parameters.AddWithValue("@EmployeeID", Empid);
                    sqlcommand.Parameters.AddWithValue("@EmpName", txtEmName.Text);
                    sqlcommand.Parameters.AddWithValue("@Position", txtEmPosition.Text);
                    sqlcommand.Parameters.AddWithValue("@Permission", txtEmpPer.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpPassword", txtEmpPassword.Text);
                    sqlcommand.Parameters.AddWithValue("@Empphone", txtempPhone.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpAddress", txtEmpAddress.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpEmail", txtEmpEmail.Text);
                    sqlcommand.Parameters.AddWithValue("@HireDate", dtpHiredate.Value);
                    sqlcommand.Parameters.AddWithValue("@ResignDate", DBNull.Value);





                    sqlcommand.ExecuteNonQuery();

                }
            }
            MessageBox.Show("員工資料新增成功!");
            讀取員工資料庫(); // 刷新數據
            ClearALL();
            ClearSearchFields(); // 新增成功後清除搜尋欄位
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ClearALL();
            ClearSearchFields(); // 停止時清除搜尋欄位
            讀取員工資料庫();
        }
        private string GenerateEmployeeID()
        {
            using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                con.Open();
                string query = "SELECT MAX(CAST(SUBSTRING(EmployeeID, 4, LEN(EmployeeID) - 3) AS INT)) " +
                       "FROM dEmployees WHERE LEN(EmployeeID) > 3 ;"; // 加條件以確保查詢沒被刪除的員工

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int newID = 1; // 默認 ID

                    if (result != DBNull.Value)
                    {
                        newID = Convert.ToInt32(result) + 1; // 增加1
                    }

                    return "EMP" + newID.ToString("D2"); // 生成新的 ID，確保格式 EMP01 EMP02 
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                con.Open();

                // 假設有一個 txtEmployeeID 輸入框用來輸入需要修改的員工 ID
                string strSQL = "UPDATE dEmployees SET EmpName = @EmpName, Position = @Position, Permission = @Permission, EmpPassword = @EmpPassword, EmpPhone = @EmpPhone, EmpAddress = @EmpAddress, EmpEmail = @EmpEmail, HireDate = @HireDate, ResignDate = @ResignDate WHERE EmployeeID = @EmployeeID;";

                using (SqlCommand sqlcommand = new SqlCommand(strSQL, con))
                {
                    sqlcommand.Parameters.AddWithValue("@EmpName", txtEmName.Text);
                    sqlcommand.Parameters.AddWithValue("@Position", txtEmPosition.Text);
                    sqlcommand.Parameters.AddWithValue("@Permission", txtEmpPer.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpPassword", txtEmpPassword.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpPhone", txtempPhone.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpAddress", txtEmpAddress.Text);
                    sqlcommand.Parameters.AddWithValue("@EmpEmail", txtEmpEmail.Text);
                    sqlcommand.Parameters.AddWithValue("@HireDate", dtpHiredate.Value);
                    sqlcommand.Parameters.AddWithValue("@ResignDate", dtpResigndate.Value); // 假設有一個日期選擇器用於辭職日期
                    sqlcommand.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text); // 假設用戶在此輸入需要修改的員工 ID

                    int rowsAffected = sqlcommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("員工資料更新成功!");
                        ClearSearchFields(); // 更新成功後清除搜尋欄位
                    }
                    else
                    {
                        MessageBox.Show("未找到對應的員工ID，更新失敗!");
                    }
                }
            }
            讀取員工資料庫(); // 刷新數據
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 確保選擇的是有效的行
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

                // 使用中文別名存取欄位
                txtEmpID.Text = row.Cells["員工編號"].Value?.ToString();
                txtEmName.Text = row.Cells["姓名"].Value?.ToString();
                txtEmPosition.Text = row.Cells["職位"].Value?.ToString();
                txtEmpPer.Text = row.Cells["權限"].Value?.ToString();
                txtEmpPassword.Text = row.Cells["密碼"].Value?.ToString();
                txtempPhone.Text = row.Cells["電話"].Value?.ToString();
                txtEmpAddress.Text = row.Cells["地址"].Value?.ToString();
                txtEmpEmail.Text = row.Cells["電子郵件"].Value?.ToString();

                // 日期相關的欄位也使用中文別名
                dtpHiredate.Value = row.Cells["到職日期"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["到職日期"].Value) : DateTime.Now;
                dtpResigndate.Value = row.Cells["離職日期"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["離職日期"].Value) : DateTime.Now;
            }
        }
        private void ClearALL()
        {
            txtEmpID.Text = string.Empty;
            txtEmName.Text = string.Empty;
            txtEmPosition.Text = string.Empty;
            txtEmpPer.Text = string.Empty;
            txtEmpPassword.Text = string.Empty;
            txtempPhone.Text = string.Empty;
            txtEmpAddress.Text = string.Empty;
            txtEmpEmail.Text = string.Empty;
            dtpHiredate.Value = DateTime.Now; // 或者設定為其他的預設值
            dtpResigndate.Value = DateTime.Now; // 或者設定為其他的預設值
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtEmpID.Text))
                {
                    MessageBox.Show("請選擇要刪除的員工。");
                    return;
                }

                var result = MessageBox.Show("確定要刪除該員工嗎？", "確認刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
                    {
                        con.Open();
                        string strSQL = "UPDATE dEmployees SET IsDeleted = 1 WHERE EmployeeID = @EmployeeID;";
                        using (SqlCommand sqlcommand = new SqlCommand(strSQL, con))
                        {
                            sqlcommand.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text);
                            int rowsAffected = sqlcommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("員工資料已刪除!");
                                讀取員工資料庫(); // 刷新資料
                            }
                            else
                            {
                                MessageBox.Show("未找到對應的員工ID，刪除失敗!");
                            }
                            ClearALL();
                            ClearSearchFields(); // 刪除成功後清除搜尋欄位
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            string str欄位名稱 = cbSearch.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(txtSerch.Text))
            {
                MessageBox.Show("請輸入搜尋關鍵字!");
                return;
            }

            string dbColumnName;
            switch (str欄位名稱)
            {
                case "員工編號":
                    dbColumnName = "EmployeeID";
                    break;
                case "姓名":
                    dbColumnName = "EmpName";
                    break;
                case "電話":
                    dbColumnName = "EmpPhone";
                    break;
                case "地址":
                    dbColumnName = "EmpAddress";
                    break;
                case "職位":
                    dbColumnName = "Position";
                    break;
                case "權限":
                    dbColumnName = "Permission";
                    break;
                case "email":
                    dbColumnName = "EmpEmail";
                    break;
                case "到職日期":
                    dbColumnName = "HireDate";
                    break;
                case "離職日期":
                    dbColumnName = "ResignDate";
                    break;
                default:
                    MessageBox.Show("無效的搜尋欄位");
                    return;
            }

            using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                con.Open();

                string strSQL;
                if (str欄位名稱 == "到職日期" || str欄位名稱 == "離職日期")
                {
                    strSQL = $"SELECT * FROM dEmployees WHERE {dbColumnName} = @SearchDate AND IsDeleted = 0;";
                }
                else if (str欄位名稱 == "員工編號")
                {
                    strSQL = $"SELECT * FROM dEmployees WHERE {dbColumnName} = @SearchID AND IsDeleted = 0;";
                }
                else
                {
                    strSQL = $"SELECT * FROM dEmployees WHERE {dbColumnName} LIKE @SearchKeyword AND IsDeleted = 0;";
                }

                using (SqlCommand cmd = new SqlCommand(strSQL, con))
                {
                    if (str欄位名稱 == "到職日期" || str欄位名稱 == "離職日期")
                    {
                        if (DateTime.TryParse(txtSerch.Text.Trim(), out DateTime searchDate))
                        {

                            cmd.Parameters.AddWithValue("@SearchDate", searchDate);
                        }
                        else
                        {
                            MessageBox.Show("請輸入有效的日期!");
                            return;
                        }
                    }
                    else if (str欄位名稱 == "員工編號")
                    {
                        cmd.Parameters.AddWithValue("@SearchID", txtSerch.Text.Trim());
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txtSerch.Text.Trim()}%");
                    }

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvEmployee.DataSource = dt;
                        ClearSearchFields(); // 搜尋成功後清除搜尋欄位
                    }
                    else
                    {
                        dgvEmployee.DataSource = null;
                        MessageBox.Show("查無此人");
                        ClearSearchFields(); // 查無資料時也清除搜尋欄位
                    }
                }
            }
        }

        // 新增清除搜尋欄位的方法
        private void ClearSearchFields()
        {
            txtSerch.Clear();
            cbSearch.SelectedIndex = 0;
        }
    }
}

