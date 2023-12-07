namespace HelloWindows
{
    partial class frmOyun
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
            this.components = new System.ComponentModel.Container();
            this.btnYakala = new System.Windows.Forms.Button();
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYakala
            // 
            this.btnYakala.Location = new System.Drawing.Point(1, -1);
            this.btnYakala.Name = "btnYakala";
            this.btnYakala.Size = new System.Drawing.Size(104, 70);
            this.btnYakala.TabIndex = 0;
            this.btnYakala.Text = "BAS";
            this.btnYakala.UseVisualStyleBackColor = true;
            this.btnYakala.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnYakala_MouseMove);
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBilgi.Controls.Add(this.lblAdSoyad);
            this.pnlBilgi.Controls.Add(this.lblSure);
            this.pnlBilgi.Controls.Add(this.lblSkor);
            this.pnlBilgi.Location = new System.Drawing.Point(631, -1);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(171, 452);
            this.pnlBilgi.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 297);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(35, 13);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "label1";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(61, 115);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 13);
            this.lblSure.TabIndex = 1;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(68, 33);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(0, 13);
            this.lblSkor.TabIndex = 0;
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBilgi);
            this.Controls.Add(this.btnYakala);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.SizeChanged += new System.EventHandler(this.frmOyun_SizeChanged);
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYakala;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}