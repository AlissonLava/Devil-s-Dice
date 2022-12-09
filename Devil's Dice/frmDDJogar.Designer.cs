namespace Devil_s_Dice
{
    partial class frmDDJogar
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
            this.lblRoll = new System.Windows.Forms.Label();
            this.lstAlmas = new System.Windows.Forms.ListBox();
            this.lblAlmaAtual = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblRollAnterior = new System.Windows.Forms.Label();
            this.lblAlmasMortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll.Font = new System.Drawing.Font("Raven Song", 50F);
            this.lblRoll.ForeColor = System.Drawing.Color.Red;
            this.lblRoll.Location = new System.Drawing.Point(505, 154);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(165, 133);
            this.lblRoll.TabIndex = 0;
            this.lblRoll.Text = "666";
            // 
            // lstAlmas
            // 
            this.lstAlmas.BackColor = System.Drawing.Color.Black;
            this.lstAlmas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAlmas.Enabled = false;
            this.lstAlmas.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F);
            this.lstAlmas.ForeColor = System.Drawing.Color.White;
            this.lstAlmas.FormattingEnabled = true;
            this.lstAlmas.ItemHeight = 16;
            this.lstAlmas.Location = new System.Drawing.Point(152, 92);
            this.lstAlmas.Name = "lstAlmas";
            this.lstAlmas.Size = new System.Drawing.Size(142, 224);
            this.lstAlmas.TabIndex = 1;
            // 
            // lblAlmaAtual
            // 
            this.lblAlmaAtual.AutoSize = true;
            this.lblAlmaAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblAlmaAtual.Font = new System.Drawing.Font("Raven Song", 20F);
            this.lblAlmaAtual.ForeColor = System.Drawing.Color.Red;
            this.lblAlmaAtual.Location = new System.Drawing.Point(336, 92);
            this.lblAlmaAtual.Name = "lblAlmaAtual";
            this.lblAlmaAtual.Size = new System.Drawing.Size(80, 54);
            this.lblAlmaAtual.TabIndex = 2;
            this.lblAlmaAtual.Text = "Alma";
            // 
            // btnRoll
            // 
            this.btnRoll.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRoll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRoll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Font = new System.Drawing.Font("Raven Song", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.ForeColor = System.Drawing.Color.Red;
            this.btnRoll.Location = new System.Drawing.Point(345, 166);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(159, 80);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            // 
            // lblRollAnterior
            // 
            this.lblRollAnterior.AutoSize = true;
            this.lblRollAnterior.BackColor = System.Drawing.Color.Transparent;
            this.lblRollAnterior.Font = new System.Drawing.Font("Raven Song", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollAnterior.ForeColor = System.Drawing.Color.Red;
            this.lblRollAnterior.Location = new System.Drawing.Point(340, 259);
            this.lblRollAnterior.Name = "lblRollAnterior";
            this.lblRollAnterior.Size = new System.Drawing.Size(137, 28);
            this.lblRollAnterior.TabIndex = 4;
            this.lblRollAnterior.Text = "Roll Anterior: 666";
            // 
            // lblAlmasMortas
            // 
            this.lblAlmasMortas.AutoSize = true;
            this.lblAlmasMortas.Font = new System.Drawing.Font("Adobe Fangsong Std R", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))));
            this.lblAlmasMortas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlmasMortas.Location = new System.Drawing.Point(244, 364);
            this.lblAlmasMortas.Name = "lblAlmasMortas";
            this.lblAlmasMortas.Size = new System.Drawing.Size(95, 18);
            this.lblAlmasMortas.TabIndex = 5;
            this.lblAlmasMortas.Text = "Almas Mortas";
            // 
            // frmDDJogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlmasMortas);
            this.Controls.Add(this.lblRollAnterior);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblAlmaAtual);
            this.Controls.Add(this.lstAlmas);
            this.Controls.Add(this.lblRoll);
            this.DoubleBuffered = true;
            this.Name = "frmDDJogar";
            this.ShowIcon = false;
            this.Text = "Devil\'s Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.ListBox lstAlmas;
        private System.Windows.Forms.Label lblAlmaAtual;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblRollAnterior;
        private System.Windows.Forms.Label lblAlmasMortas;
    }
}