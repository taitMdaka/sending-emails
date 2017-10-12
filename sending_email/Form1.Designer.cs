namespace sending_email
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
            this.butnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTo = new System.Windows.Forms.TextBox();
            this.settings = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textSMTP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textCC = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // butnSend
            // 
            this.butnSend.Location = new System.Drawing.Point(363, 80);
            this.butnSend.Name = "butnSend";
            this.butnSend.Size = new System.Drawing.Size(75, 23);
            this.butnSend.TabIndex = 5;
            this.butnSend.Text = "Send";
            this.butnSend.UseVisualStyleBackColor = true;
            this.butnSend.Click += new System.EventHandler(this.butnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(147, 44);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(171, 22);
            this.textTo.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.checkBox1);
            this.settings.Controls.Add(this.textSMTP);
            this.settings.Controls.Add(this.label8);
            this.settings.Controls.Add(this.textPort);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.textUser);
            this.settings.Controls.Add(this.textPass);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.label5);
            this.settings.Controls.Add(this.butnSend);
            this.settings.Location = new System.Drawing.Point(45, 352);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(561, 220);
            this.settings.TabIndex = 4;
            this.settings.TabStop = false;
            this.settings.Text = "groupBox1";
            this.settings.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(357, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "SSL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textSMTP
            // 
            this.textSMTP.Location = new System.Drawing.Point(378, 128);
            this.textSMTP.Name = "textSMTP";
            this.textSMTP.Size = new System.Drawing.Size(113, 22);
            this.textSMTP.TabIndex = 6;
            this.textSMTP.Text = "Smtp.gmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "SMTP:";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(142, 125);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(60, 22);
            this.textPort.TabIndex = 3;
            this.textPort.Text = "587";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Port:";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(142, 41);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(171, 22);
            this.textUser.TabIndex = 0;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(142, 77);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(171, 22);
            this.textPass.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "PassWords";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "cc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(147, 141);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(171, 22);
            this.textSubject.TabIndex = 2;
            // 
            // textCC
            // 
            this.textCC.Location = new System.Drawing.Point(147, 98);
            this.textCC.Name = "textCC";
            this.textCC.Size = new System.Drawing.Size(171, 22);
            this.textCC.TabIndex = 1;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(147, 185);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(459, 161);
            this.textMessage.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 622);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textCC);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.TextBox textSMTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textCC;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

