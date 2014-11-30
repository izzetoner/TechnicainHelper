namespace TechnicianHelper
{
    partial class Form_DeviceAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DeviceAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DeviceBrandModel = new System.Windows.Forms.TextBox();
            this.textBox_DeviceDescription = new System.Windows.Forms.TextBox();
            this.button_DeviceAdd = new System.Windows.Forms.Button();
            this.ımageList_CustomerAdd = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Marka/Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Açıklaması     :";
            // 
            // textBox_DeviceBrandModel
            // 
            this.textBox_DeviceBrandModel.Location = new System.Drawing.Point(131, 28);
            this.textBox_DeviceBrandModel.Name = "textBox_DeviceBrandModel";
            this.textBox_DeviceBrandModel.Size = new System.Drawing.Size(162, 20);
            this.textBox_DeviceBrandModel.TabIndex = 1;
            // 
            // textBox_DeviceDescription
            // 
            this.textBox_DeviceDescription.Location = new System.Drawing.Point(131, 57);
            this.textBox_DeviceDescription.Multiline = true;
            this.textBox_DeviceDescription.Name = "textBox_DeviceDescription";
            this.textBox_DeviceDescription.Size = new System.Drawing.Size(162, 82);
            this.textBox_DeviceDescription.TabIndex = 2;
            // 
            // button_DeviceAdd
            // 
            this.button_DeviceAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DeviceAdd.ImageKey = "add.ico";
            this.button_DeviceAdd.ImageList = this.ımageList_CustomerAdd;
            this.button_DeviceAdd.Location = new System.Drawing.Point(99, 168);
            this.button_DeviceAdd.Name = "button_DeviceAdd";
            this.button_DeviceAdd.Size = new System.Drawing.Size(136, 41);
            this.button_DeviceAdd.TabIndex = 3;
            this.button_DeviceAdd.Text = "Cihaz Ekle";
            this.button_DeviceAdd.UseVisualStyleBackColor = true;
            this.button_DeviceAdd.Click += new System.EventHandler(this.button_DeviceAdd_Click);
            // 
            // ımageList_CustomerAdd
            // 
            this.ımageList_CustomerAdd.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_CustomerAdd.ImageStream")));
            this.ımageList_CustomerAdd.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_CustomerAdd.Images.SetKeyName(0, "add.ico");
            // 
            // Form_DeviceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 221);
            this.Controls.Add(this.button_DeviceAdd);
            this.Controls.Add(this.textBox_DeviceDescription);
            this.Controls.Add(this.textBox_DeviceBrandModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_DeviceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.Form_DeviceAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DeviceBrandModel;
        private System.Windows.Forms.TextBox textBox_DeviceDescription;
        private System.Windows.Forms.Button button_DeviceAdd;
        private System.Windows.Forms.ImageList ımageList_CustomerAdd;
    }
}