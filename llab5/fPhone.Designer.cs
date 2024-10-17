using System.Drawing;
using System.Windows.Forms;

namespace llab5
{
    partial class fPhone
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
            this.cbHas3Cameras = new System.Windows.Forms.CheckBox();
            this.cbHasWirelessCharging = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBatteryCapacity = new System.Windows.Forms.TextBox();
            this.tbYearofPurchase = new System.Windows.Forms.TextBox();
            this.tbReleaseYear = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHas3Cameras
            // 
            this.cbHas3Cameras.AutoSize = true;
            this.cbHas3Cameras.Location = new System.Drawing.Point(22, 27);
            this.cbHas3Cameras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHas3Cameras.Name = "cbHas3Cameras";
            this.cbHas3Cameras.Size = new System.Drawing.Size(115, 17);
            this.cbHas3Cameras.TabIndex = 0;
            this.cbHas3Cameras.Text = "Has three cameras";
            this.cbHas3Cameras.UseVisualStyleBackColor = true;
            // 
            // cbHasWirelessCharging
            // 
            this.cbHasWirelessCharging.AutoSize = true;
            this.cbHasWirelessCharging.Location = new System.Drawing.Point(22, 69);
            this.cbHasWirelessCharging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHasWirelessCharging.Name = "cbHasWirelessCharging";
            this.cbHasWirelessCharging.Size = new System.Drawing.Size(129, 17);
            this.cbHasWirelessCharging.TabIndex = 1;
            this.cbHasWirelessCharging.Text = "Has wireless charging";
            this.cbHasWirelessCharging.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 24);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Firm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost ($)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Release year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year of purchase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Battery capacity(mA/h)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBatteryCapacity);
            this.groupBox1.Controls.Add(this.tbYearofPurchase);
            this.groupBox1.Controls.Add(this.tbReleaseYear);
            this.groupBox1.Controls.Add(this.tbCost);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(340, 245);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General info";
            // 
            // tbBatteryCapacity
            // 
            this.tbBatteryCapacity.Location = new System.Drawing.Point(188, 218);
            this.tbBatteryCapacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBatteryCapacity.Name = "tbBatteryCapacity";
            this.tbBatteryCapacity.Size = new System.Drawing.Size(95, 20);
            this.tbBatteryCapacity.TabIndex = 13;
            // 
            // tbYearofPurchase
            // 
            this.tbYearofPurchase.Location = new System.Drawing.Point(188, 177);
            this.tbYearofPurchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbYearofPurchase.Name = "tbYearofPurchase";
            this.tbYearofPurchase.Size = new System.Drawing.Size(95, 20);
            this.tbYearofPurchase.TabIndex = 12;
            // 
            // tbReleaseYear
            // 
            this.tbReleaseYear.Location = new System.Drawing.Point(188, 135);
            this.tbReleaseYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReleaseYear.Name = "tbReleaseYear";
            this.tbReleaseYear.Size = new System.Drawing.Size(95, 20);
            this.tbReleaseYear.TabIndex = 11;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(188, 94);
            this.tbCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(95, 20);
            this.tbCost.TabIndex = 10;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(188, 51);
            this.tbModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(95, 20);
            this.tbModel.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(188, 17);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(95, 20);
            this.tbName.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHasWirelessCharging);
            this.groupBox2.Controls.Add(this.cbHas3Cameras);
            this.groupBox2.Location = new System.Drawing.Point(9, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(340, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Features";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(354, 21);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 19);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(354, 56);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 19);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fPhone
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(460, 372);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fPhone";
            this.Text = "New phone info";
            this.Load += new System.EventHandler(this.fPhone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbHas3Cameras;
        private CheckBox cbHasWirelessCharging;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbBatteryCapacity;
        private TextBox tbYearofPurchase;
        private TextBox tbReleaseYear;
        private TextBox tbCost;
        private TextBox tbModel;
        private TextBox tbName;
        private Button btnOk;
        private Button btnCancel;
    }
}