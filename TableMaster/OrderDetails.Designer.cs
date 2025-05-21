namespace TableMaster
{
    partial class OrderDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.BtnOrderback = new Sunny.UI.UIButton();
            this.btnOrDetailSearch = new Sunny.UI.UIButton();
            this.Clear = new Sunny.UI.UIButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiDataGridView2 = new Sunny.UI.UIDataGridView();
            this.OrderIDDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSearchDetail = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.OderSatus = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txtOrdertID = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtOderMem = new Sunny.UI.UITextBox();
            this.txtOrderEmp = new Sunny.UI.UITextBox();
            this.cbDetailProduct = new System.Windows.Forms.ComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txtQuantity = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.btnDeleteDetail = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtTableNum = new Sunny.UI.UITextBox();
            this.btnEdit_Click = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(671, 26);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(185, 70);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "訂單內容";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOrderback
            // 
            this.BtnOrderback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrderback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.BtnOrderback.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOrderback.Location = new System.Drawing.Point(97, 77);
            this.BtnOrderback.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnOrderback.Name = "BtnOrderback";
            this.BtnOrderback.Radius = 35;
            this.BtnOrderback.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.BtnOrderback.Size = new System.Drawing.Size(120, 45);
            this.BtnOrderback.Style = Sunny.UI.UIStyle.Custom;
            this.BtnOrderback.TabIndex = 40;
            this.BtnOrderback.Text = "返回主選單";
            this.BtnOrderback.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOrderback.Click += new System.EventHandler(this.BtnOrderback_Click);
            // 
            // btnOrDetailSearch
            // 
            this.btnOrDetailSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrDetailSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnOrDetailSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrDetailSearch.Location = new System.Drawing.Point(1015, 71);
            this.btnOrDetailSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrDetailSearch.Name = "btnOrDetailSearch";
            this.btnOrDetailSearch.Radius = 35;
            this.btnOrDetailSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnOrDetailSearch.Size = new System.Drawing.Size(120, 45);
            this.btnOrDetailSearch.Style = Sunny.UI.UIStyle.Custom;
            this.btnOrDetailSearch.TabIndex = 39;
            this.btnOrDetailSearch.Text = "搜尋";
            this.btnOrDetailSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrDetailSearch.Click += new System.EventHandler(this.btnOrDetailSearch_Click);
            // 
            // Clear
            // 
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.Clear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clear.Location = new System.Drawing.Point(627, 569);
            this.Clear.MinimumSize = new System.Drawing.Size(1, 1);
            this.Clear.Name = "Clear";
            this.Clear.Radius = 35;
            this.Clear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.Clear.Size = new System.Drawing.Size(120, 45);
            this.Clear.Style = Sunny.UI.UIStyle.Custom;
            this.Clear.TabIndex = 38;
            this.Clear.Text = "取消動作";
            this.Clear.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            this.uiDataGridView1.AllowUserToResizeColumns = false;
            this.uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.uiDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.dgvOrderEmp,
            this.dgvMemberID,
            this.Column1,
            this.dgvPrice,
            this.tablenum,
            this.dgvOrderDate,
            this.OrderStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 15.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(12, 128);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            this.uiDataGridView1.RectColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.ScrollBarColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiDataGridView1.ScrollBarStyleInherited = false;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(920, 250);
            this.uiDataGridView1.StripeEvenColor = System.Drawing.Color.Silver;
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiDataGridView1.TabIndex = 5;
            this.uiDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "訂單編號";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 117;
            // 
            // dgvOrderEmp
            // 
            this.dgvOrderEmp.HeaderText = "點餐人員";
            this.dgvOrderEmp.Name = "dgvOrderEmp";
            this.dgvOrderEmp.ReadOnly = true;
            this.dgvOrderEmp.Width = 117;
            // 
            // dgvMemberID
            // 
            this.dgvMemberID.HeaderText = "會員ID";
            this.dgvMemberID.Name = "dgvMemberID";
            this.dgvMemberID.ReadOnly = true;
            this.dgvMemberID.Width = 97;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "打折前金額";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 138;
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "打折後金額";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 138;
            // 
            // tablenum
            // 
            this.tablenum.HeaderText = "桌號";
            this.tablenum.Name = "tablenum";
            this.tablenum.ReadOnly = true;
            this.tablenum.Width = 75;
            // 
            // dgvOrderDate
            // 
            this.dgvOrderDate.HeaderText = "訂單日期";
            this.dgvOrderDate.Name = "dgvOrderDate";
            this.dgvOrderDate.ReadOnly = true;
            this.dgvOrderDate.Width = 117;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "訂單狀態";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.Width = 117;
            // 
            // uiDataGridView2
            // 
            this.uiDataGridView2.AllowUserToAddRows = false;
            this.uiDataGridView2.AllowUserToDeleteRows = false;
            this.uiDataGridView2.AllowUserToResizeColumns = false;
            this.uiDataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGridView2.BackgroundColor = System.Drawing.Color.Ivory;
            this.uiDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView2.ColumnHeadersHeight = 32;
            this.uiDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderIDDetail,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.unitPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView2.EnableHeadersVisualStyles = false;
            this.uiDataGridView2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiDataGridView2.Location = new System.Drawing.Point(12, 398);
            this.uiDataGridView2.Name = "uiDataGridView2";
            this.uiDataGridView2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.uiDataGridView2.RowTemplate.Height = 24;
            this.uiDataGridView2.ScrollBarColor = System.Drawing.SystemColors.InactiveCaption;
            this.uiDataGridView2.ScrollBarStyleInherited = false;
            this.uiDataGridView2.SelectedIndex = -1;
            this.uiDataGridView2.Size = new System.Drawing.Size(521, 150);
            this.uiDataGridView2.StripeEvenColor = System.Drawing.Color.Silver;
            this.uiDataGridView2.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uiDataGridView2.TabIndex = 6;
            this.uiDataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView2_CellClick);
            // 
            // OrderIDDetail
            // 
            this.OrderIDDetail.HeaderText = "訂單編號";
            this.OrderIDDetail.Name = "OrderIDDetail";
            this.OrderIDDetail.ReadOnly = true;
            this.OrderIDDetail.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "商品名稱";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "數量";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "單價";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.Width = 120;
            // 
            // cbSearchDetail
            // 
            this.cbSearchDetail.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSearchDetail.FormattingEnabled = true;
            this.cbSearchDetail.Location = new System.Drawing.Point(1157, 71);
            this.cbSearchDetail.Name = "cbSearchDetail";
            this.cbSearchDetail.Size = new System.Drawing.Size(119, 27);
            this.cbSearchDetail.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearch.Location = new System.Drawing.Point(1157, 106);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(229, 29);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(1158, 143);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 35;
            this.dtpStartDate.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(1157, 171);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 36;
            this.dtpEndDate.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(1157, 215);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 35;
            this.btnUpdate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnUpdate.Size = new System.Drawing.Size(120, 45);
            this.btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "儲存編輯";
            this.btnUpdate.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(781, 569);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 35;
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "刪除訂單";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(1047, 445);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 29);
            this.uiLabel8.TabIndex = 75;
            this.uiLabel8.Text = "訂單狀態";
            // 
            // OderSatus
            // 
            this.OderSatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OderSatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OderSatus.Location = new System.Drawing.Point(1157, 454);
            this.OderSatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OderSatus.MinimumSize = new System.Drawing.Size(1, 16);
            this.OderSatus.Name = "OderSatus";
            this.OderSatus.Padding = new System.Windows.Forms.Padding(5);
            this.OderSatus.ShowText = false;
            this.OderSatus.Size = new System.Drawing.Size(163, 29);
            this.OderSatus.TabIndex = 74;
            this.OderSatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.OderSatus.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(1047, 291);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 23);
            this.uiLabel10.TabIndex = 72;
            this.uiLabel10.Text = "訂單編號";
            // 
            // txtOrdertID
            // 
            this.txtOrdertID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrdertID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrdertID.Location = new System.Drawing.Point(1157, 299);
            this.txtOrdertID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrdertID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOrdertID.Name = "txtOrdertID";
            this.txtOrdertID.Padding = new System.Windows.Forms.Padding(5);
            this.txtOrdertID.ReadOnly = true;
            this.txtOrdertID.ShowText = false;
            this.txtOrdertID.Size = new System.Drawing.Size(163, 29);
            this.txtOrdertID.TabIndex = 71;
            this.txtOrdertID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOrdertID.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(1047, 368);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 66;
            this.uiLabel3.Text = "會員ID";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(1047, 330);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 23);
            this.uiLabel9.TabIndex = 64;
            this.uiLabel9.Text = "點餐人員";
            // 
            // txtOderMem
            // 
            this.txtOderMem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOderMem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOderMem.Location = new System.Drawing.Point(1157, 376);
            this.txtOderMem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOderMem.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOderMem.Name = "txtOderMem";
            this.txtOderMem.Padding = new System.Windows.Forms.Padding(5);
            this.txtOderMem.ShowText = false;
            this.txtOderMem.Size = new System.Drawing.Size(163, 29);
            this.txtOderMem.TabIndex = 60;
            this.txtOderMem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOderMem.Watermark = "";
            // 
            // txtOrderEmp
            // 
            this.txtOrderEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderEmp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrderEmp.Location = new System.Drawing.Point(1157, 338);
            this.txtOrderEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderEmp.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOrderEmp.Name = "txtOrderEmp";
            this.txtOrderEmp.Padding = new System.Windows.Forms.Padding(5);
            this.txtOrderEmp.ShowText = false;
            this.txtOrderEmp.Size = new System.Drawing.Size(163, 29);
            this.txtOrderEmp.TabIndex = 58;
            this.txtOrderEmp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOrderEmp.Watermark = "";
            // 
            // cbDetailProduct
            // 
            this.cbDetailProduct.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDetailProduct.FormattingEnabled = true;
            this.cbDetailProduct.Location = new System.Drawing.Point(1158, 543);
            this.cbDetailProduct.Name = "cbDetailProduct";
            this.cbDetailProduct.Size = new System.Drawing.Size(119, 27);
            this.cbDetailProduct.TabIndex = 77;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(1047, 547);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 78;
            this.uiLabel2.Text = "商品名稱";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(1047, 585);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 23);
            this.uiLabel11.TabIndex = 80;
            this.uiLabel11.Text = "數量";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuantity.Location = new System.Drawing.Point(1158, 585);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.txtQuantity.ShowText = false;
            this.txtQuantity.Size = new System.Drawing.Size(163, 29);
            this.txtQuantity.TabIndex = 79;
            this.txtQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtQuantity.Watermark = "";
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(1046, 489);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(111, 31);
            this.uiLabel12.TabIndex = 81;
            this.uiLabel12.Text = "明細";
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnDeleteDetail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteDetail.Location = new System.Drawing.Point(554, 408);
            this.btnDeleteDetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Radius = 20;
            this.btnDeleteDetail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnDeleteDetail.Size = new System.Drawing.Size(102, 35);
            this.btnDeleteDetail.Style = Sunny.UI.UIStyle.Custom;
            this.btnDeleteDetail.TabIndex = 82;
            this.btnDeleteDetail.Text = "餐品刪除";
            this.btnDeleteDetail.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(1047, 407);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 29);
            this.uiLabel4.TabIndex = 77;
            this.uiLabel4.Text = "桌號";
            // 
            // txtTableNum
            // 
            this.txtTableNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTableNum.Location = new System.Drawing.Point(1157, 415);
            this.txtTableNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableNum.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTableNum.Name = "txtTableNum";
            this.txtTableNum.Padding = new System.Windows.Forms.Padding(5);
            this.txtTableNum.ShowText = false;
            this.txtTableNum.Size = new System.Drawing.Size(163, 29);
            this.txtTableNum.TabIndex = 76;
            this.txtTableNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTableNum.Watermark = "";
            // 
            // btnEdit_Click
            // 
            this.btnEdit_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit_Click.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnEdit_Click.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit_Click.Location = new System.Drawing.Point(1015, 215);
            this.btnEdit_Click.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit_Click.Name = "btnEdit_Click";
            this.btnEdit_Click.Radius = 35;
            this.btnEdit_Click.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnEdit_Click.Size = new System.Drawing.Size(120, 45);
            this.btnEdit_Click.Style = Sunny.UI.UIStyle.Custom;
            this.btnEdit_Click.TabIndex = 83;
            this.btnEdit_Click.Text = "編輯";
            this.btnEdit_Click.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit_Click.Click += new System.EventHandler(this.btnEdit_Click_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.btnEdit_Click);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.txtTableNum);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.cbDetailProduct);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.OderSatus);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.txtOrdertID);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.txtOderMem);
            this.Controls.Add(this.txtOrderEmp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchDetail);
            this.Controls.Add(this.uiDataGridView2);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnOrDetailSearch);
            this.Controls.Add(this.BtnOrderback);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton BtnOrderback;
        private Sunny.UI.UIButton btnOrDetailSearch;
        private Sunny.UI.UIButton Clear;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private System.Windows.Forms.ComboBox cbSearchDetail;
        private Sunny.UI.UITextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderIDDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox OderSatus;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox txtOrdertID;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtOderMem;
        private Sunny.UI.UITextBox txtOrderEmp;
        private System.Windows.Forms.ComboBox cbDetailProduct;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txtQuantity;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton btnDeleteDetail;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtTableNum;
        private Sunny.UI.UIButton btnEdit_Click;
    }
}