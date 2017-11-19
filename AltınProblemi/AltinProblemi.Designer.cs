namespace AltınProblemi
{
    partial class frmAltinProblemi
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
            this.lblAltinSayisi = new System.Windows.Forms.Label();
            this.txtAltinSayisi = new System.Windows.Forms.TextBox();
            this.btnHasarliAltinBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltinSayisi
            // 
            this.lblAltinSayisi.AutoSize = true;
            this.lblAltinSayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltinSayisi.Location = new System.Drawing.Point(38, 44);
            this.lblAltinSayisi.Name = "lblAltinSayisi";
            this.lblAltinSayisi.Size = new System.Drawing.Size(99, 21);
            this.lblAltinSayisi.TabIndex = 0;
            this.lblAltinSayisi.Text = "Altın Sayısı:";
            // 
            // txtAltinSayisi
            // 
            this.txtAltinSayisi.Location = new System.Drawing.Point(170, 45);
            this.txtAltinSayisi.Name = "txtAltinSayisi";
            this.txtAltinSayisi.Size = new System.Drawing.Size(119, 22);
            this.txtAltinSayisi.TabIndex = 1;
            this.txtAltinSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltinSayisi_KeyPress);
            this.txtAltinSayisi.Leave += new System.EventHandler(this.txtAltinSayisi_Leave);
            // 
            // btnHasarliAltinBul
            // 
            this.btnHasarliAltinBul.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHasarliAltinBul.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHasarliAltinBul.Location = new System.Drawing.Point(53, 113);
            this.btnHasarliAltinBul.Name = "btnHasarliAltinBul";
            this.btnHasarliAltinBul.Size = new System.Drawing.Size(227, 64);
            this.btnHasarliAltinBul.TabIndex = 2;
            this.btnHasarliAltinBul.Text = "Hasarlı Altını Bul";
            this.btnHasarliAltinBul.UseVisualStyleBackColor = false;
            this.btnHasarliAltinBul.Click += new System.EventHandler(this.btnHasarliAltinBul_Click);
            // 
            // frmAltinProblemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(326, 206);
            this.Controls.Add(this.btnHasarliAltinBul);
            this.Controls.Add(this.txtAltinSayisi);
            this.Controls.Add(this.lblAltinSayisi);
            this.Name = "frmAltinProblemi";
            this.Text = "Altın Problemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltinSayisi;
        private System.Windows.Forms.TextBox txtAltinSayisi;
        private System.Windows.Forms.Button btnHasarliAltinBul;
    }
}

