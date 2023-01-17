namespace Vista
{
    partial class FutbolHaberleri
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
            this.components = new System.ComponentModel.Container();
            this.futbolHaberleriListesi = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberBaslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıcerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCraest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.txtGuncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.futbolHaberleriListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // futbolHaberleriListesi
            // 
            this.futbolHaberleriListesi.AutoGenerateColumns = false;
            this.futbolHaberleriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.futbolHaberleriListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.haberBaslikDataGridViewTextBoxColumn,
            this.resimYoluDataGridViewTextBoxColumn,
            this.yazanDataGridViewTextBoxColumn,
            this.ıcerikDataGridViewTextBoxColumn});
            this.futbolHaberleriListesi.DataSource = this.alumnoBindingSource;
            this.futbolHaberleriListesi.Location = new System.Drawing.Point(16, 62);
            this.futbolHaberleriListesi.Margin = new System.Windows.Forms.Padding(4);
            this.futbolHaberleriListesi.Name = "futbolHaberleriListesi";
            this.futbolHaberleriListesi.RowHeadersWidth = 51;
            this.futbolHaberleriListesi.Size = new System.Drawing.Size(753, 218);
            this.futbolHaberleriListesi.TabIndex = 0;
            this.futbolHaberleriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.futbolHaberleriListesi_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // haberBaslikDataGridViewTextBoxColumn
            // 
            this.haberBaslikDataGridViewTextBoxColumn.DataPropertyName = "HaberBaslik";
            this.haberBaslikDataGridViewTextBoxColumn.HeaderText = "HaberBaslik";
            this.haberBaslikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haberBaslikDataGridViewTextBoxColumn.Name = "haberBaslikDataGridViewTextBoxColumn";
            this.haberBaslikDataGridViewTextBoxColumn.Width = 125;
            // 
            // resimYoluDataGridViewTextBoxColumn
            // 
            this.resimYoluDataGridViewTextBoxColumn.DataPropertyName = "ResimYolu";
            this.resimYoluDataGridViewTextBoxColumn.HeaderText = "ResimYolu";
            this.resimYoluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimYoluDataGridViewTextBoxColumn.Name = "resimYoluDataGridViewTextBoxColumn";
            this.resimYoluDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazanDataGridViewTextBoxColumn
            // 
            this.yazanDataGridViewTextBoxColumn.DataPropertyName = "Yazan";
            this.yazanDataGridViewTextBoxColumn.HeaderText = "Yazan";
            this.yazanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazanDataGridViewTextBoxColumn.Name = "yazanDataGridViewTextBoxColumn";
            this.yazanDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıcerikDataGridViewTextBoxColumn
            // 
            this.ıcerikDataGridViewTextBoxColumn.DataPropertyName = "Icerik";
            this.ıcerikDataGridViewTextBoxColumn.HeaderText = "Icerik";
            this.ıcerikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıcerikDataGridViewTextBoxColumn.Name = "ıcerikDataGridViewTextBoxColumn";
            this.ıcerikDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(Modelo.FutbolHaberi);
            this.alumnoBindingSource.CurrentChanged += new System.EventHandler(this.alumnoBindingSource_CurrentChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(791, 323);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 105);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Kayıt Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1040, 530);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 61);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Kayıt Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 722);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Kayıt Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(791, 62);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(114, 218);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Listeyi Getir";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 329);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Haber Başlık:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İçerik :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yazan:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 323);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(649, 22);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(120, 361);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(649, 22);
            this.txtEdad.TabIndex = 9;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtCraest
            // 
            this.txtCraest.Location = new System.Drawing.Point(120, 406);
            this.txtCraest.Margin = new System.Windows.Forms.Padding(4);
            this.txtCraest.Name = "txtCraest";
            this.txtCraest.Size = new System.Drawing.Size(649, 22);
            this.txtCraest.TabIndex = 10;
            this.txtCraest.TextChanged += new System.EventHandler(this.txtCraest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 722);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Silinecek ID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(100, 722);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(75, 22);
            this.txtSil.TabIndex = 12;
            this.txtSil.TextChanged += new System.EventHandler(this.txtSil_TextChanged);
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(1040, 501);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtGuncelle.TabIndex = 13;
            this.txtGuncelle.TextChanged += new System.EventHandler(this.txtGuncelle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(946, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kayıt güncellemek için yukarıdaki alanları doldurunuz ve güncellemek istediğiniz " +
    "kaydın ID\'sini sağdaki alana giriniz. Ardından kayıt güncelle butonuna tıklayını" +
    "z.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 733);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Silinecek Kaydın ID\'sini yazınız ve Kayıt Sil\'e tıklayınız.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(915, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Güncellenecek ID: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(969, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "FUTBOL HABERLERINI EKLEME SILME VE OLUŞTURMA İŞLEMLERİ İÇİN BU SAYFA KULLANILMAKT" +
    "ADIR";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // FutbolHaberleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 763);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCraest);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.futbolHaberleriListesi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FutbolHaberleri";
            this.Text = "Futbol Haberleri Listeleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FutbolHaberleri_FormClosed);
            this.Load += new System.EventHandler(this.FutbolHaberleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futbolHaberleriListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView futbolHaberleriListesi;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCraest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haberBaslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıcerikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.TextBox txtGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

