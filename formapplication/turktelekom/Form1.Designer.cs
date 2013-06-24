namespace turktelekom
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
            this.txtBoxBaslik = new System.Windows.Forms.TextBox();
            this.TxtBoxIcerik = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComboTur = new System.Windows.Forms.ComboBox();
            this.comboSecenek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxBaslik
            // 
            this.txtBoxBaslik.Location = new System.Drawing.Point(213, 209);
            this.txtBoxBaslik.Name = "txtBoxBaslik";
            this.txtBoxBaslik.Size = new System.Drawing.Size(192, 20);
            this.txtBoxBaslik.TabIndex = 2;
            // 
            // TxtBoxIcerik
            // 
            this.TxtBoxIcerik.Location = new System.Drawing.Point(213, 282);
            this.TxtBoxIcerik.Name = "TxtBoxIcerik";
            this.TxtBoxIcerik.Size = new System.Drawing.Size(192, 20);
            this.TxtBoxIcerik.TabIndex = 3;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(259, 337);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SECENEK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BASLIK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ICERIK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Android Veri Giris Ekrani";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtComboTur
            // 
            this.txtComboTur.FormattingEnabled = true;
            this.txtComboTur.Items.AddRange(new object[] {
            "Bireysel",
            "Kurumsal",
            "Duyuru"});
            this.txtComboTur.Location = new System.Drawing.Point(213, 106);
            this.txtComboTur.Name = "txtComboTur";
            this.txtComboTur.Size = new System.Drawing.Size(192, 21);
            this.txtComboTur.TabIndex = 10;
            this.txtComboTur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboSecenek
            // 
            this.comboSecenek.FormattingEnabled = true;
            this.comboSecenek.Items.AddRange(new object[] {
            "Kampanya",
            "Tarifeler",
            "Urunler",
            "Duyuru"});
            this.comboSecenek.Location = new System.Drawing.Point(213, 160);
            this.comboSecenek.Name = "comboSecenek";
            this.comboSecenek.Size = new System.Drawing.Size(192, 21);
            this.comboSecenek.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 464);
            this.Controls.Add(this.comboSecenek);
            this.Controls.Add(this.txtComboTur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.TxtBoxIcerik);
            this.Controls.Add(this.txtBoxBaslik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBaslik;
        private System.Windows.Forms.TextBox TxtBoxIcerik;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtComboTur;
        private System.Windows.Forms.ComboBox comboSecenek;
    }
}

