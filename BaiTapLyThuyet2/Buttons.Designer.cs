namespace BaiTapLyThuyet2
{
    partial class Buttons
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButtonFlat = new System.Windows.Forms.Button();
            this.chkMauChu = new System.Windows.Forms.CheckBox();
            this.chkMauNen = new System.Windows.Forms.CheckBox();
            this.rdPopUp = new System.Windows.Forms.RadioButton();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(53, 83);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // btnButtonFlat
            // 
            this.btnButtonFlat.Location = new System.Drawing.Point(53, 182);
            this.btnButtonFlat.Name = "btnButtonFlat";
            this.btnButtonFlat.Size = new System.Drawing.Size(75, 23);
            this.btnButtonFlat.TabIndex = 0;
            this.btnButtonFlat.Text = "button flat";
            this.btnButtonFlat.UseVisualStyleBackColor = true;
            // 
            // chkMauChu
            // 
            this.chkMauChu.AutoSize = true;
            this.chkMauChu.Location = new System.Drawing.Point(200, 61);
            this.chkMauChu.Name = "chkMauChu";
            this.chkMauChu.Size = new System.Drawing.Size(112, 17);
            this.chkMauChu.TabIndex = 1;
            this.chkMauChu.Text = "Thay đổi màu chữ";
            this.chkMauChu.UseVisualStyleBackColor = true;
            this.chkMauChu.CheckedChanged += new System.EventHandler(this.chkMauChu_CheckedChanged);
            // 
            // chkMauNen
            // 
            this.chkMauNen.AutoSize = true;
            this.chkMauNen.Location = new System.Drawing.Point(200, 109);
            this.chkMauNen.Name = "chkMauNen";
            this.chkMauNen.Size = new System.Drawing.Size(112, 17);
            this.chkMauNen.TabIndex = 1;
            this.chkMauNen.Text = "Thay đổi màu nền";
            this.chkMauNen.UseVisualStyleBackColor = true;
            this.chkMauNen.CheckedChanged += new System.EventHandler(this.chkMauNen_CheckedChanged);
            // 
            // rdPopUp
            // 
            this.rdPopUp.AutoSize = true;
            this.rdPopUp.Location = new System.Drawing.Point(200, 163);
            this.rdPopUp.Name = "rdPopUp";
            this.rdPopUp.Size = new System.Drawing.Size(82, 17);
            this.rdPopUp.TabIndex = 2;
            this.rdPopUp.TabStop = true;
            this.rdPopUp.Text = "Kiểu pop up";
            this.rdPopUp.UseVisualStyleBackColor = true;
            this.rdPopUp.CheckedChanged += new System.EventHandler(this.rdPopUp_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(200, 202);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(63, 17);
            this.rdFlat.TabIndex = 2;
            this.rdFlat.TabStop = true;
            this.rdFlat.Text = "Kiểu flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.rdPopUp);
            this.Controls.Add(this.chkMauNen);
            this.Controls.Add(this.chkMauChu);
            this.Controls.Add(this.btnButtonFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "Buttons";
            this.Text = "Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButtonFlat;
        private System.Windows.Forms.CheckBox chkMauChu;
        private System.Windows.Forms.CheckBox chkMauNen;
        private System.Windows.Forms.RadioButton rdPopUp;
        private System.Windows.Forms.RadioButton rdFlat;
    }
}