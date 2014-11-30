namespace TechnicianHelper
{
    partial class Form_CustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CustomerAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.textBox_customerTel = new System.Windows.Forms.TextBox();
            this.textBox_customerMail = new System.Windows.Forms.TextBox();
            this.textBox_customerAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.button_AddCustomer = new System.Windows.Forms.Button();
            this.ımageList_CustomerAdd = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Tel :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri  Mail :";
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Location = new System.Drawing.Point(125, 24);
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(129, 20);
            this.textBox_customerName.TabIndex = 1;
            // 
            // textBox_customerTel
            // 
            this.textBox_customerTel.Location = new System.Drawing.Point(124, 61);
            this.textBox_customerTel.MaxLength = 11;
            this.textBox_customerTel.Name = "textBox_customerTel";
            this.textBox_customerTel.Size = new System.Drawing.Size(130, 20);
            this.textBox_customerTel.TabIndex = 2;
            this.textBox_customerTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_customerTel_KeyPress);
            // 
            // textBox_customerMail
            // 
            this.textBox_customerMail.Location = new System.Drawing.Point(125, 165);
            this.textBox_customerMail.Name = "textBox_customerMail";
            this.textBox_customerMail.Size = new System.Drawing.Size(130, 20);
            this.textBox_customerMail.TabIndex = 4;
            // 
            // textBox_customerAdress
            // 
            this.textBox_customerAdress.Location = new System.Drawing.Point(125, 94);
            this.textBox_customerAdress.Multiline = true;
            this.textBox_customerAdress.Name = "textBox_customerAdress";
            this.textBox_customerAdress.Size = new System.Drawing.Size(130, 48);
            this.textBox_customerAdress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet :";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(44, 239);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(43, 17);
            this.radioButton_Male.TabIndex = 5;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Bay";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(113, 239);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Female.TabIndex = 6;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Bayan";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddCustomer.ImageKey = "add.ico";
            this.button_AddCustomer.ImageList = this.ımageList_CustomerAdd;
            this.button_AddCustomer.Location = new System.Drawing.Point(76, 282);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.Size = new System.Drawing.Size(137, 43);
            this.button_AddCustomer.TabIndex = 7;
            this.button_AddCustomer.Text = "Müşteri Ekle";
            this.button_AddCustomer.UseVisualStyleBackColor = true;
            this.button_AddCustomer.Click += new System.EventHandler(this.button_Addcustomer_Click);
            // 
            // ımageList_CustomerAdd
            // 
            this.ımageList_CustomerAdd.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_CustomerAdd.ImageStream")));
            this.ımageList_CustomerAdd.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_CustomerAdd.Images.SetKeyName(0, "add.ico");
            // 
            // Form_CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(294, 337);
            this.Controls.Add(this.button_AddCustomer);
            this.Controls.Add(this.textBox_customerAdress);
            this.Controls.Add(this.textBox_customerMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_customerTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_customerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CustomerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.Form_customerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.TextBox textBox_customerTel;
        private System.Windows.Forms.TextBox textBox_customerMail;
        private System.Windows.Forms.TextBox textBox_customerAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.Button button_AddCustomer;
        private System.Windows.Forms.ImageList ımageList_CustomerAdd;
    }
}