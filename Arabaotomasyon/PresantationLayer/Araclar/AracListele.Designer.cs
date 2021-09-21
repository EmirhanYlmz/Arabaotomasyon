
namespace Arabaotomasyon.PresantationLayer.Araclar
{
    partial class AracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracListele));
            this.model = new System.Windows.Forms.CheckBox();
            this.marka = new System.Windows.Forms.CheckBox();
            this.aracid = new System.Windows.Forms.CheckBox();
            this.secililiste = new System.Windows.Forms.RadioButton();
            this.tümliste = new System.Windows.Forms.RadioButton();
            this.Anamenudon = new System.Windows.Forms.Button();
            this.Vtlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plaka = new System.Windows.Forms.CheckBox();
            this.Yil = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.BackColor = System.Drawing.Color.Transparent;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.model.Location = new System.Drawing.Point(36, 376);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(60, 17);
            this.model.TabIndex = 50;
            this.model.Text = "Model";
            this.model.UseVisualStyleBackColor = false;
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.BackColor = System.Drawing.Color.Transparent;
            this.marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marka.Location = new System.Drawing.Point(36, 352);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(61, 17);
            this.marka.TabIndex = 49;
            this.marka.Text = "Marka";
            this.marka.UseVisualStyleBackColor = false;
            // 
            // aracid
            // 
            this.aracid.AutoSize = true;
            this.aracid.BackColor = System.Drawing.Color.Transparent;
            this.aracid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracid.Location = new System.Drawing.Point(36, 329);
            this.aracid.Name = "aracid";
            this.aracid.Size = new System.Drawing.Size(108, 17);
            this.aracid.TabIndex = 48;
            this.aracid.Text = "Araç Numarası";
            this.aracid.UseVisualStyleBackColor = false;
            // 
            // secililiste
            // 
            this.secililiste.AutoSize = true;
            this.secililiste.BackColor = System.Drawing.Color.Transparent;
            this.secililiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secililiste.Location = new System.Drawing.Point(18, 306);
            this.secililiste.Name = "secililiste";
            this.secililiste.Size = new System.Drawing.Size(139, 17);
            this.secililiste.TabIndex = 47;
            this.secililiste.TabStop = true;
            this.secililiste.Text = "Seçili Alanları Listeli";
            this.secililiste.UseVisualStyleBackColor = false;
            this.secililiste.CheckedChanged += new System.EventHandler(this.secililiste_CheckedChanged);
            // 
            // tümliste
            // 
            this.tümliste.AutoSize = true;
            this.tümliste.BackColor = System.Drawing.Color.Transparent;
            this.tümliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tümliste.Location = new System.Drawing.Point(18, 282);
            this.tümliste.Name = "tümliste";
            this.tümliste.Size = new System.Drawing.Size(136, 17);
            this.tümliste.TabIndex = 46;
            this.tümliste.TabStop = true;
            this.tümliste.Text = "Tüm Alanları Listele";
            this.tümliste.UseVisualStyleBackColor = false;
            this.tümliste.CheckedChanged += new System.EventHandler(this.tümliste_CheckedChanged);
            // 
            // Anamenudon
            // 
            this.Anamenudon.BackColor = System.Drawing.Color.Transparent;
            this.Anamenudon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anamenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Anamenudon.Location = new System.Drawing.Point(660, 399);
            this.Anamenudon.Name = "Anamenudon";
            this.Anamenudon.Size = new System.Drawing.Size(129, 39);
            this.Anamenudon.TabIndex = 45;
            this.Anamenudon.Text = "Ana Menüye Dön";
            this.Anamenudon.UseVisualStyleBackColor = false;
            this.Anamenudon.Click += new System.EventHandler(this.Anamenudon_Click);
            // 
            // Vtlistele
            // 
            this.Vtlistele.BackColor = System.Drawing.Color.Transparent;
            this.Vtlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vtlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vtlistele.Location = new System.Drawing.Point(660, 352);
            this.Vtlistele.Name = "Vtlistele";
            this.Vtlistele.Size = new System.Drawing.Size(129, 39);
            this.Vtlistele.TabIndex = 44;
            this.Vtlistele.Text = "Listele";
            this.Vtlistele.UseVisualStyleBackColor = false;
            this.Vtlistele.Click += new System.EventHandler(this.Vtlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 153);
            this.dataGridView1.TabIndex = 43;
            // 
            // plaka
            // 
            this.plaka.AutoSize = true;
            this.plaka.BackColor = System.Drawing.Color.Transparent;
            this.plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plaka.Location = new System.Drawing.Point(36, 422);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(58, 17);
            this.plaka.TabIndex = 52;
            this.plaka.Text = "Plaka";
            this.plaka.UseVisualStyleBackColor = false;
            // 
            // Yil
            // 
            this.Yil.AutoSize = true;
            this.Yil.BackColor = System.Drawing.Color.Transparent;
            this.Yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yil.Location = new System.Drawing.Point(36, 399);
            this.Yil.Name = "Yil";
            this.Yil.Size = new System.Drawing.Size(40, 17);
            this.Yil.TabIndex = 51;
            this.Yil.Text = "Yıl";
            this.Yil.UseVisualStyleBackColor = false;
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.Yil);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.aracid);
            this.Controls.Add(this.secililiste);
            this.Controls.Add(this.tümliste);
            this.Controls.Add(this.Anamenudon);
            this.Controls.Add(this.Vtlistele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AracListele";
            this.Text = "AracListele";
            this.Load += new System.EventHandler(this.AracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox model;
        private System.Windows.Forms.CheckBox marka;
        private System.Windows.Forms.CheckBox aracid;
        private System.Windows.Forms.RadioButton secililiste;
        private System.Windows.Forms.RadioButton tümliste;
        private System.Windows.Forms.Button Anamenudon;
        private System.Windows.Forms.Button Vtlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox plaka;
        private System.Windows.Forms.CheckBox Yil;
    }
}