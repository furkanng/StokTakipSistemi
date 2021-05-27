
namespace StokTakipSistemi
{
    partial class formPaslanmazSac
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
            this.lstviewSac = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSacListele = new System.Windows.Forms.Button();
            this.comboxSac = new System.Windows.Forms.ComboBox();
            this.txtboxMiktarSac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstviewSac
            // 
            this.lstviewSac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstviewSac.HideSelection = false;
            this.lstviewSac.Location = new System.Drawing.Point(12, 163);
            this.lstviewSac.Name = "lstviewSac";
            this.lstviewSac.Size = new System.Drawing.Size(618, 303);
            this.lstviewSac.TabIndex = 13;
            this.lstviewSac.UseCompatibleStateImageBehavior = false;
            this.lstviewSac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Çap";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalınlık";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ağırlık";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Miktar";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 123;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCikar);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnSacListele);
            this.groupBox1.Controls.Add(this.comboxSac);
            this.groupBox1.Controls.Add(this.txtboxMiktarSac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paslanmaz Saç Ekle";
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(185, 80);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(106, 39);
            this.btnCikar.TabIndex = 15;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(47, 80);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 39);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSacListele
            // 
            this.btnSacListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSacListele.Location = new System.Drawing.Point(324, 80);
            this.btnSacListele.Name = "btnSacListele";
            this.btnSacListele.Size = new System.Drawing.Size(174, 40);
            this.btnSacListele.TabIndex = 8;
            this.btnSacListele.Text = "LİSTELE";
            this.btnSacListele.UseVisualStyleBackColor = true;
            // 
            // comboxSac
            // 
            this.comboxSac.FormattingEnabled = true;
            this.comboxSac.Location = new System.Drawing.Point(141, 37);
            this.comboxSac.Name = "comboxSac";
            this.comboxSac.Size = new System.Drawing.Size(194, 24);
            this.comboxSac.TabIndex = 13;
            // 
            // txtboxMiktarSac
            // 
            this.txtboxMiktarSac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxMiktarSac.Location = new System.Drawing.Point(456, 37);
            this.txtboxMiktarSac.Name = "txtboxMiktarSac";
            this.txtboxMiktarSac.Size = new System.Drawing.Size(121, 26);
            this.txtboxMiktarSac.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(367, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miktar :";
            // 
            // formPaslanmazSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 478);
            this.Controls.Add(this.lstviewSac);
            this.Controls.Add(this.groupBox1);
            this.Name = "formPaslanmazSac";
            this.Text = "PASLANMAZ SAÇ GİRİŞ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstviewSac;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSacListele;
        private System.Windows.Forms.ComboBox comboxSac;
        private System.Windows.Forms.TextBox txtboxMiktarSac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}