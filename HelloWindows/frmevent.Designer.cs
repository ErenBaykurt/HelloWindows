namespace HelloWindows
{
    partial class frmevent
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblKoordinat = new System.Windows.Forms.Label();
            this.btnsayi2 = new System.Windows.Forms.Button();
            this.btnsayi1 = new System.Windows.Forms.Button();
            this.btnsayi3 = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(686, 93);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 0;
            // 
            // lblKoordinat
            // 
            this.lblKoordinat.AutoSize = true;
            this.lblKoordinat.Location = new System.Drawing.Point(671, 52);
            this.lblKoordinat.Name = "lblKoordinat";
            this.lblKoordinat.Size = new System.Drawing.Size(35, 13);
            this.lblKoordinat.TabIndex = 1;
            this.lblKoordinat.Text = "label1";
            // 
            // btnsayi2
            // 
            this.btnsayi2.Location = new System.Drawing.Point(322, 117);
            this.btnsayi2.Name = "btnsayi2";
            this.btnsayi2.Size = new System.Drawing.Size(75, 23);
            this.btnsayi2.TabIndex = 2;
            this.btnsayi2.UseVisualStyleBackColor = true;
            this.btnsayi2.Click += new System.EventHandler(this.Topla);
            // 
            // btnsayi1
            // 
            this.btnsayi1.Location = new System.Drawing.Point(322, 88);
            this.btnsayi1.Name = "btnsayi1";
            this.btnsayi1.Size = new System.Drawing.Size(75, 23);
            this.btnsayi1.TabIndex = 3;
            this.btnsayi1.UseVisualStyleBackColor = true;
            this.btnsayi1.Click += new System.EventHandler(this.Topla);
            // 
            // btnsayi3
            // 
            this.btnsayi3.Location = new System.Drawing.Point(322, 146);
            this.btnsayi3.Name = "btnsayi3";
            this.btnsayi3.Size = new System.Drawing.Size(75, 23);
            this.btnsayi3.TabIndex = 4;
            this.btnsayi3.UseVisualStyleBackColor = true;
            this.btnsayi3.Click += new System.EventHandler(this.Topla);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(264, 187);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(181, 23);
            this.btnSonuc.TabIndex = 5;
            this.btnSonuc.Text = "Sonucu Göster";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // frmevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnsayi3);
            this.Controls.Add(this.btnsayi1);
            this.Controls.Add(this.btnsayi2);
            this.Controls.Add(this.lblKoordinat);
            this.Controls.Add(this.lblText);
            this.Name = "frmevent";
            this.Text = "frmevent";
            this.MouseLeave += new System.EventHandler(this.frmevent_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmevent_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblKoordinat;
        private System.Windows.Forms.Button btnsayi2;
        private System.Windows.Forms.Button btnsayi1;
        private System.Windows.Forms.Button btnsayi3;
        private System.Windows.Forms.Button btnSonuc;
    }
}