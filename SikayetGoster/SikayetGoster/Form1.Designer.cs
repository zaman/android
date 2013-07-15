namespace SikayetGoster
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turkTelekomDataSet = new SikayetGoster.TurkTelekomDataSet();
            this.sikayetlerTableAdapter = new SikayetGoster.TurkTelekomDataSetTableAdapters.SikayetlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkTelekomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TürkTelekom Android Kullanıcı Şikayetleri\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konuDataGridViewTextBoxColumn,
            this.icerikDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sikayetlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "konu";
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            // 
            // icerikDataGridViewTextBoxColumn
            // 
            this.icerikDataGridViewTextBoxColumn.DataPropertyName = "icerik";
            this.icerikDataGridViewTextBoxColumn.HeaderText = "icerik";
            this.icerikDataGridViewTextBoxColumn.Name = "icerikDataGridViewTextBoxColumn";
            this.icerikDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // sikayetlerBindingSource
            // 
            this.sikayetlerBindingSource.DataMember = "Sikayetler";
            this.sikayetlerBindingSource.DataSource = this.turkTelekomDataSet;
            // 
            // turkTelekomDataSet
            // 
            this.turkTelekomDataSet.DataSetName = "TurkTelekomDataSet";
            this.turkTelekomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sikayetlerTableAdapter
            // 
            this.sikayetlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TurkTelekom";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turkTelekomDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TurkTelekomDataSet turkTelekomDataSet;
        private System.Windows.Forms.BindingSource sikayetlerBindingSource;
        private TurkTelekomDataSetTableAdapters.SikayetlerTableAdapter sikayetlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icerikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}

