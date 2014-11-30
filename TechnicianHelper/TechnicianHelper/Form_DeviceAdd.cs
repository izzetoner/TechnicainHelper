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
    public partial class Form_DeviceAdd : Form
    {
        public Form_DeviceAdd()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\v11.0;AttachDbFilename=" + Application.StartupPath + @"\ComputerTechnicianHelperDB.mdf;Trusted_Connection=Yes;MultipleActiveResultSets=true;");
        Form_Main form_Main = (Form_Main)Application.OpenForms["Form_Main"]; 
        private void Form_DeviceAdd_Load(object sender, EventArgs e)
        {
            #region OpenConnection
            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız. Hata Kodu :\n" + err);
            }
            #endregion
        }

        private void button_DeviceAdd_Click(object sender, EventArgs e)
        {
            if (textBox_DeviceBrandModel.Text!="")
            {
                using (SqlCommand cmd=new SqlCommand("Insert Into Devices (customerID,DeviceBrandModel,DeviceDescription) Values(@customerID,@deviceBrandModel,@deviceDescription)",conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@customerID", form_Main.label_CustomerID.Text);
                        cmd.Parameters.AddWithValue("@deviceBrandModel", textBox_DeviceBrandModel.Text);
                        cmd.Parameters.AddWithValue("@deviceDescription",textBox_DeviceDescription.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cihaz Başarıyla kaydedildi.","Kayıt Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Cihazı kaydedilemedi. Hata Çıktısı: \n"+err.Message,"Kayıt Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    this.Close();                 
                }
            }
            else
            {
                MessageBox.Show("Cihaz Marka/Model boş geçilemez.","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
