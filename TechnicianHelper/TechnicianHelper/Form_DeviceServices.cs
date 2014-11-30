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
    public partial class Form_DeviceServices : Form
    {
        public Form_DeviceServices()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\v11.0;AttachDbFilename=" + Application.StartupPath + @"\ComputerTechnicianHelperDB.mdf;Trusted_Connection=Yes;MultipleActiveResultSets=true;");
        Form_Main form_Main = (Form_Main)Application.OpenForms["Form_Main"]; 
        void showAllServiceOperations()
        {
            using (SqlDataAdapter adtr = new SqlDataAdapter("Select ServiceID, ServiceOperations From Services Where customerID=@customerId and DeviceID=@deviceId order by ServiceID ", conn))
            {
                adtr.SelectCommand.Parameters.AddWithValue("@customerId",form_Main.label_CustomerID.Text);
                adtr.SelectCommand.Parameters.AddWithValue("@deviceID",form_Main.dataGridView_Devices[0,form_Main.dataGridView_Devices.CurrentCell.RowIndex].Value);
                DataSet dtst = new DataSet();
                adtr.Fill(dtst,"Services");
                dataGridView_DevicesOperations.DataSource = dtst.Tables["Services"];
                dataGridView_DevicesOperations.Columns[0].HeaderText = "Servis No";
                dataGridView_DevicesOperations.Columns[1].HeaderText = "Servis İşlemi";
                dataGridView_DevicesOperations.Columns[0].Width = 70;
                dataGridView_DevicesOperations.Columns[1].Width = 125;
                showServiceOperationsDetails();
            }            
        }
        void showServiceOperationsDetails()
        {
            panel_DeviceOperationDetails.Visible = true;
            button_DeviceUpdateOperations.Visible = true;
            button_DeviceDeleteOperation.Visible = true;
            try
            {
                using (SqlCommand cmd = new SqlCommand("Select ServiceOperations,ServiceStatus,ServiceDescription,ServiceDate,DebtAmount,PaymentAmount From Services Where ServiceID=@serviceID order by ServiceID desc", conn))
                {
                    cmd.Parameters.AddWithValue("@serviceID", dataGridView_DevicesOperations[0, dataGridView_DevicesOperations.CurrentCell.RowIndex].Value);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        textBox_ServiceOperations.Text = rdr["ServiceOperations"].ToString();
                        comboBox_ServiceStatus.SelectedIndex=comboBox_ServiceStatus.Items.IndexOf(rdr["ServiceStatus"].ToString());
                        textBox_ServiceDescription.Text = rdr["ServiceDescription"].ToString();
                        label_ServiceDate.Text = rdr["ServiceDate"].ToString();
                        textBox_DebtAmount.Text = rdr["DebtAmount"].ToString();
                        textBox_PaymentAmount.Text = rdr["PaymentAmount"].ToString();
                    }
                }
            }
            catch (NullReferenceException)
            {
                panel_DeviceOperationDetails.Visible = false;
                button_DeviceUpdateOperations.Visible = false;
                button_DeviceDeleteOperation.Visible = false;
            }
            
        }
        private void Form_DeviceServices_Load(object sender, EventArgs e)
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
            this.Text = "Cihaz İşlemleri : "+form_Main.dataGridView_Devices[1,form_Main.dataGridView_Devices.CurrentCell.RowIndex].Value;
            showAllServiceOperations();
        }
        private void textBox_ServiceOperations_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_AddDeviceOperation_Click(object sender, EventArgs e)
        {
            Form_DeviceAddServiceOperations form = new Form_DeviceAddServiceOperations();
            form.ShowDialog();
            showAllServiceOperations();
        }

        private void dataGridView_DevicesOperations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showServiceOperationsDetails();
        }

        private void button_DeviceUpdateOperations_Click(object sender, EventArgs e)
        {

            if (textBox_ServiceOperations.Text!="")
            {
                using (SqlCommand cmd=new SqlCommand("Update Services Set ServiceDescription=@serviceDescription,ServiceOperations=@serviceOperations,DebtAmount=@debtAmount,ServiceStatus=@serviceStatus,PaymentAmount=@paymentAmount Where ServiceID=@serviceID",conn))
                {
                    cmd.Parameters.AddWithValue("@serviceDescription",textBox_ServiceDescription.Text);
                    cmd.Parameters.AddWithValue("@serviceOperations",textBox_ServiceOperations.Text);
                    cmd.Parameters.AddWithValue("@debtAmount",Convert.ToDecimal(textBox_DebtAmount.Text));
                    cmd.Parameters.AddWithValue("@serviceStatus",comboBox_ServiceStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@paymentAmount",Convert.ToDecimal(textBox_PaymentAmount.Text));
                    cmd.Parameters.AddWithValue("@serviceID",dataGridView_DevicesOperations[0,dataGridView_DevicesOperations.CurrentCell.RowIndex].Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cihaz İşlemi Başarıyla Güncellendi","Güncelleme Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    form_Main.ShowAllCustomers();
                }
            }
            else
            {
                MessageBox.Show("Servis İşlemi Boş Geçilemez.","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button_DeviceDeleteOperation_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bu Cihaz işlemine ait tüm mali ve detay bilgileri gerçekten silmek istiyor musunuz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (message==DialogResult.Yes)
            {
                 using (SqlCommand cmd=new SqlCommand("Delete Services Where ServiceID=@serviceID",conn))
                 {
                     cmd.Parameters.AddWithValue("@serviceID", dataGridView_DevicesOperations[0, dataGridView_DevicesOperations.CurrentCell.RowIndex].Value);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Cihaz İşlemi Başarıyla Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
            }
            showAllServiceOperations();
        }

        private void dataGridView_DevicesOperations_KeyDown(object sender, KeyEventArgs e)
        {
            showServiceOperationsDetails();
        }

        private void dataGridView_DevicesOperations_KeyUp(object sender, KeyEventArgs e)
        {
            showServiceOperationsDetails();
        }
    }
}
