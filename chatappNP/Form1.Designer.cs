
namespace chatappNP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.ServerPORTtextBox = new System.Windows.Forms.TextBox();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.ClientPORTtextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChatScreenrichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessagerichTextBox = new System.Windows.Forms.RichTextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Startbutton);
            this.groupBox1.Controls.Add(this.ServerPORTtextBox);
            this.groupBox1.Controls.Add(this.ServerIPtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(552, 22);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 47);
            this.Startbutton.TabIndex = 4;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // ServerPORTtextBox
            // 
            this.ServerPORTtextBox.Location = new System.Drawing.Point(357, 31);
            this.ServerPORTtextBox.Name = "ServerPORTtextBox";
            this.ServerPORTtextBox.Size = new System.Drawing.Size(131, 23);
            this.ServerPORTtextBox.TabIndex = 3;
            this.ServerPORTtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(46, 31);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(172, 23);
            this.ServerIPtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Connectbutton);
            this.groupBox2.Controls.Add(this.ClientPORTtextBox);
            this.groupBox2.Controls.Add(this.ClientIPtextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(552, 16);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(75, 46);
            this.Connectbutton.TabIndex = 4;
            this.Connectbutton.Text = "CONNECT";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // ClientPORTtextBox
            // 
            this.ClientPORTtextBox.Location = new System.Drawing.Point(359, 29);
            this.ClientPORTtextBox.Name = "ClientPORTtextBox";
            this.ClientPORTtextBox.Size = new System.Drawing.Size(131, 23);
            this.ClientPORTtextBox.TabIndex = 3;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(46, 29);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(172, 23);
            this.ClientIPtextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // ChatScreenrichTextBox
            // 
            this.ChatScreenrichTextBox.Location = new System.Drawing.Point(21, 22);
            this.ChatScreenrichTextBox.Name = "ChatScreenrichTextBox";
            this.ChatScreenrichTextBox.Size = new System.Drawing.Size(606, 95);
            this.ChatScreenrichTextBox.TabIndex = 2;
            this.ChatScreenrichTextBox.Text = "";
            // 
            // MessagerichTextBox
            // 
            this.MessagerichTextBox.Location = new System.Drawing.Point(21, 22);
            this.MessagerichTextBox.Name = "MessagerichTextBox";
            this.MessagerichTextBox.Size = new System.Drawing.Size(488, 46);
            this.MessagerichTextBox.TabIndex = 3;
            this.MessagerichTextBox.Text = "";
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(547, 22);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(80, 41);
            this.Sendbutton.TabIndex = 4;
            this.Sendbutton.Text = "SEND";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 435);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHAT APP NP";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Sendbutton);
            this.groupBox5.Controls.Add(this.MessagerichTextBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(643, 74);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MESSAGE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ChatScreenrichTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 123);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHAT SCREEN";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ServerPORTtextBox;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ClientPORTtextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.RichTextBox ChatScreenrichTextBox;
        private System.Windows.Forms.RichTextBox MessagerichTextBox;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

