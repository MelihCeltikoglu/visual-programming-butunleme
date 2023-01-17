namespace Vista
{
    partial class HaberYorumlari
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
            this.haberYorumListesi = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.haberYorumListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // haberYorumListesi
            // 
            this.haberYorumListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.haberYorumListesi.Location = new System.Drawing.Point(16, 161);
            this.haberYorumListesi.Margin = new System.Windows.Forms.Padding(4);
            this.haberYorumListesi.Name = "haberYorumListesi";
            this.haberYorumListesi.RowHeadersWidth = 51;
            this.haberYorumListesi.Size = new System.Drawing.Size(767, 240);
            this.haberYorumListesi.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(246, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // HaberYorumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.haberYorumListesi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HaberYorumlari";
            this.Text = "HaberYorumlari";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HaberYorumlari_FormClosed);
            this.Load += new System.EventHandler(this.HaberYorumlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.haberYorumListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView haberYorumListesi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}