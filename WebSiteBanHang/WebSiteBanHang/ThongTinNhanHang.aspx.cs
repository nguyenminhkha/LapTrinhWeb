using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteBanHang
{
    public partial class ThongTinNhanHang : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        
        
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";TextBox2.Text = "";TextBox3.Text = "";
            DropDownList1.Text = null;
            DropDownList2.Text = null;
            lbxacnhan.Text = "Đặt hàng thành công !";
          

        }
    }
}