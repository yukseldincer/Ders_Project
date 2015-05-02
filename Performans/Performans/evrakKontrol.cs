using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Performans
{
    public partial class evrakKontrol : Form
    {
        public evrakKontrol()
        {
            InitializeComponent();
            GetUser();
            GetDepartment();
        }
        #region BaglantıCümlesi
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Performans.accdb");
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO tEvrakKontrol(tUserId,IsPre,IsPost,IsCihaz,IsSair,IsKrm,Performance)VALUES (@Name,@IsPre,@IsPost,@IsCihaz,@IsSair,@IsKrm,@Performans)";
            cmd.Parameters.AddWithValue("Name", Convert.ToInt32(cbName.SelectedValue));
            if (cbDepartment.SelectedIndex==0)
            {
                cmd.Parameters.Add("IsPre", OleDbType.Integer, 1, "IsPre");
                cmd.Parameters.Add("IsPost", OleDbType.Integer, 0, "IsPost");
                cmd.Parameters.Add("IsCihaz", OleDbType.Integer, 0, "IsCihaz");
                cmd.Parameters.Add("IsSair", OleDbType.Integer, 0, "IsSair");
                cmd.Parameters.Add("IsKrm", OleDbType.Integer, 0, "IsKrm");
            }
            else if (cbDepartment.SelectedIndex==1)
            {
                cmd.Parameters.AddWithValue("IsPre", 0);
                cmd.Parameters.AddWithValue("IsPost", 1);
                cmd.Parameters.AddWithValue("IsCihaz", 0);
                cmd.Parameters.AddWithValue("IsSair", 0);
                cmd.Parameters.AddWithValue("IsKrm", 0);
            }
            else if (cbDepartment.SelectedIndex==2)
            {
                cmd.Parameters.AddWithValue("IsPre", 0);
                cmd.Parameters.AddWithValue("IsPost", 0);
                cmd.Parameters.AddWithValue("IsCihaz", 1);
                cmd.Parameters.AddWithValue("IsSair", 0);
                cmd.Parameters.AddWithValue("IsKrm", 0);
            }
            else if (cbDepartment.SelectedIndex==3)
            {
                cmd.Parameters.AddWithValue("IsPre", 0);
                cmd.Parameters.AddWithValue("IsPost", 0);
                cmd.Parameters.AddWithValue("IsCihaz", 0);
                cmd.Parameters.AddWithValue("IsSair", 1);
                cmd.Parameters.AddWithValue("IsKrm", 0);
            }
            else if (cbDepartment.SelectedIndex==4)
            {
                cmd.Parameters.AddWithValue("IsPre", 0);
                cmd.Parameters.AddWithValue("IsPost", 0);
                cmd.Parameters.AddWithValue("IsCihaz", 0);
                cmd.Parameters.AddWithValue("IsSair", 0);
                cmd.Parameters.AddWithValue("IsKrm", 1);
            }
            else
            {
                MessageBox.Show("Bölüm Seçiniz");
            }
            cmd.Parameters.AddWithValue("Performans", Convert.ToInt32(txtCount.Text));
           // cmd.Parameters.AddWithValue("Date", Convert.ToDateTime(dpDate.Value.ToShortDateString()));
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        #region Metotlar
        private void GetDepartment() 
        {
            cbDepartment.Items.Add("Pre-Paid");
            cbDepartment.Items.Add("Post-Paid");
            cbDepartment.Items.Add("Cihaz");
            cbDepartment.Items.Add("Sair");
            cbDepartment.Items.Add("Kurumsal");
        }
        private void GetUser()
        {
            cn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select UserName,tUserId from tUser where Departman=1", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbName.DataSource = dt;
            cbName.DisplayMember = "UserName";
            cbName.ValueMember = "tUserId";

        }
        #endregion
    }
}
