namespace SalesManagment2Project
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteribilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new SalesManagment2Project.database1DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.musteribilTableAdapter = new SalesManagment2Project.database1DataSet1TableAdapters.musteribilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ara = new System.Windows.Forms.Button();
            this.database1DataSet12 = new SalesManagment2Project.database1DataSet12();
            this.musteribilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musteribilTableAdapter1 = new SalesManagment2Project.database1DataSet12TableAdapters.musteribilTableAdapter();
            this.database1DataSet15 = new SalesManagment2Project.database1DataSet15();
            this.stokbilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokbilTableAdapter = new SalesManagment2Project.database1DataSet15TableAdapters.stokbilTableAdapter();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokbilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.satisFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokbilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 194);
            this.dataGridView1.TabIndex = 10;
            // 
            // musteribilBindingSource
            // 
            this.musteribilBindingSource.DataMember = "musteribil";
            this.musteribilBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü ",
            "Ürün Adı",
            "Adet",
            "Birim Fiyat",
            "Kdv",
            "Satış Fiyatı"});
            this.comboBox1.Location = new System.Drawing.Point(239, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(563, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.kapat_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(482, 337);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 12;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.yeniEkle_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(391, 337);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "Yeni Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.yeniEkle_Click);
            // 
            // musteribilTableAdapter
            // 
            this.musteribilTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(677, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adet";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(677, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Ara
            // 
            this.Ara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ara.Image = ((System.Drawing.Image)(resources.GetObject("Ara.Image")));
            this.Ara.Location = new System.Drawing.Point(424, 24);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(81, 37);
            this.Ara.TabIndex = 9;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // database1DataSet12
            // 
            this.database1DataSet12.DataSetName = "database1DataSet12";
            this.database1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteribilBindingSource1
            // 
            this.musteribilBindingSource1.DataMember = "musteribil";
            this.musteribilBindingSource1.DataSource = this.database1DataSet12;
            // 
            // musteribilTableAdapter1
            // 
            this.musteribilTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet15
            // 
            this.database1DataSet15.DataSetName = "database1DataSet15";
            this.database1DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokbilBindingSource
            // 
            this.stokbilBindingSource.DataMember = "stokbil";
            this.stokbilBindingSource.DataSource = this.database1DataSet15;
            // 
            // stokbilTableAdapter
            // 
            this.stokbilTableAdapter.ClearBeforeFill = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "birimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "birimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            // 
            // satisFiyatDataGridViewTextBoxColumn
            // 
            this.satisFiyatDataGridViewTextBoxColumn.DataPropertyName = "satisFiyat";
            this.satisFiyatDataGridViewTextBoxColumn.HeaderText = "satisFiyat";
            this.satisFiyatDataGridViewTextBoxColumn.Name = "satisFiyatDataGridViewTextBoxColumn";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.ekle);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokbilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource musteribilBindingSource;
        private database1DataSet1 database1DataSet1;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button ekle;
        private database1DataSet1TableAdapters.musteribilTableAdapter musteribilTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private database1DataSet12 database1DataSet12;
        private System.Windows.Forms.BindingSource musteribilBindingSource1;
        private database1DataSet12TableAdapters.musteribilTableAdapter musteribilTableAdapter1;
        private database1DataSet15 database1DataSet15;
        private System.Windows.Forms.BindingSource stokbilBindingSource;
        private database1DataSet15TableAdapters.stokbilTableAdapter stokbilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatDataGridViewTextBoxColumn;
    }
}