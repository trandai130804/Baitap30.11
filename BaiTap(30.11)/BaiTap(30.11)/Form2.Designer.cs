namespace BaiTap_30._11_
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtms = new System.Windows.Forms.TextBox();
            this.btnyes = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số";
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(127, 45);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(438, 22);
            this.txtms.TabIndex = 1;
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(108, 207);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(75, 23);
            this.btnyes.TabIndex = 2;
            this.btnyes.Text = "Đồng ý";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(127, 95);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(438, 22);
            this.txtten.TabIndex = 3;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(127, 147);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(438, 22);
            this.txtluong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lương";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(297, 207);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 7;
            this.btnno.Text = "Bỏ Qua";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 262);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.txtms);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "NhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnno;
    }
}