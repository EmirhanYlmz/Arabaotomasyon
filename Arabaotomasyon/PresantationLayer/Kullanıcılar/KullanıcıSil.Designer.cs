
namespace Arabaotomasyon.PresantationLayer.Kullanıcılar
{
    partial class KullanıcıSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıSil));
            this.Anamenudon = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.sifresil = new System.Windows.Forms.TextBox();
            this.isimsil = new System.Windows.Forms.TextBox();
            this.Kullaniciid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Anamenudon
            // 
            this.Anamenudon.BackColor = System.Drawing.Color.Transparent;
            this.Anamenudon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anamenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Anamenudon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Anamenudon.Location = new System.Drawing.Point(475, 394);
            this.Anamenudon.Name = "Anamenudon";
            this.Anamenudon.Size = new System.Drawing.Size(132, 39);
            this.Anamenudon.TabIndex = 34;
            this.Anamenudon.Text = "Ana Menüye Dön";
            this.Anamenudon.UseVisualStyleBackColor = false;
            this.Anamenudon.Click += new System.EventHandler(this.Anamenudon_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Transparent;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Sil.Location = new System.Drawing.Point(185, 394);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(132, 39);
            this.Sil.TabIndex = 33;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(603, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(341, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "İsim :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label.Location = new System.Drawing.Point(19, 292);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 15);
            this.label.TabIndex = 30;
            this.label.Text = "Kullanıcı Numarası :";
            // 
            // sifresil
            // 
            this.sifresil.Location = new System.Drawing.Point(673, 288);
            this.sifresil.Name = "sifresil";
            this.sifresil.Size = new System.Drawing.Size(100, 20);
            this.sifresil.TabIndex = 29;
            // 
            // isimsil
            // 
            this.isimsil.Location = new System.Drawing.Point(403, 288);
            this.isimsil.Name = "isimsil";
            this.isimsil.Size = new System.Drawing.Size(100, 20);
            this.isimsil.TabIndex = 28;
            // 
            // Kullaniciid
            // 
            this.Kullaniciid.Location = new System.Drawing.Point(162, 288);
            this.Kullaniciid.Name = "Kullaniciid";
            this.Kullaniciid.Size = new System.Drawing.Size(100, 20);
            this.Kullaniciid.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 163);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // KullanıcıSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Anamenudon);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sifresil);
            this.Controls.Add(this.isimsil);
            this.Controls.Add(this.Kullaniciid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullanıcıSil";
            this.Text = "KullanıcıSil";
            this.Load += new System.EventHandler(this.KullanıcıSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anamenudon;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox sifresil;
        private System.Windows.Forms.TextBox isimsil;
        private System.Windows.Forms.TextBox Kullaniciid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}