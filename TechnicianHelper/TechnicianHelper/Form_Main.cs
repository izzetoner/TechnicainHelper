using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.IO;
using System.Diagnostics;




namespace TechnicianHelper
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=(localdb)\v11.0;AttachDbFilename=" + Application.StartupPath + @"\ComputerTechnicianHelperDB.mdf;Trusted_Connection=Yes;MultipleActiveResultSets=true;");


        void ShowDeviceDetails()
        {         
            try
            {
                using (SqlCommand cmd = new SqlCommand("Select DeviceBrandModel,DeviceCreateDate,DeviceDescription From Devices where CustomerID=@CustomerID and DeviceID=@deviceID", conn))
                {
                    cmd.Parameters.AddWithValue("@deviceID", dataGridView_Devices[0, dataGridView_Devices.CurrentCell.RowIndex].Value);
                    cmd.Parameters.AddWithValue("@CustomerID", label_CustomerID.Text);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        textBox_DeviceBrandModel.Text = rdr["DeviceBrandModel"].ToString();
                        label_DeviceCreateDate.Text = "Kayıt Tarihi         :     " + rdr["DeviceCreateDate"].ToString();
                        textBox_DeviceDescription.Text = rdr["DeviceDescription"].ToString();
                    }
                }
                using (SqlCommand cmdBalance = new SqlCommand("Select sum(PaymentAmount),sum(DebtAmount) from Services Where CustomerID=@CustomerID and DeviceID=@deviceID", conn))
                {
                    cmdBalance.Parameters.AddWithValue("@CustomerID", label_CustomerID.Text);
                    cmdBalance.Parameters.AddWithValue("@deviceID", dataGridView_Devices[0, dataGridView_Devices.CurrentCell.RowIndex].Value);
                    SqlDataReader rdrBalance = cmdBalance.ExecuteReader();
                    if (rdrBalance.Read())
                    {
                        try
                        {
                            decimal payment = Convert.ToDecimal(rdrBalance[0].ToString());
                            decimal debt = Convert.ToDecimal(rdrBalance[1].ToString());
                            decimal Balance = payment - debt;
                            label_DeviceBalance.Text = "Cihaz Bakiye  :       " + Balance.ToString() + " TL";
                        }
                        catch (FormatException)
                        {
                            label_DeviceBalance.Text = "Cihaz Bakiye  :       0.000 TL";
                        }
                    }
                }
            }
            catch
            {
                //Do nothing
            }
        }
      public  void ShowAllCustomers()
        {
            using (SqlDataAdapter adtr=new SqlDataAdapter("Select CustomerName,CustomerTel From Customers",conn))
            {
                DataSet dtst = new DataSet();
                adtr.Fill(dtst,"Customers");
                dataGridView_Customers.DataSource = dtst.Tables["Customers"];
                dataGridView_Customers.Columns[0].Width = 166;
                dataGridView_Customers.Columns[1].Width=83;
                dataGridView_Customers.Columns[0].HeaderText="Müşteri Adı";
                dataGridView_Customers.Columns[1].HeaderText = "Müşteri Tel";
            }
            if (dataGridView_Customers.RowCount==0)
            {
                panel_CustomerGenderWarning.Visible = false;
                panel_CustomerWarning.Visible = false;
                groupBox_Device.Visible = false;
            }
            else
            {
                panel_CustomerGenderWarning.Visible = true;
                panel_CustomerWarning.Visible = true;
                groupBox_Device.Visible = true;
            }
            ShowCustomerDetails();
        }
        void ShowAllDevices()
        {
            using (SqlDataAdapter adtr=new SqlDataAdapter("Select DeviceID,DeviceBrandModel From Devices Where CustomerID=@CustomerID",conn))
            {
                adtr.SelectCommand.Parameters.AddWithValue("@CustomerID",label_CustomerID.Text);
                DataSet dtst = new DataSet();
                adtr.Fill(dtst,"CustomerName");
                dataGridView_Devices.DataSource=dtst.Tables["CustomerName"];
                dataGridView_Devices.Columns[0].HeaderText = "Ürün No";
                dataGridView_Devices.Columns[1].HeaderText = "Ürün Marka/Model";
                dataGridView_Devices.Columns[0].Width = 70;
                dataGridView_Devices.Columns[1].Width = 178;
                if (dataGridView_Devices.RowCount != 0)
                {
                    ShowDeviceDetails();
                    panel_Devices.Visible = true;
                    button_DeviceUpdate.Visible = true;
                    button_DeviceDelete.Visible = true;
                    button_DeviceService.Visible = true;
                }
                else
                {
                    panel_Devices.Visible = false;
                    button_DeviceUpdate.Visible = false;
                    button_DeviceDelete.Visible = false;
                    button_DeviceService.Visible = false;
                } 
            }

        }
       public void ShowCustomerDetails()
        {
            using (SqlCommand cmd=new SqlCommand("Select * From Customers Where CustomerTel=@CustomerTel",conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@CustomerTel", dataGridView_Customers[1, dataGridView_Customers.CurrentCell.RowIndex].Value);
                }
                catch (Exception)
                {

                    cmd.Parameters.AddWithValue("@CustomerTel",textBox_CustomerTel.Text);
                }
               
                SqlDataReader rdr=cmd.ExecuteReader();
                if (rdr.Read())
                {
                    label_CustomerID.Text = rdr["CustomerID"].ToString();
                    textBox_CustomerName.Text=rdr["CustomerName"].ToString();
                    textBox_CustomerTel.Text=rdr["CustomerTel"].ToString();
                    textBox_CustomerAdress.Text=rdr["CustomerAdress"].ToString();
                    textBox_CustomerMail.Text = rdr["CustomerMail"].ToString();
                    if (Convert.ToBoolean(rdr["CustomerGender"].ToString())==true)
                        radioButton_Male.Checked = true;
                    else
                        radioButton_Female.Checked = true;
                }
                using (SqlCommand cmdBalance=new SqlCommand("Select sum(PaymentAmount),sum(DebtAmount) from Services Where CustomerID=@CustomerID",conn))
                {                    
                    cmdBalance.Parameters.AddWithValue("@CustomerID",label_CustomerID.Text);
                    SqlDataReader rdrBalance = cmdBalance.ExecuteReader();
                    if (rdrBalance.Read())
                    {
                        try
                        {
                            decimal payment = Convert.ToDecimal(rdrBalance[0].ToString());
                            decimal debt = Convert.ToDecimal(rdrBalance[1].ToString());
                            decimal Balance = payment - debt;
                            label_CustomerBalance.Text = "Genel Bakiye  :   " + Balance.ToString() + " TL";
                        }
                        catch (FormatException)
                        {
                            label_CustomerBalance.Text = "Genel Bakiye  :   0.000 TL";
                        } 
                    }
                    
                }
                ShowAllDevices();
            }
        }
        void SearchCustomers()
        {
            using (SqlDataAdapter adtr=new SqlDataAdapter("Select CustomerName,CustomerTel From Customers Where CustomerName Like @CustomerName and CustomerTel Like @CustomerTel",conn))
            {
                adtr.SelectCommand.Parameters.AddWithValue("@CustomerName", textBox_SearchCustomerName.Text.Trim() + "%");
                adtr.SelectCommand.Parameters.AddWithValue("@CustomerTel", textBox_SearchCustomerTel.Text.Trim() + "%");
                DataSet dtst = new DataSet();
                adtr.Fill(dtst,"Customers");
                dataGridView_Customers.DataSource = dtst.Tables["Customers"];
                dataGridView_Customers.Columns[0].Width = 166;
                dataGridView_Customers.Columns[1].Width=83;
                dataGridView_Customers.Columns[0].HeaderText="Müşteri Adı";
                dataGridView_Customers.Columns[1].HeaderText = "Müşteri Tel";
            }
            if (dataGridView_Customers.RowCount != 0)
            {
                panel_CustomerGenderWarning.Visible = true;
                panel_CustomerWarning.Visible = true;
                button_UpdateCustomer.Visible = true;
                button_CustomerDelete.Visible = true;
                groupBox_Device.Visible = true;
                ShowCustomerDetails();
                
            }
            else
            {
                panel_CustomerGenderWarning.Visible = false;
                groupBox_Device.Visible = false;
                button_CustomerDelete.Visible = false;
                button_UpdateCustomer.Visible = false;
                panel_Devices.Visible = true;
                panel_CustomerWarning.Visible = false;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
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
            ShowAllCustomers();
        }
        private void button_ShowAllCustomer_Click(object sender, EventArgs e)
        {
            textBox_SearchCustomerName.ResetText();
            textBox_SearchCustomerTel.ResetText();
        }

        private void textBox_SearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            SearchCustomers();
        }

        private void textBox_SearchCustomerTel_TextChanged(object sender, EventArgs e)
        {
            SearchCustomers();
        }

        private void dataGridView_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCustomerDetails();
        }

        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            Form_CustomerAdd form = new Form_CustomerAdd();
            form.ShowDialog();
            ShowAllCustomers();
        }

        private void button_UpdateCustomer_Click(object sender, EventArgs e)
        {
             string error = "Aşağıdaki Alanlar Boş geçilemez.";
            if (textBox_CustomerName.Text == "")
                error += "\n Müşteri Adı";
            if (textBox_CustomerTel.Text == "")
                error += "\n Müşteri Tel.";
            if (radioButton_Female.Checked != true && radioButton_Male.Checked != true)
                error += "\n Cinsiyet";
            if (error == "Aşağıdaki Alanlar Boş geçilemez.")
            {
                        using (SqlCommand cmd = new SqlCommand("Update Customers Set CustomerName=@CustomerName, CustomerTel=@CustomerTel, CustomerAdress=@CustomerAdress, CustomerMail=@CustomerMail,CustomerGender=@CustomerGender WHERE CustomerID=@CustomerID ",conn))
                        {
                            try
                            {                     
                                cmd.Parameters.AddWithValue("@CustomerID",label_CustomerID.Text);
                                cmd.Parameters.AddWithValue("@CustomerName", textBox_CustomerName.Text);
                                cmd.Parameters.AddWithValue("@CustomerTel", textBox_CustomerTel.Text);
                                cmd.Parameters.AddWithValue("@CustomerAdress", textBox_CustomerAdress.Text);
                                cmd.Parameters.AddWithValue("@CustomerMail", textBox_CustomerMail.Text);
                                bool CustomerGender = true;
                                if (radioButton_Female.Checked == true)
                                    CustomerGender = false;
                                cmd.Parameters.AddWithValue("@CustomerGender", CustomerGender);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Müşteri Güncelleme Başarılı!","Güncelleme Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                ShowAllCustomers();
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show("Müşteri Güncelleme Başarısız. Hata çıktısı : \n"+err.Message);
                            }  
                         
                       }
               }
               else
               {
                   MessageBox.Show(error,"Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               }
          }

        private void dataGridView_Devices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDeviceDetails();
        }

        private void button_DeviceAdd_Click(object sender, EventArgs e)
        {
            Form_DeviceAdd form = new Form_DeviceAdd();
            form.ShowDialog();
            ShowAllDevices();
        }

        private void button_DeviceUpdate_Click(object sender, EventArgs e)
        {
            if (textBox_DeviceBrandModel.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand("Update Devices Set DeviceBrandModel=@deviceBrandModel,DeviceDescription=@deviceDescription where DeviceID=@deviceID",conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@deviceBrandModel", textBox_DeviceBrandModel.Text);
                        cmd.Parameters.AddWithValue("@deviceDescription", textBox_DeviceDescription.Text);
                        cmd.Parameters.AddWithValue("@deviceID", dataGridView_Devices[0, dataGridView_Devices.CurrentCell.RowIndex].Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cihaz Güncelleme Başarılı!","Güncelleme Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Cihaz güncelleme başarısız. Hata Çıktısı : \n" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show("Cihaz Marka/Model boş geçilemz.","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            ShowAllDevices();
        }

        private void button_DeviceService_Click(object sender, EventArgs e)
        {
            Form_DeviceServices form = new Form_DeviceServices();
            form.ShowDialog();
        }

        private void button_DeviceDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bu Cihaza ait tüm mali ve detay bilgileri gerçekten silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("Delete Devices Where DeviceID=@deviceID", conn))
                {
                    cmd.Parameters.AddWithValue("@deviceID",dataGridView_Devices[0,dataGridView_Devices.CurrentCell.RowIndex].Value);
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand("Delete Services Where DeviceID=@deviceID", conn))
                {
                    cmd.Parameters.AddWithValue("@deviceID", dataGridView_Devices[0, dataGridView_Devices.CurrentCell.RowIndex].Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cihaz Başarıyla Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ShowAllDevices();
            }
        }

        private void button_CustomerDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Bu Müşteriye ait tüm mali ve detay bilgileri gerçekten silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("Delete Devices Where CustomerID=@CustomerID", conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID",label_CustomerID.Text);
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand("Delete Services Where CustomerID=@CustomerID", conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID",label_CustomerID.Text);
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand("Delete Customers Where CustomerID=@CustomerID", conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", label_CustomerID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Başarıyla Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ShowAllCustomers();
            }
        }

        private void dataGridView_Customers_KeyUp(object sender, KeyEventArgs e)
        {
            ShowCustomerDetails();
        }

        private void dataGridView_Customers_KeyDown(object sender, KeyEventArgs e)
        {
            ShowCustomerDetails();
        }

        private void dataGridView_Devices_KeyDown(object sender, KeyEventArgs e)
        {
            ShowDeviceDetails();
        }

        private void dataGridView_Devices_KeyUp(object sender, KeyEventArgs e)
        {
            ShowDeviceDetails();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_SearchCustomerTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_CustomerTel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            MessageBox.Show("Yedek dosyalarınız hazırlandı. Programı kapattıkdan sonra '" + Application.StartupPath + "' klasöründeki 'ComputerTechnicianHelperDB' ve 'ComputerTechnicianHelperDB_log' adlı dosyaları koplayıp dilediğiniz yere yedek alabilirsiniz. Tamama bastığınızda gerekli klasör açılacaktır.", "Yedek Yaratıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer.exe",Application.StartupPath);
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programı kapattıktan sonra yedek dosyalarınızı '"+Application.StartupPath+"' klasörünün üzerine kopyalayınız ve gelen uyarılara onay veriniz. Tamama bastığınızda gerekli klasör açılacaktır.","Yedek Alma İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Process.Start("explorer.exe", Application.StartupPath);
        }
     }
}
