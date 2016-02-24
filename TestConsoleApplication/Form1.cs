using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestConsoleApplication
{
    public partial class ComPortAppliCation : Form
    {
        private void ComPortAppliCation_Load(object sender, EventArgs e)
        {
            object[] baudRates = { 4800, 9600, 19200, 38400, 57600, 115200, 230400 };
            BaudRateSelect.Items.AddRange(baudRates);
            BaudRateSelect.SelectedIndex = 5;

            object[] dataBits = { 5, 6, 7, 8 };
            DataBitsSelect.Items.AddRange(dataBits);
            DataBitsSelect.SelectedIndex = 3;

            object[] parityBit = { "None", "Even", "Odd", "Mark", "Space" };
            ParityBitSelect.Items.AddRange(parityBit);
            ParityBitSelect.SelectedIndex = 0;

            object[] stopBits = { "One", "OnePointFive", "Two" };
            StopBitSelect.Items.AddRange(stopBits);
            StopBitSelect.SelectedIndex = 0;

            object[] handshakes = { "None", "RequestToSend", "RequestToSendXOnXOff", "XOnXOff" };
            HandshakeSelect.Items.AddRange(handshakes);
            HandshakeSelect.SelectedIndex = 0;

            ConsoleWindow.Enabled = false;
        }

        public ComPortAppliCation()
        {
            InitializeComponent();
        }

        private void COMPortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void COMPortSelect_Dropdown(object sender, EventArgs e)
        {
            COMPortSelect.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                COMPortSelect.Items.Add(s);
            }
            if (COMPortSelect.Items.Count == 0)
            {
                MessageBox.Show("No COM Ports Available on this Machine");
            }
        }

        private void BaudRateSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void HandshakeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ParityBitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void StopBitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DataBitsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void OpenComPort_Click(object sender, EventArgs e)
        {
            if (!serialPort.isOpen)
            {
                this.serialPort.comPort = (string)COMPortSelect.SelectedItem;
                this.serialPort.baudRate = (int)BaudRateSelect.SelectedItem;
                this.serialPort.dataBits = (int)DataBitsSelect.SelectedItem;
                this.serialPort.stopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBitSelect.SelectedItem.ToString());
                this.serialPort.parityBits = (Parity)Enum.Parse(typeof(Parity), ParityBitSelect.SelectedItem.ToString());
                this.serialPort.handShake = (Handshake)Enum.Parse(typeof(Handshake), HandshakeSelect.SelectedItem.ToString());
                this.serialPort.openPort();
            }
            else ConsoleWindow.AppendText("Serial Port already open\n");
            COMPortSelect.Enabled = false;
            BaudRateSelect.Enabled = false;
            HandshakeSelect.Enabled = false;
            DataBitsSelect.Enabled = false;
            StopBitSelect.Enabled = false;
            ParityBitSelect.Enabled = false;
            SendComm.Enabled = true;
            ClearConsole.Enabled = true;
            OpenComPort.Enabled = false;
            CloseComPort.Enabled = true;
        }

        private void CloseComPort_Click(object sender, EventArgs e)
        {
            if (serialPort.isOpen)
            {
                serialPort.closePort();
            }
            else ConsoleWindow.AppendText("Serial Port already close\n");
            COMPortSelect.Enabled = true;
            BaudRateSelect.Enabled = true;
            HandshakeSelect.Enabled = true;
            DataBitsSelect.Enabled = true;
            StopBitSelect.Enabled = true;
            ParityBitSelect.Enabled = true;
            SendComm.Enabled = false;
            ClearConsole.Enabled = false;
            OpenComPort.Enabled = true;
            CloseComPort.Enabled = false;
        }

        private void SendComm_Click(object sender, EventArgs e)
        {
            if(!serialPort.isOpen)
            {
                MessageBox.Show("No COM Port is open to send Data across");
                return;
            }
            textBox1.Enabled = false; //Prevents editting of text whilst send in progress
            if(textBox1.Text != "")
            {
                try
                {
                    serialPort.sendData(textBox1.Text);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                    return;
                }
                ConsoleWindow.AppendText("Sent: \"" + textBox1.Text + " \"\n");
                textBox1.Text = "";
            }
            textBox1.Enabled = true;
            textBox1.Select();
        }

        private void textBox1_keyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SendComm_Click((object)sender, (EventArgs)e);
                    break;
                default:
                    break;
            }
        }

        private void ConsoleWindow_TextChanged(object sender, EventArgs e)
        {
            ConsoleWindow.SelectionStart = ConsoleWindow.Text.Length;
            ConsoleWindow.ScrollToCaret();
            textBox1.Select();
        }

        public void ClearConsole_Click(object sender, EventArgs e)
        {
            ConsoleWindow.Text = "";
            textBox1.Select();
        }

        public void SerialPort_DataReceived( object sender, SerialDataReceivedEventArgs e)
        {
            this.ConsoleWindow.AppendText(e.ToString());
        }
    }
}
