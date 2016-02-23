using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public ComPortAppliCation()
        {
            InitializeComponent();
        }

        private void COMPortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = COMPortSelect.SelectedItem.ToString();
            if(serialPort.PortName == "")
            {
                ConsoleWindow.AppendText("No Com Port selected");
            }
            else
            {
                ConsoleWindow.AppendText(serialPort.PortName.ToString() + " Selected\n");
                BaudRateSelect.Enabled = true;
                HandshakeSelect.Enabled = true;
                DataBitsSelect.Enabled = true;
                StopBitSelect.Enabled = true;
                ParityBitSelect.Enabled = true;
            }
        }

        private void COMPortSelect_Dropdown(object sender, EventArgs e)
        {
            if(!serialPort.IsOpen)
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
            else
            {
                ConsoleWindow.AppendText("Serial Port Cannot be changed while it is open");
            }
        }

        private void BaudRateSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = (int)BaudRateSelect.SelectedItem;
            ConsoleWindow.AppendText("Baud Rate set to " + serialPort.BaudRate + " bps\n");
        }

        private void HandshakeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.Handshake = (System.IO.Ports.Handshake)Enum.Parse(typeof(System.IO.Ports.Handshake), HandshakeSelect.SelectedItem.ToString());
            ConsoleWindow.AppendText("Handshake set to " + serialPort.Handshake + " \n");
        }

        private void ParityBitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), ParityBitSelect.SelectedItem.ToString());
            ConsoleWindow.AppendText("Parity set to " + serialPort.Parity.ToString() + " \n");
        }

        private void StopBitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), StopBitSelect.SelectedItem.ToString());
            ConsoleWindow.AppendText("Stopbits set to " + serialPort.StopBits.ToString() + " \n");
        }

        private void DataBitsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.DataBits = (int)DataBitsSelect.SelectedItem;
            ConsoleWindow.AppendText("Data Bits set to " + serialPort.DataBits + "\n");
        }

        private void OpenComPort_Click(object sender, EventArgs e)
        {
            if(!serialPort.IsOpen)
            {
                serialPort.Open();
                COMPortSelect.Enabled = false;
                BaudRateSelect.Enabled = false;
                HandshakeSelect.Enabled = false;
                DataBitsSelect.Enabled = false;
                StopBitSelect.Enabled = false;
                ParityBitSelect.Enabled = false;
            }
        }
    }
}
