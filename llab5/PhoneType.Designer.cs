namespace llab5
{
    partial class PhoneType
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxPhoneType;
        private System.Windows.Forms.Button butnOk;
        private System.Windows.Forms.Button butnCancel;
        private System.Windows.Forms.Label labelSelectType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxPhoneType = new System.Windows.Forms.ComboBox();
            this.butnOk = new System.Windows.Forms.Button();
            this.butnCancel = new System.Windows.Forms.Button();
            this.labelSelectType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPhoneType
            // 
            this.comboBoxPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhoneType.FormattingEnabled = true;
            this.comboBoxPhoneType.Items.AddRange(new object[] {
            "SmartPhone",
            "BasicPhone"});
            this.comboBoxPhoneType.Location = new System.Drawing.Point(30, 50);
            this.comboBoxPhoneType.Name = "comboBoxPhoneType";
            this.comboBoxPhoneType.Size = new System.Drawing.Size(220, 21);
            this.comboBoxPhoneType.TabIndex = 0;
            this.comboBoxPhoneType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhoneType_SelectedIndexChanged);
            // 
            // butnOk
            // 
            this.butnOk.Location = new System.Drawing.Point(30, 90);
            this.butnOk.Name = "butnOk";
            this.butnOk.Size = new System.Drawing.Size(75, 23);
            this.butnOk.TabIndex = 1;
            this.butnOk.Text = "OK";
            this.butnOk.UseVisualStyleBackColor = true;
            this.butnOk.Click += new System.EventHandler(this.butnOk_Click);
            // 
            // butnCancel
            // 
            this.butnCancel.Location = new System.Drawing.Point(175, 90);
            this.butnCancel.Name = "butnCancel";
            this.butnCancel.Size = new System.Drawing.Size(75, 23);
            this.butnCancel.TabIndex = 2;
            this.butnCancel.Text = "Cancel";
            this.butnCancel.UseVisualStyleBackColor = true;
            this.butnCancel.Click += new System.EventHandler(this.butnCancel_Click);
            // 
            // labelSelectType
            // 
            this.labelSelectType.AutoSize = true;
            this.labelSelectType.Location = new System.Drawing.Point(30, 20);
            this.labelSelectType.Name = "labelSelectType";
            this.labelSelectType.Size = new System.Drawing.Size(101, 13);
            this.labelSelectType.TabIndex = 3;
            this.labelSelectType.Text = "Select Phone Type:";
            // 
            // PhoneType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.labelSelectType);
            this.Controls.Add(this.comboBoxPhoneType);
            this.Controls.Add(this.butnOk);
            this.Controls.Add(this.butnCancel);
            this.Name = "PhoneType";
            this.Text = "Select Phone Type";
            this.Load += new System.EventHandler(this.PhoneType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}