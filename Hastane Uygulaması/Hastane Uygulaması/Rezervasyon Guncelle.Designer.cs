namespace Hastane_Uygulaması
{
    partial class Rezervasyon_Guncelle
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
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.hastaneOtomasyonuDataSet = new Hastane_Uygulaması.HastaneOtomasyonuDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerveTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonIslemiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHastane = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGüncel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rezervasyonIslemiTableAdapter = new Hastane_Uygulaması.HastaneOtomasyonuDataSetTableAdapters.RezervasyonIslemiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonIslemiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(23, 927);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(142, 43);
            this.btnAnaSayfa.TabIndex = 139;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // hastaneOtomasyonuDataSet
            // 
            this.hastaneOtomasyonuDataSet.DataSetName = "HastaneOtomasyonuDataSet";
            this.hastaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcDataGridViewTextBoxColumn,
            this.hastaneDataGridViewTextBoxColumn,
            this.rezerveTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervasyonIslemiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(608, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1446, 937);
            this.dataGridView1.TabIndex = 148;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adDataGridViewTextBoxColumn.Width = 200;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soyadDataGridViewTextBoxColumn.Width = 200;
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "T.C. Kimlik No";
            this.tcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            this.tcDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tcDataGridViewTextBoxColumn.Width = 200;
            // 
            // hastaneDataGridViewTextBoxColumn
            // 
            this.hastaneDataGridViewTextBoxColumn.DataPropertyName = "hastane";
            this.hastaneDataGridViewTextBoxColumn.HeaderText = "Hastane";
            this.hastaneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaneDataGridViewTextBoxColumn.Name = "hastaneDataGridViewTextBoxColumn";
            this.hastaneDataGridViewTextBoxColumn.ReadOnly = true;
            this.hastaneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hastaneDataGridViewTextBoxColumn.Width = 225;
            // 
            // rezerveTarihiDataGridViewTextBoxColumn
            // 
            this.rezerveTarihiDataGridViewTextBoxColumn.DataPropertyName = "rezerveTarihi";
            this.rezerveTarihiDataGridViewTextBoxColumn.HeaderText = "Rezerve Tarihi";
            this.rezerveTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezerveTarihiDataGridViewTextBoxColumn.Name = "rezerveTarihiDataGridViewTextBoxColumn";
            this.rezerveTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezerveTarihiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rezerveTarihiDataGridViewTextBoxColumn.Width = 200;
            // 
            // rezervasyonIslemiBindingSource
            // 
            this.rezervasyonIslemiBindingSource.DataMember = "RezervasyonIslemi";
            this.rezervasyonIslemiBindingSource.DataSource = this.hastaneOtomasyonuDataSet;
            // 
            // txtHastane
            // 
            this.txtHastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastane.Location = new System.Drawing.Point(265, 558);
            this.txtHastane.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastane.Name = "txtHastane";
            this.txtHastane.Size = new System.Drawing.Size(235, 24);
            this.txtHastane.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(172, 606);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 146;
            this.label6.Text = "Tarih=\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(145, 561);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 145;
            this.label4.Text = "Hastane=";
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(265, 513);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(235, 24);
            this.txtTc.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 516);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 144;
            this.label7.Text = "T.C. Kimlik Numarası=";
            // 
            // btnGüncel
            // 
            this.btnGüncel.BackColor = System.Drawing.Color.White;
            this.btnGüncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncel.Location = new System.Drawing.Point(299, 656);
            this.btnGüncel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncel.Name = "btnGüncel";
            this.btnGüncel.Size = new System.Drawing.Size(155, 57);
            this.btnGüncel.TabIndex = 138;
            this.btnGüncel.Text = "Güncelle";
            this.btnGüncel.UseVisualStyleBackColor = false;
            this.btnGüncel.Click += new System.EventHandler(this.btnGüncel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(159, 471);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 143;
            this.label5.Text = "Soyadı=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(188, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 142;
            this.label3.Text = "Adı=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 44);
            this.label2.TabIndex = 141;
            this.label2.Text = "Lütfen Rezervasyonun Değiştirmek İstediğiniz Bilgisini \r\nDiğer Bilgileriyle Birli" +
    "kte Yazın:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(265, 468);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.MaxLength = 11;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(235, 24);
            this.txtSoyad.TabIndex = 133;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(265, 423);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(235, 24);
            this.txtAd.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 140;
            this.label1.Text = "Rezerve T.C. No=";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(403, 306);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(146, 57);
            this.btnAra.TabIndex = 131;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(135, 325);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.MaxLength = 11;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(235, 24);
            this.txtAra.TabIndex = 130;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 606);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 22);
            this.dateTimePicker1.TabIndex = 149;
            // 
            // rezervasyonIslemiTableAdapter
            // 
            this.rezervasyonIslemiTableAdapter.ClearBeforeFill = true;
            // 
            // Rezervasyon_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHastane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGüncel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Name = "Rezervasyon_Guncelle";
            this.Text = "Rezervasyon Güncelleme Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rezervasyon_Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonIslemiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSayfa;
        private HastaneOtomasyonuDataSet hastaneOtomasyonuDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHastane;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGüncel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource rezervasyonIslemiBindingSource;
        private HastaneOtomasyonuDataSetTableAdapters.RezervasyonIslemiTableAdapter rezervasyonIslemiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezerveTarihiDataGridViewTextBoxColumn;
    }
}