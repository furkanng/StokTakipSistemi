
namespace StokTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUrunStok = new System.Windows.Forms.Button();
            this.btnMalzemeStok = new System.Windows.Forms.Button();
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnAnaCikis = new System.Windows.Forms.Button();
            this.btnTencereUretim = new System.Windows.Forms.Button();
            this.btnKapakUretim = new System.Windows.Forms.Button();
            this.btnHamMadde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunStok
            // 
            this.btnUrunStok.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUrunStok.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunStok.Location = new System.Drawing.Point(600, 195);
            this.btnUrunStok.Name = "btnUrunStok";
            this.btnUrunStok.Size = new System.Drawing.Size(176, 152);
            this.btnUrunStok.TabIndex = 5;
            this.btnUrunStok.Text = "ÜRÜN STOK";
            this.btnUrunStok.UseVisualStyleBackColor = false;
            // 
            // btnMalzemeStok
            // 
            this.btnMalzemeStok.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMalzemeStok.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalzemeStok.Location = new System.Drawing.Point(600, 29);
            this.btnMalzemeStok.Name = "btnMalzemeStok";
            this.btnMalzemeStok.Size = new System.Drawing.Size(176, 152);
            this.btnMalzemeStok.TabIndex = 6;
            this.btnMalzemeStok.Text = "MALZEME STOK";
            this.btnMalzemeStok.UseVisualStyleBackColor = false;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.BackColor = System.Drawing.SystemColors.Info;
            this.lblGiris.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiris.Location = new System.Drawing.Point(225, 29);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(347, 36);
            this.lblGiris.TabIndex = 7;
            this.lblGiris.Text = "STOK TAKİP SİSTEMİ";
            // 
            // btnAnaCikis
            // 
            this.btnAnaCikis.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnaCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaCikis.Location = new System.Drawing.Point(600, 361);
            this.btnAnaCikis.Name = "btnAnaCikis";
            this.btnAnaCikis.Size = new System.Drawing.Size(176, 77);
            this.btnAnaCikis.TabIndex = 9;
            this.btnAnaCikis.Text = "ÇIKIŞ";
            this.btnAnaCikis.UseVisualStyleBackColor = false;
            this.btnAnaCikis.Click += new System.EventHandler(this.btnAnaCikis_Click);
            // 
            // btnTencereUretim
            // 
            this.btnTencereUretim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTencereUretim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTencereUretim.Location = new System.Drawing.Point(26, 29);
            this.btnTencereUretim.Name = "btnTencereUretim";
            this.btnTencereUretim.Size = new System.Drawing.Size(176, 152);
            this.btnTencereUretim.TabIndex = 10;
            this.btnTencereUretim.Text = "TENCERE ÜRETİM";
            this.btnTencereUretim.UseVisualStyleBackColor = false;
            this.btnTencereUretim.Click += new System.EventHandler(this.btnTencereUretim_Click);
            // 
            // btnKapakUretim
            // 
            this.btnKapakUretim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapakUretim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapakUretim.Location = new System.Drawing.Point(26, 195);
            this.btnKapakUretim.Name = "btnKapakUretim";
            this.btnKapakUretim.Size = new System.Drawing.Size(176, 152);
            this.btnKapakUretim.TabIndex = 11;
            this.btnKapakUretim.Text = "KAPAK ÜRETİM";
            this.btnKapakUretim.UseVisualStyleBackColor = false;
            // 
            // btnHamMadde
            // 
            this.btnHamMadde.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHamMadde.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHamMadde.Location = new System.Drawing.Point(26, 361);
            this.btnHamMadde.Name = "btnHamMadde";
            this.btnHamMadde.Size = new System.Drawing.Size(176, 77);
            this.btnHamMadde.TabIndex = 12;
            this.btnHamMadde.Text = "HAM MADDE";
            this.btnHamMadde.UseVisualStyleBackColor = false;
            this.btnHamMadde.Click += new System.EventHandler(this.btnHamMadde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnHamMadde);
            this.Controls.Add(this.btnKapakUretim);
            this.Controls.Add(this.btnTencereUretim);
            this.Controls.Add(this.btnAnaCikis);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnMalzemeStok);
            this.Controls.Add(this.btnUrunStok);
            this.Name = "Form1";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUrunStok;
        private System.Windows.Forms.Button btnMalzemeStok;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Button btnAnaCikis;
        private System.Windows.Forms.Button btnTencereUretim;
        private System.Windows.Forms.Button btnKapakUretim;
        private System.Windows.Forms.Button btnHamMadde;
    }
}

