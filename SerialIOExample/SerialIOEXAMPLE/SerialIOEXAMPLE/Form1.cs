using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialExample
{
    public partial class SerialForm : Form
    {
        public SerialForm()
        {
            InitializeComponent();
            UpdatePortSelection();
        }

        SerialPort _serialPort = new SerialPort();
        void SerialPortSetup(string portName)
        {
            _serialPort.Close();
            _serialPort.PortName = portName;
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
        }

        void SerialConnect()
        {
            _serialPort.Close();
            _serialPort.Open();
        }

        void SerialSend(byte[] data)
        {
            _serialPort.Write(OutputTextBox.Text) ;
        }

        void SerialRead()
        {
            //SerialTextBox.Text = _serialPort.ReadExisting();
            byte[] RXJim = new byte[_serialPort.BytesToRead];
            int byteNumber = 0;
            _serialPort.Read(RXJim, 0, RXJim.Length);

            foreach (byte b in RXJim)
            {
                byteNumber++;
                ComListBox.Items.Add($"{byteNumber}: {b} : {b:X2} {(char)b}");
            }

        }

        string[] GetSerialPorts()
        {
            return SerialPort.GetPortNames();
        }

        void UpdatePortSelection()
        {
            foreach (string port in GetSerialPorts())
            {
                PortsComboBox.Items.Add(port);
            }

            if (PortsComboBox.Items.Count > 0)
            {
                PortsComboBox.SelectedIndex = 0;
            }

        }

        void TestQyAtBoard()
        {
            byte[] thingy = { 0xf0 };
            _serialPort.Write(thingy, 0, 1);
        }

        void WriteToDigitalOutputs()
        {
            // Safer conversion (prevents crashes if the text is invalid)
            if (byte.TryParse(OutputTextBox.Text, out byte result))
            {
                byte myByte = byte.Parse(OutputTextBox.Text);
                byte[] Whatsit = { 0x20, myByte };
                _serialPort.Write(Whatsit, 0, 2);
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 0 and 255.");
                OutputTextBox.Text = "0"; // Reset to a default value
            }
        }


        byte[] DigitalWriteQyAt(byte pins = 0x00)
        {
            byte[] command = { 0x20, pins };
            SerialSend(command);
            return (command);
        }

        bool IsQyAtBoard(string portName)
        {
            byte[] thingy = { 0xf0 };
            byte[] input = new byte[1];

            SerialPortSetup(portName);
            SerialConnect();

            //flush rx buffer
            input = new byte[_serialPort.BytesToRead];
            _serialPort.Read(input, 0, input.Length);

            //request settings
            _serialPort.Write(thingy, 0, 1);

            //wait for reply
            System.Threading.Thread.Sleep(100);

            //read rx buffer
            input = new byte[_serialPort.BytesToRead];
            _serialPort.Read(input, 0, input.Length);

            //disconnect
            _serialPort.Close();
            //test if QY@ board
            if (input.Length == 64 && input[58] == 81 && input[59] == 121 && input[60] == 64)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        byte[] AN1Read()
        {
            byte[] command = { 0x05 };
            return command;
        }

        // Event Handlers Below here ******************************************
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {

            SerialPortSetup(PortsComboBox.SelectedItem.ToString());
            SerialConnect();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //SerialSend();
           //TestQyAtBoard();
           // WriteToDigitalOutputs();
            //DigitalWriteQyAt();
            SerialSend(AN1Read());
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            SerialRead();

        }

      

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StatusTimer_Tick(object sender, EventArgs e)
        {
       
           {
        
               string portName;
                int rxBuffer, txBuffer;
             if (_serialPort.IsOpen)
              {
                   portName = _serialPort.PortName;
                  rxBuffer = _serialPort.BytesToRead;
                   txBuffer = _serialPort.BytesToWrite;
               }
                else
               {
                    portName = "none";
                   rxBuffer = 0;
          txBuffer = 0;
                 }

                 StatusLabel.Text = $"Port: {portName} tx:{txBuffer} rx:{rxBuffer}";
            }
       }

     //   private void AN1CheckBox_CheckedChanged(object sender, EventArgs e)
      //  {
       //     if (AN1CheckBox.Checked)
       //     {
            //    AnalogTimer.Enabled = true;
       //     }
           // else
          //  {
          //      AnalogTimer.Enabled = false;
         //   }
      //  }

      //  private void AnalogTimer_Tick(object sender, EventArgs e)
        //{
     //       ComListBox.Items.Add( System.DateTime.Now.ToString("YYMMDDhhmm"));
        //    SerialSend(AN1Read());
        //    System.Threading.Thread.Sleep(20);
        //    SerialRead();
        //    ComListBox.SelectedIndex = ComListBox.Items.Count - 1;
        //    ComListBox.ClearSelected();
       // }
    }
}