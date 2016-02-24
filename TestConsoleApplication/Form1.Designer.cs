using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using TestConsoleApplication;

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
            this.serialPort = new CommPort();
            this.Com1Ctrl = new System.Windows.Forms.Panel();
            this.LoadComSettings = new System.Windows.Forms.Button();
            this.SaveComSettings = new System.Windows.Forms.Button();
            this.CloseComPort = new System.Windows.Forms.Button();
            this.BaudRateSelect = new System.Windows.Forms.ComboBox();
            this.OpenComPort = new System.Windows.Forms.Button();
            this.ParityBits = new System.Windows.Forms.Label();
            this.StopBits = new System.Windows.Forms.Label();
            this.DataBits = new System.Windows.Forms.Label();
            this.Handshake = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.Label();
            this.ParityBitSelect = new System.Windows.Forms.ComboBox();
            this.ComPort = new System.Windows.Forms.Label();
            this.StopBitSelect = new System.Windows.Forms.ComboBox();
            this.DataBitsSelect = new System.Windows.Forms.ComboBox();
            this.HandshakeSelect = new System.Windows.Forms.ComboBox();
            this.COMPortSelect = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsoleWindow = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendComm = new System.Windows.Forms.Button();
            this.ClearConsole = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.Com1Ctrl.Controls.Add(this.Handshake);
            this.Com1Ctrl.Controls.Add(this.BaudRate);
            this.Com1Ctrl.Controls.Add(this.ParityBitSelect);
            this.Com1Ctrl.Controls.Add(this.ComPort);
            this.Com1Ctrl.Controls.Add(this.StopBitSelect);
            this.Com1Ctrl.Controls.Add(this.DataBitsSelect);
            this.Com1Ctrl.Controls.Add(this.HandshakeSelect);
            this.Com1Ctrl.Controls.Add(this.COMPortSelect);
            this.Com1Ctrl.Location = new System.Drawing.Point(3, 3);
            this.Com1Ctrl.Name = "Com1Ctrl";
            this.Com1Ctrl.Size = new System.Drawing.Size(165, 223);
            this.Com1Ctrl.TabIndex = 0;
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
            // SaveComSettings
            // 
            this.SaveComSettings.Location = new System.Drawing.Point(3, 194);
            this.SaveComSettings.Name = "SaveComSettings";
            this.SaveComSettings.Size = new System.Drawing.Size(75, 23);
            this.SaveComSettings.TabIndex = 13;
            this.SaveComSettings.Text = "Save";
            this.SaveComSettings.UseVisualStyleBackColor = true;
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
            this.CloseComPort.Click += new System.EventHandler(this.CloseComPort_Click);
            // 
            // BaudRateSelect
            // 
            this.BaudRateSelect.Enabled = false;
            this.BaudRateSelect.FormattingEnabled = true;
            this.BaudRateSelect.Location = new System.Drawing.Point(67, 30);
            this.BaudRateSelect.Name = "BaudRateSelect";
            this.BaudRateSelect.Size = new System.Drawing.Size(98, 21);
            this.BaudRateSelect.TabIndex = 11;
            this.BaudRateSelect.SelectedIndexChanged += new System.EventHandler(this.BaudRateSelect_SelectedIndexChanged);
            // 
            // OpenComPort
            // 
            this.OpenComPort.Location = new System.Drawing.Point(3, 165);
            this.OpenComPort.Name = "OpenComPort";
            this.OpenComPort.Size = new System.Drawing.Size(75, 23);
            this.OpenComPort.TabIndex = 1;
            this.OpenComPort.Text = "Open";
            this.OpenComPort.UseVisualStyleBackColor = true;
            this.OpenComPort.Click += new System.EventHandler(this.OpenComPort_Click);
            // 
            // ParityBits
            // 
            this.ParityBits.AutoSize = true;
            this.ParityBits.Location = new System.Drawing.Point(3, 114);
            this.ParityBits.Name = "ParityBits";
            this.ParityBits.Size = new System.Drawing.Size(53, 13);
            this.ParityBits.TabIndex = 10;
            this.ParityBits.Text = "Parity Bits";
            // 
            // StopBits
            // 
            this.StopBits.AutoSize = true;
            this.StopBits.Location = new System.Drawing.Point(3, 84);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(49, 13);
            this.StopBits.TabIndex = 9;
            this.StopBits.Text = "Stop Bits";
            // 
            // DataBits
            // 
            this.DataBits.AutoSize = true;
            this.DataBits.Location = new System.Drawing.Point(3, 60);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(50, 13);
            this.DataBits.TabIndex = 8;
            this.DataBits.Text = "Data Bits";
            // 
            // Handshake
            // 
            this.Handshake.AutoSize = true;
            this.Handshake.Location = new System.Drawing.Point(3, 141);
            this.Handshake.Name = "Handshake";
            this.Handshake.Size = new System.Drawing.Size(62, 13);
            this.Handshake.TabIndex = 7;
            this.Handshake.Text = "Handshake";
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
            // ParityBitSelect
            // 
            this.ParityBitSelect.Enabled = false;
            this.ParityBitSelect.FormattingEnabled = true;
            this.ParityBitSelect.Location = new System.Drawing.Point(67, 111);
            this.ParityBitSelect.Name = "ParityBitSelect";
            this.ParityBitSelect.Size = new System.Drawing.Size(98, 21);
            this.ParityBitSelect.TabIndex = 5;
            this.ParityBitSelect.SelectedIndexChanged += new System.EventHandler(this.ParityBitSelect_SelectedIndexChanged);
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
            // StopBitSelect
            // 
            this.StopBitSelect.Enabled = false;
            this.StopBitSelect.FormattingEnabled = true;
            this.StopBitSelect.Location = new System.Drawing.Point(67, 84);
            this.StopBitSelect.Name = "StopBitSelect";
            this.StopBitSelect.Size = new System.Drawing.Size(98, 21);
            this.StopBitSelect.TabIndex = 4;
            this.StopBitSelect.SelectedIndexChanged += new System.EventHandler(this.StopBitSelect_SelectedIndexChanged);
            // 
            // DataBitsSelect
            // 
            this.DataBitsSelect.Enabled = false;
            this.DataBitsSelect.FormattingEnabled = true;
            this.DataBitsSelect.Location = new System.Drawing.Point(67, 57);
            this.DataBitsSelect.Name = "DataBitsSelect";
            this.DataBitsSelect.Size = new System.Drawing.Size(98, 21);
            this.DataBitsSelect.TabIndex = 3;
            this.DataBitsSelect.SelectedIndexChanged += new System.EventHandler(this.DataBitsSelect_SelectedIndexChanged);
            // 
            // HandshakeSelect
            // 
            this.HandshakeSelect.Enabled = false;
            this.HandshakeSelect.FormattingEnabled = true;
            this.HandshakeSelect.Location = new System.Drawing.Point(67, 138);
            this.HandshakeSelect.Name = "HandshakeSelect";
            this.HandshakeSelect.Size = new System.Drawing.Size(98, 21);
            this.HandshakeSelect.TabIndex = 2;
            this.HandshakeSelect.SelectedIndexChanged += new System.EventHandler(this.HandshakeSelect_SelectedIndexChanged);
            // 
            // COMPortSelect
            // 
            this.COMPortSelect.FormattingEnabled = true;
            this.COMPortSelect.Location = new System.Drawing.Point(67, 3);
            this.COMPortSelect.Name = "COMPortSelect";
            this.COMPortSelect.Size = new System.Drawing.Size(98, 21);
            this.COMPortSelect.TabIndex = 1;
            this.COMPortSelect.DropDown += new System.EventHandler(this.COMPortSelect_Dropdown);
            this.COMPortSelect.SelectedIndexChanged += new System.EventHandler(this.COMPortSelect_SelectedIndexChanged);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ConsoleWindow);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(174, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(291, 223);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // ConsoleWindow
            // 
            this.ConsoleWindow.Location = new System.Drawing.Point(3, 3);
            this.ConsoleWindow.Name = "ConsoleWindow";
            this.ConsoleWindow.Size = new System.Drawing.Size(288, 185);
            this.ConsoleWindow.TabIndex = 0;
            this.ConsoleWindow.Text = "";
            this.ConsoleWindow.TextChanged += new System.EventHandler(this.ConsoleWindow_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Controls.Add(this.SendComm);
            this.flowLayoutPanel3.Controls.Add(this.ClearConsole);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 194);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(288, 26);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_keyUp);
            // 
            // SendComm
            // 
            this.SendComm.Enabled = false;
            this.SendComm.Location = new System.Drawing.Point(188, 3);
            this.SendComm.Name = "SendComm";
            this.SendComm.Size = new System.Drawing.Size(45, 23);
            this.SendComm.TabIndex = 15;
            this.SendComm.Text = "Send";
            this.SendComm.UseVisualStyleBackColor = true;
            this.SendComm.Click += new System.EventHandler(this.SendComm_Click);
            // 
            // ClearConsole
            // 
            this.ClearConsole.Enabled = false;
            this.ClearConsole.Location = new System.Drawing.Point(239, 3);
            this.ClearConsole.Name = "ClearConsole";
            this.ClearConsole.Size = new System.Drawing.Size(43, 23);
            this.ClearConsole.TabIndex = 17;
            this.ClearConsole.Text = "Clear";
            this.ClearConsole.UseVisualStyleBackColor = true;
            this.ClearConsole.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ComPortAppliCation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 250);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ComPortAppliCation";
            this.Text = "Com Port Application";
            this.Load += new System.EventHandler(this.ComPortAppliCation_Load);
            this.Com1Ctrl.ResumeLayout(false);
            this.Com1Ctrl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CommPort serialPort;
        private Panel Com1Ctrl;
        private Button LoadComSettings;
        private Button SaveComSettings;
        private Button CloseComPort;
        private ComboBox BaudRateSelect;
        private Button OpenComPort;
        private Label ParityBits;
        private Label StopBits;
        private Label DataBits;
        private Label Handshake;
        private Label BaudRate;
        private ComboBox ParityBitSelect;
        private Label ComPort;
        private ComboBox StopBitSelect;
        private ComboBox DataBitsSelect;
        private ComboBox HandshakeSelect;
        private ComboBox COMPortSelect;
        private FlowLayoutPanel flowLayoutPanel1;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FlowLayoutPanel flowLayoutPanel2;
        private RichTextBox ConsoleWindow;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox textBox1;
        private Button SendComm;
        private Button ClearConsole;
    }
}

