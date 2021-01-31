namespace Otel_Uygulaması
{
    partial class FrmUrunler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgidalar = new System.Windows.Forms.TextBox();
            this.txtiçecek = new System.Windows.Forms.TextBox();
            this.txtatistirmalik = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.Listviewitem = new System.Windows.Forms.ListView();
            this.Gıdalar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İçecekler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Atıştırmalıklar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(118, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atıştırmalık Tutarı:";
            // 
            // txtgidalar
            // 
            this.txtgidalar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgidalar.Location = new System.Drawing.Point(332, 51);
            this.txtgidalar.Name = "txtgidalar";
            this.txtgidalar.Size = new System.Drawing.Size(256, 27);
            this.txtgidalar.TabIndex = 3;
            // 
            // txtiçecek
            // 
            this.txtiçecek.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtiçecek.Location = new System.Drawing.Point(332, 87);
            this.txtiçecek.Name = "txtiçecek";
            this.txtiçecek.Size = new System.Drawing.Size(256, 27);
            this.txtiçecek.TabIndex = 4;
            // 
            // txtatistirmalik
            // 
            this.txtatistirmalik.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtatistirmalik.Location = new System.Drawing.Point(332, 128);
            this.txtatistirmalik.Name = "txtatistirmalik";
            this.txtatistirmalik.Size = new System.Drawing.Size(256, 27);
            this.txtatistirmalik.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(318, 178);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(280, 57);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // Listviewitem
            // 
            this.Listviewitem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gıdalar,
            this.İçecekler,
            this.Atıştırmalıklar});
            this.Listviewitem.HideSelection = false;
            this.Listviewitem.Location = new System.Drawing.Point(69, 319);
            this.Listviewitem.Name = "Listviewitem";
            this.Listviewitem.Size = new System.Drawing.Size(632, 97);
            this.Listviewitem.TabIndex = 7;
            this.Listviewitem.UseCompatibleStateImageBehavior = false;
            this.Listviewitem.View = System.Windows.Forms.View.Details;
            this.Listviewitem.SelectedIndexChanged += new System.EventHandler(this.Listviewitem_SelectedIndexChanged);
            // 
            // Gıdalar
            // 
            this.Gıdalar.Text = "Gıdalar";
            this.Gıdalar.Width = 214;
            // 
            // İçecekler
            // 
            this.İçecekler.Text = "İçecekler";
            this.İçecekler.Width = 190;
            // 
            // Atıştırmalıklar
            // 
            this.Atıştırmalıklar.Text = "Atıştırmalıklar";
            this.Atıştırmalıklar.Width = 223;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Listviewitem);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtatistirmalik);
            this.Controls.Add(this.txtiçecek);
            this.Controls.Add(this.txtgidalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunler";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgidalar;
        private System.Windows.Forms.TextBox txtiçecek;
        private System.Windows.Forms.TextBox txtatistirmalik;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ListView Listviewitem;
        private System.Windows.Forms.ColumnHeader Gıdalar;
        private System.Windows.Forms.ColumnHeader İçecekler;
        private System.Windows.Forms.ColumnHeader Atıştırmalıklar;
    }
}