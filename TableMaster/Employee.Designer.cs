namespace TableMaster
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployee = new Sunny.UI.UIDataGridView();
            this.txtEmName = new Sunny.UI.UITextBox();
            this.txtEmPosition = new Sunny.UI.UITextBox();
            this.txtEmpPer = new Sunny.UI.UITextBox();
            this.txtEmpAddress = new Sunny.UI.UITextBox();
            this.txtEmpPassword = new Sunny.UI.UITextBox();
            this.txtempPhone = new Sunny.UI.UITextBox();
            this.txtEmpEmail = new Sunny.UI.UITextBox();
            this.dtpHiredate = new Sunny.UI.UIDatetimePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.btnINsert = new Sunny.UI.UIButton();
            this.btn搜尋 = new Sunny.UI.UIButton();
            this.btnStop = new Sunny.UI.UIButton();
            this.btnUpdate = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnBack = new Sunny.UI.UIButton();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.dtpResigndate = new Sunny.UI.UIDatetimePicker();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txtEmpID = new Sunny.UI.UITextBox();
            this.cbSearch = new Sunny.UI.UIComboBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txtSerch = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployee.ColumnHeadersHeight = 32;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvEmployee.Location = new System.Drawing.Point(12, 38);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RectColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.ScrollBarColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEmployee.ScrollBarStyleInherited = false;
            this.dgvEmployee.SelectedIndex = -1;
            this.dgvEmployee.Size = new System.Drawing.Size(1209, 675);
            this.dgvEmployee.StripeEvenColor = System.Drawing.Color.Silver;
            this.dgvEmployee.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // txtEmName
            // 
            this.txtEmName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmName.Location = new System.Drawing.Point(1351, 77);
            this.txtEmName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmName.ShowText = false;
            this.txtEmName.Size = new System.Drawing.Size(163, 29);
            this.txtEmName.TabIndex = 1;
            this.txtEmName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmName.Watermark = "";
            // 
            // txtEmPosition
            // 
            this.txtEmPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmPosition.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmPosition.Location = new System.Drawing.Point(1351, 120);
            this.txtEmPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmPosition.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmPosition.Name = "txtEmPosition";
            this.txtEmPosition.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmPosition.ShowText = false;
            this.txtEmPosition.Size = new System.Drawing.Size(163, 29);
            this.txtEmPosition.TabIndex = 3;
            this.txtEmPosition.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmPosition.Watermark = "";
            // 
            // txtEmpPer
            // 
            this.txtEmpPer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpPer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpPer.Location = new System.Drawing.Point(1351, 159);
            this.txtEmpPer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpPer.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmpPer.Name = "txtEmpPer";
            this.txtEmpPer.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmpPer.ShowText = false;
            this.txtEmpPer.Size = new System.Drawing.Size(163, 29);
            this.txtEmpPer.TabIndex = 3;
            this.txtEmpPer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmpPer.Watermark = "";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpAddress.Location = new System.Drawing.Point(1351, 302);
            this.txtEmpAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmpAddress.ShowText = false;
            this.txtEmpAddress.Size = new System.Drawing.Size(163, 29);
            this.txtEmpAddress.TabIndex = 3;
            this.txtEmpAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmpAddress.Watermark = "";
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpPassword.Location = new System.Drawing.Point(1351, 198);
            this.txtEmpPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmpPassword.ShowText = false;
            this.txtEmpPassword.Size = new System.Drawing.Size(163, 29);
            this.txtEmpPassword.TabIndex = 3;
            this.txtEmpPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmpPassword.Watermark = "";
            // 
            // txtempPhone
            // 
            this.txtempPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtempPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtempPhone.Location = new System.Drawing.Point(1351, 263);
            this.txtempPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtempPhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtempPhone.Name = "txtempPhone";
            this.txtempPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txtempPhone.ShowText = false;
            this.txtempPhone.Size = new System.Drawing.Size(163, 29);
            this.txtempPhone.TabIndex = 3;
            this.txtempPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtempPhone.Watermark = "";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpEmail.Location = new System.Drawing.Point(1351, 354);
            this.txtEmpEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmpEmail.ShowText = false;
            this.txtEmpEmail.Size = new System.Drawing.Size(163, 29);
            this.txtEmpEmail.TabIndex = 4;
            this.txtEmpEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmpEmail.Watermark = "";
            // 
            // dtpHiredate
            // 
            this.dtpHiredate.FillColor = System.Drawing.Color.White;
            this.dtpHiredate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpHiredate.Location = new System.Drawing.Point(1351, 393);
            this.dtpHiredate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHiredate.MaxLength = 19;
            this.dtpHiredate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpHiredate.Name = "dtpHiredate";
            this.dtpHiredate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpHiredate.Size = new System.Drawing.Size(200, 29);
            this.dtpHiredate.SymbolDropDown = 61555;
            this.dtpHiredate.SymbolNormal = 61555;
            this.dtpHiredate.SymbolSize = 24;
            this.dtpHiredate.TabIndex = 5;
            this.dtpHiredate.Text = "2024-10-30 15:25:48";
            this.dtpHiredate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpHiredate.Value = new System.DateTime(2024, 10, 30, 15, 25, 48, 961);
            this.dtpHiredate.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(1244, 77);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "姓名";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(1244, 120);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "職位";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(1244, 159);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "權限";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(1244, 198);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "密碼";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(1244, 269);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "電話";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(1244, 308);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "住址";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(1244, 360);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 23);
            this.uiLabel7.TabIndex = 12;
            this.uiLabel7.Text = "信箱";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(1244, 399);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.TabIndex = 13;
            this.uiLabel8.Text = "到職日期";
            // 
            // btnINsert
            // 
            this.btnINsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINsert.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnINsert.Location = new System.Drawing.Point(1248, 590);
            this.btnINsert.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnINsert.Name = "btnINsert";
            this.btnINsert.Size = new System.Drawing.Size(100, 35);
            this.btnINsert.TabIndex = 14;
            this.btnINsert.Text = "新增";
            this.btnINsert.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnINsert.Click += new System.EventHandler(this.btnINsert_Click);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(1248, 650);
            this.btn搜尋.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(100, 35);
            this.btn搜尋.TabIndex = 15;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(1370, 650);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 35);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "取消動作";
            this.btnStop.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(1370, 590);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "編輯";
            this.btnUpdate.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(1494, 590);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "移除";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(1494, 650);
            this.btnBack.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "回主選單";
            this.btnBack.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(1244, 447);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 23);
            this.uiLabel9.TabIndex = 21;
            this.uiLabel9.Text = "離職日期";
            // 
            // dtpResigndate
            // 
            this.dtpResigndate.FillColor = System.Drawing.Color.White;
            this.dtpResigndate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpResigndate.Location = new System.Drawing.Point(1351, 441);
            this.dtpResigndate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpResigndate.MaxLength = 19;
            this.dtpResigndate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpResigndate.Name = "dtpResigndate";
            this.dtpResigndate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpResigndate.Size = new System.Drawing.Size(200, 29);
            this.dtpResigndate.SymbolDropDown = 61555;
            this.dtpResigndate.SymbolNormal = 61555;
            this.dtpResigndate.SymbolSize = 24;
            this.dtpResigndate.TabIndex = 20;
            this.dtpResigndate.Text = "2024-10-30 15:25:48";
            this.dtpResigndate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpResigndate.Value = new System.DateTime(2024, 10, 30, 15, 25, 48, 961);
            this.dtpResigndate.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(1244, 44);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 23);
            this.uiLabel10.TabIndex = 23;
            this.uiLabel10.Text = "員工編號";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpID.Location = new System.Drawing.Point(1351, 38);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.ShowText = false;
            this.txtEmpID.Size = new System.Drawing.Size(163, 29);
            this.txtEmpID.TabIndex = 22;
            this.txtEmpID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmpID.Watermark = "";
            // 
            // cbSearch
            // 
            this.cbSearch.DataSource = null;
            this.cbSearch.FillColor = System.Drawing.Color.White;
            this.cbSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSearch.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbSearch.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbSearch.Location = new System.Drawing.Point(1351, 493);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearch.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbSearch.Size = new System.Drawing.Size(104, 29);
            this.cbSearch.SymbolSize = 24;
            this.cbSearch.TabIndex = 24;
            this.cbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSearch.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(1248, 499);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 23);
            this.uiLabel11.TabIndex = 25;
            this.uiLabel11.Text = "搜尋";
            // 
            // txtSerch
            // 
            this.txtSerch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerch.Location = new System.Drawing.Point(1351, 532);
            this.txtSerch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSerch.Name = "txtSerch";
            this.txtSerch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSerch.ShowText = false;
            this.txtSerch.Size = new System.Drawing.Size(163, 29);
            this.txtSerch.TabIndex = 3;
            this.txtSerch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSerch.Watermark = "";
            // 
            // Employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1604, 860);
            this.Controls.Add(this.txtSerch);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.dtpResigndate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.btnINsert);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.dtpHiredate);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmPosition);
            this.Controls.Add(this.txtEmpPer);
            this.Controls.Add(this.txtempPhone);
            this.Controls.Add(this.txtEmpPassword);
            this.Controls.Add(this.txtEmName);
            this.Controls.Add(this.dgvEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Employee";
            this.Text = "員工管理";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvEmployee;
        private Sunny.UI.UITextBox txtEmName;
        private Sunny.UI.UITextBox txtEmPosition;
        private Sunny.UI.UITextBox txtEmpPer;
        private Sunny.UI.UITextBox txtEmpAddress;
        private Sunny.UI.UITextBox txtEmpPassword;
        private Sunny.UI.UITextBox txtempPhone;
        private Sunny.UI.UITextBox txtEmpEmail;
        private Sunny.UI.UIDatetimePicker dtpHiredate;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIButton btnINsert;
        private Sunny.UI.UIButton btn搜尋;
        private Sunny.UI.UIButton btnStop;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnBack;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIDatetimePicker dtpResigndate;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox txtEmpID;
        private Sunny.UI.UIComboBox cbSearch;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txtSerch;
    }
}