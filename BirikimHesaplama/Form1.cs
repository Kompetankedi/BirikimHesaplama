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

        int currentAmount = 0;
        int targetAmount = 0;

        private void bakiyeAl()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select bakiye from Birikimler where id=1 ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    currentAmount = dr.GetInt32(0);
                    lblBakiye.Text = currentAmount.ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HedefAl()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bakiyeEkle()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                { con.Open(); }
                SqlCommand ccomm = new SqlCommand("UPDATE Birikimler SET Bakiye = Bakiye + @Ekmiktar WHERE id = @id", con);
                ccomm.Parameters.AddWithValue("@Ekmiktar", Convert.ToInt32(txtBakiyeEkle.Text));
                ccomm.Parameters.AddWithValue("@id", 1);
                ccomm.ExecuteNonQuery();
                bakiyeAl();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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

        private void yuzdeHesap()
        {
            try
            {
                if (targetAmount > 0)
                {
                    double yuzde = (double)currentAmount / targetAmount * 100;
                    string s = $"Tamamlanan: %{yuzde:0.00}";
                    lblyuzde.Text = s;
                    progressBar1.Value = Convert.ToInt32(yuzde);
                    bunifuCircleProgress1.Value=Convert.ToInt32(yuzde);
                    bunifuCircleProgress1.Text = yuzde.ToString();
                    if (progressBar1.Value >= 100) {
                        MessageBox.Show("Helal  bittirdin birikimi.");
                     
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Birikim_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            bakiyeAl();
            HedefAl();
            yuzdeHesap();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            bakiyeEkle();
            yuzdeHesap();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBelirle_Click(object sender, EventArgs e)
        {
            hedefBelirle();
            yuzdeHesap();
        }

        private void lblyuzde_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed) 
                con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Birikimler set Hedef =0,bakiye=0 where id=1",con);
            cmd.ExecuteNonQuery();
            bakiyeAl();
            HedefAl();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bakiyeEkle();
            yuzdeHesap();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            hedefBelirle();
            yuzdeHesap();
        }
    }
}
