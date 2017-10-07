namespace SendingSMS
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
            this.NumTxt = new System.Windows.Forms.TextBox();
            this.SMSTxt = new System.Windows.Forms.TextBox();
            this.CntBtn = new System.Windows.Forms.Button();
            this.SndBtn = new System.Windows.Forms.Button();
            this.ComPort = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumTxt
            // 
            this.NumTxt.Location = new System.Drawing.Point(183, 82);
            this.NumTxt.Name = "NumTxt";
            this.NumTxt.Size = new System.Drawing.Size(150, 20);
            this.NumTxt.TabIndex = 1;
            // 
            // SMSTxt
            // 
            this.SMSTxt.Location = new System.Drawing.Point(161, 146);
            this.SMSTxt.Multiline = true;
            this.SMSTxt.Name = "SMSTxt";
            this.SMSTxt.Size = new System.Drawing.Size(172, 108);
            this.SMSTxt.TabIndex = 2;
            // 
            // CntBtn
            // 
            this.CntBtn.Location = new System.Drawing.Point(258, 37);
            this.CntBtn.Name = "CntBtn";
            this.CntBtn.Size = new System.Drawing.Size(75, 23);
            this.CntBtn.TabIndex = 3;
            this.CntBtn.Text = "Connect";
            this.CntBtn.UseVisualStyleBackColor = true;
            this.CntBtn.Click += new System.EventHandler(this.CntBtn_Click);
            // 
            // SndBtn
            // 
            this.SndBtn.Location = new System.Drawing.Point(258, 290);
            this.SndBtn.Name = "SndBtn";
            this.SndBtn.Size = new System.Drawing.Size(75, 23);
            this.SndBtn.TabIndex = 4;
            this.SndBtn.Text = "Send";
            this.SndBtn.UseVisualStyleBackColor = true;
            this.SndBtn.Click += new System.EventHandler(this.SndBtn_Click);
            // 
            // ComPort
            // 
            this.ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPort.FormattingEnabled = true;
            this.ComPort.Location = new System.Drawing.Point(114, 37);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(121, 21);
            this.ComPort.TabIndex = 5;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(78, 370);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(163, 16);
            this.status.TabIndex = 6;
            this.status.Text = "Modem Not connected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message Body:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.ComPort);
            this.Controls.Add(this.SndBtn);
            this.Controls.Add(this.CntBtn);
            this.Controls.Add(this.SMSTxt);
            this.Controls.Add(this.NumTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NumTxt;
        private System.Windows.Forms.TextBox SMSTxt;
        private System.Windows.Forms.Button CntBtn;
        private System.Windows.Forms.Button SndBtn;
        private System.Windows.Forms.ComboBox ComPort;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

