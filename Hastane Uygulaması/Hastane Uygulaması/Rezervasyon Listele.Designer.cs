namespace Hastane_Uygulaması
{
    partial class Rezervasyon_Listele
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
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerveTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonIslemiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneOtomasyonuDataSet = new Hastane_Uygulaması.HastaneOtomasyonuDataSet();
            this.rezervasyonIslemiTableAdapter = new Hastane_Uygulaması.HastaneOtomasyonuDataSetTableAdapters.RezervasyonIslemiTableAdapter();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonIslemiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2030, 958);
            this.dataGridView1.TabIndex = 2;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adDataGridViewTextBoxColumn.Width = 300;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyadDataGridViewTextBoxColumn.Width = 300;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "T.C Kimlik Numarası";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 300;
            // 
            // hastaneDataGridViewTextBoxColumn
            // 
            this.hastaneDataGridViewTextBoxColumn.DataPropertyName = "hastane";
            this.hastaneDataGridViewTextBoxColumn.HeaderText = "Hastane Bilgisi";
            this.hastaneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaneDataGridViewTextBoxColumn.Name = "hastaneDataGridViewTextBoxColumn";
            this.hastaneDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hastaneDataGridViewTextBoxColumn.Width = 320;
            // 
            // rezerveTarihiDataGridViewTextBoxColumn
            // 
            this.rezerveTarihiDataGridViewTextBoxColumn.DataPropertyName = "rezerveTarihi";
            this.rezerveTarihiDataGridViewTextBoxColumn.HeaderText = "Rezerve Tarihi";
            this.rezerveTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezerveTarihiDataGridViewTextBoxColumn.Name = "rezerveTarihiDataGridViewTextBoxColumn";
            this.rezerveTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezerveTarihiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rezerveTarihiDataGridViewTextBoxColumn.Width = 249;
            // 
            // rezervasyonIslemiBindingSource
            // 
            this.rezervasyonIslemiBindingSource.DataMember = "RezervasyonIslemi";
            this.rezervasyonIslemiBindingSource.DataSource = this.hastaneOtomasyonuDataSet;
            // 
            // hastaneOtomasyonuDataSet
            // 
            this.hastaneOtomasyonuDataSet.DataSetName = "HastaneOtomasyonuDataSet";
            this.hastaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyonIslemiTableAdapter
            // 
            this.rezervasyonIslemiTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(1882, 914);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(155, 50);
            this.btnAnaSayfa.TabIndex = 3;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // Rezervasyon_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rezervasyon_Listele";
            this.Text = "Rezervasyon Listeleme Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rezervasyon_Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonIslemiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneOtomasyonuDataSet hastaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource rezervasyonIslemiBindingSource;
        private HastaneOtomasyonuDataSetTableAdapters.RezervasyonIslemiTableAdapter rezervasyonIslemiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezerveTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}