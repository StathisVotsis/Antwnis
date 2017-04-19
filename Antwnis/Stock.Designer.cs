namespace Antwnis
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.έλεγχοςStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.νέαΚαταχώρησηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.περιοδικάToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.στοίχειαAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antwnisDataSet1 = new Antwnis.antwnisDataSet1();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.magazineTableAdapter = new Antwnis.antwnisDataSet1TableAdapters.magazineTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antwnisDataSet1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.41651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.5835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 466F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.έλεγχοςStockToolStripMenuItem,
            this.νέαΚαταχώρησηToolStripMenuItem,
            this.περιοδικάToolStripMenuItem,
            this.στοίχειαAdministratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // έλεγχοςStockToolStripMenuItem
            // 
            this.έλεγχοςStockToolStripMenuItem.Name = "έλεγχοςStockToolStripMenuItem";
            this.έλεγχοςStockToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.έλεγχοςStockToolStripMenuItem.Text = "Stock";
            this.έλεγχοςStockToolStripMenuItem.Click += new System.EventHandler(this.έλεγχοςStockToolStripMenuItem_Click);
            // 
            // νέαΚαταχώρησηToolStripMenuItem
            // 
            this.νέαΚαταχώρησηToolStripMenuItem.Name = "νέαΚαταχώρησηToolStripMenuItem";
            this.νέαΚαταχώρησηToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.νέαΚαταχώρησηToolStripMenuItem.Text = "Νέα καταχώρηση";
            this.νέαΚαταχώρησηToolStripMenuItem.Click += new System.EventHandler(this.νέαΚαταχώρησηToolStripMenuItem_Click);
            // 
            // περιοδικάToolStripMenuItem
            // 
            this.περιοδικάToolStripMenuItem.Name = "περιοδικάToolStripMenuItem";
            this.περιοδικάToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.περιοδικάToolStripMenuItem.Text = "Περιοδικά";
            this.περιοδικάToolStripMenuItem.Click += new System.EventHandler(this.περιοδικάToolStripMenuItem_Click);
            // 
            // στοίχειαAdministratorToolStripMenuItem
            // 
            this.στοίχειαAdministratorToolStripMenuItem.Name = "στοίχειαAdministratorToolStripMenuItem";
            this.στοίχειαAdministratorToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
            this.στοίχειαAdministratorToolStripMenuItem.Text = "Στοίχεια Administrator";
            this.στοίχειαAdministratorToolStripMenuItem.Click += new System.EventHandler(this.στοίχειαAdministratorToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(494, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "ΑΝΑΝΕΩΣΗ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aADataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1129, 460);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // aADataGridViewTextBoxColumn
            // 
            this.aADataGridViewTextBoxColumn.DataPropertyName = "AA";
            this.aADataGridViewTextBoxColumn.HeaderText = "AA";
            this.aADataGridViewTextBoxColumn.Name = "aADataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "ΦΩΤΟΓΡΑΦΙΑ";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "ΠΟΣΟΤΗΤΑ ΣΤΗΝ ΑΠΟΘΗΚΗ";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // magazineBindingSource
            // 
            this.magazineBindingSource.DataMember = "magazine";
            this.magazineBindingSource.DataSource = this.antwnisDataSet1;
            // 
            // antwnisDataSet1
            // 
            this.antwnisDataSet1.DataSetName = "antwnisDataSet1";
            this.antwnisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(637, 73);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αναζήτηση βάση ονόματος";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(192, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // magazineTableAdapter
            // 
            this.magazineTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(442, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock created by Stathis Votsis software engineer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stock_FormClosing);
            this.Load += new System.EventHandler(this.Stock_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antwnisDataSet1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem έλεγχοςStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem νέαΚαταχώρησηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem περιοδικάToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem στοίχειαAdministratorToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private antwnisDataSet1 antwnisDataSet1;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private antwnisDataSet1TableAdapters.magazineTableAdapter magazineTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}