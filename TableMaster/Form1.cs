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
using TableMaster.DBO;
using TableMaster.DO;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TableMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string EmployeeID = txtAconnt.Text;
            string EmpPassword = txtPassword.Text;

            if ((EmployeeID != "") && (EmpPassword != ""))
            {
                DataTable dt = dboQuery.SqlQuery($@"
                SELECT * FROM 

                dEmployees 
                WHERE EmployeeID = '{EmployeeID}' COLLATE SQL_Latin1_General_CP1_CS_AS 
                AND EmpPassword = '{EmpPassword}' COLLATE SQL_Latin1_General_CP1_CS_AS
            ");
                List<dododEmployee> lsdododEmployee = dododEmployee.GetdododEmployeeListFromDataTable(dt);
                if (lsdododEmployee.Count != 0)
                {
                    string Name = lsdododEmployee[0].EmpName;
                    string permission = lsdododEmployee[0].Permission;
                    MessageBox.Show($"登入成功，歡迎 {Name}！");
                    GlobaLVar.使用者名稱 = Name;
                    GlobaLVar.LV = permission;


                    Menu Menu = new Menu();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"登入faild");
                }
            }
            else
            {
                MessageBox.Show("登入欄位必填 !!");
            }
        }
           
        
        

    }
    
}
