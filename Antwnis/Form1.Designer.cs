namespace Antwnis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.έλεγχοςStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.νέαΚαταχώρησηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.περιοδικάToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.στοίχειαAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.antwnisDataSet3 = new Antwnis.antwnisDataSet3();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineTableAdapter = new Antwnis.antwnisDataSet3TableAdapters.magazineTableAdapter();
            this.aADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antwnisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.19178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.80822F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1131, 697);
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
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 1;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(637, 53);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αναζήτηση βάση ονόματος";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(192, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(442, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Antwnis.Properties.Resources.Magazine_Of_The_Week_Background_1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 639);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
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
            this.quantityDataGridViewTextBoxColumn,
            this.Minus});
            this.dataGridView1.DataSource = this.magazineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 486);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // antwnisDataSet3
            // 
            this.antwnisDataSet3.DataSetName = "antwnisDataSet3";
            this.antwnisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazineBindingSource
            // 
            this.magazineBindingSource.DataMember = "magazine";
            this.magazineBindingSource.DataSource = this.antwnisDataSet3;
            // 
            // magazineTableAdapter
            // 
            this.magazineTableAdapter.ClearBeforeFill = true;
            // 
            // aADataGridViewTextBoxColumn
            // 
            this.aADataGridViewTextBoxColumn.DataPropertyName = "AA";
            this.aADataGridViewTextBoxColumn.HeaderText = "A/A";
            this.aADataGridViewTextBoxColumn.Name = "aADataGridViewTextBoxColumn";
            this.aADataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameDataGridViewTextBoxColumn.HeaderText = "ΟΝΟΜΑ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "ΕΞΩΦΥΛΛΟ";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "ΠΟΣΟΤΗΤΑ";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Minus
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.Minus.DefaultCellStyle = dataGridViewCellStyle3;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minus.HeaderText = "ΜΕΙΩΣΗ";
            this.Minus.Name = "Minus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazine control created by Stathis Votsis software engineer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antwnisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem έλεγχοςStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem νέαΚαταχώρησηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem στοίχειαAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem περιοδικάToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private antwnisDataSet3 antwnisDataSet3;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private antwnisDataSet3TableAdapters.magazineTableAdapter magazineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Minus;
    }
}

