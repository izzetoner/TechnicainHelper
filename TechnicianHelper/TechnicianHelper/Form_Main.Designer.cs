namespace TechnicianHelper
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
            this.groupBox_CustomerName = new System.Windows.Forms.GroupBox();
            this.button_ShowAllCustomer = new System.Windows.Forms.Button();
            this.ımageList_Main = new System.Windows.Forms.ImageList(this.components);
            this.textBox_SearchCustomerTel = new System.Windows.Forms.TextBox();
            this.textBox_SearchCustomerName = new System.Windows.Forms.TextBox();
            this.label_SearchCustomerTel = new System.Windows.Forms.Label();
            this.label_SearchCustomerName = new System.Windows.Forms.Label();
            this.groupBox_CustomerDetails = new System.Windows.Forms.GroupBox();
            this.panel_CustomerWarning = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CustomerAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CustomerMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CustomerTel = new System.Windows.Forms.TextBox();
            this.label_CustomerBalance = new System.Windows.Forms.Label();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.panel_CustomerGenderWarning = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.button_CustomerDelete = new System.Windows.Forms.Button();
            this.button_UpdateCustomer = new System.Windows.Forms.Button();
            this.button_AddCustomer = new System.Windows.Forms.Button();
            this.label_CustomerWarning = new System.Windows.Forms.Label();
            this.dataGridView_Devices = new System.Windows.Forms.DataGridView();
            this.groupBox_Device = new System.Windows.Forms.GroupBox();
            this.button_DeviceService = new System.Windows.Forms.Button();
            this.panel_Devices = new System.Windows.Forms.Panel();
            this.label_DeviceDescription = new System.Windows.Forms.Label();
            this.textBox_DeviceDescription = new System.Windows.Forms.TextBox();
            this.textBox_DeviceBrandModel = new System.Windows.Forms.TextBox();
            this.label_DeviceBalance = new System.Windows.Forms.Label();
            this.label_DeviceCreateDate = new System.Windows.Forms.Label();
            this.label_DeviceBrandAndModel = new System.Windows.Forms.Label();
            this.label_DeviceWarning = new System.Windows.Forms.Label();
            this.button_DeviceDelete = new System.Windows.Forms.Button();
            this.button_DeviceUpdate = new System.Windows.Forms.Button();
            this.button_DeviceAdd = new System.Windows.Forms.Button();
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
            this.groupBox_CustomerName.SuspendLayout();
            this.groupBox_CustomerDetails.SuspendLayout();
            this.panel_CustomerWarning.SuspendLayout();
            this.panel_CustomerGenderWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Devices)).BeginInit();
            this.groupBox_Device.SuspendLayout();
            this.panel_Devices.SuspendLayout();
            this.toolStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Customers
            // 
            this.dataGridView_Customers.AllowUserToAddRows = false;
            this.dataGridView_Customers.AllowUserToDeleteRows = false;
            this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Customers.Location = new System.Drawing.Point(12, 157);
            this.dataGridView_Customers.MultiSelect = false;
            this.dataGridView_Customers.Name = "dataGridView_Customers";
            this.dataGridView_Customers.ReadOnly = true;
            this.dataGridView_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Customers.Size = new System.Drawing.Size(292, 155);
            this.dataGridView_Customers.TabIndex = 0;
            this.dataGridView_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Customers_CellClick);
            this.dataGridView_Customers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_Customers_KeyDown);
            this.dataGridView_Customers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_Customers_KeyUp);
            // 
            // groupBox_CustomerName
            // 
            this.groupBox_CustomerName.Controls.Add(this.button_ShowAllCustomer);
            this.groupBox_CustomerName.Controls.Add(this.textBox_SearchCustomerTel);
            this.groupBox_CustomerName.Controls.Add(this.textBox_SearchCustomerName);
            this.groupBox_CustomerName.Controls.Add(this.label_SearchCustomerTel);
            this.groupBox_CustomerName.Controls.Add(this.label_SearchCustomerName);
            this.groupBox_CustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_CustomerName.Location = new System.Drawing.Point(12, 41);
            this.groupBox_CustomerName.Name = "groupBox_CustomerName";
            this.groupBox_CustomerName.Size = new System.Drawing.Size(292, 111);
            this.groupBox_CustomerName.TabIndex = 1;
            this.groupBox_CustomerName.TabStop = false;
            this.groupBox_CustomerName.Text = "Müşteri Arama ";
            // 
            // button_ShowAllCustomer
            // 
            this.button_ShowAllCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ShowAllCustomer.ImageKey = "showallicon.png";
            this.button_ShowAllCustomer.ImageList = this.ımageList_Main;
            this.button_ShowAllCustomer.Location = new System.Drawing.Point(77, 78);
            this.button_ShowAllCustomer.Name = "button_ShowAllCustomer";
            this.button_ShowAllCustomer.Size = new System.Drawing.Size(144, 30);
            this.button_ShowAllCustomer.TabIndex = 3;
            this.button_ShowAllCustomer.Text = "Hepsini Göster";
            this.button_ShowAllCustomer.UseVisualStyleBackColor = true;
            this.button_ShowAllCustomer.Click += new System.EventHandler(this.button_ShowAllCustomer_Click);
            // 
            // ımageList_Main
            // 
            this.ımageList_Main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_Main.ImageStream")));
            this.ımageList_Main.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_Main.Images.SetKeyName(0, "addusericon.ico");
            this.ımageList_Main.Images.SetKeyName(1, "Custom-Icon-Design-Pretty-Office-3-Edit-Male-User.ico");
            this.ımageList_Main.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-3-Remove-Male-User.ico");
            this.ımageList_Main.Images.SetKeyName(3, "1398713476_23227.ico");
            this.ımageList_Main.Images.SetKeyName(4, "Awicons-Vista-Artistic-Add.ico");
            this.ımageList_Main.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico");
            this.ımageList_Main.Images.SetKeyName(6, "showallicon.png");
            this.ımageList_Main.Images.SetKeyName(7, "Actions-view-process-system-icon.png");
            // 
            // textBox_SearchCustomerTel
            // 
            this.textBox_SearchCustomerTel.Location = new System.Drawing.Point(77, 41);
            this.textBox_SearchCustomerTel.Name = "textBox_SearchCustomerTel";
            this.textBox_SearchCustomerTel.Size = new System.Drawing.Size(152, 20);
            this.textBox_SearchCustomerTel.TabIndex = 2;
            this.textBox_SearchCustomerTel.TextChanged += new System.EventHandler(this.textBox_SearchCustomerTel_TextChanged);
            this.textBox_SearchCustomerTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SearchCustomerTel_KeyPress);
            // 
            // textBox_SearchCustomerName
            // 
            this.textBox_SearchCustomerName.Location = new System.Drawing.Point(77, 13);
            this.textBox_SearchCustomerName.Name = "textBox_SearchCustomerName";
            this.textBox_SearchCustomerName.Size = new System.Drawing.Size(152, 20);
            this.textBox_SearchCustomerName.TabIndex = 1;
            this.textBox_SearchCustomerName.TextChanged += new System.EventHandler(this.textBox_SearchCustomerName_TextChanged);
            // 
            // label_SearchCustomerTel
            // 
            this.label_SearchCustomerTel.AutoSize = true;
            this.label_SearchCustomerTel.Location = new System.Drawing.Point(6, 44);
            this.label_SearchCustomerTel.Name = "label_SearchCustomerTel";
            this.label_SearchCustomerTel.Size = new System.Drawing.Size(65, 13);
            this.label_SearchCustomerTel.TabIndex = 0;
            this.label_SearchCustomerTel.Text = "Müşteri Tel :";
            // 
            // label_SearchCustomerName
            // 
            this.label_SearchCustomerName.AutoSize = true;
            this.label_SearchCustomerName.Location = new System.Drawing.Point(6, 16);
            this.label_SearchCustomerName.Name = "label_SearchCustomerName";
            this.label_SearchCustomerName.Size = new System.Drawing.Size(65, 13);
            this.label_SearchCustomerName.TabIndex = 0;
            this.label_SearchCustomerName.Text = "Müşteri Adı :";
            // 
            // groupBox_CustomerDetails
            // 
            this.groupBox_CustomerDetails.Controls.Add(this.panel_CustomerWarning);
            this.groupBox_CustomerDetails.Controls.Add(this.panel_CustomerGenderWarning);
            this.groupBox_CustomerDetails.Controls.Add(this.button_CustomerDelete);
            this.groupBox_CustomerDetails.Controls.Add(this.button_UpdateCustomer);
            this.groupBox_CustomerDetails.Controls.Add(this.button_AddCustomer);
            this.groupBox_CustomerDetails.Location = new System.Drawing.Point(330, 41);
            this.groupBox_CustomerDetails.Name = "groupBox_CustomerDetails";
            this.groupBox_CustomerDetails.Size = new System.Drawing.Size(442, 271);
            this.groupBox_CustomerDetails.TabIndex = 2;
            this.groupBox_CustomerDetails.TabStop = false;
            this.groupBox_CustomerDetails.Text = "Müşteri Ayrıntıları";
            // 
            // panel_CustomerWarning
            // 
            this.panel_CustomerWarning.Controls.Add(this.label22);
            this.panel_CustomerWarning.Controls.Add(this.label1);
            this.panel_CustomerWarning.Controls.Add(this.label2);
            this.panel_CustomerWarning.Controls.Add(this.textBox_CustomerAdress);
            this.panel_CustomerWarning.Controls.Add(this.label3);
            this.panel_CustomerWarning.Controls.Add(this.textBox_CustomerMail);
            this.panel_CustomerWarning.Controls.Add(this.label4);
            this.panel_CustomerWarning.Controls.Add(this.textBox_CustomerTel);
            this.panel_CustomerWarning.Controls.Add(this.label_CustomerBalance);
            this.panel_CustomerWarning.Controls.Add(this.textBox_CustomerName);
            this.panel_CustomerWarning.Controls.Add(this.label_CustomerID);
            this.panel_CustomerWarning.Location = new System.Drawing.Point(7, 25);
            this.panel_CustomerWarning.Name = "panel_CustomerWarning";
            this.panel_CustomerWarning.Size = new System.Drawing.Size(255, 246);
            this.panel_CustomerWarning.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Müşteri No  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Tel :";
            // 
            // textBox_CustomerAdress
            // 
            this.textBox_CustomerAdress.Location = new System.Drawing.Point(99, 111);
            this.textBox_CustomerAdress.Multiline = true;
            this.textBox_CustomerAdress.Name = "textBox_CustomerAdress";
            this.textBox_CustomerAdress.Size = new System.Drawing.Size(130, 48);
            this.textBox_CustomerAdress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Adres:";
            // 
            // textBox_CustomerMail
            // 
            this.textBox_CustomerMail.Location = new System.Drawing.Point(99, 182);
            this.textBox_CustomerMail.Name = "textBox_CustomerMail";
            this.textBox_CustomerMail.Size = new System.Drawing.Size(130, 20);
            this.textBox_CustomerMail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri  Mail :";
            // 
            // textBox_CustomerTel
            // 
            this.textBox_CustomerTel.Location = new System.Drawing.Point(98, 78);
            this.textBox_CustomerTel.MaxLength = 11;
            this.textBox_CustomerTel.Name = "textBox_CustomerTel";
            this.textBox_CustomerTel.Size = new System.Drawing.Size(130, 20);
            this.textBox_CustomerTel.TabIndex = 5;
            this.textBox_CustomerTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CustomerTel_KeyPress);
            // 
            // label_CustomerBalance
            // 
            this.label_CustomerBalance.AutoSize = true;
            this.label_CustomerBalance.Location = new System.Drawing.Point(15, 217);
            this.label_CustomerBalance.Name = "label_CustomerBalance";
            this.label_CustomerBalance.Size = new System.Drawing.Size(79, 13);
            this.label_CustomerBalance.TabIndex = 0;
            this.label_CustomerBalance.Text = "Genel Bakiye  :";
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Location = new System.Drawing.Point(99, 41);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(129, 20);
            this.textBox_CustomerName.TabIndex = 4;
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.Location = new System.Drawing.Point(96, 16);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(0, 13);
            this.label_CustomerID.TabIndex = 0;
            // 
            // panel_CustomerGenderWarning
            // 
            this.panel_CustomerGenderWarning.Controls.Add(this.label5);
            this.panel_CustomerGenderWarning.Controls.Add(this.radioButton_Female);
            this.panel_CustomerGenderWarning.Controls.Add(this.radioButton_Male);
            this.panel_CustomerGenderWarning.Location = new System.Drawing.Point(269, 197);
            this.panel_CustomerGenderWarning.Name = "panel_CustomerGenderWarning";
            this.panel_CustomerGenderWarning.Size = new System.Drawing.Size(156, 74);
            this.panel_CustomerGenderWarning.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet :";
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(75, 36);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Female.TabIndex = 10;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Bayan";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(12, 36);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(43, 17);
            this.radioButton_Male.TabIndex = 10;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Bay";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // button_CustomerDelete
            // 
            this.button_CustomerDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CustomerDelete.ImageKey = "Custom-Icon-Design-Pretty-Office-3-Remove-Male-User.ico";
            this.button_CustomerDelete.ImageList = this.ımageList_Main;
            this.button_CustomerDelete.Location = new System.Drawing.Point(268, 129);
            this.button_CustomerDelete.Name = "button_CustomerDelete";
            this.button_CustomerDelete.Size = new System.Drawing.Size(156, 36);
            this.button_CustomerDelete.TabIndex = 9;
            this.button_CustomerDelete.Text = "Müşteri Sil";
            this.button_CustomerDelete.UseVisualStyleBackColor = true;
            this.button_CustomerDelete.Click += new System.EventHandler(this.button_CustomerDelete_Click);
            // 
            // button_UpdateCustomer
            // 
            this.button_UpdateCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_UpdateCustomer.ImageKey = "Custom-Icon-Design-Pretty-Office-3-Edit-Male-User.ico";
            this.button_UpdateCustomer.ImageList = this.ımageList_Main;
            this.button_UpdateCustomer.Location = new System.Drawing.Point(268, 75);
            this.button_UpdateCustomer.Name = "button_UpdateCustomer";
            this.button_UpdateCustomer.Size = new System.Drawing.Size(156, 36);
            this.button_UpdateCustomer.TabIndex = 8;
            this.button_UpdateCustomer.Text = "Müşteri Güncelleme";
            this.button_UpdateCustomer.UseVisualStyleBackColor = true;
            this.button_UpdateCustomer.Click += new System.EventHandler(this.button_UpdateCustomer_Click);
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddCustomer.ImageKey = "addusericon.ico";
            this.button_AddCustomer.ImageList = this.ımageList_Main;
            this.button_AddCustomer.Location = new System.Drawing.Point(268, 25);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.Size = new System.Drawing.Size(156, 36);
            this.button_AddCustomer.TabIndex = 7;
            this.button_AddCustomer.Text = "Müşteri Ekle";
            this.button_AddCustomer.UseVisualStyleBackColor = true;
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // label_CustomerWarning
            // 
            this.label_CustomerWarning.AutoSize = true;
            this.label_CustomerWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_CustomerWarning.Location = new System.Drawing.Point(178, 394);
            this.label_CustomerWarning.Name = "label_CustomerWarning";
            this.label_CustomerWarning.Size = new System.Drawing.Size(435, 78);
            this.label_CustomerWarning.TabIndex = 7;
            this.label_CustomerWarning.Text = "Aramanıza uygun müşteri\r\n          bulunamadı.";
            // 
            // dataGridView_Devices
            // 
            this.dataGridView_Devices.AllowUserToAddRows = false;
            this.dataGridView_Devices.AllowUserToDeleteRows = false;
            this.dataGridView_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Devices.Location = new System.Drawing.Point(9, 19);
            this.dataGridView_Devices.MultiSelect = false;
            this.dataGridView_Devices.Name = "dataGridView_Devices";
            this.dataGridView_Devices.ReadOnly = true;
            this.dataGridView_Devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Devices.Size = new System.Drawing.Size(292, 158);
            this.dataGridView_Devices.TabIndex = 3;
            this.dataGridView_Devices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Devices_CellClick);
            this.dataGridView_Devices.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_Devices_KeyDown);
            this.dataGridView_Devices.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_Devices_KeyUp);
            // 
            // groupBox_Device
            // 
            this.groupBox_Device.Controls.Add(this.button_DeviceService);
            this.groupBox_Device.Controls.Add(this.panel_Devices);
            this.groupBox_Device.Controls.Add(this.label_DeviceWarning);
            this.groupBox_Device.Controls.Add(this.button_DeviceDelete);
            this.groupBox_Device.Controls.Add(this.button_DeviceUpdate);
            this.groupBox_Device.Controls.Add(this.button_DeviceAdd);
            this.groupBox_Device.Controls.Add(this.dataGridView_Devices);
            this.groupBox_Device.Location = new System.Drawing.Point(3, 318);
            this.groupBox_Device.Name = "groupBox_Device";
            this.groupBox_Device.Size = new System.Drawing.Size(769, 197);
            this.groupBox_Device.TabIndex = 4;
            this.groupBox_Device.TabStop = false;
            this.groupBox_Device.Text = "Cihazlar";
            // 
            // button_DeviceService
            // 
            this.button_DeviceService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceService.ImageKey = "Actions-view-process-system-icon.png";
            this.button_DeviceService.ImageList = this.ımageList_Main;
            this.button_DeviceService.Location = new System.Drawing.Point(596, 153);
            this.button_DeviceService.Name = "button_DeviceService";
            this.button_DeviceService.Size = new System.Drawing.Size(155, 34);
            this.button_DeviceService.TabIndex = 7;
            this.button_DeviceService.Text = "Cihaz İşlemleri ";
            this.button_DeviceService.UseVisualStyleBackColor = true;
            this.button_DeviceService.Click += new System.EventHandler(this.button_DeviceService_Click);
            // 
            // panel_Devices
            // 
            this.panel_Devices.Controls.Add(this.label_DeviceDescription);
            this.panel_Devices.Controls.Add(this.textBox_DeviceDescription);
            this.panel_Devices.Controls.Add(this.textBox_DeviceBrandModel);
            this.panel_Devices.Controls.Add(this.label_DeviceBalance);
            this.panel_Devices.Controls.Add(this.label_DeviceCreateDate);
            this.panel_Devices.Controls.Add(this.label_DeviceBrandAndModel);
            this.panel_Devices.Location = new System.Drawing.Point(327, 15);
            this.panel_Devices.Name = "panel_Devices";
            this.panel_Devices.Size = new System.Drawing.Size(262, 172);
            this.panel_Devices.TabIndex = 6;
            // 
            // label_DeviceDescription
            // 
            this.label_DeviceDescription.AutoSize = true;
            this.label_DeviceDescription.Location = new System.Drawing.Point(4, 64);
            this.label_DeviceDescription.Name = "label_DeviceDescription";
            this.label_DeviceDescription.Size = new System.Drawing.Size(98, 13);
            this.label_DeviceDescription.TabIndex = 13;
            this.label_DeviceDescription.Text = "Cihaz Açıklaması  : ";
            // 
            // textBox_DeviceDescription
            // 
            this.textBox_DeviceDescription.Location = new System.Drawing.Point(105, 57);
            this.textBox_DeviceDescription.Multiline = true;
            this.textBox_DeviceDescription.Name = "textBox_DeviceDescription";
            this.textBox_DeviceDescription.Size = new System.Drawing.Size(143, 85);
            this.textBox_DeviceDescription.TabIndex = 11;
            // 
            // textBox_DeviceBrandModel
            // 
            this.textBox_DeviceBrandModel.Location = new System.Drawing.Point(105, 7);
            this.textBox_DeviceBrandModel.Name = "textBox_DeviceBrandModel";
            this.textBox_DeviceBrandModel.Size = new System.Drawing.Size(143, 20);
            this.textBox_DeviceBrandModel.TabIndex = 12;
            // 
            // label_DeviceBalance
            // 
            this.label_DeviceBalance.AutoSize = true;
            this.label_DeviceBalance.Location = new System.Drawing.Point(3, 152);
            this.label_DeviceBalance.Name = "label_DeviceBalance";
            this.label_DeviceBalance.Size = new System.Drawing.Size(83, 13);
            this.label_DeviceBalance.TabIndex = 14;
            this.label_DeviceBalance.Text = "Cihaz Bakiye   : ";
            // 
            // label_DeviceCreateDate
            // 
            this.label_DeviceCreateDate.AutoSize = true;
            this.label_DeviceCreateDate.Location = new System.Drawing.Point(3, 40);
            this.label_DeviceCreateDate.Name = "label_DeviceCreateDate";
            this.label_DeviceCreateDate.Size = new System.Drawing.Size(98, 13);
            this.label_DeviceCreateDate.TabIndex = 15;
            this.label_DeviceCreateDate.Text = "Kayıt Tarihi         :   ";
            // 
            // label_DeviceBrandAndModel
            // 
            this.label_DeviceBrandAndModel.AutoSize = true;
            this.label_DeviceBrandAndModel.Location = new System.Drawing.Point(4, 14);
            this.label_DeviceBrandAndModel.Name = "label_DeviceBrandAndModel";
            this.label_DeviceBrandAndModel.Size = new System.Drawing.Size(83, 13);
            this.label_DeviceBrandAndModel.TabIndex = 16;
            this.label_DeviceBrandAndModel.Text = "Marka/Model  : ";
            // 
            // label_DeviceWarning
            // 
            this.label_DeviceWarning.AutoSize = true;
            this.label_DeviceWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_DeviceWarning.Location = new System.Drawing.Point(324, 65);
            this.label_DeviceWarning.Name = "label_DeviceWarning";
            this.label_DeviceWarning.Size = new System.Drawing.Size(257, 26);
            this.label_DeviceWarning.TabIndex = 6;
            this.label_DeviceWarning.Text = "Bu müşteriye kayıtlı cihaz bulunmamaktadır. \r\n            Lütfen bir cihaz ekleyi" +
    "niz.";
            // 
            // button_DeviceDelete
            // 
            this.button_DeviceDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceDelete.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico";
            this.button_DeviceDelete.ImageList = this.ımageList_Main;
            this.button_DeviceDelete.Location = new System.Drawing.Point(595, 108);
            this.button_DeviceDelete.Name = "button_DeviceDelete";
            this.button_DeviceDelete.Size = new System.Drawing.Size(155, 34);
            this.button_DeviceDelete.TabIndex = 5;
            this.button_DeviceDelete.Text = "Cihaz Sil";
            this.button_DeviceDelete.UseVisualStyleBackColor = true;
            this.button_DeviceDelete.Click += new System.EventHandler(this.button_DeviceDelete_Click);
            // 
            // button_DeviceUpdate
            // 
            this.button_DeviceUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceUpdate.ImageKey = "1398713476_23227.ico";
            this.button_DeviceUpdate.ImageList = this.ımageList_Main;
            this.button_DeviceUpdate.Location = new System.Drawing.Point(595, 65);
            this.button_DeviceUpdate.Name = "button_DeviceUpdate";
            this.button_DeviceUpdate.Size = new System.Drawing.Size(155, 34);
            this.button_DeviceUpdate.TabIndex = 5;
            this.button_DeviceUpdate.Text = "Cihaz Güncelle";
            this.button_DeviceUpdate.UseVisualStyleBackColor = true;
            this.button_DeviceUpdate.Click += new System.EventHandler(this.button_DeviceUpdate_Click);
            // 
            // button_DeviceAdd
            // 
            this.button_DeviceAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceAdd.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.button_DeviceAdd.ImageList = this.ımageList_Main;
            this.button_DeviceAdd.Location = new System.Drawing.Point(595, 15);
            this.button_DeviceAdd.Name = "button_DeviceAdd";
            this.button_DeviceAdd.Size = new System.Drawing.Size(155, 34);
            this.button_DeviceAdd.TabIndex = 5;
            this.button_DeviceAdd.Text = "Cihaz Ekle";
            this.button_DeviceAdd.UseVisualStyleBackColor = true;
            this.button_DeviceAdd.Click += new System.EventHandler(this.button_DeviceAdd_Click);
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(784, 25);
            this.toolStrip_Main.TabIndex = 8;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.yedekToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::TechnicianHelper.Properties.Resources.usericon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Program ";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::TechnicianHelper.Properties.Resources.Close_icon;
            this.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ExitToolStripMenuItem.Text = "Çıkış";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // yedekToolStripMenuItem
            // 
            this.yedekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupToolStripMenuItem,
            this.estoreToolStripMenuItem});
            this.yedekToolStripMenuItem.Image = global::TechnicianHelper.Properties.Resources.Backup_Folder_Graphite_icon;
            this.yedekToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yedekToolStripMenuItem.Name = "yedekToolStripMenuItem";
            this.yedekToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.yedekToolStripMenuItem.Text = "Yedek";
            // 
            // BackupToolStripMenuItem
            // 
            this.BackupToolStripMenuItem.Image = global::TechnicianHelper.Properties.Resources.Database_Recovery_icon;
            this.BackupToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
            this.BackupToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.BackupToolStripMenuItem.Text = "Yedek Al";
            this.BackupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // estoreToolStripMenuItem
            // 
            this.estoreToolStripMenuItem.Image = global::TechnicianHelper.Properties.Resources.Database_Backup_icon;
            this.estoreToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estoreToolStripMenuItem.Name = "estoreToolStripMenuItem";
            this.estoreToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.estoreToolStripMenuItem.Text = "Yedek Yükle";
            this.estoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 514);
            this.Controls.Add(this.toolStrip_Main);
            this.Controls.Add(this.groupBox_Device);
            this.Controls.Add(this.label_CustomerWarning);
            this.Controls.Add(this.groupBox_CustomerDetails);
            this.Controls.Add(this.groupBox_CustomerName);
            this.Controls.Add(this.dataGridView_Customers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknisyen Yardımcısı  V01.B";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
            this.groupBox_CustomerName.ResumeLayout(false);
            this.groupBox_CustomerName.PerformLayout();
            this.groupBox_CustomerDetails.ResumeLayout(false);
            this.panel_CustomerWarning.ResumeLayout(false);
            this.panel_CustomerWarning.PerformLayout();
            this.panel_CustomerGenderWarning.ResumeLayout(false);
            this.panel_CustomerGenderWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Devices)).EndInit();
            this.groupBox_Device.ResumeLayout(false);
            this.groupBox_Device.PerformLayout();
            this.panel_Devices.ResumeLayout(false);
            this.panel_Devices.PerformLayout();
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_CustomerName;
        private System.Windows.Forms.Label label_SearchCustomerName;
        private System.Windows.Forms.TextBox textBox_SearchCustomerTel;
        private System.Windows.Forms.TextBox textBox_SearchCustomerName;
        private System.Windows.Forms.Label label_SearchCustomerTel;
        private System.Windows.Forms.GroupBox groupBox_CustomerDetails;
        private System.Windows.Forms.TextBox textBox_CustomerAdress;
        private System.Windows.Forms.TextBox textBox_CustomerMail;
        private System.Windows.Forms.TextBox textBox_CustomerTel;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Button button_CustomerDelete;
        private System.Windows.Forms.Button button_UpdateCustomer;
        private System.Windows.Forms.Button button_AddCustomer;
        private System.Windows.Forms.Label label_CustomerBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Device;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button_ShowAllCustomer;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_DeviceAdd;
        private System.Windows.Forms.Panel panel_Devices;
        private System.Windows.Forms.Label label_DeviceDescription;
        private System.Windows.Forms.TextBox textBox_DeviceDescription;
        private System.Windows.Forms.TextBox textBox_DeviceBrandModel;
        private System.Windows.Forms.Label label_DeviceBalance;
        private System.Windows.Forms.Label label_DeviceCreateDate;
        private System.Windows.Forms.Label label_DeviceBrandAndModel;
        private System.Windows.Forms.Label label_DeviceWarning;
        private System.Windows.Forms.Button button_DeviceDelete;
        private System.Windows.Forms.Button button_DeviceUpdate;
        private System.Windows.Forms.Panel panel_CustomerGenderWarning;
        private System.Windows.Forms.Label label_CustomerWarning;
        public System.Windows.Forms.Label label_CustomerID;
        public System.Windows.Forms.Panel panel_CustomerWarning;
        private System.Windows.Forms.Button button_DeviceService;
        public System.Windows.Forms.DataGridView dataGridView_Devices;
        public System.Windows.Forms.DataGridView dataGridView_Customers;
        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoreToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList_Main;
    }
}