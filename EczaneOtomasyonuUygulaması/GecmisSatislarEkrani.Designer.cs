namespace EczaneOtomasyonuUygulaması
{
    partial class GecmisSatislarEkrani
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnGecmisSatisGoster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGecmisRecete = new System.Windows.Forms.Button();
            this.btnKayıtSil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 187);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(776, 251);
            this.dataGridView4.TabIndex = 0;
            // 
            // btnGecmisSatisGoster
            // 
            this.btnGecmisSatisGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisSatisGoster.Location = new System.Drawing.Point(38, 67);
            this.btnGecmisSatisGoster.Name = "btnGecmisSatisGoster";
            this.btnGecmisSatisGoster.Size = new System.Drawing.Size(119, 48);
            this.btnGecmisSatisGoster.TabIndex = 1;
            this.btnGecmisSatisGoster.Text = "Geçmiş Satışları Göster";
            this.btnGecmisSatisGoster.UseVisualStyleBackColor = true;
            this.btnGecmisSatisGoster.Click += new System.EventHandler(this.btnGecmisSatisGoster_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(193, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reçeteyi Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGecmisRecete
            // 
            this.btnGecmisRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisRecete.Location = new System.Drawing.Point(651, 67);
            this.btnGecmisRecete.Name = "btnGecmisRecete";
            this.btnGecmisRecete.Size = new System.Drawing.Size(137, 42);
            this.btnGecmisRecete.TabIndex = 3;
            this.btnGecmisRecete.Text = "Hastanın Geçmiş Reçetelerini Göster";
            this.btnGecmisRecete.UseVisualStyleBackColor = true;
            this.btnGecmisRecete.Click += new System.EventHandler(this.btnGecmisRecete_Click);
            // 
            // btnKayıtSil
            // 
            this.btnKayıtSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtSil.Location = new System.Drawing.Point(193, 139);
            this.btnKayıtSil.Name = "btnKayıtSil";
            this.btnKayıtSil.Size = new System.Drawing.Size(119, 42);
            this.btnKayıtSil.TabIndex = 4;
            this.btnKayıtSil.Text = "Kaydı Sil";
            this.btnKayıtSil.UseVisualStyleBackColor = true;
            this.btnKayıtSil.Click += new System.EventHandler(this.btnKayıtSil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbHastaRecete);
            // 
            // GecmisSatislarEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKayıtSil);
            this.Controls.Add(this.btnGecmisRecete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGecmisSatisGoster);
            this.Controls.Add(this.dataGridView4);
            this.Name = "GecmisSatislarEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçmiş Satışlar";
            this.Load += new System.EventHandler(this.GecmisSatislarEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnGecmisSatisGoster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGecmisRecete;
        private System.Windows.Forms.Button btnKayıtSil;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}