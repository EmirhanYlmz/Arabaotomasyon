
namespace Arabaotomasyon.PresantationLayer.Hasarlı
{
    partial class HasarlıListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasarlıListele));
            this.hasartipi = new System.Windows.Forms.CheckBox();
            this.Yil = new System.Windows.Forms.CheckBox();
            this.model = new System.Windows.Forms.CheckBox();
            this.marka = new System.Windows.Forms.CheckBox();
            this.hasarliid = new System.Windows.Forms.CheckBox();
            this.secililiste = new System.Windows.Forms.RadioButton();
            this.tümliste = new System.Windows.Forms.RadioButton();
            this.Anamenudon = new System.Windows.Forms.Button();
            this.Vtlistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hasartipi
            // 
            this.hasartipi.AutoSize = true;
            this.hasartipi.BackColor = System.Drawing.Color.Transparent;
            this.hasartipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.hasartipi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hasartipi.Location = new System.Drawing.Point(27, 363);
            this.hasartipi.Name = "hasartipi";
            this.hasartipi.Size = new System.Drawing.Size(92, 19);
            this.hasartipi.TabIndex = 62;
            this.hasartipi.Text = "Hasar Tipi";
            this.hasartipi.UseVisualStyleBackColor = false;
            // 
            // Yil
            // 
            this.Yil.AutoSize = true;
            this.Yil.BackColor = System.Drawing.Color.Transparent;
            this.Yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Yil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Yil.Location = new System.Drawing.Point(27, 340);
            this.Yil.Name = "Yil";
            this.Yil.Size = new System.Drawing.Size(42, 19);
            this.Yil.TabIndex = 61;
            this.Yil.Text = "Yıl";
            this.Yil.UseVisualStyleBackColor = false;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.BackColor = System.Drawing.Color.Transparent;
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.model.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.model.Location = new System.Drawing.Point(27, 317);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(66, 19);
            this.model.TabIndex = 60;
            this.model.Text = "Model";
            this.model.UseVisualStyleBackColor = false;
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.BackColor = System.Drawing.Color.Transparent;
            this.marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.marka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.marka.Location = new System.Drawing.Point(27, 293);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(66, 19);
            this.marka.TabIndex = 59;
            this.marka.Text = "Marka";
            this.marka.UseVisualStyleBackColor = false;
            // 
            // hasarliid
            // 
            this.hasarliid.AutoSize = true;
            this.hasarliid.BackColor = System.Drawing.Color.Transparent;
            this.hasarliid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.hasarliid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hasarliid.Location = new System.Drawing.Point(27, 270);
            this.hasarliid.Name = "hasarliid";
            this.hasarliid.Size = new System.Drawing.Size(138, 19);
            this.hasarliid.TabIndex = 58;
            this.hasarliid.Text = "Hasarlı Numarası";
            this.hasarliid.UseVisualStyleBackColor = false;
            // 
            // secililiste
            // 
            this.secililiste.AutoSize = true;
            this.secililiste.BackColor = System.Drawing.Color.Transparent;
            this.secililiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.secililiste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secililiste.Location = new System.Drawing.Point(9, 247);
            this.secililiste.Name = "secililiste";
            this.secililiste.Size = new System.Drawing.Size(157, 19);
            this.secililiste.TabIndex = 57;
            this.secililiste.TabStop = true;
            this.secililiste.Text = "Seçili Alanları Listeli";
            this.secililiste.UseVisualStyleBackColor = false;
            this.secililiste.CheckedChanged += new System.EventHandler(this.secililiste_CheckedChanged);
            // 
            // tümliste
            // 
            this.tümliste.AutoSize = true;
            this.tümliste.BackColor = System.Drawing.Color.Transparent;
            this.tümliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tümliste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tümliste.Location = new System.Drawing.Point(9, 223);
            this.tümliste.Name = "tümliste";
            this.tümliste.Size = new System.Drawing.Size(153, 19);
            this.tümliste.TabIndex = 56;
            this.tümliste.TabStop = true;
            this.tümliste.Text = "Tüm Alanları Listele";
            this.tümliste.UseVisualStyleBackColor = false;
            this.tümliste.CheckedChanged += new System.EventHandler(this.tümliste_CheckedChanged);
            // 
            // Anamenudon
            // 
            this.Anamenudon.BackColor = System.Drawing.Color.Transparent;
            this.Anamenudon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anamenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Anamenudon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Anamenudon.Location = new System.Drawing.Point(656, 399);
            this.Anamenudon.Name = "Anamenudon";
            this.Anamenudon.Size = new System.Drawing.Size(132, 39);
            this.Anamenudon.TabIndex = 55;
            this.Anamenudon.Text = "Ana Menüye Dön";
            this.Anamenudon.UseVisualStyleBackColor = false;
            this.Anamenudon.Click += new System.EventHandler(this.Anamenudon_Click);
            // 
            // Vtlistele
            // 
            this.Vtlistele.BackColor = System.Drawing.Color.Transparent;
            this.Vtlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vtlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Vtlistele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Vtlistele.Location = new System.Drawing.Point(656, 343);
            this.Vtlistele.Name = "Vtlistele";
            this.Vtlistele.Size = new System.Drawing.Size(132, 39);
            this.Vtlistele.TabIndex = 54;
            this.Vtlistele.Text = "Listele";
            this.Vtlistele.UseVisualStyleBackColor = false;
            this.Vtlistele.Click += new System.EventHandler(this.Vtlistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 173);
            this.dataGridView1.TabIndex = 53;
            // 
            // HasarlıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hasartipi);
            this.Controls.Add(this.Yil);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.hasarliid);
            this.Controls.Add(this.secililiste);
            this.Controls.Add(this.tümliste);
            this.Controls.Add(this.Anamenudon);
            this.Controls.Add(this.Vtlistele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HasarlıListele";
            this.Text = "HasarlıListele";
            this.Load += new System.EventHandler(this.HasarlıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox hasartipi;
        private System.Windows.Forms.CheckBox Yil;
        private System.Windows.Forms.CheckBox model;
        private System.Windows.Forms.CheckBox marka;
        private System.Windows.Forms.CheckBox hasarliid;
        private System.Windows.Forms.RadioButton secililiste;
        private System.Windows.Forms.RadioButton tümliste;
        private System.Windows.Forms.Button Anamenudon;
        private System.Windows.Forms.Button Vtlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}