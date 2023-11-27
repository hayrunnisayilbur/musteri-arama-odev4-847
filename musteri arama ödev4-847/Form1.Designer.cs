namespace musteri_arama_ödev4_847
{
    partial class Form1
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
            this.lblMusteriler = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriler
            // 
            this.lblMusteriler.AutoSize = true;
            this.lblMusteriler.Location = new System.Drawing.Point(59, 121);
            this.lblMusteriler.Name = "lblMusteriler";
            this.lblMusteriler.Size = new System.Drawing.Size(54, 13);
            this.lblMusteriler.TabIndex = 0;
            this.lblMusteriler.Text = "müşteriler:";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(53, 323);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(60, 13);
            this.lblMusteriAdi.TabIndex = 1;
            this.lblMusteriAdi.Text = "müşteri adı:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "hayrunnisa",
            "ömer",
            "eymen",
            "kübra",
            "efe",
            "sukeyna",
            "mehmet",
            "rabia",
            "yunus",
            "deniz",
            "umut"});
            this.listBox1.Location = new System.Drawing.Point(119, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 186);
            this.listBox1.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 320);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(113, 20);
            this.txtAd.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(56, 358);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(176, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.lblMusteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriler;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
    }
}

