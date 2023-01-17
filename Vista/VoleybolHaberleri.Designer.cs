namespace Vista
{
    partial class VoleybolHaberleri
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuncelle = new System.Windows.Forms.TextBox();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ıcerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimYoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haberBaslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtCraest = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.futbolHaberleriListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolHaberleriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(995, 28);
            this.label7.TabIndex = 35;
            this.label7.Text = "VOLEYBOL HABERLERINI EKLEME SILME VE OLUŞTURMA İŞLEMLERİ İÇİN BU SAYFA KULLANILMA" +
    "KTADIR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 729);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Silinecek Kaydın ID\'sini yazınız ve Kayıt Sil\'e tıklayınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(946, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Kayıt güncellemek için yukarıdaki alanları doldurunuz ve güncellemek istediğiniz " +
    "kaydın ID\'sini sağdaki alana giriniz. Ardından kayıt güncelle butonuna tıklayını" +
    "z.";
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(1042, 497);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtGuncelle.TabIndex = 31;
            // 
            // txtSil
            // 
            this.txtSil.Location = new System.Drawing.Point(102, 718);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(75, 22);
            this.txtSil.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 718);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Silinecek ID : ";
            // 
            // ıcerikDataGridViewTextBoxColumn
            // 
            this.ıcerikDataGridViewTextBoxColumn.DataPropertyName = "Icerik";
            this.ıcerikDataGridViewTextBoxColumn.HeaderText = "Icerik";
            this.ıcerikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıcerikDataGridViewTextBoxColumn.Name = "ıcerikDataGridViewTextBoxColumn";
            this.ıcerikDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazanDataGridViewTextBoxColumn
            // 
            this.yazanDataGridViewTextBoxColumn.DataPropertyName = "Yazan";
            this.yazanDataGridViewTextBoxColumn.HeaderText = "Yazan";
            this.yazanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazanDataGridViewTextBoxColumn.Name = "yazanDataGridViewTextBoxColumn";
            this.yazanDataGridViewTextBoxColumn.Width = 125;
            // 
            // resimYoluDataGridViewTextBoxColumn
            // 
            this.resimYoluDataGridViewTextBoxColumn.DataPropertyName = "ResimYolu";
            this.resimYoluDataGridViewTextBoxColumn.HeaderText = "ResimYolu";
            this.resimYoluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimYoluDataGridViewTextBoxColumn.Name = "resimYoluDataGridViewTextBoxColumn";
            this.resimYoluDataGridViewTextBoxColumn.Width = 125;
            // 
            // haberBaslikDataGridViewTextBoxColumn
            // 
            this.haberBaslikDataGridViewTextBoxColumn.DataPropertyName = "HaberBaslik";
            this.haberBaslikDataGridViewTextBoxColumn.HeaderText = "HaberBaslik";
            this.haberBaslikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.haberBaslikDataGridViewTextBoxColumn.Name = "haberBaslikDataGridViewTextBoxColumn";
            this.haberBaslikDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(Modelo.FutbolHaberi);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(917, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Güncellenecek ID: ";
            // 
            // txtCraest
            // 
            this.txtCraest.Location = new System.Drawing.Point(122, 402);
            this.txtCraest.Margin = new System.Windows.Forms.Padding(4);
            this.txtCraest.Name = "txtCraest";
            this.txtCraest.Size = new System.Drawing.Size(649, 22);
            this.txtCraest.TabIndex = 28;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(122, 357);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(649, 22);
            this.txtEdad.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 319);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(649, 22);
            this.txtNombre.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yazan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "İçerik :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 325);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 16);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Haber Başlık:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(793, 58);
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
            this.btnDelete.Location = new System.Drawing.Point(194, 718);
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
            this.btnUpdate.Location = new System.Drawing.Point(1042, 526);
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
            this.btnInsert.Location = new System.Drawing.Point(793, 319);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 105);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Kayıt Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.futbolHaberleriListesi.Location = new System.Drawing.Point(18, 58);
            this.futbolHaberleriListesi.Margin = new System.Windows.Forms.Padding(4);
            this.futbolHaberleriListesi.Name = "futbolHaberleriListesi";
            this.futbolHaberleriListesi.RowHeadersWidth = 51;
            this.futbolHaberleriListesi.Size = new System.Drawing.Size(753, 218);
            this.futbolHaberleriListesi.TabIndex = 18;
            // 
            // VoleybolHaberleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 870);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
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
            this.Name = "VoleybolHaberleri";
            this.Text = "Voleybol Haberleri Yönetim Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoleybolHaberleri_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolHaberleriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuncelle;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıcerikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimYoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haberBaslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCraest;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView futbolHaberleriListesi;
    }
}