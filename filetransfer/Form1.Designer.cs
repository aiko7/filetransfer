namespace filetransfer
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
            label1 = new Label();
            txtIP = new TextBox();
            label2 = new Label();
            btnBrowse = new Button();
            txtFilePath = new TextBox();
            label3 = new Label();
            btnSend = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtPort = new TextBox();
            label4 = new Label();
            btnStartListening = new Button();
            btnStopListening = new Button();
            label5 = new Label();
            inputPort = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Receiver IP:";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(85, 6);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(100, 23);
            txtIP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Select File:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(85, 46);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += button1_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(276, 47);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(247, 23);
            txtFilePath.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 50);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "File path:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(85, 84);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 23);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(276, 6);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(43, 23);
            txtPort.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 9);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 9;
            label4.Text = "Receiver Port:";
            // 
            // btnStartListening
            // 
            btnStartListening.Location = new Point(85, 172);
            btnStartListening.Name = "btnStartListening";
            btnStartListening.Size = new Size(100, 23);
            btnStartListening.TabIndex = 13;
            btnStartListening.Text = "Start Listening";
            btnStartListening.UseVisualStyleBackColor = true;
            btnStartListening.Click += button1_Click_1;
            // 
            // btnStopListening
            // 
            btnStopListening.Location = new Point(191, 172);
            btnStopListening.Name = "btnStopListening";
            btnStopListening.Size = new Size(100, 23);
            btnStopListening.TabIndex = 14;
            btnStopListening.Text = "Stop Listening";
            btnStopListening.UseVisualStyleBackColor = true;
            btnStopListening.Click += button1_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 15;
            label5.Text = "Input Port:";
            // 
            // inputPort
            // 
            inputPort.Location = new Point(85, 129);
            inputPort.Name = "inputPort";
            inputPort.Size = new Size(100, 23);
            inputPort.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputPort);
            Controls.Add(label5);
            Controls.Add(btnStopListening);
            Controls.Add(btnStartListening);
            Controls.Add(label4);
            Controls.Add(txtPort);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(txtFilePath);
            Controls.Add(btnBrowse);
            Controls.Add(label2);
            Controls.Add(txtIP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtIP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox txtIP;
        private Label label2;
        private Button btnBrowse;
        private TextBox txtFilePath;
        private Label label3;
        private Button btnSend;
        private OpenFileDialog openFileDialog1;
        private TextBox txtPort;
        private Label label4;
        private Button btnStartListening;
        private Button btnStopListening;
        private Label label5;
        private TextBox inputPort;
    }
}
