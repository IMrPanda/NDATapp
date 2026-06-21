namespace NDATapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSiparis = new Button();
            cmbOdeme = new ComboBox();
            cmbKargo = new ComboBox();
            cmbUrunler = new ComboBox();
            lstLoglar = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnYonetim = new Button();
            SuspendLayout();
            // 
            // btnSiparis
            // 
            btnSiparis.BackColor = Color.Beige;
            btnSiparis.FlatAppearance.BorderColor = Color.Black;
            btnSiparis.FlatStyle = FlatStyle.Flat;
            btnSiparis.Font = new Font("Stencil", 12F);
            btnSiparis.ForeColor = Color.LightSlateGray;
            btnSiparis.Location = new Point(1026, 54);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(114, 52);
            btnSiparis.TabIndex = 0;
            btnSiparis.Text = "siparis";
            btnSiparis.UseVisualStyleBackColor = false;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // cmbOdeme
            // 
            cmbOdeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOdeme.Font = new Font("Times New Roman", 12F);
            cmbOdeme.FormattingEnabled = true;
            cmbOdeme.Location = new Point(769, 76);
            cmbOdeme.Name = "cmbOdeme";
            cmbOdeme.Size = new Size(175, 27);
            cmbOdeme.TabIndex = 1;
            // 
            // cmbKargo
            // 
            cmbKargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKargo.Font = new Font("Times New Roman", 12F);
            cmbKargo.FormattingEnabled = true;
            cmbKargo.Location = new Point(505, 76);
            cmbKargo.Name = "cmbKargo";
            cmbKargo.Size = new Size(175, 27);
            cmbKargo.TabIndex = 2;
            // 
            // cmbUrunler
            // 
            cmbUrunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrunler.Font = new Font("Times New Roman", 12F);
            cmbUrunler.FormattingEnabled = true;
            cmbUrunler.Location = new Point(230, 76);
            cmbUrunler.Name = "cmbUrunler";
            cmbUrunler.Size = new Size(177, 27);
            cmbUrunler.TabIndex = 3;
            // 
            // lstLoglar
            // 
            lstLoglar.BackColor = Color.LightSteelBlue;
            lstLoglar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLoglar.ForeColor = SystemColors.InactiveCaptionText;
            lstLoglar.FormattingEnabled = true;
            lstLoglar.Location = new Point(125, 155);
            lstLoglar.Name = "lstLoglar";
            lstLoglar.ScrollAlwaysVisible = true;
            lstLoglar.Size = new Size(955, 280);
            lstLoglar.Sorted = true;
            lstLoglar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(505, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 5;
            label1.Text = "firma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(230, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 6;
            label2.Text = "ürünler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(769, 54);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 7;
            label3.Text = "ödeme";
            // 
            // btnYonetim
            // 
            btnYonetim.BackColor = Color.Beige;
            btnYonetim.FlatStyle = FlatStyle.Flat;
            btnYonetim.Font = new Font("Stencil", 12F);
            btnYonetim.ForeColor = Color.LightSlateGray;
            btnYonetim.Location = new Point(46, 484);
            btnYonetim.Name = "btnYonetim";
            btnYonetim.Size = new Size(109, 47);
            btnYonetim.TabIndex = 8;
            btnYonetim.Text = "yönetim";
            btnYonetim.UseVisualStyleBackColor = false;
            btnYonetim.Click += btnYonetim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1204, 581);
            Controls.Add(btnYonetim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstLoglar);
            Controls.Add(cmbUrunler);
            Controls.Add(cmbKargo);
            Controls.Add(cmbOdeme);
            Controls.Add(btnSiparis);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaEkran";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ListBox lstLoglar;
        private Label label1;
        private Label label2;
        private Button btnSiparis;
        private ComboBox cmbOdeme;
        private ComboBox cmbKargo;
        private ComboBox cmbUrunler;
        private Label label3;
        private Button btnYonetim;
    }
}
