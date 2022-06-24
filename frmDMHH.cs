using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LopPTUD2022_Sang
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=SONTRINH-HP\\KTQDSERVER;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();

            sql = "Select MaNhom,MaHH, TenHH, dvt, DgVnd,SanXuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaNhom.Text = grdData.Rows[i].Cells["manhom"].Value.ToString(); 
            txtMaHH.Text= grdData.Rows[i].Cells["mahh"].Value.ToString();
            txtTenHH.Text= grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDvt.Text= grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtdgVnd.Text= grdData.Rows[i].Cells["dgVnd"].Value.ToString();
            txtSanXuat.Text= grdData.Rows[i].Cells["sanxuat"].Value.ToString();
        }
    }
}
