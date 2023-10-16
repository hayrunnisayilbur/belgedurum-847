namespace belge_durum_847
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
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblZayif = new System.Windows.Forms.Label();
            this.lblDevamsizlik = new System.Windows.Forms.Label();
            this.btnBelgeDurumGoster = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(165, 57);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 0;
            // 
            // txtZayif
            // 
            this.txtZayif.Location = new System.Drawing.Point(165, 93);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(100, 20);
            this.txtZayif.TabIndex = 1;
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Location = new System.Drawing.Point(165, 133);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(100, 20);
            this.txtDevamsizlik.TabIndex = 2;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(49, 57);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(75, 13);
            this.lblOrtalama.TabIndex = 3;
            this.lblOrtalama.Text = "not ortalaması:";
            // 
            // lblZayif
            // 
            this.lblZayif.AutoSize = true;
            this.lblZayif.Location = new System.Drawing.Point(49, 96);
            this.lblZayif.Name = "lblZayif";
            this.lblZayif.Size = new System.Drawing.Size(81, 13);
            this.lblZayif.TabIndex = 4;
            this.lblZayif.Text = "zayıf ortalaması:";
            // 
            // lblDevamsizlik
            // 
            this.lblDevamsizlik.AutoSize = true;
            this.lblDevamsizlik.Location = new System.Drawing.Point(52, 136);
            this.lblDevamsizlik.Name = "lblDevamsizlik";
            this.lblDevamsizlik.Size = new System.Drawing.Size(92, 13);
            this.lblDevamsizlik.TabIndex = 5;
            this.lblDevamsizlik.Text = "devamsızlık sayısı:";
            // 
            // btnBelgeDurumGoster
            // 
            this.btnBelgeDurumGoster.Location = new System.Drawing.Point(41, 176);
            this.btnBelgeDurumGoster.Name = "btnBelgeDurumGoster";
            this.btnBelgeDurumGoster.Size = new System.Drawing.Size(224, 37);
            this.btnBelgeDurumGoster.TabIndex = 6;
            this.btnBelgeDurumGoster.Text = "belge durum göster";
            this.btnBelgeDurumGoster.UseVisualStyleBackColor = true;
            this.btnBelgeDurumGoster.Click += new System.EventHandler(this.btnDurumGoster_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(52, 236);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(36, 13);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnBelgeDurumGoster);
            this.Controls.Add(this.lblDevamsizlik);
            this.Controls.Add(this.lblZayif);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.txtDevamsizlik);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtOrtalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblZayif;
        private System.Windows.Forms.Label lblDevamsizlik;
        private System.Windows.Forms.Button btnBelgeDurumGoster;
        private System.Windows.Forms.Label lblDurum;
    }
}

