using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TableMaster
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();


            timer1.Start(); 

            //timer = new Timer();
            //timer.Interval = 1000;  
            //timer.Tick += Timer_Tick;
            //timer.Start();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string LV = GlobaLVar.LV;
            if (LV == "A")
            {
                btnToOder.Visible = true;
                btntoOderDetail.Visible = true;
                btnToProduct.Visible = true;
                btnToEmployee.Visible = true;
                btnToMember.Visible = true;
                btnToReport.Visible = true;
            }
            else if (LV == "B")
            {
                btnToOder.Visible = true;
                btntoOderDetail.Visible = true;
                btnToProduct.Visible = true;
                btnToEmployee.Visible = false;
                btnToMember.Visible = true;
                btnToReport.Visible = true;
            }
            else
            {
                btnToOder.Visible = true;
                btntoOderDetail.Visible = true;
                btnToProduct.Visible = false;
                btnToEmployee.Visible = false;
                btnToMember.Visible = false;
                btnToReport.Visible = false;
            }
           
        }



        private void btnToOder_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            OrderForm OrderForm = new OrderForm();
            OrderForm.TopLevel = false;
            OrderForm.Size = panel3.ClientSize;
            OrderForm.Dock = DockStyle.Fill;
            OrderForm.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(OrderForm);
            OrderForm.Show();
        }

        private void btntoOderDetail_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            OrderDetails order = new OrderDetails();
            order.TopLevel = false;
            order.Size = panel3.ClientSize;
            order.Dock = DockStyle.Fill;
            order.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(order);
            order.Show();
        }

        private void btnToProduct_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Product_Management Product = new Product_Management();
            Product.TopLevel = false;
            Product.Size = panel3.ClientSize;
            Product.Dock = DockStyle.Fill;
            Product.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(Product);
            Product.Show();
        }

        private void btnToEmployee_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Employee employee = new Employee();
            employee.TopLevel = false;
            employee.Size = panel3.ClientSize;
            employee.Dock = DockStyle.Fill;
            employee.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(employee);
            employee.Show();
        }

        private void btnToMember_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            dMember mem = new dMember();
            mem.TopLevel = false;
            mem.Dock = DockStyle.Fill;
            mem.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(mem);
            mem.Show();

        }

        private void btnToReport_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            BusinessChart bchart = new BusinessChart();
            bchart.TopLevel = false;
            bchart.Dock = DockStyle.Fill;
            bchart.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(bchart);
            bchart.Show();
        }

        private void btnTologout_Click(object sender, EventArgs e)
        {
            // 清除全球變數
            GlobaLVar.使用者名稱 = null;
            GlobaLVar.LV = null;
            
            // 回到登入頁面
            Form1 loginForm = new Form1();
            loginForm.Show();
            
            
            this.Close();
        }

        private void uiDatetimePicker1_ValueChanged(object sender, DateTime value)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ledTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");  
        }
    }
}
