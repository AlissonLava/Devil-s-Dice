namespace Devil_s_Dice
{
    partial class frmDDMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDDMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlma = new System.Windows.Forms.TextBox();
            this.btnAddAlma = new System.Windows.Forms.Button();
            this.lblAlmas = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raven Song", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(178, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devil\'s Dice";
            // 
            // txtAlma
            // 
            this.txtAlma.BackColor = System.Drawing.Color.Black;
            this.txtAlma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlma.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F);
            this.txtAlma.ForeColor = System.Drawing.Color.MistyRose;
            this.txtAlma.Location = new System.Drawing.Point(231, 232);
            this.txtAlma.Name = "txtAlma";
            this.txtAlma.Size = new System.Drawing.Size(348, 34);
            this.txtAlma.TabIndex = 1;
            // 
            // btnAddAlma
            // 
            this.btnAddAlma.BackColor = System.Drawing.Color.Black;
            this.btnAddAlma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlma.ForeColor = System.Drawing.Color.Red;
            this.btnAddAlma.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAlma.Image")));
            this.btnAddAlma.Location = new System.Drawing.Point(185, 232);
            this.btnAddAlma.Name = "btnAddAlma";
            this.btnAddAlma.Size = new System.Drawing.Size(40, 34);
            this.btnAddAlma.TabIndex = 2;
            this.btnAddAlma.Text = "+";
            this.btnAddAlma.UseVisualStyleBackColor = false;
            // 
            // lblAlmas
            // 
            this.lblAlmas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlmas.AutoSize = true;
            this.lblAlmas.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F);
            this.lblAlmas.ForeColor = System.Drawing.Color.Red;
            this.lblAlmas.Location = new System.Drawing.Point(228, 301);
            this.lblAlmas.Name = "lblAlmas";
            this.lblAlmas.Size = new System.Drawing.Size(0, 18);
            this.lblAlmas.TabIndex = 3;
            this.lblAlmas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Raven Song", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.Color.Red;
            this.btnJogar.Location = new System.Drawing.Point(322, 356);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(141, 46);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            // 
            // frmDDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblAlmas);
            this.Controls.Add(this.btnAddAlma);
            this.Controls.Add(this.txtAlma);
            this.Controls.Add(this.label1);
            this.Name = "frmDDMain";
            this.ShowIcon = false;
            this.Text = "DD Introdução";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlma;
        private System.Windows.Forms.Button btnAddAlma;
        private System.Windows.Forms.Label lblAlmas;
        private System.Windows.Forms.Button btnJogar;
    }
}

