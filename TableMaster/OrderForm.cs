using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using TableMaster.DBO;
using TableMaster.DO;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace TableMaster
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            imageList商品圖檔.ImageSize = new Size(160, 160);

            listViewPork.Clear();
            listViewBeef.View = listViewPork.View = listViewLamb.View = listViewSeafood.View = listViewChicken.View = listViewDrink.View = listViewDessert.View = View.LargeIcon;//LargeIcon, Tile, List, SmallIcon
            listViewBeef.LargeImageList = listViewPork.LargeImageList = listViewLamb.LargeImageList = listViewSeafood.LargeImageList = listViewChicken.LargeImageList = listViewDrink.LargeImageList = listViewDessert.LargeImageList = imageList商品圖檔; //LargeIcon, Tile
            listViewBeef.SmallImageList = listViewPork.SmallImageList = listViewLamb.SmallImageList = listViewSeafood.SmallImageList = listViewChicken.SmallImageList = listViewDrink.SmallImageList = listViewDessert.SmallImageList = imageList商品圖檔; //SmallIcon, List




            DataTable dt = dboQuery.SqlQuery($@"
                SELECT * FROM dProduct ;
            ");
            lsdodProduct = dodProduct.GetdodProductListFromDataTable(dt);
            foreach (var objItem in lsdodProduct)
            {
                ListViewItem item = new ListViewItem();
                item.Text = $"{objItem.ProductName} {objItem.UnitPrice}元";
                item.Tag = objItem.ProductID;
            
                string path = @"C:\Users\iSpan\Desktop\專案3\image";
                //string path = @"C:\Users\user\Desktop\專案3\image";
                string str完整圖檔路徑 = path + @"\" + objItem.Pimage;
                if (File.Exists(str完整圖檔路徑))
                {
                    System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                    Image img商品圖檔 = Image.FromStream(fs);
                    imageList商品圖檔.Images.Add(img商品圖檔);
                    item.ImageIndex = imageList商品圖檔.Images.Count - 1;
                }
                else
                    Console.Write(str完整圖檔路徑 + "照片不存在");
                switch (objItem.CategoryID)
                {
                    case "C0001":
                        listViewBeef.Items.Add(item);
                        break;
                    case "C0002":
                        listViewPork.Items.Add(item);
                        break;
                    case "C0003":
                        listViewLamb.Items.Add(item);
                        break;
                    case "C0004":
                        listViewSeafood.Items.Add(item);
                        break;
                    case "C0005":
                        listViewChicken.Items.Add(item);
                        break;
                    case "C0006":
                        listViewDrink.Items.Add(item);
                        break;
                    case "C0007":
                        listViewDessert.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
            // 顯示ListView圖片模式();

            // 新增增減按鈕欄位
            DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
            btnIncrease.HeaderText = "";
            btnIncrease.Text = "+";
            btnIncrease.Name = "ColIncrease";
            btnIncrease.UseColumnTextForButtonValue = true;
            uiDataGridView1.Columns.Add(btnIncrease);

            DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();
            btnDecrease.HeaderText = "";
            btnDecrease.Text = "-";
            btnDecrease.Name = "ColDecrease";
            btnDecrease.UseColumnTextForButtonValue = true;
            uiDataGridView1.Columns.Add(btnDecrease);
        }

        List<dodProduct> lsdodProduct = new List<dodProduct>();

        void 顯示ListView圖片模式()
        {
            for (int idx = 0; idx < lsdodProduct.Count; idx += 1)
            {
                var objItem = lsdodProduct[idx];

            }
        }

        private void lvAddProductToOrder_ItemActivate(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                AddProductToOrder(lv.SelectedItems[0]);
            }
        }

        private void AddProductToOrder(ListViewItem selectedItem)
        {
            string ProductID = selectedItem.Tag.ToString();
            DataTable dt = dboQuery.SqlQuery($"SELECT * FROM dProduct WHERE ProductID='{ProductID}';");
            dodProduct dodProduct = dodProduct.GetdodProductListFromDataTable(dt).FirstOrDefault();

            if (dodProduct != null && dodProduct.UnitPrice.HasValue) // 確保 UnitPrice 不為 null
            {
                string productName = dodProduct.ProductName;
                int unitPrice = dodProduct.UnitPrice.Value; // 取得 UnitPrice 的值
                uiDataGridView1.Rows.Add(ProductID, productName, 1, unitPrice);
                //SaveOrderDetail(dodProduct.ProductID, unitPrice);
            }
            else
            {
                MessageBox.Show("產品資料無法獲取，請檢查資料。");
            }
            CalculateTotalPrice();
        }

        private string GetCurrentOrderId()
        {
            string orderId = null;
            string startNo = "OD" + DateTime.Now.ToString("yyMMdd");
            string connectionString = @"Data Source=.;Initial Catalog=BBQ10;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT TOP 1 OrderID FROM dOrders WHERE OrderID LIKE '{startNo}%' ORDER BY OrderID DESC";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        //  或許當前最新編號並解析為整數，再+1
                        string existingOrder = result.ToString();
                        string currentNumber = existingOrder.Substring(startNo.Length); // 提取末尾數字部分
                        ulong newNumber = Convert.ToUInt64(currentNumber) + 1;

                        // 组合新的 OrderID，格式化編號固定長度
                        orderId = startNo + newNumber.ToString("D4");
                    }
                    else
                    {
                        // 如果沒有找到編號，返回默認的第一個編號
                        orderId = startNo + "0001";
                    }
                }
            }

            return orderId;
        }



        private void SaveOrderDetail(string productId, int unitPrice)
        {
            string sql = "INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice);";

            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    //command.Parameters.AddWithValue("@OrderID", orderId);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@Quantity", 1); // 假設每次添加1個
                    command.Parameters.AddWithValue("@UnitPrice", unitPrice); // 確保這裡的單價是 int                                   

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }



        private void btnShopping_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = null;

            if (listViewPork.SelectedItems.Count > 0)
            {
                selectedItem = listViewPork.SelectedItems[0];
            }
            else if (listViewBeef.SelectedItems.Count > 0)
            {
                selectedItem = listViewBeef.SelectedItems[0];
            }
            else if (listViewLamb.SelectedItems.Count > 0)
            {
                selectedItem = listViewLamb.SelectedItems[0];
            }
            else if (listViewSeafood.SelectedItems.Count > 0)
            {
                selectedItem = listViewSeafood.SelectedItems[0];
            }
            else if (listViewChicken.SelectedItems.Count > 0)
            {
                selectedItem = listViewChicken.SelectedItems[0];
            }
            else if (listViewDrink.SelectedItems.Count > 0)
            {
                selectedItem = listViewDrink.SelectedItems[0];
            }
            else if (listViewDessert.SelectedItems.Count > 0)
            {
                selectedItem = listViewDessert.SelectedItems[0];
            }

            // 確認有選擇的商品
            if (selectedItem != null)
            {
                string productId = selectedItem.Tag.ToString(); // 從 Tag 獲取 ProductID
                string productName = selectedItem.Text; // 獲取商品名稱和價格（例如 "商品名稱 100元"）

                // 提取價格
                int unitPrice = int.Parse(productName.Split(' ')[1].Replace("元", "")); // 獲取價格

                // 獲取訂單編號（假設從某個地方獲取，這裡使用 1 作為示例）
                //int orderId = GetCurrentOrderId();

                // 添加到 DataGridView
                //uiDataGridView1.Rows.Add(orderId, productName, 1, unitPrice); // 假設數量為 1

                // 保存到資料庫
                SaveOrderDetail(productId, unitPrice);
            }
            else
            {
                MessageBox.Show("請選擇要添加的產品。");
            }
        }

        private void btnOrderOK_Click(object sender, EventArgs e)
        {
            try
            {
                uiDataGridView1.CurrentCell = null;
                string orderID = GetCurrentOrderId();
                List<dodOrderDetail> lsdodOrderDetail = GetOrderDetail();

                if (lsdodOrderDetail == null || lsdodOrderDetail.Count == 0)
                {
                    MessageBox.Show("選擇產品");
                    return;
                }

                string tableNumber = txtTableNum.Text;
                if (string.IsNullOrWhiteSpace(tableNumber))
                {
                    MessageBox.Show("請輸入桌號");
                    return;
                }
                string MemberID = txtMemID.Text;
               
                // 先儲存主訂單
                SaveMaster(orderID, lsdodOrderDetail, tableNumber,MemberID);
                // 再儲存明細
                SaveDetail(orderID, lsdodOrderDetail);

                MessageBox.Show($"訂單 {orderID} 新增成功！");
                uiDataGridView1.Rows.Clear();
                txtTableNum.Clear(); // 清空桌號

                // 可選：重新載入相關資料
                // ReloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"處理訂單時發生錯誤：{ex.Message}");
            }
        }

        private List<dodOrderDetail> GetOrderDetail()
        {
            List<dodOrderDetail> lsdodOrderDetail = new List<dodOrderDetail>();
            foreach (DataGridViewRow row in uiDataGridView1.Rows)
            {
                string productID = row.Cells["ColProductID"].Value?.ToString() ?? "";
                int quantity = 0;
                int.TryParse(row.Cells["Colquantity"].Value?.ToString() ?? "", out quantity);
                int unitPrice = 0;
                int.TryParse(row.Cells["ColPrice"].Value?.ToString() ?? "", out unitPrice);
                if (productID == "" || quantity == 0 || unitPrice == 0)
                {
                    MessageBox.Show("所有資料列都必須有完整的產品編號且數量及單價不可為0");
                    return null;
                }
                else
                {
                    lsdodOrderDetail.Add(new dodOrderDetail()
                    {
                        ProductID = productID,
                        Quantity = quantity,
                        UnitPrice = unitPrice
                    });
                }
            }
            return lsdodOrderDetail;

        }

        private void SaveMaster(string orderID, List<dodOrderDetail> lsobjItem, string tableNumber, string MemberID)
        {

            double totalPriceBeforeDiscount = 0, totalPriceAfterDiscount = 0;
            foreach (var objItem in lsobjItem)
            {
                totalPriceBeforeDiscount += objItem.UnitPrice * objItem.Quantity;
            }
            if (chkVip.Checked)
            {
                totalPriceAfterDiscount = totalPriceBeforeDiscount * 0.9; // 打九折
            }
            else
            {
                totalPriceAfterDiscount = totalPriceBeforeDiscount; // 不打折
            }


            string sql = "INSERT INTO dOrders (OrderID, MemberID,OrderDate,OStatus,EmployeeID,TableNumber,TotalPriceBeforeDiscount,TotalPriceAfterDiscount) VALUES (@OrderID, @MemberID,@OrderDate,@OStatus,@EmployeeID,@TableNumber,@TotalPriceBeforeDiscount,@TotalPriceAfterDiscount);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@MemberID", string.IsNullOrWhiteSpace(MemberID) ? DBNull.Value : (object)MemberID);
                    command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    command.Parameters.AddWithValue("@OStatus", "已建立");
                    command.Parameters.AddWithValue("@EmployeeID", "EMP01");
                    command.Parameters.AddWithValue("@TableNumber", tableNumber);
                    command.Parameters.AddWithValue("@TotalPriceBeforeDiscount", totalPriceBeforeDiscount);
                    command.Parameters.AddWithValue("@TotalPriceAfterDiscount", totalPriceAfterDiscount);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show($"錯誤: {ex.Message}");
                    }
                }
            }
        }

        private string connectionString = @"Data Source=.;Initial Catalog=BBQ10;Integrated Security=True";
        private void SaveDetail(string orderID, List<dodOrderDetail> lsobjItem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. 插入訂單明細
                        string insertDetailSql = @"
                            INSERT INTO dOrderDetails 
                            (OrderID, ProductID, Quantity, UnitPrice) 
                            VALUES 
                            (@OrderID, @ProductID, @Quantity, @UnitPrice)";

                        foreach (var objItem in lsobjItem)
                        {
                            using (SqlCommand command = new SqlCommand(insertDetailSql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@OrderID", orderID);
                                command.Parameters.AddWithValue("@ProductID", objItem.ProductID);
                                command.Parameters.AddWithValue("@Quantity", objItem.Quantity);
                                command.Parameters.AddWithValue("@UnitPrice", objItem.UnitPrice);

                                int result = command.ExecuteNonQuery();
                                if (result <= 0)
                                {
                                    throw new Exception($"插入訂單明細失敗: {orderID}, {objItem.ProductID}");
                                }
                            }
                        }

                        // 2. 更新庫存
                        string updateStockSql = @"
                            UPDATE dStock 
                            SET StockQuantity = StockQuantity - @Quantity 
                            WHERE ProductID = @ProductID 
                            AND StockQuantity >= @Quantity";

                        foreach (var objItem in lsobjItem)
                        {
                            using (SqlCommand command = new SqlCommand(updateStockSql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ProductID", objItem.ProductID);
                                command.Parameters.AddWithValue("@Quantity", objItem.Quantity);

                                int result = command.ExecuteNonQuery();
                                if (result <= 0)
                                {
                                    throw new Exception($"商品 {objItem.ProductID} 庫存不足或更新失敗");
                                }
                            }
                        }

                        // 3. 提交交易
                        transaction.Commit();
                        MessageBox.Show("訂單明細儲存成功！");
                    }
                    catch (Exception ex)
                    {
                        // 發生錯誤時回滾交易
                        transaction.Rollback();
                        MessageBox.Show($"儲存訂單明細時發生錯誤：{ex.Message}");
                        throw;
                    }
                }
            }
        }

        private void btnOrderRM_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in uiDataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) // 确保不移除新行
                    {
                        uiDataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的行。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CalculateTotalPrice();
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確保點的不是標題行或無效區域
            if (e.RowIndex >= 0)
            {
                //清除現有的選中行
                uiDataGridView1.ClearSelection();

                //  設置點擊的行為為選中行
                uiDataGridView1.Rows[e.RowIndex].Selected = true;
            }

        }
        private void btnOrderClear_Click(object sender, EventArgs e)
        {
            清除();
            CalculateTotalPrice();
        }
        void 清除()
        {
            uiDataGridView1.Rows.Clear();

        }





        private void CalculateTotalPrice()
        {
            int totalPriceBeforeDiscount = 0;

            foreach (DataGridViewRow row in uiDataGridView1.Rows)
            {
                //  確保行校且不是空行
                if (row.Cells["ColPrice"].Value != null && row.Cells["Colquantity"].Value != null)
                {
                    // 取得單價和數量
                    int unitPrice = Convert.ToInt32(row.Cells["ColPrice"].Value);


                    int quantity = Convert.ToInt32(row.Cells["Colquantity"].Value);

                    // 計算總價格
                    totalPriceBeforeDiscount += (int)(unitPrice * quantity);
                }
            }

            // 更新標籤顯示總價格
            lbl總額.Text = totalPriceBeforeDiscount.ToString();
        }

        private void uiDataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (uiDataGridView1.IsCurrentCellDirty)
            {
                uiDataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }

        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btnCheckorder_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel)
            {
                // 清空panel
                panel.Controls.Clear();

                
                OrderDetails ordeDe = new OrderDetails();
                ordeDe.TopLevel = false;
                ordeDe.Size = panel.ClientSize;
                ordeDe.Dock = DockStyle.Fill;
                ordeDe.FormBorderStyle = FormBorderStyle.None;
                panel.Controls.Add(ordeDe);
                ordeDe.Show();
            }
        }

        private int GetCurrentStock(string productID, SqlConnection connection)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT StockQuantity FROM dStock WHERE ProductID = @ProductID";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@ProductID", productID);
                    var result = command.ExecuteScalar();
                    con.Close();
                    if (result != null && int.TryParse(result.ToString(), out int stock))
                    {
                        return stock;
                    }

                    return 0;  // 若找不到商品，庫存為 0
                }

            }
        }

        private void btnOrderOK_Click_1(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == uiDataGridView1.Columns["ColIncrease"].Index)
            {
                // 增加數量
                int currentQty = Convert.ToInt32(uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value);
                string productId = uiDataGridView1.Rows[e.RowIndex].Cells["ColProductID"].Value.ToString();
                
                // 檢查庫存
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int stockQty = GetCurrentStock(productId, conn);
                    if (currentQty < stockQty)
                    {
                        uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value = currentQty + 1;
                        CalculateTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("庫存不足！");
                    }
                }
            }
            else if (e.ColumnIndex == uiDataGridView1.Columns["ColDecrease"].Index)
            {
                // 減少數量
                int currentQty = Convert.ToInt32(uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value);
                if (currentQty > 1)
                {
                    uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value = currentQty - 1;
                    CalculateTotalPrice();
                }
                else
                {
                    // 如果數量為1，詢問是否要移除商品
                    if (MessageBox.Show("是否要移除此商品？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        uiDataGridView1.Rows.RemoveAt(e.RowIndex);
                        CalculateTotalPrice();
                    }
                }
            }
        }

        private void uiDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == uiDataGridView1.Columns["ColIncrease"].Index)
            {
                // 增加數量
                int currentQty = Convert.ToInt32(uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value);
                string productId = uiDataGridView1.Rows[e.RowIndex].Cells["ColProductID"].Value.ToString();

                // 檢查庫存
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int stockQty = GetCurrentStock(productId, conn);
                    if (currentQty < stockQty)
                    {
                        uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value = currentQty + 1;
                        CalculateTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("庫存不足！");
                    }
                }
            }
            else if (e.ColumnIndex == uiDataGridView1.Columns["ColDecrease"].Index)
            {
                // 減少數量
                int currentQty = Convert.ToInt32(uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value);
                if (currentQty > 1)
                {
                    uiDataGridView1.Rows[e.RowIndex].Cells["Colquantity"].Value = currentQty - 1;
                    CalculateTotalPrice();
                }
                else
                {
                    // 如果數量為1，詢問是否要移除商品
                    if (MessageBox.Show("是否要移除此商品？", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        uiDataGridView1.Rows.RemoveAt(e.RowIndex);
                        CalculateTotalPrice();
                    }
                }
            }
        }
    }
}
