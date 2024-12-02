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

namespace BirikimHesaplama
{
    public partial class Birikim : Form
    {
        public Birikim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Birikim;Integrated Security=True;Encrypt=False");

        private int currentAmount = 0;
        private int targetAmount = 0;

        private void bakiyeAl()
        {
            if (con.State == ConnectionState.Closed) { 
                con.Open(); }
            SqlCommand cmd = new SqlCommand("Select bakiye from Birikimler where id=1 ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                currentAmount = dr.GetInt32(0);
                lblBakiye.Text = currentAmount.ToString();
            }
            dr.Close();

        }

        private void HedefAl()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand com = new SqlCommand("Select Hedef from Birikimler where id=1 ", con);
            SqlDataReader drr = com.ExecuteReader();
            if (drr.Read())
            {
                targetAmount = drr.GetInt32(0);
                lblHedef.Text = targetAmount.ToString();
            }
            drr.Close();

        }
        private void bakiyeEkle()
        {
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            SqlCommand ccomm = new SqlCommand("UPDATE Birikimler SET Bakiye = Bakiye + @Ekmiktar WHERE id = @id", con);
            ccomm.Parameters.AddWithValue("@Ekmiktar",Convert.ToInt32(txtBakiyeEkle.Text));
            ccomm.Parameters.AddWithValue("@id",1);
            ccomm.ExecuteNonQuery();
            bakiyeAl();
        }
        private void hedefBelirle()
        {
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            SqlCommand ccomm = new SqlCommand("UPDATE Birikimler SET Hedef =  @hdf WHERE id = @id", con);
            ccomm.Parameters.AddWithValue("@hdf", Convert.ToInt32(txtHdfblr.Text));
            ccomm.Parameters.AddWithValue("@id", 1);
            ccomm.ExecuteNonQuery();
            HedefAl(); 
        }

        /*private void yuzdeHesap()
        {
           if (targetAmount > 0)
           {
            double yuzde = (currentAmount / targetAmount) * 0.10;
            lblyuzde.Text = $"Tamamlanan: %{yuzde:0.00}";
             }
        }*/
        private void Birikim_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            bakiyeAl();
            HedefAl();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            bakiyeEkle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBelirle_Click(object sender, EventArgs e)
        {
            hedefBelirle();
        }
    }
}
