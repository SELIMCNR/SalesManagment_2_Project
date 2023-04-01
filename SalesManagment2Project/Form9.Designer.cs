namespace SalesManagment2Project
{
    partial class Form9
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmabilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new SalesManagment2Project.database1DataSet3();
            this.kategoribilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new SalesManagment2Project.database1DataSet2();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kategoribilTableAdapter = new SalesManagment2Project.database1DataSet2TableAdapters.kategoribilTableAdapter();
            this.firmabilTableAdapter = new SalesManagment2Project.database1DataSet3TableAdapters.firmabilTableAdapter();
            this.database1DataSet10 = new SalesManagment2Project.database1DataSet10();
            this.firmabilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firmabilTableAdapter1 = new SalesManagment2Project.database1DataSet10TableAdapters.firmabilTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmabilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoribilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmabilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(164, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Ekle";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnkategoriEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaAdiDataGridViewTextBoxColumn,
            this.firmaAdresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmabilBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(206, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 153);
            this.dataGridView1.TabIndex = 4;
            // 
            // firmaAdiDataGridViewTextBoxColumn
            // 
            this.firmaAdiDataGridViewTextBoxColumn.DataPropertyName = "firmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.HeaderText = "firmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.Name = "firmaAdiDataGridViewTextBoxColumn";
            // 
            // firmaAdresiDataGridViewTextBoxColumn
            // 
            this.firmaAdresiDataGridViewTextBoxColumn.DataPropertyName = "firmaAdresi";
            this.firmaAdresiDataGridViewTextBoxColumn.HeaderText = "firmaAdresi";
            this.firmaAdresiDataGridViewTextBoxColumn.Name = "firmaAdresiDataGridViewTextBoxColumn";
            // 
            // firmabilBindingSource
            // 
            this.firmabilBindingSource.DataMember = "firmabil";
            this.firmabilBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.kapat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sil_Click);
            // 
            // kategoribilTableAdapter
            // 
            this.kategoribilTableAdapter.ClearBeforeFill = true;
            // 
            // firmabilTableAdapter
            // 
            this.firmabilTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet10
            // 
            this.database1DataSet10.DataSetName = "database1DataSet10";
            this.database1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmabilBindingSource1
            // 
            this.firmabilBindingSource1.DataMember = "firmabil";
            this.firmabilBindingSource1.DataSource = this.database1DataSet10;
            // 
            // firmabilTableAdapter1
            // 
            this.firmabilTableAdapter1.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmabilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoribilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmabilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kategoribilBindingSource;
        private database1DataSet2 database1DataSet2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private database1DataSet2TableAdapters.kategoribilTableAdapter kategoribilTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource firmabilBindingSource;
        private database1DataSet3TableAdapters.firmabilTableAdapter firmabilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdresiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private database1DataSet10 database1DataSet10;
        private System.Windows.Forms.BindingSource firmabilBindingSource1;
        private database1DataSet10TableAdapters.firmabilTableAdapter firmabilTableAdapter1;
    }
}