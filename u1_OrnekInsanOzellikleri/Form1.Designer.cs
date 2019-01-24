namespace u1_OrnekInsanOzellikleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoster = new System.Windows.Forms.Button();
            this.listBoxAdres = new System.Windows.Forms.ListBox();
            this.listBoxAdres2 = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(26, 356);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(115, 36);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // listBoxAdres
            // 
            this.listBoxAdres.ForeColor = System.Drawing.Color.Red;
            this.listBoxAdres.FormattingEnabled = true;
            this.listBoxAdres.ItemHeight = 16;
            this.listBoxAdres.Location = new System.Drawing.Point(752, 35);
            this.listBoxAdres.Name = "listBoxAdres";
            this.listBoxAdres.Size = new System.Drawing.Size(145, 164);
            this.listBoxAdres.TabIndex = 2;
            // 
            // listBoxAdres2
            // 
            this.listBoxAdres2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxAdres2.FormattingEnabled = true;
            this.listBoxAdres2.ItemHeight = 16;
            this.listBoxAdres2.Location = new System.Drawing.Point(914, 35);
            this.listBoxAdres2.Name = "listBoxAdres2";
            this.listBoxAdres2.Size = new System.Drawing.Size(145, 164);
            this.listBoxAdres2.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.Color.Orange;
            this.txtAd.Location = new System.Drawing.Point(838, 222);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(127, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.ForeColor = System.Drawing.Color.Orange;
            this.txtSoyad.Location = new System.Drawing.Point(838, 268);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(127, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtTcNo
            // 
            this.txtTcNo.ForeColor = System.Drawing.Color.Orange;
            this.txtTcNo.Location = new System.Drawing.Point(838, 316);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(127, 22);
            this.txtTcNo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1083, 479);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.listBoxAdres2);
            this.Controls.Add(this.listBoxAdres);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox listBoxAdres;
        private System.Windows.Forms.ListBox listBoxAdres2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTcNo;
    }
}

