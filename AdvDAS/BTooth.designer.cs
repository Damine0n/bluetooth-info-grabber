namespace BTooth_tutorial
{
    partial class BTooth
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.bGo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 2);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(414, 244);
            this.tbOutput.TabIndex = 0;
            // 
            // tbText
            // 
            this.tbText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbText.Location = new System.Drawing.Point(12, 267);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(579, 20);
            this.tbText.TabIndex = 1;
            this.tbText.Text = "$0F1066 0x20";
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(432, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 147);
            this.listBox1.TabIndex = 2;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Controls.Add(this.rbClient);
            this.groupBox1.Location = new System.Drawing.Point(432, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Type";
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(6, 42);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(56, 17);
            this.rbServer.TabIndex = 1;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Checked = true;
            this.rbClient.Location = new System.Drawing.Point(6, 19);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(51, 17);
            this.rbClient.TabIndex = 0;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // bGo
            // 
            this.bGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bGo.Location = new System.Drawing.Point(597, 267);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(75, 23);
            this.bGo.TabIndex = 4;
            this.bGo.Text = "GO";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bGo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbOutput);
            this.Name = "BTooth";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.Button button1;
    }
}

