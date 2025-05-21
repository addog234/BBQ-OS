using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableMaster.DBO;
using TableMaster.DO;
using static TableMaster.btn;

namespace TableMaster
{
    public partial class Product_Management : Form
    {

        public Product_Management()
        {
            InitializeComponent();
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;

        }
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        private void Product_Management_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "BBQ10";
            scsb.IntegratedSecurity = true;
            GlobaLVar.strDBConnectionString = scsb.ConnectionString.ToString();
            讀取商品資料庫();
            讀取類別資料庫();
            cbCategory.SelectedIndex = -1;
            
            cbProductSearch.Items.Clear();
            cbProductSearch.Items.AddRange(new string[] {
                "產品名稱",
                "商品類別",
                "商品餘額",
                "商品價格"
            });

            cbProductSearch.SelectedIndex = -1;

            foreach (DataGridViewColumn column in ProducTDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
            // 初始化搜尋相關控件狀態
            txtPriceSearchUp.Enabled = false;
            txtPriceSearchdown.Enabled = false;
            txtProductSerch.Enabled = false;
        }

        void 讀取類別資料庫()
        {
            DataTable dataTable = new DataTable();
            
            string strSql = "SELECT CategoryID FROM dCategory;"; 
            dataTable = dboQuery.SqlQuery(strSql);

            cbCategory.Items.Clear(); // 確保清空現有項目

            foreach (DataRow row in dataTable.Rows)
            {
                cbCategory.Items.Add(new ComBoBoxItem
                {
                    Text = row["CategoryID"].ToString(), // 現在這行不會報錯
                    Value = row["CategoryID"].ToString()   // 正確取得 ID
                });
            }

            if (cbCategory.Items.Count > 0)
            {
                cbCategory.SelectedIndex = 0; // 預設選擇第一項
            }
          
        }
        void 讀取商品資料庫()
        {
            /*  SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString);
              con.Open();
              string strSQL = "select * from dEmployees";
              SqlCommand sqlcommand = new SqlCommand(strSQL, con);
              SqlDataReader reader = sqlcommand.ExecuteReader();*/

            DataTable dataTable = new DataTable();
            string strSQL = "SELECT p.ProductID, p.ProductName, p.CategoryID, c.CategoryName, p.UnitPrice, p.Cost, " +
                 "s.StockQuantity, p.PStatus, p.PImage " +
                 "FROM dProduct p " +
                 "LEFT JOIN dCategory c ON p.CategoryID = c.CategoryID " +
                 "LEFT JOIN dStock s ON p.ProductID = s.ProductID " +
                 "WHERE p.IsDeleted = 0";  // 加入過濾條件，排除已刪除的商品



            dataTable = dboQuery.SqlQuery(strSQL);

            dataTable.Columns.Add("ImageColumn", typeof(Image));

             string path = @"C:\Users\iSpan\Desktop\專案3\image\";
            //string path = @"C:\Users\user\Desktop\專案3\image\";


            // 尋找每個DataTable，設置圖像
            foreach (DataRow row in dataTable.Rows)
            {
                // 讀取圖像路並儲存
                string imagePath = path + row["PImage"].ToString();
                if (File.Exists(imagePath))
                {
                    try
                    {
                        using (Image originalImage = Image.FromFile(imagePath))
                        {
                            // 建立縮圖（寬度和高度都設為 50 像素）
                            Bitmap thumbnail = new Bitmap(originalImage, new Size(100, 100));
                            row["ImageColumn"] = thumbnail;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image: {imagePath}. Exception: {ex.Message}");
                        row["ImageColumn"] = null;
                    }
                }
                else
                {
                    row["ImageColumn"] = null;
                }
            }

            // 將 DataTable 綁定到 DataGridView
            ProducTDataGridView.DataSource = dataTable;

            // 設置圖像列的顯示方式
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100  // 縮小圖片欄位寬度
            };

            // 確保只增加一次圖像列
            if (!ProducTDataGridView.Columns.Contains("Image"))
            {
                ProducTDataGridView.Columns.Add(imageColumn);
            }

            // 設定行高
            ProducTDataGridView.RowTemplate.Height = 100;  // 縮小行高

            
            foreach (DataGridViewRow gridViewRow in ProducTDataGridView.Rows)
            {
                DataRowView dataRowView = gridViewRow.DataBoundItem as DataRowView;
                if (dataRowView != null)
                {
                    gridViewRow.Cells["Image"].Value = dataRowView["ImageColumn"];
                }
            }

            // 隐藏原始的圖像路径列
            ProducTDataGridView.Columns["PImage"].Visible = ProducTDataGridView.Columns["Image"].Visible = false; // 隱藏原始的圖像列/

            ProducTDataGridView.Columns["ProductID"].HeaderText = "產品編號"; // 例如自定義產品名稱的標題
            ProducTDataGridView.Columns["ProductName"].HeaderText = "產品名稱"; // 自定義價格的標題
            ProducTDataGridView.Columns["CategoryName"].HeaderText = "類別名稱";
            ProducTDataGridView.Columns["UnitPrice"].HeaderText = "單價";
            ProducTDataGridView.Columns["Cost"].HeaderText = "成本";
            ProducTDataGridView.Columns["StockQuantity"].HeaderText = "數量";
            ProducTDataGridView.Columns["CategoryID"].HeaderText = "類別編號";
            ProducTDataGridView.Columns["PStatus"].HeaderText = "狀態";
            ProducTDataGridView.Columns["PImage"].HeaderText = "圖片名稱";
            ProducTDataGridView.Columns["ImageColumn"].HeaderText = "商品展示";



            
        }

        private void btnProINsert_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            string productPriceText = txtProductPrice.Text.Trim();
            string productCostText = txtProductCost.Text.Trim();
            string stockQuantityText = txtStockQuantity.Text.Trim();
            string productStatus = txtProductStaus.Text.Trim();
            string imageName = txtProductImageName.Text.Trim();
            string Productid = GenerateProductID();
            ComBoBoxItem selectedCategory = cbCategory.SelectedItem as ComBoBoxItem;
            if (selectedCategory == null)
            {
                MessageBox.Show("請先選擇一個類別。");
                return;
            }
            string categoryID = selectedCategory.Value;

            // 驗證是否數字
            if (!int.TryParse(productPriceText, out int productPrice))
            {
                MessageBox.Show("單價格式不正確！");
                return;
            }
            if (!int.TryParse(productCostText, out int productCost))
            {
                MessageBox.Show("成本格式不正確！");
                return;
            }
            if (!int.TryParse(stockQuantityText, out int stockQuantity))
            {
                MessageBox.Show("庫存格式不正確！");
                return;
            }
            string newProductID = GenerateProductID();

            // 建構插入 SQL 语句
            string insertSql = "INSERT INTO dProduct (ProductID, ProductName, CategoryID, UnitPrice, Cost, PStatus, PImage) " +
                               "VALUES (@ProductID, @ProductName, @CategoryID, @UnitPrice, @Cost, @PStatus, @PImage)";
            string insertStockSql = "INSERT INTO dStock (ProductID, StockQuantity, sStatus) " +
                            "VALUES (@ProductID, @StockQuantity, '正常')"; // 默認庫存狀態為 '正常'

            // 使用 dboQuery 執行插入
            using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertSql, connection))
                    {
                        // 添加参数防止 SQL 注入
                        command.Parameters.AddWithValue("@ProductID", newProductID);  // 使用自動生成ProductID
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@CategoryID", categoryID);
                        command.Parameters.AddWithValue("@UnitPrice", productPrice);
                        command.Parameters.AddWithValue("@Cost", productCost);
                        command.Parameters.AddWithValue("@PStatus", productStatus);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantityText);
                        command.Parameters.AddWithValue("@PImage", imageName);


                        
                        int rowsAffected = command.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("產品新增成功！");
                            using (SqlCommand cmdStock = new SqlCommand(insertStockSql, connection))
                            {
                                cmdStock.Parameters.AddWithValue("@ProductID", Productid);
                                cmdStock.Parameters.AddWithValue("@StockQuantity", stockQuantity);

                                // 行 dStock
                                cmdStock.ExecuteNonQuery();

                            }
                           
                            讀取商品資料庫();
                            ClearALL();  // 清空表單
                        }
                        else
                        {
                            MessageBox.Show("產品新增成錯誤。");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"錯誤: {ex.Message}");
                }

            }





        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            // 取得資料
            string productID = txtProductID.Text.Trim();
            string productName = txtProductName.Text.Trim();
            string productPriceText = txtProductPrice.Text.Trim();
            string productCostText = txtProductCost.Text.Trim();
            string stockQuantityText = txtStockQuantity.Text.Trim();
            string productStatus = txtProductStaus.Text.Trim();
            string imageName = txtProductImageName.Text.Trim();
            ComBoBoxItem selectedCategory = cbCategory.SelectedItem as ComBoBoxItem;

            if (selectedCategory == null)
            {
                MessageBox.Show("請先選擇一個類別。");
                return;
            }
            string categoryID = selectedCategory.Value;

            // 驗證int格式
            if (!int.TryParse(productPriceText, out int productPrice))
            {
                MessageBox.Show("單價格式不正確！");
                return;
            }
            if (!int.TryParse(productCostText, out int productCost))
            {
                MessageBox.Show("成本格式不正確！");
                return;
            }
            if (!int.TryParse(stockQuantityText, out int stockQuantity))
            {
                MessageBox.Show("庫存格式不正確！");
                return;
            }

            // 檢查是否有選擇圖片，並處理圖片儲存


            // 更新商品資料的 SQL 語句
            string updateSql = "UPDATE dProduct SET " +
                               "ProductName = @ProductName, " +
                               "CategoryID = @CategoryID, " +
                               "UnitPrice = @UnitPrice, " +
                               "Cost = @Cost, " +
                               "PStatus = @PStatus, " +
                               "PImage = @PImage " +
                               "WHERE ProductID = @ProductID";

            // 更新庫存資料的 SQL 語句
            string updateStockSql = "UPDATE dStock SET StockQuantity = @StockQuantity " +
                                    "WHERE ProductID = @ProductID";

            // 使用 dboQuery 執行更新操作
            using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                try
                {
                    connection.Open();

                    // 更新商品資料
                    using (SqlCommand command = new SqlCommand(updateSql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@CategoryID", categoryID);
                        command.Parameters.AddWithValue("@UnitPrice", productPrice);
                        command.Parameters.AddWithValue("@Cost", productCost);
                        command.Parameters.AddWithValue("@PStatus", productStatus);
                        command.Parameters.AddWithValue("@PImage", imageName); // 更新圖片的檔案名稱

                        // 執行商品更新
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 更新庫存資料
                            using (SqlCommand cmdStock = new SqlCommand(updateStockSql, connection))
                            {
                                cmdStock.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                                cmdStock.Parameters.AddWithValue("@ProductID", productID);

                                cmdStock.ExecuteNonQuery();
                            }

                            // 提示成功
                            MessageBox.Show("商品資料及庫存更新成功！");
                            讀取商品資料庫(); // 重新載入商品資料
                            ClearALL();
                        }
                        else
                        {
                            MessageBox.Show("更新失敗���檢查商品 ID 是否正確。");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"錯誤: {ex.Message}");
                }
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            string strID = txtProductID.Text.Trim();

            // 檢查是否為空ID
            if (string.IsNullOrEmpty(strID))
            {
                MessageBox.Show("請選擇一個有效的商品來刪除！");
                return;  // 若ID為空則中止
            }

            try
            {
                using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
                {
                    con.Open();

                    // SQL: 更新 IsDeleted 為 1 (標記為已刪除)
                    string strSQL = "UPDATE dProduct SET IsDeleted = 1 WHERE ProductID = @ProductID AND IsDeleted = 0";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ProductID", strID);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        // 成功刪除，清空表單
                        讀取商品資料庫();
                        清除內容();

                        MessageBox.Show($"商品 刪除完畢");
                    }
                    else
                    {
                        MessageBox.Show("未找到該商品或該商品已標記為刪除。");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}");
            }

        }

        private void btnProSearch_Click(object sender, EventArgs e)
        {
            string StrSearch = cbProductSearch.SelectedItem.ToString();
            string keyword = txtProductSerch.Text.Trim();
            int? PriceDown = null;
            int? PriceUp = null;

            // 解析價格上限
            if (!string.IsNullOrEmpty(txtPriceSearchUp.Text.Trim()))
            {
                int parsedPriceUp;
                if (int.TryParse(txtPriceSearchUp.Text.Trim(), out parsedPriceUp))
                {
                    PriceUp = parsedPriceUp;
                }
                else
                {
                    MessageBox.Show("輸入錯誤，請輸入有效的價格上限");
                    return;
                }
            }

            // 解析價格下限
            if (!string.IsNullOrEmpty(txtPriceSearchdown.Text.Trim()))
            {
                int parsedPriceDown;
                if (int.TryParse(txtPriceSearchdown.Text.Trim(), out parsedPriceDown))
                {
                    PriceDown = parsedPriceDown;
                }
                else
                {
                    MessageBox.Show("輸入錯誤，請輸入有效的價格下限");
                    return;
                }
            }

            ProducTDataGridView.CurrentCell = null;
            keyword = keyword.ToLower();

            // 篩選 DataGridView
            foreach (DataGridViewRow row in ProducTDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = "";
                bool matchesKeyword = true;
                bool matchesPrice = true;
                bool matchesStock = true;

                // 根據選擇的搜尋類型取得欄位值
                switch (StrSearch)
                {
                    case "產品名稱":
                        cellValue = row.Cells["ProductName"].Value?.ToString().ToLower();
                        matchesKeyword = string.IsNullOrEmpty(keyword) || 
                                       (cellValue != null && cellValue.Contains(keyword));
                        break;
                    case "商品類別":
                        cellValue = row.Cells["CategoryName"].Value?.ToString().ToLower();
                        matchesKeyword = string.IsNullOrEmpty(keyword) || 
                                       (cellValue != null && cellValue.Contains(keyword));
                        break;
                    case "商品餘額":
                        if (int.TryParse(row.Cells["StockQuantity"].Value?.ToString(), out int Productsum))
                        {
                            if (int.TryParse(keyword?.ToString(), out int keywordValue))
                            {
                                matchesStock = Productsum < keywordValue;
                            }
                            else
                            {
                                matchesStock = false;
                            }
                        }
                        else
                        {
                            matchesStock = false;
                        }
                        break;
                    case "商品價格":
                        if (int.TryParse(row.Cells["UnitPrice"].Value?.ToString(), out int price))
                        {
                            matchesPrice = (!PriceDown.HasValue || price >= PriceDown.Value) &&
                                         (!PriceUp.HasValue || price <= PriceUp.Value);
                        }
                        else
                        {
                            matchesPrice = false;
                        }
                        break;
                }

                row.Visible = matchesKeyword && matchesPrice && matchesStock;
            }

            // 在搜尋完成後清除欄位
            ClearSearchFields();
        }

        private void btnProStop_Click(object sender, EventArgs e)
        {
            清除內容();
            讀取商品資料庫();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComBoBoxItem selectedItem = cbCategory.SelectedItem as ComBoBoxItem;

            if (selectedItem != null)
            {
                更新TextBox(selectedItem);
            }
            else
            {
                // 如果没有選擇有校巷，清空 TextBox
                txtCategory.Text = string.Empty;
            }
        }
        private void 更新TextBox(btn.ComBoBoxItem selectedItem)
        {
            // 使用資料庫查詢 CategoryName
            string strSql = $"SELECT CategoryName FROM dCategory WHERE CategoryID = @CategoryID";

            using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                SqlCommand command = new SqlCommand(strSql, connection);
                command.Parameters.AddWithValue("@CategoryID", selectedItem.Value); // 使用 selectedItem.Value

                connection.Open();
                string categoryName = command.ExecuteScalar() as string; // 獲取 CategoryName

                if (categoryName != null)
                {
                    txtCategory.Text = categoryName; // 將 CategoryName 顯示在 TextBox 中
                }
                else
                {
                    txtCategory.Text = "未找到类别";
                }
            }

        }
        private void ClearALL()
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            cbCategory.SelectedIndex = -1;

            txtProductPrice.Text = string.Empty;
            txtProductCost.Text = string.Empty;
            txtStockQuantity.Text = string.Empty;
            txtProductStaus.Text = string.Empty;
            txtProductImageName.Text = string.Empty;

        }
        private string GenerateProductID()
        {
            using (SqlConnection con = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                con.Open();
                string query = "SELECT MAX(CAST(SUBSTRING(ProductID, 2, LEN(ProductID) - 1) AS INT)) FROM dProduct WHERE ProductID LIKE 'P%';";




                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int newID = 1; // 默認ID

                    if (result != DBNull.Value)
                    {
                        newID = Convert.ToInt32(result) + 1; // 增加1
                    }

                    return "P" + newID.ToString("D5"); // 生成新的 ID，确保格式为 EMP01, EMP02 等 P0001
                }
            }
        }

        private void ProducTDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.RowIndex >= 0 && e.RowIndex < ProducTDataGridView.Rows.Count)
            {
                // 直接通過列名来獲取 ProductID
                string productID = ProducTDataGridView.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                //拔循並顯示該商品的詳細資料
                顯示商品詳細資料(productID);
            }
            else
            {
                // 提示用戶點擊無效行
                MessageBox.Show("请选择有效的商品！");
            }

        }
        private void 清除內容()
        {
            // 清空所有 TextBox
            txtProductID.Clear();
            txtProductName.Clear();
            txtCategory.Clear();
            txtProductPrice.Clear();
            txtProductCost.Clear();
            txtStockQuantity.Clear();
            txtProductStaus.Clear();
            txtProductImageName.Clear();
            cbCategory.SelectedIndex = -1;  // 清空 ComboBox
            cbProductSearch.SelectedIndex = -1;
            txtPriceSearchdown.Clear();
            txtPriceSearchUp.Clear();
            txtProductSerch.Clear();
            //btnDelete.Visible = false;  // 隱藏刪除按鈕
        }
        private void 顯示商品詳細資料(string productID)
        {
            try
            {
                // SQL 查詢語句
                string strSQL = "SELECT p.ProductID, p.ProductName, p.CategoryID, c.CategoryName, p.UnitPrice, p.Cost, " +
                       "s.StockQuantity, p.PStatus, p.PImage " +
                       "FROM dProduct p " +
                       "LEFT JOIN dCategory c ON p.CategoryID = c.CategoryID " +
                       "LEFT JOIN dStock s ON p.ProductID = s.ProductID " +
                       "WHERE p.ProductID = @ProductID";

                // 使用 SqlConnection 查詢資料
                using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
                {
                    SqlCommand command = new SqlCommand(strSQL, connection);
                    // 使用參數查詢來避免 SQL 注入
                    command.Parameters.AddWithValue("@ProductID", productID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // if (reader.HasRows)
                    if (reader.Read())

                    {

                        // reader.Read();
                        txtProductID.Text = reader["ProductID"].ToString();
                        txtProductName.Text = reader["ProductName"].ToString();
                        txtCategory.Text = reader["CategoryName"].ToString();
                        txtProductPrice.Text = reader["UnitPrice"].ToString();
                        txtProductCost.Text = reader["Cost"].ToString();
                        txtStockQuantity.Text = reader["StockQuantity"].ToString();
                        txtProductStaus.Text = reader["PStatus"].ToString();
                        txtProductImageName.Text = reader["PImage"].ToString();
                        string selectedCategoryID = reader["CategoryID"].ToString();

                        // 遍歷 ComboBox 的項目，根據 CategoryID 選擇對應的項目
                        foreach (ComBoBoxItem item in cbCategory.Items)
                        {
                            if (item.Value == selectedCategoryID)
                            {
                                cbCategory.SelectedItem = item;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到該商品資料");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取商品資料時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<dodProduct> GetProducts()
        {
            List<dodProduct> products = new List<dodProduct>();

            // SQL 查詢字串，聯接了 dCategory 和 dStock 表
            string query = "SELECT p.ProductID, p.ProductName, p.CategoryID, c.CategoryName, p.UnitPrice, p.Cost, s.StockQuantity, p.PStatus, p.PImage, p.IsDeleted " +
                           "FROM dProduct p " +
                           "JOIN dCategory c ON p.CategoryID = c.CategoryID " +
                           "LEFT JOIN dStock s ON p.ProductID = s.ProductID " +
                           "WHERE p.IsDeleted = 0"; // 只查詢未刪除的商品

            using (SqlConnection conn = new SqlConnection(GlobaLVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new dodProduct
                    {
                        ProductID = reader["ProductID"].ToString(),
                        ProductName = reader["ProductName"].ToString(),
                        CategoryID = reader["CategoryID"].ToString(),
                        CategoryName = reader["CategoryName"].ToString(), // 來自 Category 表
                        UnitPrice = int.Parse(reader["UnitPrice"].ToString()),
                        Cost = int.Parse(reader["Cost"].ToString()),
                        StockQuantity = reader.IsDBNull(reader.GetOrdinal("StockQuantity")) ? 0 : int.Parse(reader["StockQuantity"].ToString()), // 來自 Stock 表
                        ProductStatus = reader["PStatus"].ToString(),
                        Pimage = reader["PImage"].ToString(),
                        IsDeleted = reader.GetBoolean(reader.GetOrdinal("IsDeleted"))
                    }); 
                }
            }

            return products;  // 返回商品列表
        }

        private void cbProductSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 根據選擇的搜尋條件顯示/隱藏控件
            if (cbProductSearch.SelectedItem != null)
            {
                switch (cbProductSearch.SelectedItem.ToString())
                {
                    case "商品價格":
                        txtPriceSearchUp.Enabled = true;
                        txtPriceSearchdown.Enabled = true;
                        txtProductSerch.Enabled = false;
                        break;

                    default:
                        txtPriceSearchUp.Enabled = false;
                        txtPriceSearchdown.Enabled = false;
                        txtProductSerch.Enabled = true;
                        break;
                }
            }
        }

        // 新增清除搜尋欄位的方法
        private void ClearSearchFields()
        {
            txtProductSerch.Clear();
            txtPriceSearchUp.Clear();
            txtPriceSearchdown.Clear();
            cbProductSearch.SelectedIndex = -1;
        }
    }
}
