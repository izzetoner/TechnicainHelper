namespace TechnicianHelper
{
    partial class Form_DeviceServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DeviceServices));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_DeviceDeleteOperation = new System.Windows.Forms.Button();
            this.ımageList_DeviceServices = new System.Windows.Forms.ImageList(this.components);
            this.button_DeviceUpdateOperations = new System.Windows.Forms.Button();
            this.panel_DeviceOperationDetails = new System.Windows.Forms.Panel();
            this.label_ServiceDate = new System.Windows.Forms.Label();
            this.comboBox_ServiceStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ServiceDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ServiceOperations = new System.Windows.Forms.TextBox();
            this.textBox_PaymentAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DebtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_DeviceAddOperation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_DevicesOperations = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel_DeviceOperationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DevicesOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_DeviceDeleteOperation);
            this.groupBox1.Controls.Add(this.button_DeviceUpdateOperations);
            this.groupBox1.Controls.Add(this.panel_DeviceOperationDetails);
            this.groupBox1.Controls.Add(this.button_DeviceAddOperation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(288, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Ara ";
            // 
            // button_DeviceDeleteOperation
            // 
            this.button_DeviceDeleteOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceDeleteOperation.ImageKey = "deleteeventicon.png";
            this.button_DeviceDeleteOperation.ImageList = this.ımageList_DeviceServices;
            this.button_DeviceDeleteOperation.Location = new System.Drawing.Point(307, 114);
            this.button_DeviceDeleteOperation.Name = "button_DeviceDeleteOperation";
            this.button_DeviceDeleteOperation.Size = new System.Drawing.Size(127, 33);
            this.button_DeviceDeleteOperation.TabIndex = 8;
            this.button_DeviceDeleteOperation.Text = "İşlem Sil";
            this.button_DeviceDeleteOperation.UseVisualStyleBackColor = true;
            this.button_DeviceDeleteOperation.Click += new System.EventHandler(this.button_DeviceDeleteOperation_Click);
            // 
            // ımageList_DeviceServices
            // 
            this.ımageList_DeviceServices.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_DeviceServices.ImageStream")));
            this.ımageList_DeviceServices.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_DeviceServices.Images.SetKeyName(0, "addeventicon.png");
            this.ımageList_DeviceServices.Images.SetKeyName(1, "deleteeventicon.png");
            this.ımageList_DeviceServices.Images.SetKeyName(2, "editeventicon.png");
            // 
            // button_DeviceUpdateOperations
            // 
            this.button_DeviceUpdateOperations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceUpdateOperations.ImageKey = "editeventicon.png";
            this.button_DeviceUpdateOperations.ImageList = this.ımageList_DeviceServices;
            this.button_DeviceUpdateOperations.Location = new System.Drawing.Point(307, 66);
            this.button_DeviceUpdateOperations.Name = "button_DeviceUpdateOperations";
            this.button_DeviceUpdateOperations.Size = new System.Drawing.Size(127, 33);
            this.button_DeviceUpdateOperations.TabIndex = 7;
            this.button_DeviceUpdateOperations.Text = "İşlem Güncelle";
            this.button_DeviceUpdateOperations.UseVisualStyleBackColor = true;
            this.button_DeviceUpdateOperations.Click += new System.EventHandler(this.button_DeviceUpdateOperations_Click);
            // 
            // panel_DeviceOperationDetails
            // 
            this.panel_DeviceOperationDetails.Controls.Add(this.label_ServiceDate);
            this.panel_DeviceOperationDetails.Controls.Add(this.comboBox_ServiceStatus);
            this.panel_DeviceOperationDetails.Controls.Add(this.label1);
            this.panel_DeviceOperationDetails.Controls.Add(this.label3);
            this.panel_DeviceOperationDetails.Controls.Add(this.textBox_ServiceDescription);
            this.panel_DeviceOperationDetails.Controls.Add(this.label2);
            this.panel_DeviceOperationDetails.Controls.Add(this.label4);
            this.panel_DeviceOperationDetails.Controls.Add(this.textBox_ServiceOperations);
            this.panel_DeviceOperationDetails.Controls.Add(this.textBox_PaymentAmount);
            this.panel_DeviceOperationDetails.Controls.Add(this.label6);
            this.panel_DeviceOperationDetails.Controls.Add(this.textBox_DebtAmount);
            this.panel_DeviceOperationDetails.Controls.Add(this.label5);
            this.panel_DeviceOperationDetails.Location = new System.Drawing.Point(9, 19);
            this.panel_DeviceOperationDetails.Name = "panel_DeviceOperationDetails";
            this.panel_DeviceOperationDetails.Size = new System.Drawing.Size(292, 303);
            this.panel_DeviceOperationDetails.TabIndex = 4;
            // 
            // label_ServiceDate
            // 
            this.label_ServiceDate.AutoSize = true;
            this.label_ServiceDate.Location = new System.Drawing.Point(114, 190);
            this.label_ServiceDate.Name = "label_ServiceDate";
            this.label_ServiceDate.Size = new System.Drawing.Size(0, 13);
            this.label_ServiceDate.TabIndex = 2;
            // 
            // comboBox_ServiceStatus
            // 
            this.comboBox_ServiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ServiceStatus.FormattingEnabled = true;
            this.comboBox_ServiceStatus.Items.AddRange(new object[] {
            "Teslim Alındı",
            "Arıza Tesbit Edildi",
            "Onay Bekleniyor",
            "Parça Bekliyor",
            "Arıza Giderildi",
            "Teslim Edildi"});
            this.comboBox_ServiceStatus.Location = new System.Drawing.Point(116, 44);
            this.comboBox_ServiceStatus.Name = "comboBox_ServiceStatus";
            this.comboBox_ServiceStatus.Size = new System.Drawing.Size(167, 21);
            this.comboBox_ServiceStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service İşlemi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servis Durumu :";
            // 
            // textBox_ServiceDescription
            // 
            this.textBox_ServiceDescription.Location = new System.Drawing.Point(116, 80);
            this.textBox_ServiceDescription.Multiline = true;
            this.textBox_ServiceDescription.Name = "textBox_ServiceDescription";
            this.textBox_ServiceDescription.Size = new System.Drawing.Size(167, 85);
            this.textBox_ServiceDescription.TabIndex = 3;
            this.textBox_ServiceDescription.TextChanged += new System.EventHandler(this.textBox_ServiceOperations_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servis Açılama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ücret              :";
            // 
            // textBox_ServiceOperations
            // 
            this.textBox_ServiceOperations.Location = new System.Drawing.Point(117, 9);
            this.textBox_ServiceOperations.Name = "textBox_ServiceOperations";
            this.textBox_ServiceOperations.Size = new System.Drawing.Size(167, 20);
            this.textBox_ServiceOperations.TabIndex = 1;
            this.textBox_ServiceOperations.TextChanged += new System.EventHandler(this.textBox_ServiceOperations_TextChanged);
            // 
            // textBox_PaymentAmount
            // 
            this.textBox_PaymentAmount.Location = new System.Drawing.Point(116, 261);
            this.textBox_PaymentAmount.Name = "textBox_PaymentAmount";
            this.textBox_PaymentAmount.Size = new System.Drawing.Size(167, 20);
            this.textBox_PaymentAmount.TabIndex = 5;
            this.textBox_PaymentAmount.TextChanged += new System.EventHandler(this.textBox_ServiceOperations_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Servis Tarihi    :";
            // 
            // textBox_DebtAmount
            // 
            this.textBox_DebtAmount.Location = new System.Drawing.Point(116, 226);
            this.textBox_DebtAmount.Name = "textBox_DebtAmount";
            this.textBox_DebtAmount.Size = new System.Drawing.Size(167, 20);
            this.textBox_DebtAmount.TabIndex = 4;
            this.textBox_DebtAmount.TextChanged += new System.EventHandler(this.textBox_ServiceOperations_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ödeme           :";
            // 
            // button_DeviceAddOperation
            // 
            this.button_DeviceAddOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceAddOperation.ImageKey = "addeventicon.png";
            this.button_DeviceAddOperation.ImageList = this.ımageList_DeviceServices;
            this.button_DeviceAddOperation.Location = new System.Drawing.Point(307, 19);
            this.button_DeviceAddOperation.Name = "button_DeviceAddOperation";
            this.button_DeviceAddOperation.Size = new System.Drawing.Size(127, 33);
            this.button_DeviceAddOperation.TabIndex = 6;
            this.button_DeviceAddOperation.Text = "İşlem Ekle";
            this.button_DeviceAddOperation.UseVisualStyleBackColor = true;
            this.button_DeviceAddOperation.Click += new System.EventHandler(this.button_AddDeviceOperation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(22, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 48);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bu Cihaza Ait İşlem Bilgisi\r\n      Bulunmamaktadır.";
            // 
            // dataGridView_DevicesOperations
            // 
            this.dataGridView_DevicesOperations.AllowUserToAddRows = false;
            this.dataGridView_DevicesOperations.AllowUserToDeleteRows = false;
            this.dataGridView_DevicesOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DevicesOperations.Location = new System.Drawing.Point(21, 12);
            this.dataGridView_DevicesOperations.MultiSelect = false;
            this.dataGridView_DevicesOperations.Name = "dataGridView_DevicesOperations";
            this.dataGridView_DevicesOperations.ReadOnly = true;
            this.dataGridView_DevicesOperations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DevicesOperations.Size = new System.Drawing.Size(241, 328);
            this.dataGridView_DevicesOperations.TabIndex = 1;
            this.dataGridView_DevicesOperations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DevicesOperations_CellClick);
            this.dataGridView_DevicesOperations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_DevicesOperations_KeyDown);
            this.dataGridView_DevicesOperations.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_DevicesOperations_KeyUp);
            // 
            // Form_DeviceServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 360);
            this.Controls.Add(this.dataGridView_DevicesOperations);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_DeviceServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihaz İşlemleri";
            this.Load += new System.EventHandler(this.Form_DeviceServices_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_DeviceOperationDetails.ResumeLayout(false);
            this.panel_DeviceOperationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DevicesOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_DebtAmount;
        private System.Windows.Forms.Button button_DeviceAddOperation;
        private System.Windows.Forms.DataGridView dataGridView_DevicesOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ServiceDescription;
        private System.Windows.Forms.ComboBox comboBox_ServiceStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PaymentAmount;
        private System.Windows.Forms.TextBox textBox_ServiceOperations;
        private System.Windows.Forms.Label label_ServiceDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_DeviceDeleteOperation;
        private System.Windows.Forms.Button button_DeviceUpdateOperations;
        private System.Windows.Forms.Panel panel_DeviceOperationDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList ımageList_DeviceServices;
    }
}