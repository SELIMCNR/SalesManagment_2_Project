namespace SalesManagment2Project
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoribilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new SalesManagment2Project.database1DataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kategoribilTableAdapter = new SalesManagment2Project.database1DataSet2TableAdapters.kategoribilTableAdapter();
            this.database1DataSet9 = new SalesManagment2Project.database1DataSet9();
            this.kategoribilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kategoribilTableAdapter1 = new SalesManagment2Project.database1DataSet9TableAdapters.kategoribilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoribilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoribilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kategoribilBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(96, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // kategoriAdiDataGridViewTextBoxColumn
            // 
            this.kategoriAdiDataGridViewTextBoxColumn.DataPropertyName = "kategoriAdi";
            this.kategoriAdiDataGridViewTextBoxColumn.HeaderText = "kategoriAdi";
            this.kategoriAdiDataGridViewTextBoxColumn.Name = "kategoriAdiDataGridViewTextBoxColumn";
            // 
            // kategoribilBindingSource
            // 
            this.kategoribilBindingSource.DataMember = "kategoribil";
            this.kategoribilBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kategori Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnkategoriEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori İsmi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sil_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.kapat_Click);
            // 
            // kategoribilTableAdapter
            // 
            this.kategoribilTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet9
            // 
            this.database1DataSet9.DataSetName = "database1DataSet9";
            this.database1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoribilBindingSource1
            // 
            this.kategoribilBindingSource1.DataMember = "kategoribil";
            this.kategoribilBindingSource1.DataSource = this.database1DataSet9;
            // 
            // kategoribilTableAdapter1
            // 
            this.kategoribilTableAdapter1.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoribilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoribilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource kategoribilBindingSource;
        private database1DataSet2TableAdapters.kategoribilTableAdapter kategoribilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriAdiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private database1DataSet9 database1DataSet9;
        private System.Windows.Forms.BindingSource kategoribilBindingSource1;
        private database1DataSet9TableAdapters.kategoribilTableAdapter kategoribilTableAdapter1;
    }
}