namespace SalesManagment2Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteribilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new SalesManagment2Project.database1DataSet1();
            this.ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.musteribilTableAdapter = new SalesManagment2Project.database1DataSet1TableAdapters.musteribilTableAdapter();
            this.Ara = new System.Windows.Forms.Button();
            this.database1DataSet7 = new SalesManagment2Project.database1DataSet7();
            this.musteribilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musteribilTableAdapter1 = new SalesManagment2Project.database1DataSet7TableAdapters.musteribilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü ",
            "Müşteri Adı ",
            "Müşteri Soyadı ",
            "Tc Kimlik ",
            "Cep Tel ",
            "Ev Tel",
            "Adres"});
            this.comboBox1.Location = new System.Drawing.Point(239, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tckimlikDataGridViewTextBoxColumn,
            this.musteriAdiDataGridViewTextBoxColumn,
            this.musteriSoyadiDataGridViewTextBoxColumn,
            this.cepTelDataGridViewTextBoxColumn,
            this.evTelDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteribilBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 194);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            this.musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "musteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.HeaderText = "musteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            // 
            // musteriSoyadiDataGridViewTextBoxColumn
            // 
            this.musteriSoyadiDataGridViewTextBoxColumn.DataPropertyName = "musteriSoyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.HeaderText = "musteriSoyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.Name = "musteriSoyadiDataGridViewTextBoxColumn";
            // 
            // cepTelDataGridViewTextBoxColumn
            // 
            this.cepTelDataGridViewTextBoxColumn.DataPropertyName = "cepTel";
            this.cepTelDataGridViewTextBoxColumn.HeaderText = "cepTel";
            this.cepTelDataGridViewTextBoxColumn.Name = "cepTelDataGridViewTextBoxColumn";
            // 
            // evTelDataGridViewTextBoxColumn
            // 
            this.evTelDataGridViewTextBoxColumn.DataPropertyName = "evTel";
            this.evTelDataGridViewTextBoxColumn.HeaderText = "evTel";
            this.evTelDataGridViewTextBoxColumn.Name = "evTelDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
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
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(391, 334);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 4;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(482, 334);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 5;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(563, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Kapat);
            // 
            // musteribilTableAdapter
            // 
            this.musteribilTableAdapter.ClearBeforeFill = true;
            // 
            // Ara
            // 
            this.Ara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ara.Image = ((System.Drawing.Image)(resources.GetObject("Ara.Image")));
            this.Ara.Location = new System.Drawing.Point(424, 21);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(81, 37);
            this.Ara.TabIndex = 2;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteribilBindingSource1
            // 
            this.musteribilBindingSource1.DataMember = "musteribil";
            this.musteribilBindingSource1.DataSource = this.database1DataSet7;
            // 
            // musteribilTableAdapter1
            // 
            this.musteribilTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button button4;
        private database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource musteribilBindingSource;
        private database1DataSet1TableAdapters.musteribilTableAdapter musteribilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource musteribilBindingSource1;
        private database1DataSet7TableAdapters.musteribilTableAdapter musteribilTableAdapter1;
    }
}