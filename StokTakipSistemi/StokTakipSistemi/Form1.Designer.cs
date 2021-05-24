
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
            this.btnKesimhane = new System.Windows.Forms.Button();
            this.btnPreshane = new System.Windows.Forms.Button();
            this.btnCakma = new System.Windows.Forms.Button();
            this.btnForma = new System.Windows.Forms.Button();
            this.btnKulpMontaj = new System.Windows.Forms.Button();
            this.btnUrunStok = new System.Windows.Forms.Button();
            this.btnMalzemeStok = new System.Windows.Forms.Button();
            this.lblGiris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnaCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKesimhane
            // 
            this.btnKesimhane.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKesimhane.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKesimhane.Location = new System.Drawing.Point(12, 29);
            this.btnKesimhane.Name = "btnKesimhane";
            this.btnKesimhane.Size = new System.Drawing.Size(189, 77);
            this.btnKesimhane.TabIndex = 0;
            this.btnKesimhane.Text = "KESİMHANE ";
            this.btnKesimhane.UseVisualStyleBackColor = false;
            this.btnKesimhane.Click += new System.EventHandler(this.btnKesimhane_Click);
            // 
            // btnPreshane
            // 
            this.btnPreshane.BackColor = System.Drawing.Color.Yellow;
            this.btnPreshane.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreshane.Location = new System.Drawing.Point(12, 112);
            this.btnPreshane.Name = "btnPreshane";
            this.btnPreshane.Size = new System.Drawing.Size(189, 77);
            this.btnPreshane.TabIndex = 1;
            this.btnPreshane.Text = "PRESHANE";
            this.btnPreshane.UseVisualStyleBackColor = false;
            // 
            // btnCakma
            // 
            this.btnCakma.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCakma.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCakma.Location = new System.Drawing.Point(12, 195);
            this.btnCakma.Name = "btnCakma";
            this.btnCakma.Size = new System.Drawing.Size(189, 77);
            this.btnCakma.TabIndex = 2;
            this.btnCakma.Text = "ÇAKMA";
            this.btnCakma.UseVisualStyleBackColor = false;
            // 
            // btnForma
            // 
            this.btnForma.BackColor = System.Drawing.Color.Violet;
            this.btnForma.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForma.Location = new System.Drawing.Point(12, 278);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(189, 77);
            this.btnForma.TabIndex = 3;
            this.btnForma.Text = "FORMA";
            this.btnForma.UseVisualStyleBackColor = false;
            // 
            // btnKulpMontaj
            // 
            this.btnKulpMontaj.BackColor = System.Drawing.Color.Purple;
            this.btnKulpMontaj.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulpMontaj.Location = new System.Drawing.Point(12, 361);
            this.btnKulpMontaj.Name = "btnKulpMontaj";
            this.btnKulpMontaj.Size = new System.Drawing.Size(189, 77);
            this.btnKulpMontaj.TabIndex = 4;
            this.btnKulpMontaj.Text = "KULP MONTAJ";
            this.btnKulpMontaj.UseVisualStyleBackColor = false;
            // 
            // btnUrunStok
            // 
            this.btnUrunStok.BackColor = System.Drawing.Color.ForestGreen;
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
            this.btnMalzemeStok.BackColor = System.Drawing.Color.Chocolate;
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
            this.lblGiris.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiris.Location = new System.Drawing.Point(225, 29);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(347, 36);
            this.lblGiris.TabIndex = 7;
            this.lblGiris.Text = "STOK TAKİP SİSTEMİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(251, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "DEVELOPER : FURKAN GÜZELGÖRÜR";
            // 
            // btnAnaCikis
            // 
            this.btnAnaCikis.BackColor = System.Drawing.Color.Red;
            this.btnAnaCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaCikis.Location = new System.Drawing.Point(600, 361);
            this.btnAnaCikis.Name = "btnAnaCikis";
            this.btnAnaCikis.Size = new System.Drawing.Size(176, 77);
            this.btnAnaCikis.TabIndex = 9;
            this.btnAnaCikis.Text = "ÇIKIŞ";
            this.btnAnaCikis.UseVisualStyleBackColor = false;
            this.btnAnaCikis.Click += new System.EventHandler(this.btnAnaCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnaCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnMalzemeStok);
            this.Controls.Add(this.btnUrunStok);
            this.Controls.Add(this.btnKulpMontaj);
            this.Controls.Add(this.btnForma);
            this.Controls.Add(this.btnCakma);
            this.Controls.Add(this.btnPreshane);
            this.Controls.Add(this.btnKesimhane);
            this.Name = "Form1";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKesimhane;
        private System.Windows.Forms.Button btnPreshane;
        private System.Windows.Forms.Button btnCakma;
        private System.Windows.Forms.Button btnForma;
        private System.Windows.Forms.Button btnKulpMontaj;
        private System.Windows.Forms.Button btnUrunStok;
        private System.Windows.Forms.Button btnMalzemeStok;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnaCikis;
    }
}

