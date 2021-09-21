
namespace Arabaotomasyon.PresantationLayer.Kullanıcılar
{
    partial class KullanıcıListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıListele));
            this.Anamenudon = new System.Windows.Forms.Button();
            this.Vtlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tümliste = new System.Windows.Forms.RadioButton();
            this.secililiste = new System.Windows.Forms.RadioButton();
            this.kullaniciid = new System.Windows.Forms.CheckBox();
            this.isim = new System.Windows.Forms.CheckBox();
            this.sifre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Anamenudon
            // 
            this.Anamenudon.BackColor = System.Drawing.Color.Transparent;
            this.Anamenudon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anamenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Anamenudon.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Anamenudon.Location = new System.Drawing.Point(680, 468);
            this.Anamenudon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Anamenudon.Name = "Anamenudon";
            this.Anamenudon.Size = new System.Drawing.Size(132, 39);
            this.Anamenudon.TabIndex = 37;
            this.Anamenudon.Text = "Ana Menüye Dön";
            this.Anamenudon.UseVisualStyleBackColor = false;
            this.Anamenudon.Click += new System.EventHandler(this.Anamenudon_Click);
            // 
            // Vtlistele
            // 
            this.Vtlistele.BackColor = System.Drawing.Color.Transparent;
            this.Vtlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vtlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vtlistele.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Vtlistele.Location = new System.Drawing.Point(680, 405);
            this.Vtlistele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Vtlistele.Name = "Vtlistele";
            this.Vtlistele.Size = new System.Drawing.Size(132, 39);
            this.Vtlistele.TabIndex = 36;
            this.Vtlistele.Text = "Listele";
            this.Vtlistele.UseVisualStyleBackColor = false;
            this.Vtlistele.Click += new System.EventHandler(this.Vtlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 173);
            this.dataGridView1.TabIndex = 35;
            // 
            // tümliste
            // 
            this.tümliste.AutoSize = true;
            this.tümliste.BackColor = System.Drawing.Color.Transparent;
            this.tümliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tümliste.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tümliste.Location = new System.Drawing.Point(13, 207);
            this.tümliste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tümliste.Name = "tümliste";
            this.tümliste.Size = new System.Drawing.Size(153, 19);
            this.tümliste.TabIndex = 38;
            this.tümliste.TabStop = true;
            this.tümliste.Text = "Tüm Alanları Listele";
            this.tümliste.UseVisualStyleBackColor = false;
            this.tümliste.CheckedChanged += new System.EventHandler(this.tümliste_CheckedChanged);
            // 
            // secililiste
            // 
            this.secililiste.AutoSize = true;
            this.secililiste.BackColor = System.Drawing.Color.Transparent;
            this.secililiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secililiste.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.secililiste.Location = new System.Drawing.Point(13, 235);
            this.secililiste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secililiste.Name = "secililiste";
            this.secililiste.Size = new System.Drawing.Size(157, 19);
            this.secililiste.TabIndex = 39;
            this.secililiste.TabStop = true;
            this.secililiste.Text = "Seçili Alanları Listeli";
            this.secililiste.UseVisualStyleBackColor = false;
            this.secililiste.CheckedChanged += new System.EventHandler(this.secililiste_CheckedChanged);
            // 
            // kullaniciid
            // 
            this.kullaniciid.AutoSize = true;
            this.kullaniciid.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciid.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.kullaniciid.Location = new System.Drawing.Point(37, 261);
            this.kullaniciid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kullaniciid.Name = "kullaniciid";
            this.kullaniciid.Size = new System.Drawing.Size(148, 19);
            this.kullaniciid.TabIndex = 40;
            this.kullaniciid.Text = "Kullanıcı Numarası";
            this.kullaniciid.UseVisualStyleBackColor = false;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.BackColor = System.Drawing.Color.Transparent;
            this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.isim.Location = new System.Drawing.Point(37, 288);
            this.isim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(53, 19);
            this.isim.TabIndex = 41;
            this.isim.Text = "İsim";
            this.isim.UseVisualStyleBackColor = false;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.sifre.Location = new System.Drawing.Point(37, 315);
            this.sifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(56, 19);
            this.sifre.TabIndex = 42;
            this.sifre.Text = "Sifre";
            this.sifre.UseVisualStyleBackColor = false;
            // 
            // KullanıcıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 519);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.kullaniciid);
            this.Controls.Add(this.secililiste);
            this.Controls.Add(this.tümliste);
            this.Controls.Add(this.Anamenudon);
            this.Controls.Add(this.Vtlistele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KullanıcıListele";
            this.Text = "KullanıcıListele";
            this.Load += new System.EventHandler(this.KullanıcıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anamenudon;
        private System.Windows.Forms.Button Vtlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton tümliste;
        private System.Windows.Forms.RadioButton secililiste;
        private System.Windows.Forms.CheckBox kullaniciid;
        private System.Windows.Forms.CheckBox isim;
        private System.Windows.Forms.CheckBox sifre;
    }
}