namespace TableMaster
{
    partial class BusinessChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.piechatCateGory = new Sunny.UI.UIPieChart();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.btnSellChange = new Sunny.UI.UISymbolButton();
            this.lblTIme = new Sunny.UI.UILabel();
            this.btnVIPSearch = new Sunny.UI.UISymbolButton();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.OderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dpStart = new Sunny.UI.UIDatePicker();
            this.dpEnd = new Sunny.UI.UIDatePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbChange = new Sunny.UI.UIComboBox();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // piechatCateGory
            // 
            this.piechatCateGory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.piechatCateGory.LegendFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.piechatCateGory.Location = new System.Drawing.Point(0, 1);
            this.piechatCateGory.MinimumSize = new System.Drawing.Size(1, 1);
            this.piechatCateGory.Name = "piechatCateGory";
            this.piechatCateGory.Size = new System.Drawing.Size(443, 277);
            this.piechatCateGory.SubFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.piechatCateGory.TabIndex = 0;
            this.piechatCateGory.Text = "uiPieChart1";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnClose);
            this.uiPanel1.Controls.Add(this.btnSellChange);
            this.uiPanel1.Controls.Add(this.lblTIme);
            this.uiPanel1.Controls.Add(this.btnVIPSearch);
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.uiDataGridView1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 324);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1058, 300);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(356, 0);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 4;
            this.btnClose.Size = new System.Drawing.Size(97, 53);
            this.btnClose.Symbol = -1;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "關閉資料";
            this.btnClose.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSellChange
            // 
            this.btnSellChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellChange.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSellChange.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSellChange.Location = new System.Drawing.Point(255, 0);
            this.btnSellChange.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSellChange.Name = "btnSellChange";
            this.btnSellChange.Radius = 4;
            this.btnSellChange.Size = new System.Drawing.Size(101, 53);
            this.btnSellChange.Symbol = -1;
            this.btnSellChange.TabIndex = 5;
            this.btnSellChange.Text = "銷售變化";
            this.btnSellChange.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSellChange.Click += new System.EventHandler(this.btnSellChange_Click);
            // 
            // lblTIme
            // 
            this.lblTIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTIme.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTIme.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold);
            this.lblTIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTIme.Location = new System.Drawing.Point(450, 0);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(608, 53);
            this.lblTIme.TabIndex = 4;
            this.lblTIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVIPSearch
            // 
            this.btnVIPSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVIPSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVIPSearch.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVIPSearch.Location = new System.Drawing.Point(125, 0);
            this.btnVIPSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnVIPSearch.Name = "btnVIPSearch";
            this.btnVIPSearch.Radius = 4;
            this.btnVIPSearch.Size = new System.Drawing.Size(130, 53);
            this.btnVIPSearch.Symbol = -1;
            this.btnVIPSearch.TabIndex = 3;
            this.btnVIPSearch.Text = "高消費族群";
            this.btnVIPSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVIPSearch.Click += new System.EventHandler(this.btnVIPSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 4;
            this.btnSearch.Size = new System.Drawing.Size(125, 53);
            this.btnSearch.Symbol = -1;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "每月銷售額";
            this.btnSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 53);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(1058, 247);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 0;
            // 
            // OderChart
            // 
            chartArea1.Name = "ChartArea1";
            this.OderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.OderChart.Legends.Add(legend1);
            this.OderChart.Location = new System.Drawing.Point(560, 1);
            this.OderChart.Name = "OderChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.OderChart.Series.Add(series1);
            this.OderChart.Size = new System.Drawing.Size(395, 277);
            this.OderChart.TabIndex = 3;
            this.OderChart.Text = "chart1";
            // 
            // dpStart
            // 
            this.dpStart.FillColor = System.Drawing.Color.White;
            this.dpStart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpStart.Location = new System.Drawing.Point(30, 285);
            this.dpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpStart.MaxLength = 10;
            this.dpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpStart.Size = new System.Drawing.Size(150, 29);
            this.dpStart.SymbolDropDown = 61555;
            this.dpStart.SymbolNormal = 61555;
            this.dpStart.SymbolSize = 24;
            this.dpStart.TabIndex = 4;
            this.dpStart.Text = "2024-11-13";
            this.dpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpStart.Value = new System.DateTime(2024, 11, 13, 1, 5, 50, 947);
            this.dpStart.Watermark = "";
            // 
            // dpEnd
            // 
            this.dpEnd.FillColor = System.Drawing.Color.White;
            this.dpEnd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpEnd.Location = new System.Drawing.Point(200, 285);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEnd.MaxLength = 10;
            this.dpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEnd.Size = new System.Drawing.Size(150, 29);
            this.dpEnd.SymbolDropDown = 61555;
            this.dpEnd.SymbolNormal = 61555;
            this.dpEnd.SymbolSize = 24;
            this.dpEnd.TabIndex = 5;
            this.dpEnd.Text = "2024-11-13";
            this.dpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEnd.Value = new System.DateTime(2024, 11, 13, 1, 5, 50, 947);
            this.dpEnd.Watermark = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbChange
            // 
            this.cbChange.DataSource = null;
            this.cbChange.FillColor = System.Drawing.Color.White;
            this.cbChange.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbChange.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbChange.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbChange.Location = new System.Drawing.Point(560, 285);
            this.cbChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbChange.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbChange.Name = "cbChange";
            this.cbChange.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbChange.Size = new System.Drawing.Size(150, 29);
            this.cbChange.SymbolSize = 24;
            this.cbChange.TabIndex = 6;
            this.cbChange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbChange.Watermark = "";
            // 
            // BusinessChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1058, 624);
            this.Controls.Add(this.cbChange);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.OderChart);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.piechatCateGory);
            this.Name = "BusinessChart";
            this.Text = "BusinessChart";
            this.Load += new System.EventHandler(this.BusinessChart_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OderChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPieChart piechatCateGory;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UISymbolButton btnVIPSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart OderChart;
        private Sunny.UI.UIDatePicker dpStart;
        private Sunny.UI.UIDatePicker dpEnd;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILabel lblTIme;
        private Sunny.UI.UIComboBox cbChange;
        private Sunny.UI.UISymbolButton btnSellChange;
        private Sunny.UI.UISymbolButton btnClose;
    }
}