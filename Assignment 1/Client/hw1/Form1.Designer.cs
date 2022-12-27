namespace hw1
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
            this.Ipbox = new System.Windows.Forms.TextBox();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Surnamebox = new System.Windows.Forms.TextBox();
            this.Usernamebox = new System.Windows.Forms.TextBox();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.Portbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientlogs = new System.Windows.Forms.RichTextBox();
            this.button1_connect = new System.Windows.Forms.Button();
            this.button2_disconnect = new System.Windows.Forms.Button();
            this.button_CreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ipbox
            // 
            this.Ipbox.Location = new System.Drawing.Point(99, 103);
            this.Ipbox.Name = "Ipbox";
            this.Ipbox.Size = new System.Drawing.Size(170, 20);
            this.Ipbox.TabIndex = 0;
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(99, 167);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(170, 20);
            this.Namebox.TabIndex = 1;
            // 
            // Surnamebox
            // 
            this.Surnamebox.Location = new System.Drawing.Point(99, 229);
            this.Surnamebox.Name = "Surnamebox";
            this.Surnamebox.Size = new System.Drawing.Size(170, 20);
            this.Surnamebox.TabIndex = 2;
            // 
            // Usernamebox
            // 
            this.Usernamebox.Location = new System.Drawing.Point(99, 299);
            this.Usernamebox.Name = "Usernamebox";
            this.Usernamebox.Size = new System.Drawing.Size(170, 20);
            this.Usernamebox.TabIndex = 3;
            // 
            // Passwordbox
            // 
            this.Passwordbox.Location = new System.Drawing.Point(99, 369);
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.PasswordChar = '*';
            this.Passwordbox.Size = new System.Drawing.Size(170, 20);
            this.Passwordbox.TabIndex = 4;
            this.Passwordbox.TextChanged += new System.EventHandler(this.Passwordbox_TextChanged);
            // 
            // Portbox
            // 
            this.Portbox.Location = new System.Drawing.Point(444, 103);
            this.Portbox.Name = "Portbox";
            this.Portbox.Size = new System.Drawing.Size(170, 20);
            this.Portbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Port:";
            // 
            // clientlogs
            // 
            this.clientlogs.Location = new System.Drawing.Point(382, 170);
            this.clientlogs.Name = "clientlogs";
            this.clientlogs.Size = new System.Drawing.Size(254, 413);
            this.clientlogs.TabIndex = 12;
            this.clientlogs.Text = "";
            // 
            // button1_connect
            // 
            this.button1_connect.Location = new System.Drawing.Point(530, 134);
            this.button1_connect.Name = "button1_connect";
            this.button1_connect.Size = new System.Drawing.Size(84, 30);
            this.button1_connect.TabIndex = 13;
            this.button1_connect.Text = "Connect";
            this.button1_connect.UseVisualStyleBackColor = true;
            this.button1_connect.Click += new System.EventHandler(this.button1_connect_Click);
            // 
            // button2_disconnect
            // 
            this.button2_disconnect.Enabled = false;
            this.button2_disconnect.Location = new System.Drawing.Point(552, 610);
            this.button2_disconnect.Name = "button2_disconnect";
            this.button2_disconnect.Size = new System.Drawing.Size(84, 35);
            this.button2_disconnect.TabIndex = 14;
            this.button2_disconnect.Text = "Disconnect";
            this.button2_disconnect.UseVisualStyleBackColor = true;
            this.button2_disconnect.Click += new System.EventHandler(this.button2_disconnect_Click);
            // 
            // button_CreateAccount
            // 
            this.button_CreateAccount.Enabled = false;
            this.button_CreateAccount.Location = new System.Drawing.Point(173, 535);
            this.button_CreateAccount.Name = "button_CreateAccount";
            this.button_CreateAccount.Size = new System.Drawing.Size(96, 48);
            this.button_CreateAccount.TabIndex = 15;
            this.button_CreateAccount.Text = "Create Account";
            this.button_CreateAccount.UseVisualStyleBackColor = true;
            this.button_CreateAccount.Click += new System.EventHandler(this.button_CreateAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 694);
            this.Controls.Add(this.button_CreateAccount);
            this.Controls.Add(this.button2_disconnect);
            this.Controls.Add(this.button1_connect);
            this.Controls.Add(this.clientlogs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Portbox);
            this.Controls.Add(this.Passwordbox);
            this.Controls.Add(this.Usernamebox);
            this.Controls.Add(this.Surnamebox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.Ipbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ipbox;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.TextBox Surnamebox;
        private System.Windows.Forms.TextBox Usernamebox;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.TextBox Portbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox clientlogs;
        private System.Windows.Forms.Button button1_connect;
        private System.Windows.Forms.Button button2_disconnect;
        private System.Windows.Forms.Button button_CreateAccount;
    }
}

