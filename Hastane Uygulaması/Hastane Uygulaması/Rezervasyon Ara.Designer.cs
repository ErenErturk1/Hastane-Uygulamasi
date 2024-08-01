namespace Hastane_Uygulaması
{
    partial class Rezervasyon_Ara
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
            this.hastaneOtomasyonuDataSet = new Hastane_Uygulaması.HastaneOtomasyonuDataSet();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.rezervasyonIslemiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyonIslemiTableAdapter = new Hastane_Uygulaması.HastaneOtomasyonuDataSetTableAdapters.RezervasyonIslemiTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerveTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonIslemiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.hastaneDataGridViewTextBoxColumn,
            this.rezerveTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervasyonIslemiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(828, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 968);
            this.dataGridView1.TabIndex = 13;
            // 
            // hastaneOtomasyonuDataSet
            // 
            this.hastaneOtomasyonuDataSet.DataSetName = "HastaneOtomasyonuDataSet";
            this.hastaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(13, 937);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(132, 43);
            this.btnAnaSayfa.TabIndex = 2;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 499);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rezervasyonun T.C. Numarası=";
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKod.Location = new System.Drawing.Point(143, 532);
            this.txtKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtKod.MaxLength = 11;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(233, 24);
            this.txtKod.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(384, 499);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(155, 57);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // rezervasyonIslemiBindingSource
            // 
            this.rezervasyonIslemiBindingSource.DataMember = "RezervasyonIslemi";
            this.rezervasyonIslemiBindingSource.DataSource = this.hastaneOtomasyonuDataSet;
            // 
            // rezervasyonIslemiTableAdapter
            // 
            this.rezervasyonIslemiTableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adDataGridViewTextBoxColumn.Width = 170;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyadDataGridViewTextBoxColumn.Width = 170;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "T.C Kimlik No";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 170;
            // 
            // hastaneDataGridViewTextBoxColumn
            // 
            this.hastaneDataGridViewTextBoxColumn.DataPropertyName = "hastane";
            this.hastaneDataGridViewTextBoxColumn.HeaderText = "Hastane";
            this.hastaneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaneDataGridViewTextBoxColumn.Name = "hastaneDataGridViewTextBoxColumn";
            this.hastaneDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hastaneDataGridViewTextBoxColumn.Width = 170;
            // 
            // rezerveTarihiDataGridViewTextBoxColumn
            // 
            this.rezerveTarihiDataGridViewTextBoxColumn.DataPropertyName = "rezerveTarihi";
            this.rezerveTarihiDataGridViewTextBoxColumn.HeaderText = "Rezerve Tarihi";
            this.rezerveTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezerveTarihiDataGridViewTextBoxColumn.Name = "rezerveTarihiDataGridViewTextBoxColumn";
            this.rezerveTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezerveTarihiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rezerveTarihiDataGridViewTextBoxColumn.Width = 170;
            // 
            // Rezervasyon_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.btnAra);
            this.Name = "Rezervasyon_Ara";
            this.Text = "Rezervasyon Arama İşlemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rezervasyon_Ara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonIslemiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneOtomasyonuDataSet hastaneOtomasyonuDataSet;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.BindingSource rezervasyonIslemiBindingSource;
        private HastaneOtomasyonuDataSetTableAdapters.RezervasyonIslemiTableAdapter rezervasyonIslemiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezerveTarihiDataGridViewTextBoxColumn;
    }
}