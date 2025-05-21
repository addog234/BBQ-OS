using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableMaster.DBO;
using TableMaster.DO;
using System.Data.SqlClient;

namespace TableMaster
{
    public partial class OrderDetails : Form
    {
        private DataTable productData; // 新增類別層級的變數來儲存商品資料
        private string connectionString = @"Data Source=.;Initial Catalog=BBQ10;Integrated Security=True";

        public OrderDetails()
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
                cbDetailProduct.SelectedIndexChanged += cbDetailProduct_SelectedIndexChanged;
                uiDat();
                
                cbSearchDetail.Items.Add("訂單編號");
                cbSearchDetail.Items.Add("會員手機");
                cbSearchDetail.Items.Add("員工編號");
                cbSearchDetail.Items.Add("訂單狀態");
                cbSearchDetail.Items.Add("高於金額");
                cbSearchDetail.Items.Add("低於金額");
                cbSearchDetail.Items.Add("訂單日期");
                cbSearchDetail.SelectedIndex = -1;

                // 初始化日期選擇器
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Today;
                
                // 預設隱藏日期選擇器
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
                
                // 綁定下拉選單變更事件
                cbSearchDetail.SelectedIndexChanged += CbSearchDetail_SelectedIndexChanged;

                // 設定日期選擇器的格式和預設值
                dtpStartDate.Format = DateTimePickerFormat.Custom;
                dtpStartDate.CustomFormat = "yyyy-MM-dd";
                dtpEndDate.Format = DateTimePickerFormat.Custom;
                dtpEndDate.CustomFormat = "yyyy-MM-dd";

                // 設定預設日期範圍（例如：最近一個月）
                dtpEndDate.Value = DateTime.Today;
                dtpStartDate.Value = DateTime.Today.AddMonths(-1);

                // 確保控件可見性
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"表單載入時發生錯誤：{ex.Message}");
            }
        }

        private void LoadProducts()
        {
            try
            {
                // 查詢所有可用的商品
                string sql = @"
                    SELECT p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName, s.StockQuantity
                    FROM dProduct p
                    JOIN dCategory c ON p.CategoryID = c.CategoryID
                    LEFT JOIN dStock s ON p.ProductID = s.ProductID
                    WHERE p.IsDeleted = 0 
                    AND p.PStatus = '正常'
                    AND (s.StockQuantity > 0 OR s.StockQuantity IS NULL)
                    ORDER BY c.CategoryName, p.ProductName";

                productData = dboQuery.SqlQuery(sql); // 儲存查詢結果

                // 清空並重新綁定下拉選單
                cbDetailProduct.Items.Clear();
                
                // 加入一個空選項
                cbDetailProduct.Items.Add("");
                
                // 將商品名稱加入下拉選單
                foreach (DataRow row in productData.Rows)
                {
                    string productName = row["ProductName"].ToString();
                    cbDetailProduct.Items.Add(productName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入商品清單時發生錯誤：{ex.Message}");
            }
        }

        // 當選擇商品時自動填入單價
        private void cbDetailProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDetailProduct.SelectedIndex <= 0) // 空選項
                {
                    return;
                }

                if (productData != null)
                {
                    string selectedProduct = cbDetailProduct.SelectedItem.ToString();
                    DataRow[] rows = productData.Select($"ProductName = '{selectedProduct}'");
                    
                    if (rows.Length > 0)
                    {
                        // 可以在這裡處理單價或其他相關資訊
                        int unitPrice = Convert.ToInt32(rows[0]["UnitPrice"]);
                        // 如果需要顯示單價，可以加入相關控制項
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"選擇商品時發生錯誤：{ex.Message}");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // 清空所有輸入欄位
            txtOrdertID.Clear();
            txtOrderEmp.Clear();
            txtOderMem.Clear();
            txtTableNum.Clear();
            OderSatus.Clear();
            txtQuantity.Clear();
            cbDetailProduct.SelectedIndex = -1;
            
            // 清空搜尋條件
            txtSearch.Clear();
            cbSearchDetail.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            // 清空訂單明細
            uiDataGridView2.Rows.Clear();

            // 重新載入訂單列表
            uiDat();
        }

        private void btnOrDetailSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // 檢查是否有選擇搜尋條件
                if (cbSearchDetail.SelectedIndex == -1)
                {
                    MessageBox.Show("請選擇搜尋條件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 檢查搜尋值（日期搜尋除外）
                if (cbSearchDetail.SelectedItem.ToString() != "訂單日期" && 
                    string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("請輸入搜尋內容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 清空訂單列表和明細
                uiDataGridView1.Rows.Clear();
                uiDataGridView2.Rows.Clear();

                // 清空訂單相關欄位
                txtOrdertID.Clear();
                txtOrderEmp.Clear();
                txtOderMem.Clear();
                txtTableNum.Clear();
                OderSatus.Clear();
                txtQuantity.Clear();
                cbDetailProduct.SelectedIndex = -1;

                List<string> conditions = new List<string>();

                // 處理搜尋條件
                string searchValue = txtSearch.Text.Trim();
                switch (cbSearchDetail.SelectedItem.ToString())
                {
                    case "訂單編號":
                        conditions.Add($"AND o.OrderID LIKE '%{searchValue}%'");
                        break;
                    case "會員手機":
                        conditions.Add($"AND m.MemPhone LIKE '%{searchValue}%'");
                        break;
                    case "員工編號":
                        conditions.Add($"AND o.EmployeeID LIKE '%{searchValue}%'");
                        break;
                    case "訂單狀態":
                        conditions.Add($"AND o.OStatus LIKE '%{searchValue}%'");
                        break;
                    case "高於金額":
                        if (decimal.TryParse(searchValue, out decimal minPrice))
                            conditions.Add($"AND o.TotalPriceAfterDiscount >= {minPrice}");
                        break;
                    case "低於金額":
                        if (decimal.TryParse(searchValue, out decimal maxPrice))
                            conditions.Add($"AND o.TotalPriceAfterDiscount <= {maxPrice}");
                        break;
                    case "訂單日期":
                        conditions.Add($"AND CONVERT(date, o.OrderDate) BETWEEN '{dtpStartDate.Value:yyyy-MM-dd}' AND '{dtpEndDate.Value:yyyy-MM-dd}'");
                        break;
                }

                // 如果沒有任何搜尋條件，直接返回
                if (conditions.Count == 0)
                {
                    MessageBox.Show("請輸入有效的搜尋條件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string sql = $@"
                    SELECT 
                        o.OrderID, 
                        o.EmployeeID, 
                        o.MemberID, 
                        o.TotalPriceBeforeDiscount, 
                        o.TotalPriceAfterDiscount, 
                        o.TableNumber, 
                        CONVERT(varchar, o.OrderDate, 111) as OrderDate, 
                        o.OStatus
                    FROM dOrders o
                    LEFT JOIN dMember m ON o.MemberID = m.MemberID
                    WHERE 1=1 {string.Join(" ", conditions)}
                    ORDER BY OrderDate DESC, o.OrderID";

                DataTable dt = dboQuery.SqlQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    uiDataGridView1.Rows.Add(
                        row["OrderID"],
                        row["EmployeeID"],
                        row["MemberID"],
                        row["TotalPriceBeforeDiscount"],
                        row["TotalPriceAfterDiscount"],
                        row["TableNumber"],
                        row["OrderDate"],
                        row["OStatus"]
                    );
                }

                if (uiDataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("沒有找到符合條件的訂單。", "搜尋結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 在搜尋完成後清空搜尋框
                txtSearch.Clear();
                cbSearchDetail.SelectedIndex = -1;
                
                // 如果使用日期選擇器，也可以重置日期
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜尋時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrdertID.Text))
                {
                    MessageBox.Show("請先選擇要刪除的訂單");
                    return;
                }

                if (MessageBox.Show("確定要刪除此訂單嗎？", "確認刪除", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                string orderID = txtOrdertID.Text;

                // 先刪除明細
                string deleteDetailsSql = $"DELETE FROM dOrderDetails WHERE OrderID = '{orderID}'";
                dboQuery.SqlQuery(deleteDetailsSql);

                // 再刪除主訂單
                string deleteOrderSql = $"DELETE FROM dOrders WHERE OrderID = '{orderID}'";
                dboQuery.SqlQuery(deleteOrderSql);

                MessageBox.Show("訂單刪除成功！");

                // 清空所有欄位
                txtOrdertID.Clear();
                txtOrderEmp.Clear();
                txtOderMem.Clear();
                
                txtTableNum.Clear();
                OderSatus.Clear();

                // 清空明細表格
                uiDataGridView2.Rows.Clear();

                // 重新載入訂單列表
                uiDat();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除訂單時發生錯誤：{ex.Message}");
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrdertID.Text))
                {
                    MessageBox.Show("請先選擇單");
                    return;
                }

                // 確保有選擇明細行
                if (uiDataGridView2.CurrentRow == null)
                {
                    MessageBox.Show("請選擇要刪除的明細");
                    return;
                }

                if (MessageBox.Show("確定要刪除選中的明細嗎？", "確認刪除", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                string orderID = txtOrdertID.Text;
                string productName = uiDataGridView2.CurrentRow.Cells[1].Value.ToString();
                int quantity = Convert.ToInt32(uiDataGridView2.CurrentRow.Cells[2].Value);

                // 先取得要刪除的明細ID
                string getDetailIDSql = $@"
                    SELECT TOP 1 od.OrderDetailID
                    FROM dOrderDetails od
                    JOIN dProduct p ON od.ProductID = p.ProductID
                    WHERE od.OrderID = '{orderID}'
                    AND p.ProductName = '{productName}'
                    AND od.Quantity = {quantity}";

                DataTable dtDetailID = dboQuery.SqlQuery(getDetailIDSql);
                
                if (dtDetailID.Rows.Count > 0)
                {
                    int orderDetailID = Convert.ToInt32(dtDetailID.Rows[0]["OrderDetailID"]);

                    // 刪除特定明細
                    string deleteDetailSql = $"DELETE FROM dOrderDetails WHERE OrderDetailID = {orderDetailID}";
                    dboQuery.SqlQuery(deleteDetailSql);

                    // 更新訂單總金額
                    string updateTotalSql = $@"
                        UPDATE dOrders 
                        SET TotalPriceBeforeDiscount = (
                            SELECT ISNULL(SUM(od.Quantity * od.UnitPrice), 0)
                            FROM dOrderDetails od
                            WHERE od.OrderID = '{orderID}'
                        ),
                        TotalPriceAfterDiscount = (
                            SELECT ISNULL(SUM(od.Quantity * od.UnitPrice), 0)
                            FROM dOrderDetails od
                            WHERE od.OrderID = '{orderID}'
                        )
                        WHERE OrderID = '{orderID}'";

                    dboQuery.SqlQuery(updateTotalSql);

                    MessageBox.Show("明細刪除成功！");

                    // 重新載入明細資料
                    LoadOrderDetails(orderID);
                    LoadOrderInfo(orderID);
                }
                else
                {
                    MessageBox.Show("找不到要刪除的明細記錄");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除明細時發生錯誤：{ex.Message}");
            }
        }

        private void UpdateOrderTotal(string orderID)
        {
            try
            {
                // 計算訂單總金額
                string totalSql = $@"
                    SELECT ISNULL(SUM(d.Quantity * d.UnitPrice), 0) as Total 
                    FROM dOrderDetails d 
                    WHERE d.OrderID = '{orderID}'";
                
                DataTable dtTotal = dboQuery.SqlQuery(totalSql);
                decimal totalAmount = Convert.ToDecimal(dtTotal.Rows[0]["Total"]);

                // 更新訂單金額
                string updateSql = $@"
                    UPDATE dOrders 
                    SET TotalPriceBeforeDiscount = {totalAmount},
                        TotalPriceAfterDiscount = {totalAmount}
                    WHERE OrderID = '{orderID}'";
                
                dboQuery.SqlQuery(updateSql);
            }
            catch (Exception ex)
            {
                throw new Exception($"更新訂單金額時發生錯誤：{ex.Message}");
            }
        }

        private void LoadOrderInfo(string orderID)
        {
            try
            {
                string sql = $@"
                    SELECT 
                        OrderID,
                        EmployeeID,
                        MemberID,
                        TotalPriceBeforeDiscount,
                        TotalPriceAfterDiscount,
                        TableNumber,
                        OStatus
                    FROM dOrders 
                    WHERE OrderID = '{orderID}'";

                DataTable dt = dboQuery.SqlQuery(sql);
                
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtOrdertID.Text = row["OrderID"].ToString();
                    txtOrderEmp.Text = row["EmployeeID"].ToString();
                    txtOderMem.Text = row["MemberID"].ToString();
                    txtTableNum.Text = row["TableNumber"].ToString();
                    OderSatus.Text = row["OStatus"].ToString();

                    // 更新DataGridView1中的對應行
                    foreach (DataGridViewRow dgvRow in uiDataGridView1.Rows)
                    {
                        if (dgvRow.Cells["OrderID"].Value?.ToString() == orderID)
                        {
                            dgvRow.Cells["Column1"].Value = row["TotalPriceBeforeDiscount"];
                            dgvRow.Cells["dgvPrice"].Value = row["TotalPriceAfterDiscount"];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入訂單資訊時發生錯誤：{ex.Message}");
            }
        }

        private void uiDat()
        {
            uiDataGridView1.Rows.Clear();

            List<string> ls = new List<string>();

            string aa = $@"
                SELECT * FROM dOrders where 1=1 {string.Join(" ", ls.ToArray())}";
            DataTable dt = dboQuery.SqlQuery(aa);

            List<doOrders> lsdoOrders = doOrders.GetdodOrderListFromDataTable(dt);
            foreach (var item in lsdoOrders)
            {
                uiDataGridView1.Rows.Add(item.OrderID, item.EmployeeID, item.MemberID, item.TotalPriceBeforeDiscount, item.TotalPriceAfterDiscount, item.TableNumber, item.OrderDate.ToString("yyyy-MM-dd"), item.Status);
            }
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= uiDataGridView1.Rows.Count)
                return;

            try
            {
                uiDataGridView2.Rows.Clear();
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];

                // 確保OrderID不為空
                if (row.Cells["OrderID"].Value == null)
                    return;

                // 將選中行的資料填入文本框
                txtOrdertID.Text = row.Cells["OrderID"].Value.ToString();
                txtOrderEmp.Text = row.Cells["dgvOrderEmp"].Value?.ToString();
                txtOderMem.Text = row.Cells["dgvMemberID"].Value?.ToString();
                txtTableNum.Text = row.Cells["tablenum"].Value?.ToString();
                OderSatus.Text = row.Cells["OrderStatus"].Value?.ToString();

                // 清空商品明細相關欄位
                cbDetailProduct.SelectedIndex = -1;
                txtQuantity.Clear();

                // 設置所控制項為唯讀
                SetControlsReadOnly(true);
                
                // 重置編輯按鈕狀態
                btnEdit_Click.Text = "編輯";
                btnEdit_Click.FillColor = Color.FromArgb(110, 190, 240); // 藍色
                btnEdit_Click.RectColor = Color.FromArgb(110, 190, 240);

                string orderID = row.Cells["OrderID"].Value.ToString();

                DataTable dt = dboQuery.SqlQuery($@"
                    SELECT d.OrderID, d.ProductID, p.ProductName, d.Quantity, p.UnitPrice
                    FROM dOrderDetails d
                    JOIN dProduct p ON d.ProductID = p.ProductID
                    WHERE d.OrderID = '{orderID}'
                ");

                List<dodOrderDetail> lsdodOrderDetail = dodOrderDetail.GetdodOrderDetailListFromDataTable(dt);
                foreach (var item in lsdodOrderDetail)
                {
                    uiDataGridView2.Rows.Add(item.OrderID, item.ProductName, item.Quantity, item.UnitPrice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入訂單明細時發生錯誤：{ex.Message}");
            }
        }

        private void BtnOrderback_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel)
            {
                // 清空panel中的控件
                panel.Controls.Clear();

                // 回去ORDER FORM
                OrderForm orderForm = new OrderForm();
                orderForm.TopLevel = false;
                orderForm.Size = panel.ClientSize;
                orderForm.Dock = DockStyle.Fill;
                orderForm.FormBorderStyle = FormBorderStyle.None;
                panel.Controls.Add(orderForm);
                orderForm.Show();
            }
        }

        private void LoadOrderDetails(string orderID)
        {
            try
            {
                uiDataGridView2.Rows.Clear();
                
                string sql = $@"
                    SELECT 
                        d.OrderDetailID,
                        d.OrderID,
                        p.ProductName,
                        d.Quantity,
                        d.UnitPrice
                    FROM dOrderDetails d
                    JOIN dProduct p ON d.ProductID = p.ProductID
                    WHERE d.OrderID = '{orderID}'
                    ORDER BY d.OrderDetailID";

                DataTable dt = dboQuery.SqlQuery(sql);
                
                foreach (DataRow row in dt.Rows)
                {
                    uiDataGridView2.Rows.Add(
                        row["OrderID"],
                        row["ProductName"],
                        row["Quantity"],
                        row["UnitPrice"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入訂單明細時發生錯誤：{ex.Message}");
            }
        }

        private void uiDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < uiDataGridView2.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = uiDataGridView2.Rows[e.RowIndex];
                    
                    // 設置商品名稱到 ComboBox
                    string productName = row.Cells["dataGridViewTextBoxColumn1"].Value?.ToString();
                    if (!string.IsNullOrEmpty(productName))
                    {
                        cbDetailProduct.Text = productName;
                        // 允許 ComboBox 編輯
                        cbDetailProduct.Enabled = true;
                    }

                    // 設置數量到 TextBox
                    string quantity = row.Cells["dataGridViewTextBoxColumn2"].Value?.ToString();
                    if (!string.IsNullOrEmpty(quantity))
                    {
                        txtQuantity.Text = quantity;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"載入明細資料時發生錯誤：{ex.Message}");
                }
            }
        }

       

        private void UpdateOrderMaster(string orderID)
        {
            try
            {
                string memberID = txtOderMem.Text.Trim();
                string employeeID = txtOrderEmp.Text.Trim();
                
                string updateMasterSql = @"
                    UPDATE dOrders 
                    SET EmployeeID = CASE 
                            WHEN @EmployeeID = '' THEN NULL 
                            ELSE @EmployeeID 
                        END,
                        MemberID = CASE 
                            WHEN @MemberID = '' THEN NULL 
                            ELSE @MemberID 
                        END,
                        TableNumber = @TableNumber,
                        OStatus = @OStatus
                    WHERE OrderID = @OrderID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updateMasterSql, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderID);
                        command.Parameters.AddWithValue("@EmployeeID", string.IsNullOrWhiteSpace(employeeID) ? DBNull.Value : (object)employeeID);
                        command.Parameters.AddWithValue("@MemberID", string.IsNullOrWhiteSpace(memberID) ? DBNull.Value : (object)memberID);
                        command.Parameters.AddWithValue("@TableNumber", txtTableNum.Text.Trim());
                        command.Parameters.AddWithValue("@OStatus", OderSatus.Text.Trim());

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"更新訂單資料時發生錯誤：{ex.Message}");
            }
        }

        private void UpdateOrderDetail(string orderID)
        {
            try
            {
                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    throw new Exception("輸入有效的數量");
                }

                // 獲取當前選中的明細行
                if (uiDataGridView2.CurrentRow == null)
                {
                    throw new Exception("請先選擇要修改的明細行");
                }

                string oldProductName = uiDataGridView2.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                string newProductName = cbDetailProduct.Text;

                // 先獲取要修改的明細記錄 OrderDetailID
                string getDetailIDSql = $@"
                    SELECT TOP 1 od.OrderDetailID
                    FROM dOrderDetails od
                    JOIN dProduct p ON od.ProductID = p.ProductID
                    WHERE od.OrderID = '{orderID}'
                    AND p.ProductName = '{oldProductName}'";

                DataTable dtDetailID = dboQuery.SqlQuery(getDetailIDSql);
                if (dtDetailID.Rows.Count == 0)
                {
                    throw new Exception("找不到要修改的明細記錄");
                }

                int orderDetailID = Convert.ToInt32(dtDetailID.Rows[0]["OrderDetailID"]);

                // 獲取新商品的資訊
                string getProductInfoSql = $@"
                    SELECT ProductID, UnitPrice 
                    FROM dProduct 
                    WHERE ProductName = '{newProductName}'";

                DataTable dtProduct = dboQuery.SqlQuery(getProductInfoSql);
                if (dtProduct.Rows.Count == 0)
                {
                    throw new Exception("找不到商品資訊");
                }

                string productID = dtProduct.Rows[0]["ProductID"].ToString();
                int unitPrice = Convert.ToInt32(dtProduct.Rows[0]["UnitPrice"]);

                // 使用 OrderDetailID 更新特定明細行
                string updateDetailSql = $@"
                    UPDATE dOrderDetails
                    SET ProductID = '{productID}',
                        Quantity = {quantity},
                        UnitPrice = {unitPrice}
                    WHERE OrderDetailID = {orderDetailID}";

                dboQuery.SqlQuery(updateDetailSql);

                // 更新訂單總金額
                UpdateOrderTotal(orderID);

                // 重新載入明細資料
                LoadOrderDetails(orderID);
            }
            catch (Exception ex)
            {
                throw new Exception($"更新訂單明細時發生錯誤：{ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOrdertID.Text))
                {
                    MessageBox.Show("請先選擇要修改的訂單");
                    return;
                }

                // 檢查員工編號（如果有填寫的話）
                string employeeID = txtOrderEmp.Text.Trim();
                if (!string.IsNullOrWhiteSpace(employeeID) && !CheckEmployeeExists(employeeID))
                {
                    MessageBox.Show("輸入的員工編號不存在或已被刪除，請確認後重試");
                    return;
                }

                // 檢查會員編號（如果有填寫的話）
                string memberID = txtOderMem.Text.Trim();
                if (!string.IsNullOrWhiteSpace(memberID) && !CheckMemberExists(memberID))
                {
                    MessageBox.Show("輸入的會員編號不存在，請確認後重試");
                    return;
                }

                string orderID = txtOrdertID.Text;

                // 更新訂單主檔
                UpdateOrderMaster(orderID);

                // 如果有選擇商品和數量，則更新明細
                if (cbDetailProduct.SelectedIndex > 0 && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    UpdateOrderDetail(orderID);
                }

                MessageBox.Show("更新成功！");

                // 清空所有明細相關欄位和控件
                uiDataGridView2.Rows.Clear();
                cbDetailProduct.SelectedIndex = -1;
                txtQuantity.Clear();
                txtOrdertID.Clear();
                txtOrderEmp.Clear();
                txtOderMem.Clear();
                txtTableNum.Clear();
                OderSatus.Clear();

                // 重新載入訂單列表
                uiDat();

                // 將編輯按鈕恢復到初始狀態
                btnEdit_Click.Text = "編輯";
                btnEdit_Click.FillColor = Color.FromArgb(110, 190, 240);
                btnEdit_Click.RectColor = Color.FromArgb(110, 190, 240);
                SetControlsReadOnly(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新訂單時發生錯誤：{ex.Message}");
            }
        }

        private void btnEdit_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdertID.Text))
            {
                MessageBox.Show("請先選擇要修改的訂單");
                return;
            }

            // 切換控制項的唯讀狀態
            bool currentState = txtOrderEmp.ReadOnly;
            SetControlsReadOnly(!currentState);

            // 更改按鈕文字
            btnEdit_Click.Text = currentState ? "取消編輯" : "編輯";

            // 根據編輯狀態設置按鈕顏色
            if (currentState)
            {
                // 進入編輯模��
                btnEdit_Click.FillColor = Color.FromArgb(230, 80, 80); // 紅色
                btnEdit_Click.RectColor = Color.FromArgb(230, 80, 80);
            }
            else
            {
                // 返回唯讀模式
                btnEdit_Click.FillColor = Color.FromArgb(110, 190, 240); // 藍色
                btnEdit_Click.RectColor = Color.FromArgb(110, 190, 240);
                
                // 清空商品選擇和數量
                cbDetailProduct.SelectedIndex = -1;
                txtQuantity.Clear();
            }
        }

        // 新增或修改 SetControlsReadOnly 方法
        private void SetControlsReadOnly(bool readOnly)
        {
            // 設置主檔相關控制項
            txtOrdertID.ReadOnly = true; // 訂單編號永遠唯讀
            txtOrderEmp.ReadOnly = readOnly;
            txtOderMem.ReadOnly = readOnly;
            txtTableNum.ReadOnly = readOnly;
            OderSatus.ReadOnly = readOnly;

            // 設置明細相關控制項
            cbDetailProduct.Enabled = !readOnly;
            txtQuantity.ReadOnly = readOnly;

            // 設置按鈕狀態
            btnUpdate.Enabled = !readOnly;
            btnDelete.Enabled = !readOnly;
            btnDeleteDetail.Enabled = !readOnly;
        }

        // 新增這個事件處理方法
        private void CbSearchDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 根據選擇的搜尋條件顯示/隱藏控件
            if (cbSearchDetail.SelectedItem != null && cbSearchDetail.SelectedItem.ToString() == "訂單日期")
            {
                dtpStartDate.Visible = true;
                dtpEndDate.Visible = true;
                txtSearch.Visible = false;
            }
            else
            {
                dtpStartDate.Visible = false;
                dtpEndDate.Visible = false;
                txtSearch.Visible = true;
            }
        }

        private bool CheckMemberExists(string memberID)
        {
            if (string.IsNullOrWhiteSpace(memberID))
                return true; // 空值視為有效

            string sql = "SELECT COUNT(*) FROM dMember WHERE MemberID = @MemberID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool CheckEmployeeExists(string employeeID)
        {
            if (string.IsNullOrWhiteSpace(employeeID))
                return true; // 允許員工編號為空值

            string sql = "SELECT COUNT(*) FROM dEmployees WHERE EmployeeID = @EmployeeID AND IsDeleted = 0";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
