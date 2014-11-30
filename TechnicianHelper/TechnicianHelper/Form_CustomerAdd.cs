using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TechnicianHelper
{
    public partial class Form_CustomerAdd : Form
    {
        public Form_CustomerAdd()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\v11.0;AttachDbFilename=" + Application.StartupPath + @"\ComputerTechnicianHelperDB.mdf;Trusted_Connection=Yes;MultipleActiveResultSets=true;");
        Form_Main form_Main = (Form_Main)Application.OpenForms["Form_Main"]; 
        private void button_Addcustomer_Click(object sender, EventArgs e)
        {
            string error = "Aşağıdaki Alanlar Boş geçilemez.";
            if (textBox_customerName.Text == null)
                error += "\n Müşteri Adı";
            if (textBox_customerTel.Text == null)
                error += "\n Müşteri Tel.";
            if (radioButton_Female.Checked != true && radioButton_Male.Checked != true)
                error += "\n Cinsiyet";
            if (error=="Aşağıdaki Alanlar Boş geçilemez.")
            {
                using (SqlCommand checkTel = new SqlCommand("Select customerTel From customers where customerTel=@customerTel",conn))
                {
                    checkTel.Parameters.AddWithValue("@customerTel",textBox_customerTel.Text);
                    SqlDataReader rdr = checkTel.ExecuteReader();
                    if (rdr.Read())
                    {
                        MessageBox.Show("Veritabanında zaten " + textBox_customerTel.Text + " telefon numaralı bir kayıt mevcut. Aynı Telefon numarası ile birden fazla müşteri olamaz!");
                        textBox_customerTel.Focus();                    
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert Into customers (customerName,customerTel,customerAdress,customerMail,customerGender) Values(@customerName,@customerTel,@customerAdress,@customerMail,@customerGender)", conn))
                        {
                            try
                            {
                                cmd.Parameters.AddWithValue("@customerName",textBox_customerName.Text);
                                cmd.Parameters.AddWithValue("@customerTel",textBox_customerTel.Text);
                                cmd.Parameters.AddWithValue("@customerAdress",textBox_customerAdress.Text);
                                cmd.Parameters.AddWithValue("@customerMail",textBox_customerMail.Text);
                                bool customerGender=true;
                                if(radioButton_Female.Checked==true)
                                    customerGender=false;
                                cmd.Parameters.AddWithValue("@customerGender",customerGender);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Müşteri Başarıyla Kaydedildi.","Kaydetme Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                           
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show("Müşteri Kaydedilemedi. Hata Çıktısı : \n"+err.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(error,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void Form_customerAdd_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız. Hata Kodu :\n" + err);
            }
        }

        private void textBox_customerTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
