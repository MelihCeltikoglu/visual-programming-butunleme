namespace Vista
{
    partial class HaberKategorileri
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuncelle = new System.Windows.Forms.TextBox();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.kategoriGridListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 35);
            this.label7.TabIndex = 35;
            this.label7.Text = "HABER KATEGORİLERİ YÖNETİMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(912, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Güncellenecek ID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Silinecek Kaydın ID\'sini yazınız ve Kayıt Sil\'e tıklayınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(946, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kayıt güncellemek için yukarıdaki alanları doldurunuz ve güncellemek istediğiniz " +
    "kaydın ID\'sini sağdaki alana giriniz. Ardından kayıt güncelle butonuna tıklayını" +
    "z.";
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(1037, 396);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtGuncelle.TabIndex = 31;
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(107, 558);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(75, 22);
            this.txtSil.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Silinecek ID : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 321);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(649, 22);
            this.txtNombre.TabIndex = 26;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 327);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 20);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Kategori Adı:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(788, 60);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(114, 218);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "Listeyi Getir";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 558);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Kayıt Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1037, 425);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 61);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Kayıt Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(788, 321);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 26);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Kayıt Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // kategoriGridListesi
            // 
            this.kategoriGridListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategoriGridListesi.Location = new System.Drawing.Point(17, 60);
            this.kategoriGridListesi.Name = "kategoriGridListesi";
            this.kategoriGridListesi.RowHeadersWidth = 51;
            this.kategoriGridListesi.RowTemplate.Height = 24;
            this.kategoriGridListesi.Size = new System.Drawing.Size(749, 218);
            this.kategoriGridListesi.TabIndex = 36;
            // 
            // HaberKategorileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 640);
            this.Controls.Add(this.kategoriGridListesi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "HaberKategorileri";
            this.Text = "HaberKategorileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HaberKategorileri_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGridListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuncelle;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView kategoriGridListesi;
    }
}