namespace TechnicianHelper
{
    partial class Form_DeviceAddServiceOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DeviceAddServiceOperations));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_DeviceAddOperation = new System.Windows.Forms.Button();
            this.ımageList_DeviceAddServiceOperations = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ServiceDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ServiceOperations = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_DeviceAddOperation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_ServiceDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_ServiceOperations);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 210);
            this.panel1.TabIndex = 5;
            // 
            // button_DeviceAddOperation
            // 
            this.button_DeviceAddOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceAddOperation.ImageKey = "add.ico";
            this.button_DeviceAddOperation.ImageList = this.ımageList_DeviceAddServiceOperations;
            this.button_DeviceAddOperation.Location = new System.Drawing.Point(92, 153);
            this.button_DeviceAddOperation.Name = "button_DeviceAddOperation";
            this.button_DeviceAddOperation.Size = new System.Drawing.Size(140, 41);
            this.button_DeviceAddOperation.TabIndex = 3;
            this.button_DeviceAddOperation.Text = "İşlem Ekle";
            this.button_DeviceAddOperation.UseVisualStyleBackColor = true;
            this.button_DeviceAddOperation.Click += new System.EventHandler(this.button_DeviceAddOperation_Click);
            // 
            // ımageList_DeviceAddServiceOperations
            // 
            this.ımageList_DeviceAddServiceOperations.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_DeviceAddServiceOperations.ImageStream")));
            this.ımageList_DeviceAddServiceOperations.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_DeviceAddServiceOperations.Images.SetKeyName(0, "add.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servis İşlemi :";
            // 
            // textBox_ServiceDescription
            // 
            this.textBox_ServiceDescription.Location = new System.Drawing.Point(116, 39);
            this.textBox_ServiceDescription.Multiline = true;
            this.textBox_ServiceDescription.Name = "textBox_ServiceDescription";
            this.textBox_ServiceDescription.Size = new System.Drawing.Size(167, 85);
            this.textBox_ServiceDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servis Açılama :";
            // 
            // textBox_ServiceOperations
            // 
            this.textBox_ServiceOperations.Location = new System.Drawing.Point(117, 9);
            this.textBox_ServiceOperations.Name = "textBox_ServiceOperations";
            this.textBox_ServiceOperations.Size = new System.Drawing.Size(167, 20);
            this.textBox_ServiceOperations.TabIndex = 1;
            // 
            // Form_DeviceAddServiceOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 232);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DeviceAddServiceOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servis İşlemi Ekle";
            this.Load += new System.EventHandler(this.Form_DeviceAddServiceOperations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ServiceDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ServiceOperations;
        private System.Windows.Forms.Button button_DeviceAddOperation;
        private System.Windows.Forms.ImageList ımageList_DeviceAddServiceOperations;
    }
}