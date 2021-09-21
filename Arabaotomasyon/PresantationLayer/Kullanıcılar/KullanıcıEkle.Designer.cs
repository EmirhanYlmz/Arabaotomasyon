
namespace Arabaotomasyon.PresantationLayer.Kullanıcılar
{
    partial class KullanıcıEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıEkle));
            this.Anamenudon = new System.Windows.Forms.Button();
            this.Vtekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.TextBox();
            this.Kullaniciid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Anamenudon
            // 
            this.Anamenudon.BackColor = System.Drawing.Color.Transparent;
            this.Anamenudon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anamenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Anamenudon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Anamenudon.Location = new System.Drawing.Point(496, 378);
            this.Anamenudon.Name = "Anamenudon";
            this.Anamenudon.Size = new System.Drawing.Size(132, 39);
            this.Anamenudon.TabIndex = 25;
            this.Anamenudon.Text = "Ana Menüye Dön";
            this.Anamenudon.UseVisualStyleBackColor = false;
            this.Anamenudon.Click += new System.EventHandler(this.Anamenudon_Click);
            // 
            // Vtekle
            // 
            this.Vtekle.BackColor = System.Drawing.Color.Transparent;
            this.Vtekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vtekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vtekle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Vtekle.Location = new System.Drawing.Point(160, 378);
            this.Vtekle.Name = "Vtekle";
            this.Vtekle.Size = new System.Drawing.Size(132, 39);
            this.Vtekle.TabIndex = 24;
            this.Vtekle.Text = "Ekle";
            this.Vtekle.UseVisualStyleBackColor = false;
            this.Vtekle.Click += new System.EventHandler(this.Vtekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(587, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(335, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "İsim :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label.Location = new System.Drawing.Point(12, 287);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 15);
            this.label.TabIndex = 17;
            this.label.Text = "Kullanıcı Numarası :";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(667, 284);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 16;
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(405, 284);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 20);
            this.isim.TabIndex = 15;
            // 
            // Kullaniciid
            // 
            this.Kullaniciid.Location = new System.Drawing.Point(160, 284);
            this.Kullaniciid.Name = "Kullaniciid";
            this.Kullaniciid.Size = new System.Drawing.Size(100, 20);
            this.Kullaniciid.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 184);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // KullanıcıEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Anamenudon);
            this.Controls.Add(this.Vtekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.Kullaniciid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullanıcıEkle";
            this.Text = "KullanıcıEkle";
            this.Load += new System.EventHandler(this.KullanıcıEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anamenudon;
        private System.Windows.Forms.Button Vtekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox Kullaniciid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}