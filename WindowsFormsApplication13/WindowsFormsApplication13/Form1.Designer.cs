namespace WindowsFormsApplication13
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTC = new System.Windows.Forms.MaskedTextBox();
            this.maskIp = new System.Windows.Forms.MaskedTextBox();
            this.maskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskKart = new System.Windows.Forms.MaskedTextBox();
            this.maskDTarih = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kart Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP Address:";
            // 
            // maskTC
            // 
            this.maskTC.Location = new System.Drawing.Point(120, 36);
            this.maskTC.Name = "maskTC";
            this.maskTC.Size = new System.Drawing.Size(160, 20);
            this.maskTC.TabIndex = 10;
            // 
            // maskIp
            // 
            this.maskIp.Location = new System.Drawing.Point(165, 238);
            this.maskIp.Name = "maskIp";
            this.maskIp.Size = new System.Drawing.Size(160, 20);
            this.maskIp.TabIndex = 11;
            // 
            // maskTelefon
            // 
            this.maskTelefon.Location = new System.Drawing.Point(121, 93);
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(160, 20);
            this.maskTelefon.TabIndex = 11;
            // 
            // maskKart
            // 
            this.maskKart.Location = new System.Drawing.Point(185, 184);
            this.maskKart.Name = "maskKart";
            this.maskKart.Size = new System.Drawing.Size(160, 20);
            this.maskKart.TabIndex = 12;
            // 
            // maskDTarih
            // 
            this.maskDTarih.Location = new System.Drawing.Point(181, 137);
            this.maskDTarih.Name = "maskDTarih";
            this.maskDTarih.Size = new System.Drawing.Size(160, 20);
            this.maskDTarih.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 295);
            this.Controls.Add(this.maskDTarih);
            this.Controls.Add(this.maskKart);
            this.Controls.Add(this.maskTelefon);
            this.Controls.Add(this.maskIp);
            this.Controls.Add(this.maskTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskTC;
        private System.Windows.Forms.MaskedTextBox maskIp;
        private System.Windows.Forms.MaskedTextBox maskTelefon;
        private System.Windows.Forms.MaskedTextBox maskKart;
        private System.Windows.Forms.MaskedTextBox maskDTarih;
    }
}

