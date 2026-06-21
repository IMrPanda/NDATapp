namespace NDATapp
{
    partial class SiparisYonetimForm
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
            lstSiparisler = new ListBox();
            btnDurumIlerlet = new Button();
            btnIptalEt = new Button();
            SuspendLayout();
            // 
            // lstSiparisler
            // 
            lstSiparisler.BackColor = Color.MintCream;
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.Location = new Point(41, 31);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(561, 154);
            lstSiparisler.TabIndex = 0;
            // 
            // btnDurumIlerlet
            // 
            btnDurumIlerlet.BackColor = Color.LightSlateGray;
            btnDurumIlerlet.FlatAppearance.BorderSize = 0;
            btnDurumIlerlet.FlatStyle = FlatStyle.Flat;
            btnDurumIlerlet.Font = new Font("Stencil", 12F);
            btnDurumIlerlet.ForeColor = SystemColors.ControlLightLight;
            btnDurumIlerlet.Location = new Point(647, 31);
            btnDurumIlerlet.Name = "btnDurumIlerlet";
            btnDurumIlerlet.Size = new Size(111, 65);
            btnDurumIlerlet.TabIndex = 1;
            btnDurumIlerlet.Text = "ilerlet";
            btnDurumIlerlet.UseVisualStyleBackColor = false;
            btnDurumIlerlet.Click += btnDurumIlerlet_Click;
            // 
            // btnIptalEt
            // 
            btnIptalEt.BackColor = Color.LightSlateGray;
            btnIptalEt.FlatAppearance.BorderSize = 0;
            btnIptalEt.FlatStyle = FlatStyle.Flat;
            btnIptalEt.Font = new Font("Stencil", 12F);
            btnIptalEt.ForeColor = SystemColors.ControlLightLight;
            btnIptalEt.Location = new Point(647, 120);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(111, 65);
            btnIptalEt.TabIndex = 2;
            btnIptalEt.Text = "iptal";
            btnIptalEt.UseVisualStyleBackColor = false;
            btnIptalEt.Click += btnIptalEt_Click;
            // 
            // SiparisYonetimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 216);
            Controls.Add(btnIptalEt);
            Controls.Add(btnDurumIlerlet);
            Controls.Add(lstSiparisler);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "SiparisYonetimForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SiparisYonetimForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstSiparisler;
        private Button btnDurumIlerlet;
        private Button btnIptalEt;
    }
}