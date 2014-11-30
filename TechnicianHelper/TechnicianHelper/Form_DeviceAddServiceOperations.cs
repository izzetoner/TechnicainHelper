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
    public partial class Form_DeviceAddServiceOperations : Form
    {
        public Form_DeviceAddServiceOperations()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\v11.0;AttachDbFilename=" + Application.StartupPath + @"\ComputerTechnicianHelperDB.mdf;Trusted_Connection=Yes;MultipleActiveResultSets=true;");
        Form_Main form_Main = (Form_Main)Application.OpenForms["Form_Main"]; 
        private void button_DeviceAddOperation_Click(object sender, EventArgs e)
        {
            if (textBox_ServiceOperations.Text!="")
            {
                using (SqlCommand cmd=new SqlCommand("Insert Into Services(customerID,DeviceID,ServiceOperations,ServiceDescription,ServiceStatus) Values(@customerID,@deviceID,@serviceOperations,@serviceDescription,@serviceStatus)",conn))
                {
                    cmd.Parameters.AddWithValue("@customerID",form_Main.label_CustomerID.Text);
                    cmd.Parameters.AddWithValue("@deviceID",form_Main.dataGridView_Devices[0,form_Main.dataGridView_Devices.CurrentCell.RowIndex].Value);
                    cmd.Parameters.AddWithValue("@serviceOperations", textBox_ServiceOperations.Text);
                    cmd.Parameters.AddWithValue("@serviceDescription", textBox_ServiceDescription.Text);
                    cmd.Parameters.AddWithValue("@serviceStatus", "Teslim Alındı");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cihaz İşlemi Başarıyla Eklendi","İşlem Eklendi!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Servis İşlemi Boş olamaz!","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form_DeviceAddServiceOperations_Load(object sender, EventArgs e)
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
    }
}
