namespace SalesManagment2Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasiyerİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisbilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new SalesManagment2Project.database1DataSet();
            this.satisbilTableAdapter = new SalesManagment2Project.database1DataSetTableAdapters.satisbilTableAdapter();
            this.database1DataSet6 = new SalesManagment2Project.database1DataSet6();
            this.satisbilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.satisbilTableAdapter1 = new SalesManagment2Project.database1DataSet6TableAdapters.satisbilTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisbilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisbilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.kasiyerİşlemleriToolStripMenuItem,
            this.stokİşlemleriToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.müşteriİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("müşteriİşlemleriToolStripMenuItem.Image")));
            this.müşteriİşlemleriToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ürünİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünİşlemleriToolStripMenuItem.Image")));
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(160, 32);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem_Click);
            // 
            // kasiyerİşlemleriToolStripMenuItem
            // 
            this.kasiyerİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.kasiyerİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kasiyerİşlemleriToolStripMenuItem.Image")));
            this.kasiyerİşlemleriToolStripMenuItem.Name = "kasiyerİşlemleriToolStripMenuItem";
            this.kasiyerİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.kasiyerİşlemleriToolStripMenuItem.Text = "Kasiyer İşlemleri";
            this.kasiyerİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kasiyerİşlemleriToolStripMenuItem_Click);
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.stokİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stokİşlemleriToolStripMenuItem.Image")));
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(156, 32);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri";
            this.stokİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.stokİşlemleriToolStripMenuItem_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.satışİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("satışİşlemleriToolStripMenuItem.Image")));
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(158, 32);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            this.satışİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.satışİşlemleriToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.45F);
            this.button1.Location = new System.Drawing.Point(619, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_SatisGoster);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(126, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satış Listesi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaNoDataGridViewTextBoxColumn,
            this.musteriAdiDataGridViewTextBoxColumn,
            this.musteriSoyadiDataGridViewTextBoxColumn,
            this.tcKimlikDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.satisFiyatDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.toplamtutarDataGridViewTextBoxColumn,
            this.kasaNoDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satisbilBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1065, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "faturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "faturaNo";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
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
            // tcKimlikDataGridViewTextBoxColumn
            // 
            this.tcKimlikDataGridViewTextBoxColumn.DataPropertyName = "tcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.HeaderText = "tcKimlik";
            this.tcKimlikDataGridViewTextBoxColumn.Name = "tcKimlikDataGridViewTextBoxColumn";
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // satisFiyatDataGridViewTextBoxColumn
            // 
            this.satisFiyatDataGridViewTextBoxColumn.DataPropertyName = "satisFiyat";
            this.satisFiyatDataGridViewTextBoxColumn.HeaderText = "satisFiyat";
            this.satisFiyatDataGridViewTextBoxColumn.Name = "satisFiyatDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // toplamtutarDataGridViewTextBoxColumn
            // 
            this.toplamtutarDataGridViewTextBoxColumn.DataPropertyName = "toplamtutar";
            this.toplamtutarDataGridViewTextBoxColumn.HeaderText = "toplamtutar";
            this.toplamtutarDataGridViewTextBoxColumn.Name = "toplamtutarDataGridViewTextBoxColumn";
            // 
            // kasaNoDataGridViewTextBoxColumn
            // 
            this.kasaNoDataGridViewTextBoxColumn.DataPropertyName = "kasaNo";
            this.kasaNoDataGridViewTextBoxColumn.HeaderText = "kasaNo";
            this.kasaNoDataGridViewTextBoxColumn.Name = "kasaNoDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // satisbilBindingSource
            // 
            this.satisbilBindingSource.DataMember = "satisbil";
            this.satisbilBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisbilTableAdapter
            // 
            this.satisbilTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisbilBindingSource1
            // 
            this.satisbilBindingSource1.DataMember = "satisbil";
            this.satisbilBindingSource1.DataSource = this.database1DataSet6;
            // 
            // satisbilTableAdapter1
            // 
            this.satisbilTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisbilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisbilBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasiyerİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource satisbilBindingSource;
        private database1DataSetTableAdapters.satisbilTableAdapter satisbilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource satisbilBindingSource1;
        private database1DataSet6TableAdapters.satisbilTableAdapter satisbilTableAdapter1;
    }
}