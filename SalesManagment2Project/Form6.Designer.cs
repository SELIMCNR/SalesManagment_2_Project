namespace SalesManagment2Project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteribilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new SalesManagment2Project.database1DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.musteribilTableAdapter = new SalesManagment2Project.database1DataSet1TableAdapters.musteribilTableAdapter();
            this.Ara = new System.Windows.Forms.Button();
            this.database1DataSet8 = new SalesManagment2Project.database1DataSet8();
            this.musteribilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musteribilTableAdapter1 = new SalesManagment2Project.database1DataSet8TableAdapters.musteribilTableAdapter();
            this.database1DataSet14 = new SalesManagment2Project.database1DataSet14();
            this.urunbilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunbilTableAdapter = new SalesManagment2Project.database1DataSet14TableAdapters.urunbilTableAdapter();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunbilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunKoduDataGridViewTextBoxColumn,
            this.firmaAdiDataGridViewTextBoxColumn,
            this.alisFiyatiDataGridViewTextBoxColumn,
            this.satisFiyatiDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunbilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 194);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            "Ürün Adı ",
            "Ürün Kodu ",
            "Firma Adı",
            "Alış Fiyatı",
            "Satış Fiyatı",
            "Kategori"});
            this.comboBox1.Location = new System.Drawing.Point(304, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(628, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(547, 370);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 12;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(456, 370);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // musteribilTableAdapter
            // 
            this.musteribilTableAdapter.ClearBeforeFill = true;
            // 
            // Ara
            // 
            this.Ara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ara.Image = ((System.Drawing.Image)(resources.GetObject("Ara.Image")));
            this.Ara.Location = new System.Drawing.Point(489, 57);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(81, 37);
            this.Ara.TabIndex = 9;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // database1DataSet8
            // 
            this.database1DataSet8.DataSetName = "database1DataSet8";
            this.database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteribilBindingSource1
            // 
            this.musteribilBindingSource1.DataMember = "musteribil";
            this.musteribilBindingSource1.DataSource = this.database1DataSet8;
            // 
            // musteribilTableAdapter1
            // 
            this.musteribilTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet14
            // 
            this.database1DataSet14.DataSetName = "database1DataSet14";
            this.database1DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunbilBindingSource
            // 
            this.urunbilBindingSource.DataMember = "urunbil";
            this.urunbilBindingSource.DataSource = this.database1DataSet14;
            // 
            // urunbilTableAdapter
            // 
            this.urunbilTableAdapter.ClearBeforeFill = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunKoduDataGridViewTextBoxColumn
            // 
            this.urunKoduDataGridViewTextBoxColumn.DataPropertyName = "urunKodu";
            this.urunKoduDataGridViewTextBoxColumn.HeaderText = "urunKodu";
            this.urunKoduDataGridViewTextBoxColumn.Name = "urunKoduDataGridViewTextBoxColumn";
            // 
            // firmaAdiDataGridViewTextBoxColumn
            // 
            this.firmaAdiDataGridViewTextBoxColumn.DataPropertyName = "firmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.HeaderText = "firmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.Name = "firmaAdiDataGridViewTextBoxColumn";
            // 
            // alisFiyatiDataGridViewTextBoxColumn
            // 
            this.alisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "alisFiyati";
            this.alisFiyatiDataGridViewTextBoxColumn.HeaderText = "alisFiyati";
            this.alisFiyatiDataGridViewTextBoxColumn.Name = "alisFiyatiDataGridViewTextBoxColumn";
            // 
            // satisFiyatiDataGridViewTextBoxColumn
            // 
            this.satisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "satisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.HeaderText = "satisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.Name = "satisFiyatiDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.ekle);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunbilBindingSource)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGridView1;
        private database1DataSet8 database1DataSet8;
        private System.Windows.Forms.BindingSource musteribilBindingSource1;
        private database1DataSet8TableAdapters.musteribilTableAdapter musteribilTableAdapter1;
        private database1DataSet14 database1DataSet14;
        private System.Windows.Forms.BindingSource urunbilBindingSource;
        private database1DataSet14TableAdapters.urunbilTableAdapter urunbilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
    }
}