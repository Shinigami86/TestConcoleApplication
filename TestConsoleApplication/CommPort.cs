using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace TestConsoleApplication
{
    class CommPort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void dataReceivedEventHandler(object sender, EventArgs e);
        public event dataReceivedEventHandler _dataReceived;

        #region
        /// <summary>
        /// 
        /// </summary>
        private SerialPort sp;
        /// <summary>
        /// 
        /// </summary>
        private string _comPort = "";
        /// <summary>
        /// 
        /// </summary>
        
        public string comPort
        {
            get
            {
                return _comPort;
            }
            set
            {
                try
                {
                    _comPort = comPort;
                    sp.PortName = _comPort;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private int _baudRate = 115200;
        /// <summary>
        /// 
        /// </summary>
        public int baudRate
        {
            get
            {
                return _baudRate;
            }
            set
            {
                _baudRate = baudRate;
                try
                {
                    sp.BaudRate = _baudRate;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private StopBits _stopBits = StopBits.One;
        /// <summary>
        /// 
        /// </summary>
        public StopBits stopBits
        {
            get
            {
                return _stopBits;
            }
            set
            {
                _stopBits = stopBits;
                try
                {
                    sp.StopBits = _stopBits;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private int _dataBits = 8;
        /// <summary>
        /// 
        /// </summary>
        public int dataBits
        {
            get
            {
                return _dataBits;
            }
            set
            {
                if ((dataBits > 4) && (dataBits < 9))
                {
                    _dataBits = dataBits;
                    try
                    {
                        sp.DataBits = _dataBits;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else throw new ArgumentOutOfRangeException("dataBits","Databits must be no less than 5 and no more than 8");            
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private Parity _parityBits = Parity.None;
        /// <summary>
        /// 
        /// </summary>
        public Parity parityBits
        {
            get
            {
                return _parityBits;
            }
            set
            {
                _parityBits = parityBits;
                try
                {
                    sp.Parity = _parityBits;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private Handshake _handshake = Handshake.None;
        /// <summary>
        /// 
        /// </summary>
        public Handshake handShake
        {
            get
            {
                return _handshake;
            }
            set
            {
                _handshake = handShake;
                try
                {
                    sp.Handshake = _handshake;
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private bool _isOpen = false;
        /// <summary>
        /// 
        /// </summary>
        public bool isOpen
        {
            get
            {
                try
                {
                    _isOpen = sp.IsOpen;
                }
                catch (Exception)
                {
                    return false;
                }
                return _isOpen;
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public CommPort()
        {
            sp = new SerialPort();
            sp.DataReceived += new SerialDataReceivedEventHandler(_serialDataReceived);
            sp.BaudRate = 115200;
            sp.Parity = Parity.None;
            sp.Handshake = Handshake.None;
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _serialDataReceived(object sender, EventArgs e)
        {
            _dataReceived(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool openPort()
        {
            if(!sp.IsOpen)
            {
                sp.Open();
                return true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool closePort()
        {
            if(sp.IsOpen)
            {
                try
                {
                    sp.Close();
                }
                catch(Exception)
                {
                    throw;
                }
                return true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool sendData(string data)
        {
            if (sp.IsOpen)
            {
                try
                {
                    sp.Write(data);
                }
                catch (Exception)
                {
                    throw;
                }
                return true;
            }
            else
            {
                throw new InvalidCastException();
            }
        }




    }
}
