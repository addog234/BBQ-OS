using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableMaster.DO;


namespace TableMaster
{
    public class btn
    {
        private dododEmployee dEmployee; // 確保這裡正確初始化
        public class ComBoBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        public btn(dododEmployee employee)
        {
            dEmployee = employee;
        }
        public static void ShowMenuForm(Form currentForm)
        {
            OrderForm order = new OrderForm();
            order.ShowDialog();

            currentForm.Close(); // 關閉當前窗體
        }
        //public void 顯示權限功能(dododEmployee employee)
        //{
        //    // 根據員工權限設置按鈕可見性
        //    if (employee.Permission == "A") // admin
        //    {
        //        btnOrderdetail.Visible = true;
        //        btnStock.Visible = true;
        //        btn圖表.Visible = true;
        //        btn員工資料.Visible = true;
        //    }
        //    else if (employee.Permission == "B")
        //    {
        //        btnOrderdetail.Visible = true;
        //        btnStock.Visible = true;
        //        btn圖表.Visible = true;
        //        btn員工資料.Visible = false; // 假設 B 只有部分權限
        //    }
        //    else // C
        //    {
        //        btnOrderdetail.Visible = true;
        //        btnStock.Visible = true;
        //        btn圖表.Visible = false; // 假設 C 無權限查看圖表
        //        btn員工資料.Visible = false; // 假設 C 無權限查看員工資料
        //    }
        //}


    }  

}
