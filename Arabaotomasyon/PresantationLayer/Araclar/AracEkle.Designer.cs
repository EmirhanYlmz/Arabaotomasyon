
namespace Arabaotomasyon.PresantationLayer.Araclar
{
    partial class AracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracid = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yil = new System.Windows.Forms.TextBox();
            this.plaka = new System.Windows.Forms.TextBox();
            this.Vtekle = new System.Windows.Forms.Button();
            this.Anamenudon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // aracid
            // 
            this.aracid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aracid.Location = new System.Drawing.Point(118, 226);
            this.aracid.Name = "aracid";
            this.aracid.Size = new System.Drawing.Size(100, 20);
            this.aracid.TabIndex = 1;
            // 
            // marka
            // 
            this.marka.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.marka.Location = new System.Drawing.Point(393, 225);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(100, 20);
            this.marka.TabIndex = 2;
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.SystemColors.Window;
            this.model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.model.Location = new System.Drawing.Point(664, 226);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 20);
            this.model.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(294, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(599, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(186, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yıl :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(476, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plaka :";
            // 
            // yil
            // 
            this.yil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yil.Location = new System.Drawing.Point(244, 322);
            this.yil.Name = "yil";
            this.yil.Size = new System.Drawing.Size(100, 20);
            this.yil.TabIndex = 9;
            // 
            // plaka
            // 
            this.plaka.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plaka.Location = new System.Drawing.Point(548, 322);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(100, 20);
            this.plaka.TabIndex = 10;
            // 
            // Vtekle
            // 
            this.Vtekle.BackColor = System.Drawing.Color.Transparent;
            this.Vtekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vtekle.CausesValidation = false;
            this.Vtekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vtekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vtekle.ForeColor = System.Drawing.Color.White;
            this.Vtekle.Location = new System.Drawing.Point(255, 396);
            this.Vtekle.Name = "Vtekle";
            this.Vtekle.Size = new System.Drawing.Size(114, 37);
            this.Vtekle.TabIndex = 11;
            this.Vtekle.Text = "Ekle";
            this.Vtekle.UseVisualStyleBackColor = false;
            this.Vtekle.Click += new System.EventHandler(this.Vtekle_Click);
            // 
            // Anamenudon
            // 
            this.Anamenudon.BackColor = System.Drawing.Color.Transparent;
            this.Anamenudon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Anamenudon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anamenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Anamenudon.ForeColor = System.Drawing.Color.White;
            this.Anamenudon.Location = new System.Drawing.Point(479, 396);
            this.Anamenudon.Name = "Anamenudon";
            this.Anamenudon.Size = new System.Drawing.Size(114, 37);
            this.Anamenudon.TabIndex = 12;
            this.Anamenudon.Text = "Ana Menüye Dön";
            this.Anamenudon.UseVisualStyleBackColor = false;
            this.Anamenudon.Click += new System.EventHandler(this.Anamenudon_Click);
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Anamenudon);
            this.Controls.Add(this.Vtekle);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.yil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.aracid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AracEkle";
            this.Text = "AracEkle";
            this.Load += new System.EventHandler(this.AracEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox aracid;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yil;
        private System.Windows.Forms.TextBox plaka;
        private System.Windows.Forms.Button Vtekle;
        private System.Windows.Forms.Button Anamenudon;
    }
}