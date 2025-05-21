namespace TableMaster
{
    partial class OrderForm
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
            this.listViewChicken = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listViewSeafood = new System.Windows.Forms.ListView();
            this.listViewDessert = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewLamb = new System.Windows.Forms.ListView();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.ColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewBeef = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewPork = new System.Windows.Forms.ListView();
            this.listViewDrink = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMemID = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnCheckorder = new Sunny.UI.UIButton();
            this.txtTableNum = new Sunny.UI.UITextBox();
            this.chkVip = new Sunny.UI.UICheckBox();
            this.btnOrderOK = new Sunny.UI.UIButton();
            this.lbl總額 = new Sunny.UI.UILabel();
            this.btnOrderClear = new Sunny.UI.UIButton();
            this.btnOrderRM = new Sunny.UI.UIButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.TCOrderlMenu = new Sunny.UI.UITabControlMenu();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.TCOrderlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewChicken
            // 
            this.listViewChicken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChicken.HideSelection = false;
            this.listViewChicken.Location = new System.Drawing.Point(0, 0);
            this.listViewChicken.Name = "listViewChicken";
            this.listViewChicken.Size = new System.Drawing.Size(1032, 506);
            this.listViewChicken.TabIndex = 8;
            this.listViewChicken.UseCompatibleStateImageBehavior = false;
            this.listViewChicken.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listViewSeafood);
            this.tabPage4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage4.Location = new System.Drawing.Point(201, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1032, 506);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "現撈海鮮";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listViewSeafood
            // 
            this.listViewSeafood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSeafood.HideSelection = false;
            this.listViewSeafood.Location = new System.Drawing.Point(0, 0);
            this.listViewSeafood.Name = "listViewSeafood";
            this.listViewSeafood.Size = new System.Drawing.Size(1032, 506);
            this.listViewSeafood.TabIndex = 8;
            this.listViewSeafood.UseCompatibleStateImageBehavior = false;
            this.listViewSeafood.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // listViewDessert
            // 
            this.listViewDessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDessert.HideSelection = false;
            this.listViewDessert.Location = new System.Drawing.Point(0, 0);
            this.listViewDessert.Name = "listViewDessert";
            this.listViewDessert.Size = new System.Drawing.Size(1032, 506);
            this.listViewDessert.TabIndex = 8;
            this.listViewDessert.UseCompatibleStateImageBehavior = false;
            this.listViewDessert.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewLamb);
            this.tabPage3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(201, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1032, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "紐西蘭小羔羊";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewLamb
            // 
            this.listViewLamb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLamb.HideSelection = false;
            this.listViewLamb.Location = new System.Drawing.Point(0, 0);
            this.listViewLamb.Name = "listViewLamb";
            this.listViewLamb.Size = new System.Drawing.Size(1032, 506);
            this.listViewLamb.TabIndex = 8;
            this.listViewLamb.UseCompatibleStateImageBehavior = false;
            this.listViewLamb.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProductID,
            this.ColProductName,
            this.Colquantity,
            this.ColPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 0);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(414, 506);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 1;
            this.uiDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellClick);
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick_1);
            this.uiDataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellEndEdit);
            this.uiDataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.uiDataGridView1_CurrentCellDirtyStateChanged);
            // 
            // ColProductID
            // 
            this.ColProductID.HeaderText = "產品編號";
            this.ColProductID.Name = "ColProductID";
            this.ColProductID.ReadOnly = true;
            // 
            // ColProductName
            // 
            this.ColProductName.HeaderText = "產品名稱";
            this.ColProductName.Name = "ColProductName";
            this.ColProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Colquantity
            // 
            this.Colquantity.HeaderText = "數量";
            this.Colquantity.Name = "Colquantity";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "價格";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewBeef);
            this.tabPage1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1032, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "高級日本牛";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewBeef
            // 
            this.listViewBeef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBeef.HideSelection = false;
            this.listViewBeef.Location = new System.Drawing.Point(0, 0);
            this.listViewBeef.Name = "listViewBeef";
            this.listViewBeef.Size = new System.Drawing.Size(1032, 506);
            this.listViewBeef.TabIndex = 7;
            this.listViewBeef.UseCompatibleStateImageBehavior = false;
            this.listViewBeef.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewPork);
            this.tabPage2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1032, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "伊比利黑豬";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewPork
            // 
            this.listViewPork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPork.HideSelection = false;
            this.listViewPork.Location = new System.Drawing.Point(0, 0);
            this.listViewPork.Name = "listViewPork";
            this.listViewPork.Size = new System.Drawing.Size(1032, 506);
            this.listViewPork.TabIndex = 7;
            this.listViewPork.UseCompatibleStateImageBehavior = false;
            this.listViewPork.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // listViewDrink
            // 
            this.listViewDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDrink.HideSelection = false;
            this.listViewDrink.Location = new System.Drawing.Point(0, 0);
            this.listViewDrink.Name = "listViewDrink";
            this.listViewDrink.Size = new System.Drawing.Size(1032, 506);
            this.listViewDrink.TabIndex = 8;
            this.listViewDrink.UseCompatibleStateImageBehavior = false;
            this.listViewDrink.ItemActivate += new System.EventHandler(this.lvAddProductToOrder_ItemActivate);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMemID);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.btnCheckorder);
            this.panel2.Controls.Add(this.txtTableNum);
            this.panel2.Controls.Add(this.chkVip);
            this.panel2.Controls.Add(this.btnOrderOK);
            this.panel2.Controls.Add(this.lbl總額);
            this.panel2.Controls.Add(this.btnOrderClear);
            this.panel2.Controls.Add(this.btnOrderRM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1651, 168);
            this.panel2.TabIndex = 12;
            // 
            // txtMemID
            // 
            this.txtMemID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemID.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMemID.Location = new System.Drawing.Point(1482, 17);
            this.txtMemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Padding = new System.Windows.Forms.Padding(5);
            this.txtMemID.ShowText = false;
            this.txtMemID.Size = new System.Drawing.Size(87, 29);
            this.txtMemID.TabIndex = 9;
            this.txtMemID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMemID.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(1405, 23);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(85, 23);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "會員編號";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(1166, 25);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(42, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "桌號";
            // 
            // btnCheckorder
            // 
            this.btnCheckorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCheckorder.FillDisableColor = System.Drawing.Color.Silver;
            this.btnCheckorder.FillHoverColor = System.Drawing.Color.Olive;
            this.btnCheckorder.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheckorder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckorder.Location = new System.Drawing.Point(60, 27);
            this.btnCheckorder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCheckorder.Name = "btnCheckorder";
            this.btnCheckorder.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCheckorder.Size = new System.Drawing.Size(100, 35);
            this.btnCheckorder.TabIndex = 2;
            this.btnCheckorder.Text = "查看訂單";
            this.btnCheckorder.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckorder.Click += new System.EventHandler(this.btnCheckorder_Click);
            // 
            // txtTableNum
            // 
            this.txtTableNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableNum.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTableNum.Location = new System.Drawing.Point(1215, 17);
            this.txtTableNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableNum.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTableNum.Name = "txtTableNum";
            this.txtTableNum.Padding = new System.Windows.Forms.Padding(5);
            this.txtTableNum.ShowText = false;
            this.txtTableNum.Size = new System.Drawing.Size(87, 29);
            this.txtTableNum.TabIndex = 7;
            this.txtTableNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTableNum.Watermark = "";
            // 
            // chkVip
            // 
            this.chkVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkVip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkVip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkVip.Location = new System.Drawing.Point(1339, 19);
            this.chkVip.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(60, 29);
            this.chkVip.TabIndex = 2;
            this.chkVip.Text = "VIP";
            // 
            // btnOrderOK
            // 
            this.btnOrderOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderOK.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderOK.Location = new System.Drawing.Point(841, 55);
            this.btnOrderOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrderOK.Name = "btnOrderOK";
            this.btnOrderOK.Size = new System.Drawing.Size(128, 35);
            this.btnOrderOK.TabIndex = 6;
            this.btnOrderOK.Text = "確認點餐";
            this.btnOrderOK.TipsFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderOK.Click += new System.EventHandler(this.btnOrderOK_Click);
            // 
            // lbl總額
            // 
            this.lbl總額.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總額.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl總額.Location = new System.Drawing.Point(1249, 77);
            this.lbl總額.Name = "lbl總額";
            this.lbl總額.Size = new System.Drawing.Size(226, 35);
            this.lbl總額.TabIndex = 5;
            this.lbl總額.Text = "總計:";
            // 
            // btnOrderClear
            // 
            this.btnOrderClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderClear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderClear.Location = new System.Drawing.Point(568, 55);
            this.btnOrderClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrderClear.Name = "btnOrderClear";
            this.btnOrderClear.Size = new System.Drawing.Size(128, 35);
            this.btnOrderClear.TabIndex = 4;
            this.btnOrderClear.Text = "清空所有訂單";
            this.btnOrderClear.TipsFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderClear.Click += new System.EventHandler(this.btnOrderClear_Click);
            // 
            // btnOrderRM
            // 
            this.btnOrderRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderRM.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderRM.Location = new System.Drawing.Point(702, 55);
            this.btnOrderRM.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrderRM.Name = "btnOrderRM";
            this.btnOrderRM.Size = new System.Drawing.Size(128, 35);
            this.btnOrderRM.TabIndex = 3;
            this.btnOrderRM.Text = "移除品項";
            this.btnOrderRM.TipsFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderRM.Click += new System.EventHandler(this.btnOrderRM_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listViewChicken);
            this.tabPage5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage5.Location = new System.Drawing.Point(201, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1032, 506);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "住在山上的雞";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listViewDrink);
            this.tabPage6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage6.Location = new System.Drawing.Point(201, 0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1032, 506);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "現調飲品";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.listViewDessert);
            this.tabPage7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage7.Location = new System.Drawing.Point(201, 0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1032, 506);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "讚讚甜點";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // TCOrderlMenu
            // 
            this.TCOrderlMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TCOrderlMenu.Controls.Add(this.tabPage1);
            this.TCOrderlMenu.Controls.Add(this.tabPage2);
            this.TCOrderlMenu.Controls.Add(this.tabPage3);
            this.TCOrderlMenu.Controls.Add(this.tabPage4);
            this.TCOrderlMenu.Controls.Add(this.tabPage5);
            this.TCOrderlMenu.Controls.Add(this.tabPage6);
            this.TCOrderlMenu.Controls.Add(this.tabPage7);
            this.TCOrderlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCOrderlMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TCOrderlMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TCOrderlMenu.Location = new System.Drawing.Point(0, 0);
            this.TCOrderlMenu.Multiline = true;
            this.TCOrderlMenu.Name = "TCOrderlMenu";
            this.TCOrderlMenu.SelectedIndex = 0;
            this.TCOrderlMenu.Size = new System.Drawing.Size(1233, 506);
            this.TCOrderlMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TCOrderlMenu.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TCOrderlMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uiDataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1651, 506);
            this.splitContainer1.SplitterDistance = 1233;
            this.splitContainer1.TabIndex = 11;
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1651, 674);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.TCOrderlMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewChicken;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listViewSeafood;
        private System.Windows.Forms.ListView listViewDessert;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewLamb;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewBeef;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewPork;
        private System.Windows.Forms.ListView listViewDrink;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtTableNum;
        private Sunny.UI.UICheckBox chkVip;
        private Sunny.UI.UIButton btnOrderOK;
        private Sunny.UI.UILabel lbl總額;
        private Sunny.UI.UIButton btnOrderClear;
        private Sunny.UI.UIButton btnCheckorder;
        private Sunny.UI.UIButton btnOrderRM;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private Sunny.UI.UITabControlMenu TCOrderlMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtMemID;
    }
}