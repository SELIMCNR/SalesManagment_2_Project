namespace SalesManagment2Project
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.kasiyerBilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet5 = new SalesManagment2Project.database1DataSet5();
            this.musteribilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new SalesManagment2Project.database1DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.musteribilTableAdapter = new SalesManagment2Project.database1DataSet1TableAdapters.musteribilTableAdapter();
            this.Ara = new System.Windows.Forms.Button();
            this.database1DataSet4 = new SalesManagment2Project.database1DataSet4();
            this.kasiyerBilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasiyerBilTableAdapter = new SalesManagment2Project.database1DataSet4TableAdapters.kasiyerBilTableAdapter();
            this.kasiyerBilTableAdapter1 = new SalesManagment2Project.database1DataSet5TableAdapters.kasiyerBilTableAdapter();
            this.database1DataSet11 = new SalesManagment2Project.database1DataSet11();
            this.kasiyerBilBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kasiyerBilTableAdapter2 = new SalesManagment2Project.database1DataSet11TableAdapters.kasiyerBilTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevBaslangiciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevBitimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBilBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBilBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kasiyerBilBindingSource1
            // 
            this.kasiyerBilBindingSource1.DataMember = "kasiyerBil";
            this.kasiyerBilBindingSource1.DataSource = this.database1DataSet5;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            " Adı ",
            " Soyadı ",
            "Tc Kimlik ",
            "Cep Tel ",
            "Ev Tel",
            "Adres",
            "Maaş",
            "Görevli old . Kasa",
            "Görev Başlangıcı",
            "Görev Bitimi"});
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
            this.button4.Location = new System.Drawing.Point(622, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Kapat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.kapat_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(547, 370);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 12;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.sil_Click);
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
            this.Ara.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasiyerBilBindingSource
            // 
            this.kasiyerBilBindingSource.DataMember = "kasiyerBil";
            this.kasiyerBilBindingSource.DataSource = this.database1DataSet4;
            // 
            // kasiyerBilTableAdapter
            // 
            this.kasiyerBilTableAdapter.ClearBeforeFill = true;
            // 
            // kasiyerBilTableAdapter1
            // 
            this.kasiyerBilTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "database1DataSet11";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasiyerBilBindingSource2
            // 
            this.kasiyerBilBindingSource2.DataMember = "kasiyerBil";
            this.kasiyerBilBindingSource2.DataSource = this.database1DataSet11;
            // 
            // kasiyerBilTableAdapter2
            // 
            this.kasiyerBilTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn,
            this.cepTelDataGridViewTextBoxColumn,
            this.evTelDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.kasaNoDataGridViewTextBoxColumn,
            this.gorevBaslangiciDataGridViewTextBoxColumn,
            this.gorevBitimiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasiyerBilBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 210);
            this.dataGridView1.TabIndex = 14;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "tcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "tcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
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
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "maas";
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            // 
            // kasaNoDataGridViewTextBoxColumn
            // 
            this.kasaNoDataGridViewTextBoxColumn.DataPropertyName = "kasaNo";
            this.kasaNoDataGridViewTextBoxColumn.HeaderText = "kasaNo";
            this.kasaNoDataGridViewTextBoxColumn.Name = "kasaNoDataGridViewTextBoxColumn";
            // 
            // gorevBaslangiciDataGridViewTextBoxColumn
            // 
            this.gorevBaslangiciDataGridViewTextBoxColumn.DataPropertyName = "gorevBaslangici";
            this.gorevBaslangiciDataGridViewTextBoxColumn.HeaderText = "gorevBaslangici";
            this.gorevBaslangiciDataGridViewTextBoxColumn.Name = "gorevBaslangiciDataGridViewTextBoxColumn";
            // 
            // gorevBitimiDataGridViewTextBoxColumn
            // 
            this.gorevBitimiDataGridViewTextBoxColumn.DataPropertyName = "gorevBitimi";
            this.gorevBitimiDataGridViewTextBoxColumn.HeaderText = "gorevBitimi";
            this.gorevBitimiDataGridViewTextBoxColumn.Name = "gorevBitimiDataGridViewTextBoxColumn";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.ekle);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBilBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteribilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerBilBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource kasiyerBilBindingSource;
        private database1DataSet4TableAdapters.kasiyerBilTableAdapter kasiyerBilTableAdapter;
        private database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource kasiyerBilBindingSource1;
        private database1DataSet5TableAdapters.kasiyerBilTableAdapter kasiyerBilTableAdapter1;
        private database1DataSet11 database1DataSet11;
        private System.Windows.Forms.BindingSource kasiyerBilBindingSource2;
        private database1DataSet11TableAdapters.kasiyerBilTableAdapter kasiyerBilTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevBaslangiciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevBitimiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}