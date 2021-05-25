
namespace StokTakipSistemi
{
    partial class FormTencereUretim
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
            this.btnTencereKesim = new System.Windows.Forms.Button();
            this.btnTencerePres = new System.Windows.Forms.Button();
            this.btnTencereCakma = new System.Windows.Forms.Button();
            this.btnTencereForma = new System.Windows.Forms.Button();
            this.btnKulpMontaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTencereKesim
            // 
            this.btnTencereKesim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTencereKesim.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTencereKesim.Location = new System.Drawing.Point(31, 23);
            this.btnTencereKesim.Name = "btnTencereKesim";
            this.btnTencereKesim.Size = new System.Drawing.Size(140, 217);
            this.btnTencereKesim.TabIndex = 13;
            this.btnTencereKesim.Text = "KESİMHANE";
            this.btnTencereKesim.UseVisualStyleBackColor = false;
            // 
            // btnTencerePres
            // 
            this.btnTencerePres.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTencerePres.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTencerePres.Location = new System.Drawing.Point(177, 23);
            this.btnTencerePres.Name = "btnTencerePres";
            this.btnTencerePres.Size = new System.Drawing.Size(140, 217);
            this.btnTencerePres.TabIndex = 14;
            this.btnTencerePres.Text = "PRESHANE";
            this.btnTencerePres.UseVisualStyleBackColor = false;
            // 
            // btnTencereCakma
            // 
            this.btnTencereCakma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTencereCakma.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTencereCakma.Location = new System.Drawing.Point(323, 23);
            this.btnTencereCakma.Name = "btnTencereCakma";
            this.btnTencereCakma.Size = new System.Drawing.Size(140, 217);
            this.btnTencereCakma.TabIndex = 15;
            this.btnTencereCakma.Text = "ÇAKMA";
            this.btnTencereCakma.UseVisualStyleBackColor = false;
            // 
            // btnTencereForma
            // 
            this.btnTencereForma.AccessibleDescription = "";
            this.btnTencereForma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTencereForma.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTencereForma.Location = new System.Drawing.Point(469, 23);
            this.btnTencereForma.Name = "btnTencereForma";
            this.btnTencereForma.Size = new System.Drawing.Size(140, 217);
            this.btnTencereForma.TabIndex = 16;
            this.btnTencereForma.Text = "FORMA";
            this.btnTencereForma.UseVisualStyleBackColor = false;
            // 
            // btnKulpMontaj
            // 
            this.btnKulpMontaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKulpMontaj.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulpMontaj.Location = new System.Drawing.Point(615, 23);
            this.btnKulpMontaj.Name = "btnKulpMontaj";
            this.btnKulpMontaj.Size = new System.Drawing.Size(140, 217);
            this.btnKulpMontaj.TabIndex = 17;
            this.btnKulpMontaj.Text = "KULP MONTAJ";
            this.btnKulpMontaj.UseVisualStyleBackColor = false;
            // 
            // FormTencereUretim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKulpMontaj);
            this.Controls.Add(this.btnTencereForma);
            this.Controls.Add(this.btnTencereCakma);
            this.Controls.Add(this.btnTencerePres);
            this.Controls.Add(this.btnTencereKesim);
            this.Name = "FormTencereUretim";
            this.Text = "TENCERE ÜRETİM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTencereKesim;
        private System.Windows.Forms.Button btnTencerePres;
        private System.Windows.Forms.Button btnTencereCakma;
        private System.Windows.Forms.Button btnTencereForma;
        private System.Windows.Forms.Button btnKulpMontaj;
    }
}