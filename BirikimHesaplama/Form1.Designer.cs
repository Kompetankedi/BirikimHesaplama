namespace BirikimHesaplama
{
    partial class Birikim
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
            this.lblHedef = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBakiyeEkle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBelirle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHdfblr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hedef:";
            // 
            // lblHedef
            // 
            this.lblHedef.AutoSize = true;
            this.lblHedef.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedef.Location = new System.Drawing.Point(111, 9);
            this.lblHedef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHedef.Name = "lblHedef";
            this.lblHedef.Size = new System.Drawing.Size(62, 32);
            this.lblHedef.TabIndex = 2;
            this.lblHedef.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bakiye:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(111, 54);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(62, 32);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Null";
            // 
            // txtBakiyeEkle
            // 
            this.txtBakiyeEkle.Location = new System.Drawing.Point(99, 290);
            this.txtBakiyeEkle.Name = "txtBakiyeEkle";
            this.txtBakiyeEkle.Size = new System.Drawing.Size(115, 25);
            this.txtBakiyeEkle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bakiye Ekle:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBelirle
            // 
            this.btnBelirle.Location = new System.Drawing.Point(150, 180);
            this.btnBelirle.Name = "btnBelirle";
            this.btnBelirle.Size = new System.Drawing.Size(75, 23);
            this.btnBelirle.TabIndex = 10;
            this.btnBelirle.Text = "Belirle";
            this.btnBelirle.UseVisualStyleBackColor = true;
            this.btnBelirle.Click += new System.EventHandler(this.btnBelirle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hedef Belirle:";
            // 
            // txtHdfblr
            // 
            this.txtHdfblr.Location = new System.Drawing.Point(110, 149);
            this.txtHdfblr.Name = "txtHdfblr";
            this.txtHdfblr.Size = new System.Drawing.Size(115, 25);
            this.txtHdfblr.TabIndex = 8;
            this.txtHdfblr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Birikim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 448);
            this.Controls.Add(this.btnBelirle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHdfblr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBakiyeEkle);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHedef);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Birikim";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Birikim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHedef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBakiyeEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBelirle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHdfblr;
    }
}

