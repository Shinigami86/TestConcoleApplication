namespace TestConsoleApplication
{
    partial class ComPortAppliCation
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.Com1Ctrl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.COMPortSelect = new System.Windows.Forms.ComboBox();
            this.StartBitSelect = new System.Windows.Forms.ComboBox();
            this.DataBitsSelect = new System.Windows.Forms.ComboBox();
            this.StopBitSelect = new System.Windows.Forms.ComboBox();
            this.ParityBitSelect = new System.Windows.Forms.ComboBox();
            this.ComPort = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.Label();
            this.StartBits = new System.Windows.Forms.Label();
            this.DataBits = new System.Windows.Forms.Label();
            this.StopBits = new System.Windows.Forms.Label();
            this.ParityBits = new System.Windows.Forms.Label();
            this.BaudRateSelect = new System.Windows.Forms.ComboBox();
            this.OpenComPort = new System.Windows.Forms.Button();
            this.CloseComPort = new System.Windows.Forms.Button();
            this.SaveComSettings = new System.Windows.Forms.Button();
            this.LoadComSettings = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.SendComm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Com1Ctrl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Com1Ctrl
            // 
            this.Com1Ctrl.Controls.Add(this.LoadComSettings);
            this.Com1Ctrl.Controls.Add(this.SaveComSettings);
            this.Com1Ctrl.Controls.Add(this.CloseComPort);
            this.Com1Ctrl.Controls.Add(this.BaudRateSelect);
            this.Com1Ctrl.Controls.Add(this.OpenComPort);
            this.Com1Ctrl.Controls.Add(this.ParityBits);
            this.Com1Ctrl.Controls.Add(this.StopBits);
            this.Com1Ctrl.Controls.Add(this.DataBits);
            this.Com1Ctrl.Controls.Add(this.StartBits);
            this.Com1Ctrl.Controls.Add(this.BaudRate);
            this.Com1Ctrl.Controls.Add(this.ParityBitSelect);
            this.Com1Ctrl.Controls.Add(this.ComPort);
            this.Com1Ctrl.Controls.Add(this.StopBitSelect);
            this.Com1Ctrl.Controls.Add(this.DataBitsSelect);
            this.Com1Ctrl.Controls.Add(this.StartBitSelect);
            this.Com1Ctrl.Controls.Add(this.COMPortSelect);
            this.Com1Ctrl.Location = new System.Drawing.Point(3, 3);
            this.Com1Ctrl.Name = "Com1Ctrl";
            this.Com1Ctrl.Size = new System.Drawing.Size(165, 223);
            this.Com1Ctrl.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Com1Ctrl);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 231);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // COMPortSelect
            // 
            this.COMPortSelect.FormattingEnabled = true;
            this.COMPortSelect.Location = new System.Drawing.Point(64, 3);
            this.COMPortSelect.Name = "COMPortSelect";
            this.COMPortSelect.Size = new System.Drawing.Size(98, 21);
            this.COMPortSelect.TabIndex = 1;
            // 
            // StartBitSelect
            // 
            this.StartBitSelect.FormattingEnabled = true;
            this.StartBitSelect.Location = new System.Drawing.Point(64, 57);
            this.StartBitSelect.Name = "StartBitSelect";
            this.StartBitSelect.Size = new System.Drawing.Size(98, 21);
            this.StartBitSelect.TabIndex = 2;
            // 
            // DataBitsSelect
            // 
            this.DataBitsSelect.FormattingEnabled = true;
            this.DataBitsSelect.Location = new System.Drawing.Point(64, 84);
            this.DataBitsSelect.Name = "DataBitsSelect";
            this.DataBitsSelect.Size = new System.Drawing.Size(98, 21);
            this.DataBitsSelect.TabIndex = 3;
            // 
            // StopBitSelect
            // 
            this.StopBitSelect.FormattingEnabled = true;
            this.StopBitSelect.Location = new System.Drawing.Point(64, 111);
            this.StopBitSelect.Name = "StopBitSelect";
            this.StopBitSelect.Size = new System.Drawing.Size(98, 21);
            this.StopBitSelect.TabIndex = 4;
            // 
            // ParityBitSelect
            // 
            this.ParityBitSelect.FormattingEnabled = true;
            this.ParityBitSelect.Location = new System.Drawing.Point(64, 138);
            this.ParityBitSelect.Name = "ParityBitSelect";
            this.ParityBitSelect.Size = new System.Drawing.Size(98, 21);
            this.ParityBitSelect.TabIndex = 5;
            // 
            // ComPort
            // 
            this.ComPort.AutoSize = true;
            this.ComPort.Location = new System.Drawing.Point(3, 6);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(50, 13);
            this.ComPort.TabIndex = 1;
            this.ComPort.Text = "Com Port";
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Location = new System.Drawing.Point(3, 33);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(58, 13);
            this.BaudRate.TabIndex = 6;
            this.BaudRate.Text = "Baud Rate";
            // 
            // StartBits
            // 
            this.StartBits.AutoSize = true;
            this.StartBits.Location = new System.Drawing.Point(3, 60);
            this.StartBits.Name = "StartBits";
            this.StartBits.Size = new System.Drawing.Size(49, 13);
            this.StartBits.TabIndex = 7;
            this.StartBits.Text = "Start Bits";
            // 
            // DataBits
            // 
            this.DataBits.AutoSize = true;
            this.DataBits.Location = new System.Drawing.Point(3, 87);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(50, 13);
            this.DataBits.TabIndex = 8;
            this.DataBits.Text = "Data Bits";
            // 
            // StopBits
            // 
            this.StopBits.AutoSize = true;
            this.StopBits.Location = new System.Drawing.Point(3, 114);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(49, 13);
            this.StopBits.TabIndex = 9;
            this.StopBits.Text = "Stop Bits";
            // 
            // ParityBits
            // 
            this.ParityBits.AutoSize = true;
            this.ParityBits.Location = new System.Drawing.Point(3, 141);
            this.ParityBits.Name = "ParityBits";
            this.ParityBits.Size = new System.Drawing.Size(53, 13);
            this.ParityBits.TabIndex = 10;
            this.ParityBits.Text = "Parity Bits";
            // 
            // BaudRateSelect
            // 
            this.BaudRateSelect.FormattingEnabled = true;
            this.BaudRateSelect.Location = new System.Drawing.Point(64, 30);
            this.BaudRateSelect.Name = "BaudRateSelect";
            this.BaudRateSelect.Size = new System.Drawing.Size(98, 21);
            this.BaudRateSelect.TabIndex = 11;
            // 
            // OpenComPort
            // 
            this.OpenComPort.Location = new System.Drawing.Point(3, 165);
            this.OpenComPort.Name = "OpenComPort";
            this.OpenComPort.Size = new System.Drawing.Size(75, 23);
            this.OpenComPort.TabIndex = 1;
            this.OpenComPort.Text = "Open";
            this.OpenComPort.UseVisualStyleBackColor = true;
            // 
            // CloseComPort
            // 
            this.CloseComPort.Enabled = false;
            this.CloseComPort.Location = new System.Drawing.Point(84, 165);
            this.CloseComPort.Name = "CloseComPort";
            this.CloseComPort.Size = new System.Drawing.Size(75, 23);
            this.CloseComPort.TabIndex = 12;
            this.CloseComPort.Text = "Close";
            this.CloseComPort.UseVisualStyleBackColor = true;
            // 
            // SaveComSettings
            // 
            this.SaveComSettings.Location = new System.Drawing.Point(3, 194);
            this.SaveComSettings.Name = "SaveComSettings";
            this.SaveComSettings.Size = new System.Drawing.Size(75, 23);
            this.SaveComSettings.TabIndex = 13;
            this.SaveComSettings.Text = "Save";
            this.SaveComSettings.UseVisualStyleBackColor = true;
            // 
            // LoadComSettings
            // 
            this.LoadComSettings.Location = new System.Drawing.Point(84, 194);
            this.LoadComSettings.Name = "LoadComSettings";
            this.LoadComSettings.Size = new System.Drawing.Size(75, 23);
            this.LoadComSettings.TabIndex = 14;
            this.LoadComSettings.Text = "Load";
            this.LoadComSettings.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(174, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(291, 223);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 185);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Controls.Add(this.SendComm);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 194);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(288, 26);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // SendComm
            // 
            this.SendComm.Enabled = false;
            this.SendComm.Location = new System.Drawing.Point(207, 3);
            this.SendComm.Name = "SendComm";
            this.SendComm.Size = new System.Drawing.Size(75, 23);
            this.SendComm.TabIndex = 15;
            this.SendComm.Text = "Send";
            this.SendComm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 16;
            // 
            // ComPortAppliCation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 250);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ComPortAppliCation";
            this.Text = "Com Port Application";
            this.Com1Ctrl.ResumeLayout(false);
            this.Com1Ctrl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel Com1Ctrl;
        private System.Windows.Forms.Button LoadComSettings;
        private System.Windows.Forms.Button SaveComSettings;
        private System.Windows.Forms.Button CloseComPort;
        private System.Windows.Forms.ComboBox BaudRateSelect;
        private System.Windows.Forms.Button OpenComPort;
        private System.Windows.Forms.Label ParityBits;
        private System.Windows.Forms.Label StopBits;
        private System.Windows.Forms.Label DataBits;
        private System.Windows.Forms.Label StartBits;
        private System.Windows.Forms.Label BaudRate;
        private System.Windows.Forms.ComboBox ParityBitSelect;
        private System.Windows.Forms.Label ComPort;
        private System.Windows.Forms.ComboBox StopBitSelect;
        private System.Windows.Forms.ComboBox DataBitsSelect;
        private System.Windows.Forms.ComboBox StartBitSelect;
        private System.Windows.Forms.ComboBox COMPortSelect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SendComm;
    }
}

