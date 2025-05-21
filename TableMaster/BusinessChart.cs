using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace TableMaster
{
    public partial class BusinessChart : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public BusinessChart()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cbChange.Items.Clear();
            cbChange.Items.AddRange(new string[] {
                "日銷售額變化",
                "週銷售額變化",
                "月銷售額變化",
                "類別銷售變化"
            });
            cbChange.SelectedIndex = 0;
        }

        private void BusinessChart_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                // 設定連線字串
                scsb.DataSource = @".";
                scsb.InitialCatalog = "BBQ10";  // 資料庫名稱
                scsb.IntegratedSecurity = true;
                GlobaLVar.strDBConnectionString = scsb.ToString();

                using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        @"SELECT c.CategoryName, SUM(od.Quantity * od.UnitPrice) AS TotalSales 
                        FROM dOrderDetails od 
                        JOIN dProduct p ON od.ProductID = p.ProductID 
                        JOIN dCategory c ON p.CategoryID = c.CategoryID 
                        GROUP BY c.CategoryName",
                        connection);

                    SqlDataReader reader = command.ExecuteReader();

                    var series = new UIPieSeries();
                    List<string> categories = new List<string>();

                    // 設置數據標籤的顯示格式
                    series.Label.Show = true;  // 顯示標籤
                    series.Label.Position = UIPieSeriesLabelPosition.Outside;  // 標籤位置在內部
                    series.Label.Formatter = "{b}: {c}元\n({d}%)";  // 類別名稱: 銷售總額 (百分比)
                    while (reader.Read())
                    {
                        string categoryName = reader["CategoryName"].ToString();
                        float totalSales = Convert.ToSingle(reader["TotalSales"]);
                        
                        categories.Add(categoryName);
                        series.AddData(categoryName, totalSales);
                    }
                    reader.Close();

                    var option = new UIPieOption();
                    option.Title = new UITitle();
                    option.Title.Text = "類別銷售統計";
                    
                    option.Series.Add(series);
                    piechatCateGory.SetOption(option);

                    if (categories.Count == 0)
                    {
                        MessageBox.Show("沒有找到任何銷售資料");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}\n{ex.StackTrace}");
            }
        }

       
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dpStart.Value;
                DateTime endDate = dpEnd.Value;

                using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
                {
                    connection.Open();
                    string query = @"
                        WITH AllCategories AS (
                            SELECT DISTINCT CategoryName 
                            FROM dCategory
                        ),
                        AllMonths AS (
                            SELECT 
                                YEAR(DATEADD(MONTH, number, @StartDate)) as Year,
                                MONTH(DATEADD(MONTH, number, @StartDate)) as Month
                            FROM master.dbo.spt_values 
                            WHERE type = 'P' 
                            AND DATEADD(MONTH, number, @StartDate) <= @EndDate
                        ),
                        MonthlyTotalSales AS (
                            SELECT 
                                YEAR(o.OrderDate) as Year,
                                MONTH(o.OrderDate) as Month,
                                c.CategoryName, 
                                ISNULL(SUM(od.Quantity * od.UnitPrice), 0) AS CategorySales
                            FROM dOrders o
                            JOIN dOrderDetails od ON o.OrderID = od.OrderID
                            JOIN dProduct p ON od.ProductID = p.ProductID 
                            JOIN dCategory c ON p.CategoryID = c.CategoryID 
                            WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                                AND o.IsDeleted = 0
                            GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate), c.CategoryName
                        )
                        SELECT 
                            m.Year,
                            m.Month,
                            SUM(ISNULL(mts.CategorySales, 0)) as MonthlyTotal,
                            STRING_AGG(
                                ISNULL(ac.CategoryName + ': ' + 
                                CAST(ISNULL(mts.CategorySales, 0) AS NVARCHAR), 
                                ac.CategoryName + ': 0'), 
                                CHAR(13) + CHAR(10)
                            ) WITHIN GROUP (ORDER BY ISNULL(mts.CategorySales, 0) DESC) as CategoryDetails
                        FROM AllMonths m
                        CROSS JOIN AllCategories ac
                        LEFT JOIN MonthlyTotalSales mts 
                            ON m.Year = mts.Year 
                            AND m.Month = mts.Month 
                            AND ac.CategoryName = mts.CategoryName
                        GROUP BY m.Year, m.Month
                        ORDER BY m.Year, m.Month";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // 設置 DataGridView
                    uiDataGridView1.DataSource = null;
                    uiDataGridView1.Columns.Clear();
                    uiDataGridView1.DataSource = dataTable;

                    // 自定義列標題
                    uiDataGridView1.Columns["Year"].HeaderText = "年份";
                    uiDataGridView1.Columns["Month"].HeaderText = "月份";
                    uiDataGridView1.Columns["MonthlyTotal"].HeaderText = "月總收入";
                    uiDataGridView1.Columns["CategoryDetails"].HeaderText = "類別明細（由高到低）";

                    // 設置金額格式
                    if (uiDataGridView1.Columns["MonthlyTotal"] != null)
                    {
                        uiDataGridView1.Columns["MonthlyTotal"].DefaultCellStyle.Format = "N0";
                    }

                    // 調整列寬
                    uiDataGridView1.Columns["Year"].Width = 80;
                    uiDataGridView1.Columns["Month"].Width = 80;
                    uiDataGridView1.Columns["MonthlyTotal"].Width = 120;
                    uiDataGridView1.Columns["CategoryDetails"].Width = 300;

                    // 設置自動換行
                    uiDataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    uiDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // 更新圖表
                    UpdateChart(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查詢時發生錯誤：{ex.Message}", "錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePieChart(DataTable dataTable)
        {
            // 清除現有的數據
            

            // 創建餅圖系列
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            // 添加數據點
            foreach (DataRow row in dataTable.Rows)
            {
                string category = row["類別名稱"].ToString();
                decimal sales = Convert.ToDecimal(row["銷售總額"]);
                series.Points.AddXY(category, sales);
            }

            // 設置數據標籤
            series.Label = "#VALX\n#PERCENT{P2}";
            series["PieLabelStyle"] = "Outside";
            series.IsValueShownAsLabel = true;

            // 添加系列到圖表
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTIme.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");  
        }

        private void btnVIPSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dpStart.Value;
                DateTime endDate = dpEnd.Value;

                using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            m.MemberID as '會員編號',
                            m.MemName as '會員姓名',
                            COUNT(DISTINCT o.OrderID) as '訂單數量',
                            SUM(od.Quantity * od.UnitPrice) as '消費總額',
                            MIN(o.OrderDate) as '第一筆消費日期',
                            MAX(o.OrderDate) as '最後消費日期'
                        FROM dOrders o
                        JOIN dOrderDetails od ON o.OrderID = od.OrderID
                        JOIN dMember m ON o.MemberID = m.MemberID
                        WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                            AND o.IsDeleted = 0
                            AND o.MemberID IS NOT NULL
                        GROUP BY 
                            m.MemberID,
                            m.MemName
                        ORDER BY SUM(od.Quantity * od.UnitPrice) DESC";  // 按消費總額降序排序

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // 設置 DataGridView
                    uiDataGridView1.DataSource = null;
                    uiDataGridView1.Columns.Clear();
                    uiDataGridView1.DataSource = dataTable;

                    // 設置金額格式
                    if (uiDataGridView1.Columns["消費總額"] != null)
                    {
                        uiDataGridView1.Columns["消費總額"].DefaultCellStyle.Format = "N0";
                    }

                    // 設置日期格式
                    if (uiDataGridView1.Columns["第一筆消費日期"] != null)
                    {
                        uiDataGridView1.Columns["第一筆消費日期"].DefaultCellStyle.Format = "yyyy/MM/dd";
                    }
                    if (uiDataGridView1.Columns["最後消費日期"] != null)
                    {
                        uiDataGridView1.Columns["最後消費日期"].DefaultCellStyle.Format = "yyyy/MM/dd";
                    }

                    // 調整列寬
                    foreach (DataGridViewColumn col in uiDataGridView1.Columns)
                    {
                        switch (col.Name)
                        {
                            case "會員姓名":
                            case "會員編號":
                                col.Width = 120;
                                break;
                            case "消費總額":
                                col.Width = 130;
                                break;
                            case "第一筆消費日期":
                            case "最後消費日期":
                                col.Width = 150;
                                break;
                            default:
                                col.Width = 100;
                                break;
                        }
                    }

                    // 如果沒有數
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("在選定的時間範圍內沒有找到會員消費記錄。", "查詢結果", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查詢時發生錯誤：{ex.Message}", "錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSellChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbChange.SelectedItem == null)
                {
                    MessageBox.Show("請選擇要查看的變化類型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startDate = dpStart.Value;
                DateTime endDate = dpEnd.Value;

                using (SqlConnection connection = new SqlConnection(GlobaLVar.strDBConnectionString))
                {
                    connection.Open();
                    string query = "";
                    
                    // 根據選擇的類型設置不同的查詢
                    switch (cbChange.SelectedItem.ToString())
                    {
                        case "日銷售額變化":
                            query = @"
                                SELECT 
                                    CAST(o.OrderDate AS DATE) as '日期',
                                    COUNT(DISTINCT o.OrderID) as '訂單數',
                                    SUM(od.Quantity * od.UnitPrice) as '銷售總額'
                                FROM dOrders o
                                JOIN dOrderDetails od ON o.OrderID = od.OrderID
                                WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                                    AND o.IsDeleted = 0
                                GROUP BY CAST(o.OrderDate AS DATE)
                                ORDER BY CAST(o.OrderDate AS DATE)";
                            break;

                        case "週銷售額變化":
                            query = @"
                                SELECT 
                                    DATEADD(DAY, -(DATEPART(WEEKDAY, o.OrderDate)-1), CAST(o.OrderDate AS DATE)) as '週開始日期',
                                    COUNT(DISTINCT o.OrderID) as '訂單數',
                                    SUM(od.Quantity * od.UnitPrice) as '銷售總額'
                                FROM dOrders o
                                JOIN dOrderDetails od ON o.OrderID = od.OrderID
                                WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                                    AND o.IsDeleted = 0
                                GROUP BY DATEADD(DAY, -(DATEPART(WEEKDAY, o.OrderDate)-1), CAST(o.OrderDate AS DATE))
                                ORDER BY DATEADD(DAY, -(DATEPART(WEEKDAY, o.OrderDate)-1), CAST(o.OrderDate AS DATE))";
                            break;

                        case "月銷售額變化":
                            query = @"
                                SELECT 
                                    DATEFROMPARTS(YEAR(o.OrderDate), MONTH(o.OrderDate), 1) as '月份',
                                    COUNT(DISTINCT o.OrderID) as '訂單數',
                                    SUM(od.Quantity * od.UnitPrice) as '銷售總額'
                                FROM dOrders o
                                JOIN dOrderDetails od ON o.OrderID = od.OrderID
                                WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                                    AND o.IsDeleted = 0
                                GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)
                                ORDER BY YEAR(o.OrderDate), MONTH(o.OrderDate)";
                            break;

                        case "類別銷售變化":
                            query = @"
                                SELECT 
                                    CAST(o.OrderDate AS DATE) as '日期',
                                    c.CategoryName as '類別',
                                    SUM(od.Quantity * od.UnitPrice) as '銷售總額'
                                FROM dOrders o
                                JOIN dOrderDetails od ON o.OrderID = od.OrderID
                                JOIN dProduct p ON od.ProductID = p.ProductID
                                JOIN dCategory c ON p.CategoryID = c.CategoryID
                                WHERE o.OrderDate BETWEEN @StartDate AND @EndDate
                                    AND o.IsDeleted = 0
                                GROUP BY CAST(o.OrderDate AS DATE), c.CategoryName
                                ORDER BY CAST(o.OrderDate AS DATE), c.CategoryName";
                            break;
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // 更新 DataGridView
                    uiDataGridView1.DataSource = dataTable;

                    // 設置金額格式
                    if (uiDataGridView1.Columns["銷售總額"] != null)
                    {
                        uiDataGridView1.Columns["銷售總額"].DefaultCellStyle.Format = "N0";
                    }

                    // 更新圖表
                    UpdateChangeChart(dataTable, cbChange.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查詢時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateChangeChart(DataTable dataTable, string chartType)
        {
            OderChart.Series.Clear();
            OderChart.ChartAreas.Clear();
            OderChart.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea());
            OderChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            if (chartType == "類別銷售變化")
            {
                // 為每個類別創建一條折線
                var categories = dataTable.AsEnumerable()
                    .Select(row => row.Field<string>("類別"))
                    .Distinct()
                    .ToList();

                foreach (var category in categories)
                {
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = category,
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                        MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                    };

                    var categoryData = dataTable.AsEnumerable()
                        .Where(row => row.Field<string>("類別") == category);

                    foreach (var row in categoryData)
                    {
                        series.Points.AddXY(
                            row.Field<DateTime>("日期").ToString("MM/dd"),
                            Convert.ToDouble(row["銷售總額"]));
                    }

                    OderChart.Series.Add(series);
                }
            }
            else
            {
                // 創建單一折線圖
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "銷售總額",
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                };

                string dateColumnName = dataTable.Columns[0].ColumnName;
                foreach (DataRow row in dataTable.Rows)
                {
                    string xValue = row[dateColumnName] is DateTime date
                        ? (chartType == "月銷售額變化" ? date.ToString("yyyy/MM") : date.ToString("MM/dd"))
                        : row[dateColumnName].ToString();

                    series.Points.AddXY(xValue, Convert.ToDouble(row["銷售總額"]));
                }

                OderChart.Series.Add(series);
            }

            // 設置圖表標題
            OderChart.Titles.Clear();
            OderChart.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                chartType, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new System.Drawing.Font("Arial", 14, FontStyle.Bold),
                System.Drawing.Color.Black));

            // 啟用數據標籤
            foreach (var series in OderChart.Series)
            {
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N0";
            }

            OderChart.Update();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                // 清除折線圖/長條圖
                OderChart.Series.Clear();
                OderChart.Titles.Clear();

                // 清除 DataGridView
                uiDataGridView1.DataSource = null;
                uiDataGridView1.Columns.Clear();

                // 重置日期選擇器今天
                dpStart.Value = DateTime.Now;
                dpEnd.Value = DateTime.Now;

                // 重置 ComboBox 選擇
                cbChange.SelectedIndex = 0;

                // 關閉表單
               // this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"關閉時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateChart(DataTable dataTable)
        {
            OderChart.Series.Clear();
            OderChart.ChartAreas.Clear();
            OderChart.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea());

            // 創建柱狀圖系列
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "月銷售額",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            // 添加數據點
            foreach (DataRow row in dataTable.Rows)
            {
                string period = $"{row["Year"]}/{row["Month"]}";
                decimal total = Convert.ToDecimal(row["MonthlyTotal"]);
                series.Points.AddXY(period, total);
            }

            // 設置圖表外觀
            OderChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            OderChart.ChartAreas[0].AxisX.Interval = 1;
            OderChart.ChartAreas[0].AxisY.Title = "銷售額";
            OderChart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            // 設置數據標籤
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "N0";

            // 添加系列到圖表
            OderChart.Series.Add(series);

            // 設置標題
            OderChart.Titles.Clear();
            OderChart.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "月度銷售統計", 
                System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new System.Drawing.Font("Arial", 14, FontStyle.Bold),
                Color.Black));

            OderChart.Update();
        }
    }
}
