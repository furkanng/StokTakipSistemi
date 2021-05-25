
namespace StokTakipSistemi
{
    partial class formHammadde
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
            this.btnAlüminyum = new System.Windows.Forms.Button();
            this.btnPaslanmazSac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlüminyum
            // 
            this.btnAlüminyum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlüminyum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlüminyum.Location = new System.Drawing.Point(44, 74);
            this.btnAlüminyum.Name = "btnAlüminyum";
            this.btnAlüminyum.Size = new System.Drawing.Size(176, 152);
            this.btnAlüminyum.TabIndex = 11;
            this.btnAlüminyum.Text = "ALÜMİNYUM";
            this.btnAlüminyum.UseVisualStyleBackColor = false;
            this.btnAlüminyum.Click += new System.EventHandler(this.btnAlüminyum_Click);
            // 
            // btnPaslanmazSac
            // 
            this.btnPaslanmazSac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPaslanmazSac.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaslanmazSac.Location = new System.Drawing.Point(286, 74);
            this.btnPaslanmazSac.Name = "btnPaslanmazSac";
            this.btnPaslanmazSac.Size = new System.Drawing.Size(176, 152);
            this.btnPaslanmazSac.TabIndex = 12;
            this.btnPaslanmazSac.Text = "PASLANMAZ SAÇ";
            this.btnPaslanmazSac.UseVisualStyleBackColor = false;
            // 
            // formHammadde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPaslanmazSac);
            this.Controls.Add(this.btnAlüminyum);
            this.Name = "formHammadde";
            this.Text = "HAMMADDE GİRİŞ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlüminyum;
        private System.Windows.Forms.Button btnPaslanmazSac;
    }
}