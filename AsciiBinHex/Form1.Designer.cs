namespace AsciiBinHex
{
    partial class UmrechnerAsciiHExBin
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
            this.textBoxAscii = new System.Windows.Forms.TextBox();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxBin = new System.Windows.Forms.TextBox();
            this.labelAscii = new System.Windows.Forms.Label();
            this.labelHex = new System.Windows.Forms.Label();
            this.labelBin = new System.Windows.Forms.Label();
            this.textBoxUTF8 = new System.Windows.Forms.TextBox();
            this.labelUTF8 = new System.Windows.Forms.Label();
            this.labelBin2 = new System.Windows.Forms.Label();
            this.labelHex2 = new System.Windows.Forms.Label();
            this.textBoxBin2 = new System.Windows.Forms.TextBox();
            this.textBoxHex2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAscii
            // 
            this.textBoxAscii.Location = new System.Drawing.Point(47, 12);
            this.textBoxAscii.Multiline = true;
            this.textBoxAscii.Name = "textBoxAscii";
            this.textBoxAscii.Size = new System.Drawing.Size(204, 103);
            this.textBoxAscii.TabIndex = 0;
            this.textBoxAscii.TextChanged += new System.EventHandler(this.textBoxAscii_TextChanged);
            this.textBoxAscii.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAscii_KeyDown);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(47, 121);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(204, 20);
            this.textBoxHex.TabIndex = 1;
            this.textBoxHex.TextChanged += new System.EventHandler(this.textBoxHex_TextChanged);
            this.textBoxHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHex_KeyDown);
            // 
            // textBoxBin
            // 
            this.textBoxBin.Location = new System.Drawing.Point(47, 147);
            this.textBoxBin.Multiline = true;
            this.textBoxBin.Name = "textBoxBin";
            this.textBoxBin.Size = new System.Drawing.Size(204, 36);
            this.textBoxBin.TabIndex = 2;
            this.textBoxBin.TextChanged += new System.EventHandler(this.textBoxBin_TextChanged);
            this.textBoxBin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBin_KeyDown);
            // 
            // labelAscii
            // 
            this.labelAscii.AutoSize = true;
            this.labelAscii.Location = new System.Drawing.Point(9, 15);
            this.labelAscii.Name = "labelAscii";
            this.labelAscii.Size = new System.Drawing.Size(32, 13);
            this.labelAscii.TabIndex = 3;
            this.labelAscii.Text = "Ascii:";
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Location = new System.Drawing.Point(9, 124);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(29, 13);
            this.labelHex.TabIndex = 4;
            this.labelHex.Text = "Hex:";
            // 
            // labelBin
            // 
            this.labelBin.AutoSize = true;
            this.labelBin.Location = new System.Drawing.Point(9, 150);
            this.labelBin.Name = "labelBin";
            this.labelBin.Size = new System.Drawing.Size(25, 13);
            this.labelBin.TabIndex = 5;
            this.labelBin.Text = "Bin:";
            // 
            // textBoxUTF8
            // 
            this.textBoxUTF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUTF8.Location = new System.Drawing.Point(315, 12);
            this.textBoxUTF8.Multiline = true;
            this.textBoxUTF8.Name = "textBoxUTF8";
            this.textBoxUTF8.ReadOnly = true;
            this.textBoxUTF8.Size = new System.Drawing.Size(191, 103);
            this.textBoxUTF8.TabIndex = 6;
            this.textBoxUTF8.TextChanged += new System.EventHandler(this.textBoxUTF8_TextChanged);
            this.textBoxUTF8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUTF8_KeyDown);
            // 
            // labelUTF8
            // 
            this.labelUTF8.AutoSize = true;
            this.labelUTF8.Location = new System.Drawing.Point(269, 15);
            this.labelUTF8.Name = "labelUTF8";
            this.labelUTF8.Size = new System.Drawing.Size(40, 13);
            this.labelUTF8.TabIndex = 7;
            this.labelUTF8.Text = "UTF-8:";
            // 
            // labelBin2
            // 
            this.labelBin2.AutoSize = true;
            this.labelBin2.Location = new System.Drawing.Point(269, 150);
            this.labelBin2.Name = "labelBin2";
            this.labelBin2.Size = new System.Drawing.Size(25, 13);
            this.labelBin2.TabIndex = 11;
            this.labelBin2.Text = "Bin:";
            // 
            // labelHex2
            // 
            this.labelHex2.AutoSize = true;
            this.labelHex2.Location = new System.Drawing.Point(269, 124);
            this.labelHex2.Name = "labelHex2";
            this.labelHex2.Size = new System.Drawing.Size(29, 13);
            this.labelHex2.TabIndex = 10;
            this.labelHex2.Text = "Hex:";
            // 
            // textBoxBin2
            // 
            this.textBoxBin2.Location = new System.Drawing.Point(315, 147);
            this.textBoxBin2.Multiline = true;
            this.textBoxBin2.Name = "textBoxBin2";
            this.textBoxBin2.Size = new System.Drawing.Size(191, 36);
            this.textBoxBin2.TabIndex = 9;
            this.textBoxBin2.TextChanged += new System.EventHandler(this.textBoxBin2_TextChanged);
            this.textBoxBin2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBin2_KeyDown);
            // 
            // textBoxHex2
            // 
            this.textBoxHex2.Location = new System.Drawing.Point(315, 121);
            this.textBoxHex2.Name = "textBoxHex2";
            this.textBoxHex2.Size = new System.Drawing.Size(191, 20);
            this.textBoxHex2.TabIndex = 8;
            this.textBoxHex2.TextChanged += new System.EventHandler(this.textBoxHex2_TextChanged);
            this.textBoxHex2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHex2_KeyDown);
            // 
            // UmrechnerAsciiHExBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 191);
            this.Controls.Add(this.labelBin2);
            this.Controls.Add(this.labelHex2);
            this.Controls.Add(this.textBoxBin2);
            this.Controls.Add(this.textBoxHex2);
            this.Controls.Add(this.labelUTF8);
            this.Controls.Add(this.textBoxUTF8);
            this.Controls.Add(this.labelBin);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.labelAscii);
            this.Controls.Add(this.textBoxBin);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.textBoxAscii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UmrechnerAsciiHExBin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Umrechner Ascii/Hex/Bin/UTF-8";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UmrechnerAsciiHExBin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAscii;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.TextBox textBoxBin;
        private System.Windows.Forms.Label labelAscii;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Label labelBin;
        private System.Windows.Forms.TextBox textBoxUTF8;
        private System.Windows.Forms.Label labelUTF8;
        private System.Windows.Forms.Label labelBin2;
        private System.Windows.Forms.Label labelHex2;
        private System.Windows.Forms.TextBox textBoxBin2;
        private System.Windows.Forms.TextBox textBoxHex2;
    }
}

